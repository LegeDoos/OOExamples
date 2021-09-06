using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.BusinessModel
{
    abstract class Pet : Animal
    {
        public bool IndoorPet { get; set; }
    }
}
