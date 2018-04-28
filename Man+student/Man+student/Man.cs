using System.IO;

namespace Man_student
{
    public class Man
    {
        protected string _name;
        protected int _age;
        protected double _weight;
        protected double _height;

        public Man(string name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("age can't be negative or 0");
                }

                _age = value;
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("weight can't be negative or 0");
                }

                _weight = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("height can't be negative or 0");
                }

                _height = value;
            }
        }
    }
}
