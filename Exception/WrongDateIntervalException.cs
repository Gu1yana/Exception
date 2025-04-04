using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionn;

internal class WrongDateIntervalException:Exception
{
    public WrongDateIntervalException(string message):base(message){ }
}
class ReservedDateInterval:Exception
{
    public ReservedDateInterval(string message):base(message) { }
}
