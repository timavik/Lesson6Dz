using Lesson6Dz.Models;

namespace Lesson6Dz
{
  internal class Program
  {
    

    static void Main(string[] args)
    {
      var manager = new Manager { Name = "John Doe", Position = "Manager" };
      var worker = new Worker { Name = "Jane Smith", Position = "Developer" };

      EmployeeRegistry.AddEmployee(manager);
      EmployeeRegistry.AddEmployee(worker);

      var project = new Manager.Project
      {
        ProjectName = "Employee Management System",
        Deadline = new DateTime(2023, 12, 31)
      };

      EmployeeRegistry.ListAllEmployees();
      project.DisplayProjectInfo();

      var foundEmployee = EmployeeRegistry.FindEmployee("John Doe");
      foundEmployee?.GetDetails();
    }
  }
}
