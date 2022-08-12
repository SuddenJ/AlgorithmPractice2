
namespace AlgorithmPractice
{
    internal class ReverseArrayV1
    {
            public static void Run()
            {

                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                int lengthArray = cars.Length;
                string[] returnArray = new string[lengthArray];

                int aCount = 0;
                for (int i = (lengthArray - 1); i > -1; i--)
                {

                    returnArray[aCount] = cars[i];
                    aCount++;

                }

                foreach (string car in returnArray)
                {
                    Console.WriteLine(car);
                }

            }
        
    }
}
