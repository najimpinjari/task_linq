using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderby_in_linq
{
    class Program
    {
        static void Main()
        {
            // Sample data - a list of persons with ages
            List<Person> persons = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 22 },
            new Person { Name = "David", Age = 28 }
        };

            // Sorting persons by name in descending order with a custom comparer
            var sortedPersons = persons.OrderBy(person => person.Name, StringComparer.OrdinalIgnoreCase);

            // Displaying sorted persons
            foreach (var person in sortedPersons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }

            Console.ReadLine();
        }

        // Sample class representing a person
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }
    }
}
