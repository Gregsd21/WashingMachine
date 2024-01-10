//Washing Machine class with all functions that make up the operations of the washer. 
//Extends the IMachine Interface to turn on/off.
//Associates with the Engine, Water Sensor, Timer, and Wash Options classes. 

public class WashingMachine : IMachine
{
        private int washTime;
        private int rinseTime;
        private int spinTime;
        private Timer timer;
        private WashOption washOption;
        private WaterSensor waterSensor;
        private Engine engine;

    //Constructor for associated class parameters. 
    public WashingMachine(int washTime, int rinseTime, int spinTime)
    {
       this.washTime = washTime;
       this.rinseTime = rinseTime;
       this.spinTime = spinTime;
    }
    
    public void TurnOn()
    {
        Console.WriteLine("Washer has power in WashingMachine class.");
    }
    public void TurnOff()
    {
        Console.WriteLine("Washer power removed operation in WashingMachine class.");
    }
    public void Wash()
    {   int washTime = 20;
        Console.WriteLine("Washing clothes operation in WashingMachine class for {0} minutes...", washTime);
    }
    public void Rinse()
    {   int rinseTime = 10;
        Console.WriteLine("Rinsing clothes operation in WashingMachine class for {0} minutes...", rinseTime);
    }
    public void Spin()
    {   int spinTime = 10;
        Console.WriteLine("Spinning clothes operation in WashingMachine class for {0} minutes...", spinTime);
    }
    public void Fill()
    {
        Console.WriteLine("Filling operation in WashingMachine class...");
    }
    public void Empty()
    {
        Console.WriteLine("Emptying operation in WashingMachine class...");
    }
    public void DoubleRinse()
    {
        Console.WriteLine("Rinsing clothes twice operation in WashingMachine class...");
    }
    public void Main()
    {
        while (Timer.SetCount()){
        Console.WriteLine("Main Wash Method in WashingMachine class...");
        Timer.SetDuration(60);
        Timer.Start();
        Timer.Count();
        Fill();
        WaterSensor.currentLvl(100);
        WaterSensor.desiredLvl(100);
        Engine.TurnOn(20);
        Wash();
        Rinse();
        DoubleRinse();
        Empty();
        Spin();
        }

        TurnOff();
    }
    public void HeavyDuty()
    {
        Console.WriteLine("Heavy Duty Wash Method in WashingMachine class...");
        Fill();
        Engine.TurnOn(20);
        Wash();
        Rinse();
        DoubleRinse();
        Spin();
        Empty();
        TurnOff();
    }
    public void Delicates()
    {
        Console.WriteLine("Delicates Wash Method in WashingMachine class...");
        Fill();
        Engine.TurnOn(20);
        Wash();
        Rinse();
        DoubleRinse();
        Spin();
        Empty();
        TurnOff();
    }
    public void QuickWash()
    {
        Console.WriteLine("Quick Wash Method in WashingMachine class...");
        Fill();
        Engine.TurnOn(20);
        Wash();
        Rinse();
        DoubleRinse();
        Spin();
        Empty();
        TurnOff();
    }
    public void Whites()
    {
        Console.WriteLine("Whites Wash Method in WashingMachine class...");
        Fill();
        Engine.TurnOn(20);
        Wash();
        Rinse();
        DoubleRinse();
        Spin();
        Empty();
        TurnOff();
    }
    public void SelectionStart()
    {   
       string washOption = this.WashOption;

       if (washOption == "1")
       {
        Main();
       }
       else if (washOption == "2")
       {
        HeavyDuty();
       }
       else if (washOption == "3")
       {
        Delicates();
       }
       else if (washOption == "4")
       {
        QuickWash();
       }
       else if (washOption == "5")
       {
        Whites();
       }
       else
       {
        Console.WriteLine("Invalid Entry.");
       }
    }
    
}