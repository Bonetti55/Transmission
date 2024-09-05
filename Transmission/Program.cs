namespace Transmission
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Я вас категорически приветствую, здесь у нас будет простецкая аля АККП, выберите реджим коробки:");
            Console.WriteLine("Comfort - 'C'");
            Console.WriteLine("Sport - 'S'");
            var mode = Console.ReadLine();
            switch (mode)
            {
                case "C":
                {
                    var carComfort = new Car();
                    carComfort.TurnOnEngineComfort();
                    break;
                }
                case "S":
                {
                    var carSport = new CarSport();
                    carSport.TurnOnEngineSport();
                    break;
                }
                default:
                    throw new Exception("Введите режим коробки передач из предложенных и повторите еще раз!");
            }
        }
    }
}

