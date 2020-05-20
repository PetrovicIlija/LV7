﻿using System;
using System.Collections.Generic;
using System.Text;

namespace prvi
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                    if (array[j] > array[j + 1])
                        Swap(ref array[j + 1], ref array[j]);
        }
    }
}
