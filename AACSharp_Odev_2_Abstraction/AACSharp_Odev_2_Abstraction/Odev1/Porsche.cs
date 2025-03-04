using AACSharp_Odev_2_Abstraction.Odev1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Odev_2_Abstraction.Odev1
{
    public class Porsche : Car, IFly
    {
        public void Flies()
        {
            Console.Write("Havada uçar.");
        }
    }
}
