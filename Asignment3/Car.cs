using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Asignment3
{
    class Car
    {
        private int CarID;
        private string Brand;
        private string Model;
        private int Year;
        private int Price;

        public Car()
        {
        }
        //parametrize Constructor
        public Car(int CarID, string Brand, string Model, int Year, int Price)
        {
            this.CarID = CarID;
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            //Console.WriteLine("parmaetrize Car Information:");
            //Console.WriteLine("CarId:{0}\nBrand:{1}\nModel:{2}\nYear:{3}\nPrice:{4}", CarID, Brand, Model, Year, Price);
        }

        //method
        public void carDetails() {
            Console.WriteLine("Enter the car id: ");
            this.CarID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the brand name: ");
            this.Brand = Console.ReadLine(); 
            Console.WriteLine("Enter the model name: ");
            this.Model = Console.ReadLine();
            Console.WriteLine("Enter the Year: ");
            this.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price: ");
            this.Price = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Reciving Car Information:");
        }
        //method or function

        public void Display() {
            Console.WriteLine("CarId:{0}\nBrand:{1}\nModel:{2}\nYear:{3}\nPrice:{4}",CarID,Brand,Model,Year,Price);
        }



    }
}
