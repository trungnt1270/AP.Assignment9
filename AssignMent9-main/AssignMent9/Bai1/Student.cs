using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Student : IComparable <Student>
    {
        public string name;

        public override string ToString()
        {
            return name;
        }
        public int CompareTo(Student student)
        {
            return name.CompareTo(student.name);
        }

    }
}
