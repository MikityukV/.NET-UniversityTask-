# Send message Task:

This code is an implementation of a simple TCP/IP server and client that operates in a request-response mode.

The server listens on port 9595 at the local address and waits for a client to connect. When a client connects, the server launches a new thread to handle the client's request, using a thread pool. In the request processing thread, the server reads the data sent by the client, splits it into numbers, sorts them, and then sends the sorted numbers back to the client in the form of an ASCII string.

The client requests the user to input numbers, then sends the entered numbers to the server in the form of an ASCII string. When the client receives the sorted numbers from the server, it displays them on the screen.

Both applications use the TcpClient, TcpListener, NetworkStream, and Thread classes. TcpListener is used to listen on the port and accept incoming connections, while TcpClient is used to connect to the server. NetworkStream is used to read and write data from and to the socket stream. A thread pool is used to process client requests asynchronously.
# Send Sort Get Task:

This code implements a simple client-server socket-based application for exchanging data between two applications. The code consists of two parts - a server-side and a client-side.

The server-side code implements receiving and sending messages from clients. It binds to a local endpoint and starts listening on a port where it waits for connections from clients. Upon a client's connection, the server receives the data, converts it to a string, and outputs it to the console. Then it sends a response to the client, closes the connection, and continues listening on the port for new connections.

The client-side code establishes a connection with the server and sends a message. Then it receives a response from the server and outputs it to the console. Then it closes the connection.

It is important to note that the server and client must use the same protocol for exchanging data. In this case, the TCP protocol is used.
