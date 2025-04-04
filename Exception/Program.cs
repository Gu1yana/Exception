namespace Exception;

class Program
{
    static void Main(string[] args)
    {
        Meeting gorush1 = new Meeting("Exception", new(2020, 12, 30), new(2021, 01, 1));
        Meeting gorush2 = new Meeting("Exception", new(2010, 11, 2), new(2011, 04, 6));
        Meeting gorush3 = new Meeting("Quiz", new(2000, 12, 3), new(2000, 12, 7));
        MeetingSchedule yenigorush1 = new MeetingSchedule();
        yenigorush1.SetMeeting("Quiz", new(2000, 12, 10), new(2000,12,7));
        try
        {

        }
        catch
        {
            Console.WriteLine(";(");
        }
    }
}
