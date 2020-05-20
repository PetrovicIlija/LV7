using System;
using System.Collections.Generic;
using System.Text;

namespace drugi
{
    class LinearSearch:SearchStrategy
    {
        public int Search(double[] array, double toSearch)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == toSearch)
                    return i;
            return -1;
        }
    }
}
