using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
namespace CNotify
{
    public partial class NotifyManager
    {
        public bool ExitRequest = false;
        public int LoopRate = 1000;//1s

        // List of IP addresses to check
        public List<Server> Servers = new List<Server>()
    {
          new Server()
        {
            Name="mini",
            Ip="192.168.8.100",
            Info="Ethernet",
            Index=0
        },
        new Server()
        {
            Name="mini2",
            Ip="192.168.8.101",
            Info="WIFI",
            Index=1
        },
    };

    }
}
