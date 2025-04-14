using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_9
{
    internal class Surgery
    {
        public readonly int departmentid;
        public string name;
        public Cardiology headOfDepartment;
        public List<Doctor> doctors;
        public bool[] beds;
    }
}
