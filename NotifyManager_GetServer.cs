using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
namespace CNotify
{
    public partial class NotifyManager
    {
        public Server GetServer(string name)
        {
            Server server = new Server();
            for (int item = 0; item < Servers.Count; item++)
            {
                if (name == Servers[item].Name)
                {
                    server = Servers[item];
                    return server;
                }
            }
            return server;
        }
    }
}
