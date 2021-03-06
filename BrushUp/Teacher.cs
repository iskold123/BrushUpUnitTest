﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUp
{

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

        public Teacher(string name, string address, int salary) : base(name, address, GenderType.male)
        {
            _salary = salary;
        }

        public override string ToString()
        {
            return ($"mit navn er {Name}");
        }
    }
}
