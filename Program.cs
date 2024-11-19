using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using CNotify;
class Program
{
  

 

    static void Main(string[] args)
    {
        // Initialize the previous status for each IP to false (assuming they are offline initially)
        NotifyManager manager = new NotifyManager();

        Thread notify = new Thread(()=> { manager.StartNotify(); });
        notify.Start();
        while (true)
        {
            Console.WriteLine("Type exit to exit");
            string[] cmd = Console.ReadLine().ToLower().Split(' ');
            //mini2 enabled = false
            if(cmd.Length > 0)
            {
                string action = cmd[0];
                if(action == "exit")
                {
                    manager.ExitRequest = true;
                    break;
                }if(action == "clear")
                {
                    Console.Clear();
                }
                if (cmd.Length >= 5)
                {
                    manager.ProcessCMD(cmd);
                }
            }
         

        }

    }




}
