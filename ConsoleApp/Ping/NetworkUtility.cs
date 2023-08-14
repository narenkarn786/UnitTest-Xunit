using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DNS;

namespace ConsoleApp.Ping
{
    public class NetworkUtility
    {
        private readonly IDNS _dNS;

        public NetworkUtility(IDNS dNS)
        {
            _dNS = dNS;
        }
        public string SendPing()
        {
            var dnssuccess = _dNS.SendDNS();
            if (dnssuccess)
            {
                return "Success: Ping Sent";
            }
            else
            {
                return "Failed: Ping Not Sent";
            }
        }
    }
}
