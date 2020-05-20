using System;

namespace drugi
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchStrategy searchStrategy = new LinearSearch();
            Random random = new Random();
            double[] myArray = new double[10];
            for (int i = 0; i < 10; i++)
                myArray[i] = random.NextDouble() * 20;
            NumberSequence numberSequence = new NumberSequence(myArray);
            numberSequence.SetSearchStrategy(searchStrategy);
            int firstSearch = numberSequence.Search(myArray[5]), secondSearch = numberSequence.Search(100);
            if (firstSearch == -1)
                Console.WriteLine("Broj nije pronadjen.");
            else
                Console.WriteLine("Broj pronadjen na " + firstSearch.ToString() + ". mjestu.");
            if (secondSearch == -1)
                Console.WriteLine("Broj nije pronadjen.");
            else
                Console.WriteLine("Broj pronadjen na ", secondSearch, "mjestu");
        }
    }
}
