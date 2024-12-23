using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Dz.Models;

public abstract class EmployeeBase
{
  public string Name { get; set; }
  public string Position { get; set; }

  public abstract void GetDetails();
}
