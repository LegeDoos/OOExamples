using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExamplesRWA.Model
{
    public class ParentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        // onderstaande <List< implementeerd de "een op veel" relatie van ParentClass met ChildClass
        public List<ChildClass> ListOfChildClasses = new List<ChildClass>();

        // constructor
        public ParentClass(int id, string name, string status)
        {
            Id = id;
            Name = name;
            Status = status;
        }

        // object toevoegen aan lijst met ChildClass objecten
        public void AddChildClass(ChildClass childclass)
        {
            ListOfChildClasses.Add(childclass);
        }

    }
}
