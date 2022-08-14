namespace AlgorithmPractice
{
    internal class SumEvenNumber
    {
        public static int SumNum(int[] xxx)
        {
            int counter = 0;
            int final = 0;
            foreach (int i in xxx)
            {

                int num = i % 2;
                if (num == 0)
                {
                    counter++;
                    final += i;
                }

            }
            return final;
        }
    }
}