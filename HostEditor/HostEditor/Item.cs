using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostEditor
{
    class Item
    {
        public string IPAdress { get; set; }
        public string HostName { get; set; }
        public bool Access { get; private set; }
        public Item(string ip, string host, bool access = false)
        {
            IPAdress = ip;
            HostName = host;
            Access = access;
        }

        public override string ToString()
        {
            return IPAdress + " " + HostName;
        }
    }
}
