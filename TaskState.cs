using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileBoard
{
  /// <summary>
  /// Статус задачи.
  /// </summary>
  public enum TaskState
  {
    // Ожидает 
    Wait,

    // В работе
    InProcess,

    // Выполнено
    Done
  }
}
