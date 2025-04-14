using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_9
{
    internal class Patient
    {
        public readonly int patientid;
        public string FirstName;
        public string LastName;
        public DateTime dateOfBirth;
        public string diagnosis;

        public Patient () { }
        public Patient (int patientid) {this.patientid = patientid; }
        public Patient (int patientid, string FirstName) :this (patientid) {this .FirstName = FirstName; }
        public Patient (int patientid, string FirstName, string LastName) :this (patientid, FirstName) {this .LastName = LastName; }
        public Patient (int patientid, string FirstName, string LastName, DateTime dateOfBirth) :this (patientid, FirstName, LastName) { this.dateOfBirth = dateOfBirth; }

        public void UpdateDiagnosis(string NewDiagnosis)
        {
            this.diagnosis = NewDiagnosis;
        }
        public void GetAge(DateTime dateofBirth)
        {
            
        }
        public void ToString()
        {

        }
    }
}
