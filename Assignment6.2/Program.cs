namespace Assignment6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                WorkshopRegistration eventRegistration = new WorkshopRegistration();

                // Register students
                eventRegistration.RegisterStudent("AI Workshop", 101);
                eventRegistration.RegisterStudent("AI Workshop", 102);
                eventRegistration.RegisterStudent("Cybersecurity", 103);
                eventRegistration.RegisterStudent("AI Workshop", 101); // Duplicate, should be prevented

                // Display registered students
                eventRegistration.DisplayWorkshopRegistrations("AI Workshop");
                eventRegistration.DisplayWorkshopRegistrations("Cybersecurity");
                eventRegistration.DisplayWorkshopRegistrations("Blockchain");
            }
        }
    }
    }
}
