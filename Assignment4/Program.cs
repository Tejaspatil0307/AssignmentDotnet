namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserLog user1 = new UserLog("tejas");
            UserLog user2 = new UserLog("omkar");
            UserLog user3 = new UserLog("asd");

            UserLog.GetUserCount();

            #region Ass4.2

            Manager manager = new Manager("Tejas", 500, 400);
            manager.DisplayDetails();
            Employee employee = new Employee("omkar", 5000);
            employee.DisplayDetails();



            #endregion

        }
    }
}
