using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CA1.MainWindow;

namespace CA1
{
    internal class Patient
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public BloodType BloodType { get; set; }

        public Patient() : this("New Patient", DateTime.Now, BloodType.A) { }
        public Patient(string name, DateTime dob, BloodType bloodType)
        {
            Name = name;
            DateOfBirth = dob;
            BloodType = bloodType;
        }

        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        public override string ToString()
        {
            return $"{Name} (Age: {Age}, Blood Type: {BloodType})";
        }
    }

}
