﻿namespace DesignPatterns.TemplateMethodAndStrategy.TemplateMethod.Sorter
{
    public static  class BbleSorter
    {
        static int operations = 0;
        
        public static int Sort(int[] array)
        {
            operations = 0;
            if (array.Length <= 1)
                return operations;

            for (var nextToLast = array.Length - 2; nextToLast >=0; nextToLast--)
                for (var index = 0; index <= nextToLast; index++)
                    CompareAndSwap(array, index);

            return operations;
        }

        private static void Swap(int[] array, int index)
        {
            var temp = array[index];
            array[index] = array[index + 1];
            array[index+1] = temp;
        }

        private static void CompareAndSwap(int[] array, int index)
        {
            if (array[index] > array[index+1])
                Swap(array, index);
            operations++;
        }
    }
}
