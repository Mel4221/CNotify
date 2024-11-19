using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
namespace CNotify
{
    public partial class NotifyManager
    {
        public void ProcessCMD(string[] cmd)
        {
            string action, obj, prop, value;
            //update mini2 enabled = true
            action = cmd[0];
            obj = cmd[1];
            prop = cmd[2];
            value = cmd[4];
            Server server = GetServer(obj);
            if (server.Name == null)
            {
                PrintError($"SERVER NOT FOUND: {obj}");
                return;
            }
            switch (action)
            {
                case "update":
                    switch (prop)
                    {
                        case "enabled":
                            Servers[server.Index].IsIgnored = value == "true" ? true : false;
                            break;
                        case "name":
                            Servers[server.Index].Name = value;
                            break;
                        case "ip":
                            Servers[server.Index].Ip = value;
                            break;
                        case "info":
                            Servers[server.Index].Info = value;
                            break;
                        default:
                            PrintError($"NOT VALID PROPERTY: {prop}");
                            break;
                    }
                    Console.WriteLine($"\n[{action.ToUpper()}]\n");
                    Console.WriteLine(Servers[server.Index]);
                    break;
                default:
                    PrintError($"NOT VALID ACTION: {action}");
                    break;
            }


        }
    }
}
