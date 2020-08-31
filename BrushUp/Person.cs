using System;

namespace BrushUp
{
    public class Person
    {
        private string _name;
        private string _address;
        private GenderType _gender;

        public Person(string name, string address, GenderType gender)
        {
            _name = name;
            _address = address;
            _gender = gender;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException();
                if (value == null) throw new ArgumentNullException();
                    _name = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentNullException();
                _address = value;
            }
        }

        public GenderType Gender { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}