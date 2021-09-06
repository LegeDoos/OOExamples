using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExamplesRWA.Model
{
    public class ChildClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // onderstaande ParentClass is het ParentClass object dat bij dit ChildClass object hoort
        public ParentClass TheParent { get; set; }

        // constructor
        public ChildClass(int id, string name, ParentClass theParent)
        {
            Id = id;
            Name = name;
            TheParent = theParent;
        }
    }

}
