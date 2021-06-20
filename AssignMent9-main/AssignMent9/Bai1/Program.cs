using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StudentImple studentImple = new StudentImple();

            string inputChoice;

            do
            {

                Student student = new Student();
                Console.WriteLine("Enter student's name :");
                student.name = Console.ReadLine();
                Console.WriteLine("Do you want to add more name ? [Y/N]: ");
                inputChoice = Console.ReadLine();
                students.Add(student);


            } while (inputChoice.StartsWith("Y") || inputChoice.StartsWith("y"));

            Console.WriteLine("List of students :");
            foreach (var student1 in students)
            {
                Console.WriteLine(student1.name);
            }
            Console.WriteLine("Total  number of student is :" + students.Count);
            do
            {
                getMenu();
                int choice;
                do
                {
                    Console.WriteLine("Enter your choice :");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice) 
                {
                    case 1:
                        
                        Console.WriteLine("------------AfterSorting-------");
                        studentImple.Sort(students);
                        Console.WriteLine("Total  number of student is :" + students.Count);

                        break;
                    case 2:
                        Console.WriteLine("Enter the name of student ");
                        string name = Console.ReadLine();

                        Console.WriteLine("------------AfterRemoving-------");
                        if (!studentImple.Remove(students,name))
                        {
                            Console.WriteLine("Ko tim thay ten sinh vien");
                        }
                        else
                        {
                            foreach (var student in students)
                            {
                                Console.WriteLine(student.name);
                            }
                            
                            Console.WriteLine("Total  number of student is :" + students.Count);

                        }
                        break;
                    case 3:
                        Console.WriteLine("------------AfterReserving-------");
                        studentImple.Reverse(students);
                        Console.WriteLine("Total  number of student is :" + students.Count);

                        break;
                    case 4:
                        if (!studentImple.FindByName(students))
                        {
                            Console.WriteLine("Ko tim thay ten sinh vien");
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                      



                }

            } while (true);
            
            
            
            
            
            
            
            
            Console.ReadKey();

        } 
        static void getMenu()
        {
            Console.WriteLine("Select one of the following options");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Reverse");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Exit");
            
        }
    }
}
