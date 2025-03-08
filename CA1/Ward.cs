using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    internal class Ward
    {
        public static int WardCount { get; set; } = 0;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; }

        public Ward() : this("New Ward", 10) { }
        public Ward(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Patients = new List<Patient>();
            WardCount++;
        }

        public override string ToString()
        {
            return $"{Name} (Capacity: {Capacity})";
        }
    }
}
