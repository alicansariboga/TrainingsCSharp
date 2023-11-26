using Project10.Customer;
using Project10.Employee;
using System;

namespace Project10
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
        }
    }
}