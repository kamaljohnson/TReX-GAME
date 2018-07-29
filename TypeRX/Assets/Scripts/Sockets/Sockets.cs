using System.Net.Sockets;
using System.Net;
using UnityEngine;
using System.Text;

/*
 * this static functions writen in this class will be a gate way interface between the server and the dependent functions 
 */
public class Sockets:MonoBehaviour{

    public static string message;   //this message will be used by all the other funtions in this project for getting the data
    
    static void MakeConnection()
    {
        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddress = ipHostInfo.AddressList[0];
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8000);

        Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        sender.Connect(remoteEP);
        Debug.Log("Socket connected to " + sender.RemoteEndPoint.ToString());
    }
}
