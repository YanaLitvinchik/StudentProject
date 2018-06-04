using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    class Student
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public Student()
        {

        }
        public Student(string _name, string _secondname, string _surname)
        {
            this.Name = _name;
            this.SecondName = _secondname;
            this.Surname = _surname;
        }
        public override string ToString()
        {
            return $"{Surname} {Name}";
        }
    }
}
