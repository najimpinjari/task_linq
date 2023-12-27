using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace filtering_oprator__linq
{
    class Program
    {
        static void Main(string[] args)
        {

            #region where oprator
            student s = new student(); //object for calling method
            var students = s.GetStudents();

            Console.WriteLine(" *** ALl student ***");
            foreach (student item in students)
            {
                Console.WriteLine($" rollnumber :{item.rollnumber} name : {item.name} age ;{item.age}  city ; {item.city}");
            }


            //using linq short the code 
            var result = students.Where(a => a.city.Equals("pune"));

            Console.WriteLine(" *** ALl student from pune ***");
            foreach (student item in result)
            {
                Console.WriteLine($" rollnumber :{item.rollnumber} name : {item.name} age ;{item.age}  city ; {item.city}");
            }

            #endregion where oprator 

            #region OfType operator


            List<object> list = new List<object>()
            { 10,"Vishal", new student(), 10.5f, 20, "Mahesh"};

            var result = list.OfType<int>();
            //var result = list.OfType<string>();
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            List<Car> cars = new List<Car>()
            {
                new Audi(),
                new BMW(),
                new BMW(),
                new BMW(),
                new Audi()
            };

            var result1 = cars.OfType<BMW>();
            foreach (var item in result1)
            {
                Console.WriteLine(item.Name);
            }

            #endregion OfType operator





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
    public class Car
    {
        public string Name { get; set; }
    }

    public class Audi : Car
    {
        public Audi()
        {
            Name = "Audi";
        }
    }

    public class BMW : Car
    {
        public BMW()
        {
            Name = "BMW";
        }
    }
}