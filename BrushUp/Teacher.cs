using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp
{
    public enum GenderT
    {
        Male,
        Female
    }

    public class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _salary = value;
            }
        }

        public Teacher(string name, string address, int salary, GenderT gender) : base(name, address, gender)
        {
            _salary = salary;
        }

        public GenderT Gender { get; set; }

        public override string ToString()
        {
            return Name + " " + Salary;

        }
    }
}
