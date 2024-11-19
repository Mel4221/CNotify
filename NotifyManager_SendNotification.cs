using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
namespace CNotify
{
    public partial class NotifyManager
    {
        // Method to send a notification using notify-send (Linux command line)
        public void SendNotification(string title, string message)
        {
            string command = $"\"{title}\" \"{message}\"";
            try
            {
                Process.Start("notify-send", command);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending notification: {ex.Message}");
            }
        }
    }
}
