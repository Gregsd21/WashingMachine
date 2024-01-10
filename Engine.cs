//Engine Class to be energized when IMachine interface indicates On. De-energizes when IMachine interface indicates off.

public class Engine : IMachine
{
private int rotation;

public void TurnOn()
{
    Console.WriteLine("Engine energized...starting drum rotation to reach {0} rpm", rotation);
}
public void TurnOff()
{
    Console.WriteLine("Engine de-energized...drum RPM decreasing.");
}
}