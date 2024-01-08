using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace join_task_1._1
{
    class Students
    {
        public int rollnumber { get; set; }
        public string name { get; set; }

        public int standard { get; set; }

        public Gender Gender { get; set; }
        public static List<Students> GetStudents()
        {
            return new List<Students>
            {
            new Students { rollnumber = 101, name = "najim", Gender = Gender.male, standard = 10 },
             new Students { rollnumber = 102, name = "radhesh", Gender = Gender.male, standard = 8 },
            new Students { rollnumber = 103, name = "pratham", Gender = Gender.male, standard = 13 },
            new Students { rollnumber = 104, name = "farin", Gender = Gender.female, standard = 16 },
            new Students { rollnumber = 105, name = "sagar", Gender = Gender.male, standard = 16 },
             new Students { rollnumber = 106, name = "vasudha", Gender = Gender.female, standard = 15 },
             new Students { rollnumber = 107, name = "gopal", Gender = Gender.male, standard = 2 },
            new Students { rollnumber = 108, name = "zoya", Gender = Gender.female },

            };

        }

    }
    public enum Gender
    {
        male ,
        female 
    }
}
