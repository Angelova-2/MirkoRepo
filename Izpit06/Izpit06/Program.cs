namespace Izpit06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 9, 1, 7 };

            int c = 0;
            int middle = (array.Length - 1) / 2;
            int pivot = array.Length - 1;

            c = array[pivot];
            array[pivot] = array[middle];
            array[middle] = array[c];

            bool goo = false;

            for (int i = 0; i < array.Count(); i++)
            {
                for (int j = 0; j < array.Count(); j++)
                {
                    if (array[pivot] >= array[j])
                    {
                        
                    }
                }
            }

            foreach (int i in array)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
