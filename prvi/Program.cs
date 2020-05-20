using System;

namespace prvi
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            double[] myArray = new double[10];
            for (int i = 0; i < 10; i++)
                myArray[i] = random.NextDouble() * 20;
            NumberSequence[] numberSequence = new NumberSequence[]{
            new NumberSequence(myArray),
            new NumberSequence(myArray),
            new NumberSequence(myArray) };
            SortStrategy[] sortStrategies = new SortStrategy[] { 
            new BubbleSort(),
            new SequentialSort(),
            new CombSort()
            };
            for (int i = 0; i < 3; i++)
            {
                numberSequence[i].SetSortStrategy(sortStrategies[i]);
                numberSequence[i].Sort();
                Console.WriteLine(numberSequence[i].ToString());
            }

        }
    }
}
