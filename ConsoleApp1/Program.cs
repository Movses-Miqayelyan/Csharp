namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Clock c = new Clock(6, 59);
            c.addMinute();
    }
}

struct Clock
{
    public int Hour;
    public int Minute;

    public Clock(int hour, int minute)
    {
        Hour = hour;
        Minute = minute;
    }

    public void addMinute()
    {
        Minute++;

        if (Minute > 60)
        {
            Minute = 0;
            Hour++;
        }
    }
}