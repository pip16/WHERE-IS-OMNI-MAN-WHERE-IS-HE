using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_9
{
    internal class Cardiology
    {
        public int departmentid;
        public string name;
        public Doctor headOfDepartment;
        public List<Doctor> doctors = new List<Doctor>();
        public bool[] beds;
        public Cardiology() { }
        public Cardiology(int departmentid) { this.departmentid = departmentid; }
        public Cardiology(int departmentid, string name) : this(departmentid) { this.name = name; }

        public void AddDoctor(Doctor medic)
        {
            doctors.Add(medic);
        }
        public void RemoveDoctor(Doctor medic)
        {
            doctors.Remove(medic);
        }
        public void FindDoctors(Doctor medic)
        {
            
        }
        public int GetAvailableBeds()
        {

        }
    }
}
