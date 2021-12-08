using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Laptop
    {
        public string LaptopName { get; set; }
        public int Price { get; set; }
        public static implicit operator PC (Laptop laptop)
        {
            PC pC = new PC();
            pC.PCName = laptop.LaptopName;
            return pC;
        }

        public static explicit operator Server (Laptop laptop)
        {
            Server server = new Server();
            server.ServerName = laptop.LaptopName;
            return server;
        }

        public static implicit operator int(Laptop laptop)
        {
            return laptop.Price;
        }

        public static explicit operator byte(Laptop laptop)
        {
            return (byte)laptop.Price;
        }
    }
}
