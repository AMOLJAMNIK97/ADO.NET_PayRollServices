namespace EmployeePayRollServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo repo = new EmployeeRepo();
            repo.CreateDatabase();
            repo.CreateTable();
        }
    }
}