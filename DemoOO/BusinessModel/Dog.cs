using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.BusinessModel
{
    class Dog : Pet
    {
        public override void MakeSound()
        {
            MakeSoundIntern();
        }

        internal void MakeSoundIntern()
        {
            Console.WriteLine("Bark");
        }
    }
}
