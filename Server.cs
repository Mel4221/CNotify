using System;
namespace CNotify
{
    public class Server
    {
        public string Name { get; set; } = null;
        public string Ip { get; set; } = null;
        public string Info { get; set; }
        public bool Connected { get; set; } = false;
        public bool IsIgnored { get; set; } = false;
        public int Index { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}\nIp: {this.Ip}\nDescription: {this.Info}\nStatus: {(this.Connected ? "Connected" : "Disconnected")}\nIgnored: {(this.IsIgnored ? "Yes" : "No")}\n";
        }
    }
}
