using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesCsharp02Enum.Entities02
{
    class DepartmentClass
    {
        // # Properties
        public string Name { get; set; }
        // # Constructors

        public DepartmentClass()
        {
        }
        public DepartmentClass(string name)
        {
            Name = name;
        }
    }
}
