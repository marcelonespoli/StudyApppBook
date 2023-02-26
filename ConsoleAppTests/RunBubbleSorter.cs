using DesignPatterns.TemplateMethodAndStrategy.TemplateMethod.Sorter;

namespace ConsoleAppTests
{
    public class RunBubbleSorter
    {
        public void Execute()
        {
            // var intArray = new int[] { 10, 5, 1, 25 };
            //BbleSorter.Sort(array);

            // using template method for sort int[]
            var intArray = new int[] { 10, 5, 1, 25 };
            var intbuBllerSort = new IntBubbleSorter();
            intbuBllerSort.Sort(intArray);
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }

            // using template method for sort double[]
            var doubleArray = new double[] { 10.33, 5.6, 1, 25.3 };
            var doubleBubllerSort = new DoubleBubbleSorter();
            doubleBubllerSort.Sort(doubleArray);
            foreach (var item in doubleArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
