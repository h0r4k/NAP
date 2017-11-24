using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Security;
using System.IO;
using static NAP.Utils.WebSocket.WebSocketMethods;

namespace NAP.Utils.WebSocket
{
    class PacketTuner
    {
        int Size = 0;
        MemoryStream RecvDataStream = null;
        byte[] Maskingkey = new byte[0];
        PacketTuner return_packet_tuner;
        byte[] saved_data = new byte[0];
        byte[] header;
        byte[] writeData;
        bool masked;
        Action<byte[]> receiver;
        

        public PacketTuner(Action<byte[]> receiver)
        {
            this.receiver = receiver;
        }
        
        public void RidFrame(byte[] data)
        {
            //返り値を用意
            return_packet_tuner = this;
            //取得パケットストリームに書き込むデータを確保
            writeData = data;
            //ヘッダーの取得
            if (RecvDataStream == null && Size == 0)
            {
                //opcodeの抽出
                //opcode(下4bit) & 00001111
                WebSocketMethods.opcode = WebSocketMethods.opcode == -1 ? (int)data[0] & 15 : opcode;
                //opcodeが8のとき
                if (data[0] == 136)
                {
                    //sslstream.Close();
                }
                //ヘッダーの一部がセーブされているとき
                if (saved_data.Length > 0)
                {
                    //ヘッダーの長さが足りず保存されたデータを結合し、ヘッダーを完成させる
                    data = saved_data.Concat(data).ToArray();
                    saved_data = new byte[0];
                }
                //ヘッダーサイズが不明なとき
                if (data.Length == 1)
                {
                    //次のパケットでヘッダーを完成させるための先頭データを保存
                    saved_data = data;
                }
                //ヘッダーサイズがわかっているとき
                if (data.Length > 1)
                {
                    //ヘッダーサイズ分の配列を確保
                    header = new byte[CheckHeadSize(data.Take(2).ToArray())+1];
                    //ヘッダーサイズよりデータサイズが大きいとき
                    if (header.Length <= data.Length)
                    {
                        //ヘッダー情報からパケットサイズやマスク情報を取得
                        masked = data[1] >= 0x80 ? true : false;
                        uint[] val = CheckPacketSize(data, masked);
                        if (masked)
                        {
                            Maskingkey = data.Skip(1 + (int)val[1]).Take(4).ToArray();
                        }
                        header = data.Take(header.Length).ToArray();
                        Size = (int)val[0];
                        //パケットサイズから保存メモリーストリームを生成
                        RecvDataStream = new MemoryStream(Size);
                        //書き込むべきデータを保存
                        data = data.Skip(1 + (int)val[1] + (masked == true ? 4 : 0)).ToArray();
                        writeData = data.Take(Size).ToArray();
                    }
                    //ヘッダーサイズよりデータサイズが小さいとき
                    if (header.Length > data.Length)
                    {
                        //次のパケットでヘッダーを完成させるための先頭データを保存
                        saved_data = data;
                    }
                }
            }

            //ヘッダーの取得が完了しているとき
            if (RecvDataStream != null && Size > 0&& writeData.Length >0)
            {
                //書き込み可能領域の記録
                int WritableSpace = Size - (int)RecvDataStream.Position;
                //データの取得
                if (WritableSpace > 0)
                {
                    //残りの書き込み可能領域のサイズに合わせ、データを書き込む
                    RecvDataStream.Write(writeData, 0, writeData.Length > WritableSpace ? WritableSpace: writeData.Length);
                    writeData = new byte[0];
                }
                //データの取得完了時
                if (Size == RecvDataStream.Position)
                {
                    //完成したパケットをストリームから書き出す
                    byte[] CompletedData = RecvDataStream.ToArray();
                    //完成したパケットにマスクがかかっていた場合はずす
                    if (masked)
                    {
                        CompletedData = RidMasking(CompletedData, Maskingkey);
                    }
                    //初期化
                    Size = 0;
                    RecvDataStream = null;
                    //完成したパケットをレシーバーに書き込む
                    receiver(CompletedData);
                    //データの後ろに新しいパケットがついている場合
                    if(data.Length > WritableSpace)
                    {
                        //結合されたパケットを再びこのメソッドにおくり、返り値をとる
                        RidFrame(data.Skip(WritableSpace).ToArray());
                    }
                }
            }
        }
    }
}
