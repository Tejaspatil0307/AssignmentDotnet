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

            Car c2 = new Car(2, "Toyota", "Camery", 2018, 500000);

            c2.Display();

            Console.WriteLine("enter password");

            
       

        }
    }
}
