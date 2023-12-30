using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruping_in_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region groping 

            student s = new student();
            List<student> stud = s.GetStudents();

            //Console.WriteLine(" ** all student ***");

            //foreach (student item in stud)
            //{
            //    Console.WriteLine($"Roll Number : {item.  rollnumbers} " +
            //       $"Name : {item.name} Age : {item.age} " +
            //       $"City : {item.city}");
            //}


            var groups = stud.GroupBy(s1 => s1.city);
            foreach (var item in groups)
            {
                Console.WriteLine($"  how many citys {item.Key} count :  {item.Count( ) }");

            }



            #endregion groping 


            Console.ReadLine();

        }
    }
    public class student : IComparable
    {
        public int rollnumbers { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public string city { get; set; }

        public int CompareTo(object obj)
        {
            student s = (student)obj;
            // based on age
            if (this.age > s.age)
            {
                return -1;
            }
            else if (this.age < s.age)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<student> GetStudents()
        {
            return new List<student>()
            {
            new student(){ rollnumbers = 1, name = "Vishal", age = 18, city = "Pune"},
            new student(){ rollnumbers = 2, name = "Ajay", age = 21, city = "Mumbai"},
            new student(){ rollnumbers = 3, name = "Mahesh", age = 16, city = "Pune"},
            new student(){ rollnumbers = 4, name = "Dipali", age = 23, city = "Satara"},
            new student(){ rollnumbers = 5, name = "Vrushali", age = 32, city = "Pune"}
            };
        }
    }

}
