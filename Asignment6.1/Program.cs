namespace Asignment6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankTokenSystem bank = new BankTokenSystem();

            bank.AddCustomer();//Token 1 added
            bank.AddCustomer();//token 2 added
            bank.NextCustomer();// token 1 is next
            bank.serveCustomer();//servering customer 1
            bank.NextCustomer();//token 2 is next
            bank.serveCustomer();//serveing cut 2
            bank.serveCustomer();//no cust left


        }
    }
}
