using System;

namespace AdoNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepo repository = new EmployeeRepo();  //Creating a object of EmployeeRepository class.

            // UC1 Ensuring the database connection using the sql connection string
            repository.DataBaseConnection();


        }


    }
}