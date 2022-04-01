using System;
using ConsoleApp36.Models;
namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            User users = new User("Kenan Nagiyev", "Kenan2001");
            Group group = new Group("AP205", 18);
            users.ShowInfo();
            Student stud1 = new Student("Ibrahim Huseynov",50);
            Student stud2 = new Student("Murad Niftullayev",60);
            Student stud3 = new Student("Revan Huseynov", 45);
            Student stud4 = new Student("Perviz Hesenov", 76);

            Console.WriteLine("------Menu------");
            int choose = 0;
            do
            {
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        users.ShowInfo();
                        break;
                    case 2:
                        
                        break;
                    default:
                        break;
                }
            } while (choose!=0);

            Console.WriteLine("------Menu------");
            int chouse = 0;
            do
            {
                chouse = Convert.ToInt32(Console.ReadLine());

                switch (chouse)
                {
                    case 1:
                        stud1.StudentInfo();
                        stud2.StudentInfo();
                        stud3.StudentInfo();
                        stud4.StudentInfo();
                        break;
                    case 2:
                        
                        break;
                    default:
                        break;
                }
            } while (chouse!=0);
        }
    }
}
