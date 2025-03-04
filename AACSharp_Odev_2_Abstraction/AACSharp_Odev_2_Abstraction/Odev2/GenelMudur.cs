using AACSharp_Odev_2_Abstraction.Odev2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Odev_2_Abstraction.Odev2
{
    internal class GenelMudur : Calisan, IMaas
    {
        public double MaasinizNedir()
        {
            return 80000; 
        }
    }
}
