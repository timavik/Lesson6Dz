using System;

public abstract class EmployeeBase
{
  public string Name { get; set; }
  public string Position { get; set; }

  public abstract void GetDetails();
}

// Производный класс Manager
public class Manager : EmployeeBase
{
  public override void GetDetails()
  {
    Console.WriteLine($"Name: {Name}, Position: {Position}");
  }

  public class Project
  {
    public string ProjectName { get; set; }
    public DateTime Deadline { get; set; }

    public void DisplayProjectInfo()
    {
      Console.WriteLine($"Project Name: {ProjectName}, Deadline: {Deadline.ToString("yyyy-MM-dd")}");
    }
  }
}

// Производный класс Worker
public class Worker : EmployeeBase
{
  public override void GetDetails()
  {
    Console.WriteLine($"Name: {Name}, Position: {Position}");
  }
}

// Статический класс EmployeeRegistry
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
