//Timer class for setting operation time of washer.
using System;
using System.Threading;

public class Timer
{
private int value;
private int duration;
private int count;

public int GetDuration()
{   
    ConsoleWriteLine("Getting default cycle duration of zero...");
    return duration;
}
public void SetDuration(int customDuration)
{
    Console.WriteLine("Setting cycle duration to {0} minutes...", customDuration);
    duration = customDuration;
}
public int GetValue()
{   
    ConsoleWriteLine("Getting current time value of cycle...");
    return value;
}
public int SetValue(int time)
{
    ConsoleWriteLine("There is {0} time left in this cycle...", time);
    value = time;
}
public void GetCount()
{
    ConsoleWriteLine("Beginning timer countdown...");
    return count;
}
public int SetCount(int minCount)
{   
    
    for (int counter = minCount; counter > 0; counter--)
    {
    ConsoleWriteLine("Time remaining: {0} minutes...", counter);
    Thread.Sleep(60000);//Sleeps for one minute each iteration.
    count = minCount;
    }
    ConsoleWriteLine("No time remaining for this cycle...");
}
public void Start()
{
    Console.WriteLine("Starting Timer...");
}
public void Count()
{
    Console.WriteLine("Timer counting...");
}

}