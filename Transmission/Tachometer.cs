namespace Transmission;

public abstract class Tachometer
{
    public static void RevvingAndSwitching()
    {
        for (var rpm = 700; rpm < 4000; rpm++)
        {
            Console.WriteLine(rpm);
                
            switch (rpm)
            {
                case 2100: 
                    Console.WriteLine("gear 2"); 
                    break;
                case 2500: 
                    Console.WriteLine("gear 3"); 
                    break;
                default:
                    Console.WriteLine("gear 4");
                    break;
            }
        }
    }
}