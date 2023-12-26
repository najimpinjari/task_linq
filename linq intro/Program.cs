using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>()
            {
                new student() { rollnumber = 1, name = "najim", age = 20 },
                new student() { rollnumber = 2, name = "radhesh", age = 21 },
                new student() { rollnumber = 3, name = "gotya", age = 22 },
                new student() { rollnumber = 4, name = "sham", age = 23 },
                new student() { rollnumber = 5, name = "veda", age = 24 }
            };

            Console.WriteLine("**** all student ****");
            foreach ( student item in students)
            {
                Console.WriteLine($" rollnumber : {item.rollnumber}  name : {item.name}  age ; {item.age}"  );
            }


            //filtering sudent having age 18 to 23

            //List<student> result1 = new List<student>();
            //foreach ( student item in students )
            //{
            //    if (item.age >= 20 && item.age <= 23)
            //    {
            //        result1.Add(item);
            //    }
            //   // result1.Add( item );
            //}
            //Console.WriteLine("**** all student ****having age 18 to 23 ");
            //foreach (student item in result1)
            //{
            //    Console.WriteLine($" rollnumber : {item.rollnumber}  name : {item.name}  age ; {item.age}");
            //}


            //List<student> result2 = new List<student>();
            var result4 = from r1 in students where r1.age >=18 && r1.age <= 23 select r1;

            Console.WriteLine("**** all student filtering sudent having age 18 to 23 ****");
            foreach (student item in result4)
            {
                Console.WriteLine($" rollnumber : {item.rollnumber}  name : {item.name}  age ; {item.age}");
            }


            //var result2 = students.Where(s => s.age >= 18 && s.age <= 23);

            //Console.WriteLine("**** all student filtering sudent having age 18 to 23 ****");
            //foreach (student item in result2)
            //{
            //    Console.WriteLine($" rollnumber : {item.rollnumber}  name : {item.name}  age ; {item.age}");
            //}



            Console.ReadLine();
        }
    }
    public class student //new class 
    {
        public int rollnumber { get; set; }

        public string name { get; set; }     // this is a property 

        public int age { get; set; }
    }
    
}
