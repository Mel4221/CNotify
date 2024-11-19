using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
namespace CNotify
{

    public partial class NotifyManager
    {
        public void StartNotify()
        {
            while (!ExitRequest)
            {

                for (int item = 0; item < Servers.Count; item++)
                {
                    Server server = Servers[item];
                    bool isReachable = IsPingable(server.Ip);

                    if (isReachable &&
                        !server.Connected &&
                        !server.IsIgnored)
                    {
                        Servers[item].Connected = true; // Update status
                                                        // IP became reachable
                        SendNotification($"Server {server.Name} online", $"{server}");
                        //Thread.Sleep(2000);
                        Console.WriteLine(server);
                    }
                    else if (!isReachable &&
                             server.Connected &&
                             !server.IsIgnored)
                    {
                        Servers[item].Connected = false; // Update status
                                                         // IP became unreachable
                        SendNotification($"Server {server.Name} offline", $"{server}");
                        Console.WriteLine(server);

                    }
                }
                // Check every 60 seconds (or adjust based on your needs)
                Thread.Sleep(LoopRate);
            }
        }
    }
}
