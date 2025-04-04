using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exceptionn;

class MeetingSchedule
{
    public Meeting[] meeting;
    public void SetMeeting(string fullname, DateTime todate, DateTime fromdate)
    {
        //foreach (var Meeting in meeting)
        //{


        //}

            if(fromdate>todate)
        {
            throw new WrongDateIntervalException("fromdate todate den kicik deyil");
        }
        Meeting[] yenigorush = new Meeting[meeting.Length + 1];
        for (int i = 0; i < meeting.Length; i++)
        {
            yenigorush[i] = meeting[i];
        }
    }
    public MeetingSchedule()
    {
        meeting = new Meeting[0];
    }
}