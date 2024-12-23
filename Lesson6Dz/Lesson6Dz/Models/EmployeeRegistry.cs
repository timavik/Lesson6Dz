using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Dz.Models;


public static class EmployeeRegistry
{
  private static List<EmployeeBase> employees = new List<EmployeeBase>();

  public static void AddEmployee(EmployeeBase employee)
  {
    employees.Add(employee);
  }

  public static void ListAllEmployees()
  {
    foreach (var employee in employees)
    {
      employee.GetDetails();
    }
  }

  public static EmployeeBase FindEmployee(string name)
  {
    return employees.Find(e => e.Name == name);
  }
}
