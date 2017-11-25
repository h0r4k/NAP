# NAP

## What is NAP?

NAP (Network Analyzer Proxy) is a tool designed to analyze networks under your control for Windows. It can mediate connection of arbitrary TCP, SSL, TLS or WebSocket to capture and rewrite packets.

## Caution

* NAP needs to switch client's connection destination on your own. You need to route accordingly by rewriting the hosts file or the connection destination of winsock connect().

* NAP does not support the connection from clients that require certificate authentication.

* Please use it only in the network under your control.

* Never exploit NAP.

* I do not guarantee any disadvantage due to using NAP.