
namespace AlgorithmPractice
{
    internal class ReverseArrayV2
    {
        public static void Run()
        {

            string[] cars = { "Volvo2", "BMW2", "Ford2", "Mazda2", "Tesla2" };
            int carArrayCounter = cars.Length-1;
            int carArrayCounterZero = 0;

            foreach (string car in cars)
            {
                cars[carArrayCounterZero] = cars[carArrayCounter];
                cars[carArrayCounter] = car;
                if (car == cars[carArrayCounter]) { break; }
                carArrayCounter--;
                carArrayCounterZero++;
            }
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }


        }
    }
}
