namespace Transmission;

public class Car
{
    private int rpm = 700;
    private int gear = 0;
    private Tachometer tachometer = new Tachometer();

    public void TurnOn()
    {
        gear += 1;
        StartRevving();
    }

    private void Shifting()
    {
        switch (rpm)
        {
            case 2100 when gear == 1:
            case 2400 when gear == 2:
            case 2700 when gear == 3:
                gear += 1;
                rpm -= 800;
                break;
        }
    }

    private void StartRevving()
    {
        while (rpm >= 700)
        {
            rpm += 10;
            Shifting();
            Tachometer.LogRpmAndGear(rpm, gear);
            Thread.Sleep(20);
        }
    }
}