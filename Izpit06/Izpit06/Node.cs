using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit06
{
    internal class Node
    {
        class Node
        {
            public int Value { get; set; }
            public Node(int value)
            {
                Value = value;
            }
        }
        class DynamicNodeArray <T>
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
                nodes[count++] = new Node(value);
            }
            private void Resize() 
            {
                
            }
            public int Count() 
            {
                return count;
            }
            public int GetValue(int index)
            {
                return nodes[index].Value;
            }
            public void SetValue(int index, int value) 
            {

            }
            public void Print() 
            {
                
            }
        }
    }
}
