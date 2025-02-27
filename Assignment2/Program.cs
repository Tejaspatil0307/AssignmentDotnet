namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            double Tax_Dediction = salary * 0.1;
            double bonus = 0;
            Console.WriteLine("Enter Rating from 0 to 10:");
            int rating = Convert.ToInt32(Console.ReadLine());
            if (rating >= 8)
            {
                bonus = salary * 0.2;

            }
            else if (rating >= 5)
            {
                bonus = salary * 0.1;
            }
            double finalSalary = (salary - Tax_Dediction) + bonus;
            Console.WriteLine($"TAX : {finalSalary}");



            #region 2 Question
            Console.WriteLine("*****************************************");
            const double General_tkt = 200D;
            const double Ac_tkt = 400D;
            const double Sleeper_tkt = 700D;
            bool book_tkt = true;
            double tkt_price = 0;
            int tkt_number;
            string choice;


            Console.WriteLine("welcom to Book Your Ticket");
            Console.WriteLine("Enter Choice from 1 To 4:\n1.General 200Rs \n2.A/c 1000Rs \n3.Sleeper 500Rs \n4.Exit");


            while (book_tkt)
            {

                Console.WriteLine("Enter Your Ticket Type (general/ac/sleeper)");
                Console.WriteLine("Type '4.exit' to finish booking.");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter number of ticket");
                        tkt_number = Convert.ToInt32(Console.ReadLine());
                        tkt_price = (General_tkt * tkt_number);
                        Console.WriteLine($"price : {tkt_price}");
                        break;
                    case "2":
                        Console.WriteLine("Enter number of ticket");
                        tkt_number = Convert.ToInt32(Console.ReadLine());
                        tkt_price = (Ac_tkt * tkt_number);
                        Console.WriteLine($"price : {tkt_price}");
                        break;
                    case "3":
                        Console.WriteLine("Enter number of ticket");
                        tkt_number = Convert.ToInt32(Console.ReadLine());
                        tkt_price = (Sleeper_tkt * tkt_number);
                        Console.WriteLine($"price : {tkt_price}");
                        break;
                    case "4":
                        Console.WriteLine("thank you for visit");
                        Console.WriteLine($"final price of booked tickets : {tkt_price}");
                        book_tkt = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input Provided");
                        break;

                }
            }
            #endregion

            #region 3Question
            Console.WriteLine("**************************************************");


            string[] username = { "Tejas_123", "sam26", "dao_03" };
            double[] Wallet_amount = { 12000, 15000, 30000 };
            bool IsValidUserId = false;

            while (true)
            {
                Console.WriteLine("Enter your User ID");
                string User_id = Console.ReadLine();

                for (int i = 0; i < username.Length; i++)
                {
                    if (username[i] == User_id)
                    {
                        
                        Console.WriteLine($"Your user name : {User_id} \nAmount in your Wallet : {Wallet_amount[i]}");
                        IsValidUserId = true;
                        break;
                    }
                }
                if (IsValidUserId)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid User Id Please Try Again");
                    
                }

                #endregion

            }
        }
    }
}

    




    

