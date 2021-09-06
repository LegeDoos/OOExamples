using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExamplesRWA.Model
{
    // SubClass is een ChildClass (dus erft de attributen en methoden)
    class SubClass: ChildClass
    {
        public string ExtraAttribute { get; set; }

        // constructor voor subclass gebruikt constructor voor superclass
        public SubClass(int id, string name, ParentClass theParent, string extraAttribute)
            :base(id, name, theParent)
        {
            ExtraAttribute = extraAttribute;
        }
    }
}
