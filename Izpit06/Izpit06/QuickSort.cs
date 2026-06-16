using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit06
{
    internal class QuickSort
    {
        public void Sort(DynamicNodeArray array)
        {
            if (array == null || array.Count() < 2)
            {
                return;
            }

            QuickSortMethod(array, 0, array.Count() - 1);
        }

        private void QuickSortMethod(DynamicNodeArray array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivotIndex = Partition(array, left, right);

            QuickSortMethod(array, left, pivotIndex - 1);
            QuickSortMethod(array, pivotIndex + 1, right);
        }

        private int Partition(DynamicNodeArray array, int left, int right)
        {
            int pivot = array.GetValue(right);
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array.GetValue(j) <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }
    }
}
