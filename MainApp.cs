/*Greg Arnold
//Date: 1/8/2024
//Main Application Class that runs the Washine Machine Functions
*/

class MainApp
{
    static void Main()
    {   WashingMachine newWashCycle = new WashingMachine();
        WashOption newWashOption = new WashOption();
        Timer newTimer = new Timer();
        
        newWashCycle.TurnOn();
        newWashOption.SetWashSelection(Console.ReadLine());
        newTimer.SetCount(2);
        newWashCycle.SelectionStart();
    }
}