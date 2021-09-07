using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.BusinessModel
{
    public abstract class Animal
    {
        public int NumberOfLegs { get; set; }
        public string Color { get; set; }

        /// <summary>
        /// Gives the sound the animal can make
        /// </summary>
        public abstract void MakeSound();
    }
}
