using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Dz.Models;


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
