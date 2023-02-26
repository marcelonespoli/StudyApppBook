using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodAndStrategy.Strategy.Sorter
{
    public class BubbleSorter
    {
        private int operations = 0;
        private int length = 0;
        private readonly SortHandler _sortHandler;

        public BubbleSorter(SortHandler sortHandler)
        {
            _sortHandler = sortHandler;
        }

        public int Sort(object array)
        {
            _sortHandler.SetArray(array);
            length = _sortHandler.Length();
            operations = 0;
            if (length <= 1)
                return operations;
            for (int nextToLast = length - 2; nextToLast >= 0; nextToLast--)
            {
                for (var index = 0; index <= nextToLast; index++)
                {
                    if (_sortHandler.OutOfOrder(index))
                    {
                        _sortHandler.Swap(index);
                    }
                    operations++;
                }
            }
            return operations;
        }
    }
}
