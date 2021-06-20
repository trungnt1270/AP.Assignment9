using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    interface StudentManageMent
    {
        void Sort(List<Student> students);
        bool Remove(List<Student> students,string name);
        void Reverse(List<Student> students);
        bool FindByName(List<Student> students);
    }
}
