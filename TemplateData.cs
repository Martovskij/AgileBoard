using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileBoard
{
  public class TemplateData : ObservableCollection<Task>
  {
    public TemplateData()
    {
      this.Add(new Task());

      this.Add(new Task());

      this.Add(new Task());
    }
  }
}
