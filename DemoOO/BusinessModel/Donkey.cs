using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.BusinessModel
{
    class Donkey : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("IA!");
        }
    }
}
