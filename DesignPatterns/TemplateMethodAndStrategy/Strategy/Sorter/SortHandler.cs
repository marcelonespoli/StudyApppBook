namespace DesignPatterns.TemplateMethodAndStrategy.Strategy.Sorter
{
    public interface SortHandler
    {
        void Swap(int index);
        bool OutOfOrder(int index);
        int Length();
        void SetArray(object array);
    }
}