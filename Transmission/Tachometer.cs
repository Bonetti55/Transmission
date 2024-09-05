namespace Transmission;

public abstract class Tachometer
{
    public static void LogRpmAndGear(int rpm, int gear)
    {
        Console.WriteLine($"rpm: {rpm}, gear: {gear}");
    }
    
}