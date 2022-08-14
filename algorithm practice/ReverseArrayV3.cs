// I realised ReverseArray v2 would not work in some instances, if you had duplicates in your array
// V3 will now be the most efficient way
namespace AlgorithmPractice
{
    internal class ReverseArrayV3
    {
        public static void Run()
        {

            string[] cars = { "one", "two", "three", "four", "five", "six", "seven", "eight", };
            int caCounter = cars.Length - 1;
            string x;


            for (int i = 0; i < (cars.Length / 2); i++)
            {
                x = cars[i];
                cars[i] = cars[caCounter];
                cars[caCounter] = x;
                caCounter--;
            }
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }


        }
    }
}
