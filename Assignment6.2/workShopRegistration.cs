using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    class workShopRegistration
    {
        // Dictionary to store workshop names as keys and a HashSet of student IDs as values
        private Dictionary<string, HashSet<int>> workshopRegistrations = new Dictionary<string, HashSet<int>>();

        // Register a student for a workshop
        public void RegisterStudent(string workshop, int studentId)
        {
            if (!workshopRegistrations.ContainsKey(workshop))
            {
                // Create a new HashSet for the workshop if it doesn't exist
                workshopRegistrations[workshop] = new HashSet<int>();
            }

            if (workshopRegistrations[workshop].Contains(studentId))
            {
                Console.WriteLine($"Student {studentId} is already registered for {workshop}.");
            }
            else
            {
                workshopRegistrations[workshop].Add(studentId);
                Console.WriteLine($"Student {studentId} successfully registered for {workshop}.");
            }
        }

        // Display registered students for a workshop
        public void DisplayWorkshopRegistrations(string workshop)
        {
            if (workshopRegistrations.ContainsKey(workshop) && workshopRegistrations[workshop].Count > 0)
            {
                Console.WriteLine($"Students registered for {workshop}: {string.Join(", ", workshopRegistrations[workshop])}");
            }
            else
            {
                Console.WriteLine($"No students registered for {workshop}.");
            }
        }
    }
}

