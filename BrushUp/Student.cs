using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BrushUp
{
    public class Student : Person
    {
        private int _semester;

        public int Semester
        {
            get => _semester;
            set
            {
                if (value >= 1 && value <= 8)
                {
                    _semester = value;
                }   
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Student(string name, string address, int semester) : base(name, address, GenderType.female)
        {
            _semester = semester;
        }

        public override string ToString()
        {
            return $"mit navn er {Name}";
        }
    }
}
