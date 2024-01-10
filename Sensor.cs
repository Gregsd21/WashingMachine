//This is the abstract Sensor class for checking various sensors by extending the ability to check them. The sensors involved are for the Door, Temp, and Water. 

public abstract class Sensor
{
    public bool Check()
    {
        Console.WriteLine("Checking Sensor...");
        return true; 
    }
} 