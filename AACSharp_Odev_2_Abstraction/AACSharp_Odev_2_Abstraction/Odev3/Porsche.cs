using AACSharp_Odev_2_Abstraction.Odev3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Odev_2_Abstraction.Odev3
{
    internal class Porsche : Araba, IYakit
    {
        public double Yakit()
        {
            return 60;
        }
    }
}
