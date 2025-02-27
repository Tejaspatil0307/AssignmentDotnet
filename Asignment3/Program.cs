namespace Asignment3
{
    internal class Program
    {


        static void Main(string[] args)
        {//object creation
            Car c1 = new Car();
            c1.carDetails();
            //c1.carDetails(1, "Toyota", "Legander", 2015, 550000);
            c1.Display();
            Console.WriteLine("**************");
            #region Q2 Parmaterize Constructor

            //Car c2 = new Car(2, "Toyota", "Camery", 2018, 500000);

            //c2.Display();
            #endregion

            #region Q3 Password
            //Console.WriteLine("Enter password it must contain 6 chars,atlist 1uppercase,one digit:");
            //String pass = Console.ReadLine();

            //if (pass.Length >= 6 && pass.Any(char.IsUpper) && pass.Any(char.IsDigit))
            //{
            //    Console.WriteLine("Valid Password:");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid password:");
            //}
            #endregion




        }
    }
}
