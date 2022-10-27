using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        // Parameterized constructor to Initializes a new instance of the class
        public Node(int data)
        {
            this.data = data;
        }
    }
}
