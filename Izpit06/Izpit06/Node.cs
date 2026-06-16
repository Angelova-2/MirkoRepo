namespace Izpit06
{
    internal class Node
    {
        public int Value { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    internal class DynamicNodeArray
    {
        private Node[] nodes;
        private int count;

        public DynamicNodeArray()
        {
            nodes = new Node[2];
            count = 0;
        }

        public void Add(int value)
        {
            if (count == nodes.Length)
            {
                Resize();
            }

            nodes[count] = new Node(value);
            count++;
        }

        private void Resize()
        {
            Node[] newArray = new Node[nodes.Length * 2];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = nodes[i];
            }

            nodes = newArray;
        }

        public int Count()
        {
            return count;
        }

        public int GetValue(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            return nodes[index].Value;
        }

        public void SetValue(int index, int value)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            nodes[index].Value = value;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(nodes[i].Value + " ");
            }

            Console.WriteLine();
        }
    }
}
