using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace IP_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Is_valid_IP("12.34.56"));
            Console.ReadKey();
        }

        public static bool Is_valid_IP(string IpAddres)
        {
            IPAddress ip;
            
            int i = 0, period = 0;
            
            foreach(char a in IpAddres)
            {
                if (a == '.')
                    period++;
            }

            if (period < 3 || period > 4)
                return false;

            return IPAddress.TryParse(IpAddres, out ip);
            

            end:;

        }
    }
}
