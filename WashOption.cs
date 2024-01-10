//Washing Option class that indicates selections made on the washer to start Washing Machine functioning.

public class WashOption
{
    private int washSelection;

    public int GetWashSelection()
    {
        ConsoleWriteLine("Wash Options:");
        return washSelection;
    }
    public void SetWashSelection(string newWashSelection)
    {
        ConsoleWriteLine(" ***1 For Main\n ***2 Heavy Duty\n ***3 For Delicates\n ***4 For Quick Wash\n ***5 For Whites\nMake a Wash Selection (1-5): {0}\n", newWashSelection);
        washSelection = newWashSelection;
        ConsoleWriteLine("You have selected {0}.\n", newWashSelection);
        
    }
}