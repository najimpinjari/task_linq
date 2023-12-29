using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_filtering_operators_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SIMPLE TYPE SORTING  
            //student s1 = new student();
            //var students = s1.GetStudents();

            //Console.WriteLine("** All Student");

            //foreach (student item in students)
            //{
            //    Console.WriteLine($" rollnumber : {item.rollnumber} name : {item.name} age : {item.age} city : {item.city}");
            //}

            //var rsult = students.OrderBy(s => s.name);  //order by name syntax 
            //Console.WriteLine("** All StudentrderBy(s => s.city)");

            //foreach (var item in rsult)
            //{
            //    Console.WriteLine($" rollnumber : {item.rollnumber} name : {item.name} age : {item.age} city : {item.city}");
            //}

            #endregion SIMPLE TYPE SORTING  


             #region thenby and orderby asending and disending 
            student s1 = new student();
            var students = s1.GetStudents();
            //var result1 = students.OrderBy(s => s.name ).OrderByDescending(s => s.city);
            //Console.WriteLine("** All StudentrderBy(s => s.city)henBy(s => s.city);");

            //foreach (var item in result1)
            //{
            //    Console.WriteLine($" rollnumber : {item.rollnumber} name : {item.name} age : {item.age} city : {item.city}");
            //}

            #endregion thenby and orderby asending and disending 

            var SORTINGNEW = students.OrderByDescending(s => s.age);

            foreach (var item in SORTINGNEW)
            {
                Console.WriteLine($" rollnumber : {item.rollnumber} name : {item.name} age : {item.age} city : {item.city}");
            }



            Console.ReadLine();
        }
    }
    public class student //NEW CLASS 
    {
        public int rollnumber { get; set; }
        public string name { get; set; }
        // PROPERTY IN CLASS
        public int age { get; set; }
        public string city { get; set; }


        public List<student> GetStudents() //list for student 
        {
            return new List<student>()
            {
                new student() {rollnumber = 1 ,name = "rupesh" , age = 31, city = "chandrapur"},
               new student() {rollnumber = 2 ,name = "abhi" , age = 21, city = "pune"},
                 new student() {rollnumber = 3 ,name = "nilesh" , age = 26, city = "mumbai"},
                 new student() {rollnumber = 4 ,name = "arbaj" , age = 23, city = "solapur"},
               new student() {rollnumber = 5 ,name = "kishor" , age = 24, city = "nanded"}

            };
        }
    }
}
