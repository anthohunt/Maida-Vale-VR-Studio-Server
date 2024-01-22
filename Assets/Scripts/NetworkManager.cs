using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using UnityEngine;
using extOSC;

public class NetworkManager : MonoBehaviour
{
    [HideInInspector]
    public int numberOfUsers = 2;

    [Header("IPs")]
    public string serverIP;
    public string userIP1;
    public string userIP2;

    [HideInInspector]
    public OSCTransmitter client1;
    [HideInInspector]
    public OSCTransmitter client2;

    // Start is called before the first frame update
    void Start()
    {
        //get local iPV4
        serverIP = GetLocalIPv4();

        client1.RemoteHost = userIP1;
        client2.RemoteHost = userIP2;
    }

    public static string GetLocalIPv4()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }
}
