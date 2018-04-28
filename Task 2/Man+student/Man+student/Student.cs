using System.IO;

namespace Man_student
{
    class Student : Man
    {
        private int _yearOfBegin;
        private int _course;
        private int _groupNumber;


        public Student(string name, int age, double weight, double height) 
            : base(name, age, weight, height)
        {
        }


        public Student(string name, int age, double weight, double height, int yearOfBegin, int course, int groupNumber) 
            : base(name, age, weight, height)
        {
            YearOfBegin = yearOfBegin;
            Course = course;
            GroupNumber = groupNumber;
        }

        public int YearOfBegin
        {
            get
            {
                return _yearOfBegin;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("year of begin number can't be negative or 0");
                }

                _yearOfBegin = value;
            }
        }

        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("course number can't be negative or 0");
                }

                _course = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return _groupNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("group number number can't be negative or 0");
                }

                _groupNumber = value;
            }
        }

        public override string ToString()
        {
            return $"{Name},{Age}, {Height}, {Weight}, {YearOfBegin}, {Course}, {GroupNumber}";
        }

    }
}
