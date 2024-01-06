using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp
{

    class CalendarEvent
    {
        public DateTime Date { get; set; }
        public string EventName { get; set; }
    }

    class CalendarApp
    {
        private List<CalendarEvent> events;

        public CalendarApp()
        {
            events = new List<CalendarEvent>();
        }

        public void AddEvent(DateTime date, string eventName)
        {
            events.Add(new CalendarEvent { Date = date, EventName = eventName });
            Console.WriteLine("Event added successfully.");
        }

        public void ViewEvents()
        {
            foreach (var calendarEvent in events)
            {
                Console.WriteLine($"{calendarEvent.Date}: {calendarEvent.EventName}");
            }
        }

        // You can add more features like editing and deleting events
    }
    class Program
    {
        static void Main()
        {
            CalendarApp calendarApp = new CalendarApp();

            // Example usage
            calendarApp.AddEvent(new DateTime(2024, 1, 10), "Meeting with John");
            calendarApp.AddEvent(new DateTime(2024, 1, 15), "Project deadline");

            calendarApp.ViewEvents();
            Console.ReadLine();
        }
    }
}
