using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            Listoperation listOperation = new Listoperation();
            listOperation.Add(56);
            listOperation.Add(30);
            listOperation.Add(70);
            listOperation.display();
        }
    }
}
