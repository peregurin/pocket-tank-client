using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class TestSocket : MonoBehaviour
{
    public SocketIOComponent socket;

    // Start is called before the first frame update
    void Start()
    {
        socket.Connect();
        socket.On("connection", OnConnected);
        socket.On("error", OnError);
    }

    void OnConnected(SocketIOEvent evt)
    {
        Debug.Log("connected to server" + evt);
    }

    void OnError(SocketIOEvent evt)
    {
        Debug.Log("server connection error: " + evt);
    }
}
