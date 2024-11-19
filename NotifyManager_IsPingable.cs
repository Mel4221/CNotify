using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace CNotify
{
    public partial class NotifyManager
    {
        // Method to check if the IP is reachable via ping
        public bool IsPingable(string ipAddress)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(ipAddress, 2000); // 2 seconds timeout
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error pinging {ipAddress}: {ex.Message}");
                return false;
            }
        }
    }
}
