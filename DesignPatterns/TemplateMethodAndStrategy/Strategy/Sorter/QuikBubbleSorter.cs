using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodAndStrategy.Strategy.Sorter
{
    public class QuikBubbleSorter
    {
        private int operations = 0;
        private int lengh = 0;
        private readonly SortHandler _sortHandler;

        public QuikBubbleSorter(SortHandler sortHandler)
        {
            _sortHandler = sortHandler;
        }

        public int Sort(object array)
        {
            _sortHandler.SetArray(array);
            lengh = _sortHandler.Length();
            operations = 0;
            if (lengh <= 1)
                return operations;

            var passInOrder = false;
            for (var nextToLast = lengh - 2; (nextToLast >= 0 && !passInOrder); nextToLast--)
            {
                passInOrder = true;
                for (var index = 0; index <= nextToLast; index++)
                {
                    if (_sortHandler.OutOfOrder(index))
                    {
                        _sortHandler.Swap(index);
                        passInOrder = false;
                    }
                    operations++;
                }
            }
            return operations;
        }
    }
}
