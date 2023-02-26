namespace DesignPatterns.TemplateMethodAndStrategy.TemplateMethod.Sorter
{
    public abstract class BubbleSorter
    {
        private int operations = 0;
        protected int lengh = 0;

        protected int DoSort()
        {
            operations = 0;
            if (lengh <= 1)
                return operations;

            for (var nextTolast = lengh - 2; nextTolast >= 0; nextTolast--)
                for (var index = 0; index <= nextTolast; index++)
                {
                    if (OutOfOrder(index))
                        Swap(index);
                    operations++;
                }
            return operations;
        }

        protected abstract void Swap(int index);
        protected abstract bool OutOfOrder(int inex);
    }
}
