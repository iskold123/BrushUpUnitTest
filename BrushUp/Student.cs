using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BrushUp
{
    public enum GenderType
    {
        Male,
        Female
    }

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

        public Student(string name, string address, int semester, GenderType gender) : base(name, address, gender)
        {
        }
    }
}
