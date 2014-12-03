using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileBoard
{
  /// <summary>
  /// Задача.
  /// </summary>
  public class Task
  {
    public DateTime Started
    {
      get { return DateTime.Now; }
      set { }
    }

    public DateTime Deadline
    {
      get { return DateTime.Now.AddDays(1); }
      set { }
    }

    public string Description
    {
      get { return "test"; }
      set { }
    }
  }
}
