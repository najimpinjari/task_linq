using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join_A1
{
    class Program
    {
        static void Main()
        {
            // Sample data
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice" },
            new Student { Id = 2, Name = "Bob" },
            new Student { Id = 3, Name = "Charlie" }
        };

            List<Course> courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Math" },
            new Course { CourseId = 102, CourseName = "English" },
            new Course { CourseId = 103, CourseName = "History" }
        };

            // Problem 1: Join students with courses based on student's Id and display the result
            var studentCourseJoin = from student in students
                                    join course in courses on student.Id equals course.CourseId
                                    select new { student.Name, course.CourseName };

            Console.WriteLine("Problem 1: Join students with courses");
            foreach (var item in studentCourseJoin)
            {
                Console.WriteLine($"{item.Name} is enrolled in {item.CourseName}");
            }
            Console.WriteLine();

            // Problem 2: Find students who are not enrolled in any course
            var studentsNotEnrolled = from student in students
                                      join course in courses on student.Id equals course.CourseId into temp
                                      from t in temp.DefaultIfEmpty()
                                      where t == null
                                      select student;

            Console.WriteLine("Problem 2: Students not enrolled in any course");
            foreach (var student in studentsNotEnrolled)
            {
                Console.WriteLine($"{student.Name} is not enrolled in any course");
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
