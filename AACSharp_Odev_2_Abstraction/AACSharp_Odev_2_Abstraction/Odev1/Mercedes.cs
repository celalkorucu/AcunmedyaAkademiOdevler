using AACSharp_Odev_2_Abstraction.Odev1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Odev_2_Abstraction.Odev1
{
    public class Mercedes : Car, ISwim, IFly
    {
        public void Flies()
        {
            Console.Write("havada uçar.");
        }

        public void Swim()
        {
            Console.Write("Denizde yüzer ,");
        }
    }
}
