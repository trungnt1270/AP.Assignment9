using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class StudentImple : StudentManageMent
    {
        public bool FindByName(List<Student>students)
        {
            
            Console.WriteLine("Enter the name of student : ");
            string name = Console.ReadLine();

            bool check = false;

            for (int i = 0; i < students.Count; i++)
            {
                 if (students[i].name.Equals(name))
                {
                    check = true;
                    Console.WriteLine(students[i].name + " đã tìm thấy trong mảng , vị trí là :" + i + 1);
                    break;
                }
            }
            return check;
        }

        public bool Remove(List<Student> students, string name)
        {
            bool check = false;

            foreach (var student in students)
            {
                if (student.name.Equals(name))
                {
                    check = true;
                    students.Remove(student);
                    break;
                }
            }
            return check;

        }

        public void Reverse(List<Student> students)
        {
            students.Sort(new ReserveSort());
            foreach (var student in students)
            {
                Console.WriteLine(student.name);
            }
        }

        public void Sort(List<Student> students)
        {

            students.Sort();
            foreach (var student in students)
            {
                Console.WriteLine(student.name);
            }
        }
    }
}
