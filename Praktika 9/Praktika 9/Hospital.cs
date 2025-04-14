using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_9
{
    internal class Hospital
    {
        public readonly int hospitalid;
        public string name;
        public string address;
        public List<string> departments;
        public Hospital() { }
        public Hospital(int hospitalid) { this.hospitalid = hospitalid; }
        public Hospital(int hospitalid, string name) : this(hospitalid) { this.name = name; }
        public Hospital(int hospitalid, string name, string address) : this(hospitalid, name) { this.address = address; }        
    }
}
