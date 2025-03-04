namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
         VehicalPolicies vehical1 = new TwoWheelerPolicies( "Tw123",100000,"Two-wheler");

        

        VehicalPolicies vehical2 = new FourWheelerpolicies( "Fw123", 100000,"four wheeler");

            Console.WriteLine($"Policy {vehical1.PolicyNo} ({vehical1.PolicyNo}) - Premium for one year: {vehical1.CalculatePremium()}");
            Console.WriteLine($"Policy {vehical2.PolicyNo} ({vehical2.PolicyNo}) - Premium for one year:: {vehical2.CalculatePremium()}");


        }
    }
}
