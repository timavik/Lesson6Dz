using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Dz.Models;


public class Worker : EmployeeBase
{
  public override void GetDetails()
  {
    Console.WriteLine($"Name: {Name}, Position: {Position}");
  }
}
