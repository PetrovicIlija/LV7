using System;

namespace peti
{
    class Program
    {
        static void Main(string[] args)
        {
            IItem[] items = new IItem[]
            {
                new Book("Harry Spotter", 99.99),
                new VHS("Vlak u snijegu", 5.99),
                new DVD("Scooby and the gang face their most challenging mystery ever: " +
                "a plot to unleash the ghost dog Cerberus upon the world. As they race to stop this dogpocalypse," +
                " the gang discovers that Scooby has an epic destiny greater than anyone imagined.", DVDType.MOVIE, 10.99)
            };
            IVisitor visitor = new BuyVisitor();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(items[i].Accept(visitor));  
            }
        }
    }
}
