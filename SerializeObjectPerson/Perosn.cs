using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeObjectPerson
{
    public class Person
    {
        public string FName = null;
        public string LName = null;
        public string Phone = null;
        public int Age;

        public Person()
        {

        }

        public Person(string fn, string ln, string ph, int age)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
            Age = age;
        }
    }
}
