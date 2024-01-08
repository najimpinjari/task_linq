using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join_task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Students.GetStudents();
            var classes = Standard.Getclasses();

            //foreach (var item in students)
            //{
            //    Console.WriteLine($" {item.name} {item.standard} {item.Gender} {item.rollnumber}");
            //}
            //Console.ReadLine();
            //var data = from s in students
            //           join c in classes
            //           on s.standard equals c.Id
            //           select new
            //           {
            //               studentsname1 = s.name,
            //               newteacher = c.Classteacher
            //           };


            //var data = from s in students
            //           join c in classes
            //           on s.standard equals c.Id
            //           select new
            //           {
            //               studentsname1 = s.name,
            //               newteacher = c.Classteacher
            //           };

            //foreach (var item in data)
            //{
            //    Console.WriteLine($" {item.newteacher} ; {item.studentsname1}");
            //    Console.ReadLine(); 

            //}
            //Console.ReadLine();

            var data = students
               .Join(classes, s => s.standard, c => c.Id, (s, c) => new
               {
                   studentsname1 = s.name,
                   newteacher = c.Classteacher
               });

            foreach (var item in data)
            {
                Console.WriteLine($" {item.newteacher} ; {item.studentsname1}");
            }

            Console.ReadLine();


        }
    }
}
