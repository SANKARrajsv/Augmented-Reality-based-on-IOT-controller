using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using UnityEngine.Networking;
public class OffUrl : MonoBehaviour
{

    // public string url;
    public string IP = "192.168.1.6"; //
    public int Port = 50001;
    public byte[] dane = System.Text.Encoding.ASCII.GetBytes("OFF");
    public Socket client;

    public void opens()
    {
        client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        client.Connect(IP, Port);
        if (client.Connected)
        {
            Debug.Log("Connected");
        }
        client.Send(dane);
    }


    void OnApplicationQuit()
    {
        client.Close();
    }

}
