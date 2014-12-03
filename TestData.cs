using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileBoard
{
  public static class TestData
  {
    public static IEnumerable<Task> Generate()
    {
      var list = new List<Task>();
      list.Add(new Task() { Deadline = DateTime.Now, Started = DateTime.Now, Description = "asdasdasd"});
      list.Add(new Task() { Deadline = DateTime.Now, Started = DateTime.Now, Description = "asdasdasd" });
      list.Add(new Task() { Deadline = DateTime.Now, Started = DateTime.Now, Description = "asdasdasd" });
      return list;
    }
  }
}
