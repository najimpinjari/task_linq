using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOIN_OPRETORS
{
    public class TRAINER
    {
        public int TrainerId { get; set; }
                                                // trainer class property 
        public string TrainerName { get; set; }
        public int Experiance {  get; set; }

        public static List<TRAINER> GetTrainer() //method 
        {
            return new List<TRAINER>()
            {
                new TRAINER () { TrainerId = 1, TrainerName = "vikul" ,Experiance = 14},
                new TRAINER () { TrainerId = 2, TrainerName = "usha" ,Experiance = 2},
                new TRAINER () { TrainerId = 3, TrainerName = "atul" ,Experiance = 3 }

            };
        }

    }
    public class Student
    {
        public int Rollnumber { get; set; }
        public string StudentName { get; set;}      // student class property
        public string city { get; set;}

        public int? TrainerId { get; set;}

        public static List<Student> GetStudent()
        {
            return new List<Student>()
            {
                new Student () {Rollnumber = 1,StudentName ="jayesh", city = "dhule", TrainerId = 1 },
                new Student () {Rollnumber = 2,StudentName ="rahesh", city = "nasik", TrainerId = 2 },
                new Student () {Rollnumber = 3,StudentName ="prathm", city = "satara", TrainerId = 1 },
                new Student () {Rollnumber = 4,StudentName ="sham", city = "jalgoan", TrainerId = null },
                new Student () {Rollnumber = 5,StudentName ="najim", city = "sakri", TrainerId = null },



            };

        }


    }

   
}
