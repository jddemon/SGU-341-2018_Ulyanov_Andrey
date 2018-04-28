using System;
using System.IO;

namespace Book
{
    public class Author
    {
        private string _name;
        private string _surname;
        private DateTime _birthDate;


        public Author(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
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

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _surname = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                if (value.Date >= DateTime.Now.Date)
                {
                    throw new InvalidDataException("birth date can't be in future ");
                }

                _birthDate = value;
            }
        }

        public override string ToString()
        {
            return $"{Name},{Surname},{BirthDate}";
        }

    }
}
