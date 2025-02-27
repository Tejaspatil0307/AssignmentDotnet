namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();
            Console.WriteLine("name of student is:" + name);

            Console.WriteLine("Enter Your Age:");

            int age;
            bool result;
            result = int.TryParse(Console.ReadLine(), out age);

            if (!result)
            {
                Console.WriteLine("plz enter valid age");
                result = int.TryParse(Console.ReadLine(), out age);
            }

            Console.WriteLine("age of student is:" + age);

            double percentage;
            Console.WriteLine("Enter Your percentage:");
            percentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("percentage of student is:" + percentage);

            string email;
            Console.WriteLine("Enter Your email:");
            email = Console.ReadLine();
            if (email == "")
            {
                Console.WriteLine("plz enter email");
                email = Console.ReadLine();
            }
            Console.WriteLine("email of student is:" + email);


            //string datetime;
            Console.WriteLine("Enter DateTime:");
            string date = Console.ReadLine();
            DateTime? dischargeDate = null;

            if (string.IsNullOrEmpty(date) && DateTime.TryParse(date, out DateTime parsedDate))
            {
                dischargeDate = parsedDate;

            }

            if (dischargeDate.HasValue)
            {
                Console.WriteLine($"discharged Date:{dischargeDate.Value}");
            }
            else
            {
                Console.WriteLine("not Discharged");
            }
        }
    }
}
