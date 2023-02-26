namespace DesignPatterns.TemplateMethodAndStrategy.Strategy.Sorter
{
    public class IntSortHandler : SortHandler
    {
        private int[] array = null;

        public void Swap(int index)
        {
            var temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }

        public void SetArray(object array)
        {
            this.array = (int[])array;
        }

        public int Length()
        {
            return array.Length;
        }

        public bool OutOfOrder(int index)
        {
            return array[index] > array[index + 1];
        }
    }
}
