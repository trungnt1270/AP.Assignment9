using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class ReserveSort : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.name.CompareTo(x.name);
        }
    }
}
