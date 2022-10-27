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
            listOperation.Display();
            listOperation = new Listoperation();
            listOperation.Add2(70);
            listOperation.Add2(30);
            listOperation.Add2(56);
            listOperation.Display();
            listOperation = new Listoperation();
            listOperation.Add(56);
            listOperation.Add(70);
            listOperation.Display();
            Console.WriteLine("\n");
            listOperation.InsertAtParticularPoistion(2, 30);
            listOperation.Display();
            Console.WriteLine("First element is poped out from linked list = " + listOperation.removeFirstNode().data);
            listOperation.Display();
        }
    }
}
