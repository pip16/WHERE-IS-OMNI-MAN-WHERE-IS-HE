using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_9
{
    internal class Doctor
    {
        public readonly int doctorid;
        public string FirstName;
        public string LastName;
        public string specialization;
        public List<Patient> patients;
        public Doctor() { }
        public Doctor(int doctorid) { this.doctorid = doctorid;}
        public Doctor(int doctorid, string FirstName) : this(doctorid) { this.FirstName = FirstName;}

        public void AddPatient(Patient patient) 
        { 
            patients.Add(patient);
        }
        public void RemovePatient(Patient patient)
        {
            patients.Remove(patient);
        }
        public void FindPatient()
        {

        }
        public void GetPatientCount()
        {

        }
    }
}
