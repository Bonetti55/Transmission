namespace Transmission;

public class CarSport
{
    private int _rpm = 1000;
    private int _gear;

    public void TurnOnEngineSport()
    {
        _gear += 1;
        StartMotorRotation();
    }

    private void Switching()
    {
        switch (_rpm)
        {
            case 3400 when _gear == 1:
            case 3500 when _gear == 2:
            case 3700 when _gear == 3:
                _gear += 1;
                _rpm -= 1000;
                break;
        }
    }

    private void StartMotorRotation()
    {
        while (_rpm < 4000)
        {
            _rpm += 10;
            Switching();
            Tachometer.LogRpmAndGear(_rpm, _gear);
            Thread.Sleep(50);
            Console.Clear();
            
        }

        while (_rpm == 4000)
        {
            Console.WriteLine("Отсечка");
            Tachometer.LogRpmAndGear(_rpm, _gear);
            Thread.Sleep(50);
            Console.Clear();
        }
    }
}