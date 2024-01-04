using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JOIN_OPRETORS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TRAINER> trainers = TRAINER.GetTrainer(); // for trainers info call get get trainer list or method so you can hve a list of traners

            Console.WriteLine("*** all student ***");
            foreach (var item in trainers)
            {
                Console.WriteLine($" trainerId : {item.TrainerId} trainername : {item.TrainerName} experiance : {item.Experiance} ");

            }
            //all student for collection 

            List<Student> students = Student.GetStudent();
            Console.WriteLine("*** all students ***");

            foreach(var item in students)
            {
                Console.WriteLine($" rollnumber : {item.Rollnumber} studentname : {item.StudentName} city : {item.city} trainerId : {item.TrainerId}");
            }

            //method syntax 

            var result =
                students.Join(trainers, s => s.TrainerId, t => t.TrainerId, (s, t)
                => new { studentname = s.StudentName, Trainername = t.TrainerName });
            Console.WriteLine("*** student  join trainers ***");

            foreach(var item in result)
            {
                Console.WriteLine($" Student name : {item.studentname} trainer name : {item.Trainername}"); 
            }




            Console.ReadKey();
        }
    }
}
