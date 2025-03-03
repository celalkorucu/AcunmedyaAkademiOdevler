using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharpOdev_1_Inheritance
{
    public class Car
    {
        public string carName {  get; set; }
        public string carGear { get; set; }

        public void Read(string carName , string carGear)
        {
            Console.WriteLine(carName + " " + carGear + " viteslidir");
        }
    }
}
