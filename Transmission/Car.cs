namespace Transmission;

public class Car
{
    private int _rpm = 700;
    private int _gear;
    //private Tachometer tachometer = new Tachometer();

    public void TurnOn()
    {
        _gear += 1;
        StartMotorRotation();
    }

    private void Switching()
    {
        switch (_rpm)
        {
            case 2100 when _gear == 1:
            case 2400 when _gear == 2:
            case 2700 when _gear == 3:
                _gear += 1;
                _rpm -= 800;
                break;
        }
    }

    private void StartMotorRotation()
    {
        while (_rpm <4000)
        {
            _rpm += 10;
            Switching();
            Tachometer.LogRpmAndGear(_rpm, _gear);
            Thread.Sleep(50);
        }

        while (_rpm ==4000)
        {
            Console.WriteLine("Отсечка");
            Tachometer.LogRpmAndGear(_rpm, _gear);
            Thread.Sleep(50);
        }
    }
}