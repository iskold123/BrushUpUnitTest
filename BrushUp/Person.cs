using System;

namespace BrushUp
{
    public enum GenderType
    {
        male,
        female
    };

    public class Person
    {
        private string _name;
        private string _address;
        private GenderType _genderType;

        public Person(string name, string address, GenderType genderType)
        {
            _name = name;
            _address = address;
            _genderType = genderType;

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

        public  GenderType Gender
        {
            get { return _genderType; }
            set { _genderType = value; }
        }
        public virtual string ToString()
        {
            return "";
        }
    }
        
    }