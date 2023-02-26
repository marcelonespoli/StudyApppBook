namespace DesignPatterns.TemplateMethodAndStrategy.TemplateMethod.Sorter
{
    public class IntBubbleSorter : BubbleSorter
    {
        private int[] array = null;

        public int Sort(int[] array)
        {
            this.array = array;
            lengh = array.Length;
            return DoSort();
        }

        protected override void Swap(int index)
        {
            var temp = array[index]; 
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }

        protected override bool OutOfOrder(int index)
        {
            return (array[index] > array[index + 1]);
        }
    }
}
