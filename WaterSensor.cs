//The Water Sensor which extends the Abstract Sensor Class indicating if water level is correct.

public class WaterSensor : Sensor
{
    public int currentLvl {get; set; }
    public int desiredLvl {get; set; }

    public bool Check()
    {
        Console.WriteLine("Water level correct? (In WaterSensor Class)");
        if (currentLvl==desiredLvl)
        {
        return true; 
        }
        else 
        {
            Console.WriteLine("Water supply insufficient. Check main supply line. (In WaterSensor Class)");
            return false;
        }
    }
}