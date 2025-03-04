using AACSharp_Odev_2_Abstraction.Odev1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Odev_2_Abstraction.Odev1
{
    public class BMW : Car, IFast, ISwim, IFly
    {
        public void Flies()
        {
            Console.Write("havada uçar .");
        }

        public void GoesFast()
        {
            Console.Write("Çok hızlı gider ,");
        }

        public void Swim()
        {
            Console.Write("denizde yüzer,");
        }
    }
}
