using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AgileBoard
{
  public class StateConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is TaskState)
      {
        var val = (TaskState) value;
        switch (val)
        {
            case TaskState.Wait:
            return 0;
            case TaskState.InProcess:
            return 1;
            case TaskState.Done:
            return 2;
        }
      }
      return 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return Binding.DoNothing;
    }
  }
}
