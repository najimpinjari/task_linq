using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join_task_1._1
{
    class Standard
    {
        public int Id {  get; set; }
        public string Classteacher { get; set; }

        public double Fees { get; set; }

        public static List<Standard> Getclasses()
        {
            return new List<Standard>
            {
                new Standard { Id = 12, Classteacher = "patil",  Fees =  10000 },
                new Standard { Id = 19, Classteacher = "patil",  Fees =  20000 },
                 new Standard { Id = 11, Classteacher = "more",  Fees =  24000 },
                 new Standard { Id = 1, Classteacher = "pinjari",  Fees =  25000 },


            };
            
        }
    }
}
