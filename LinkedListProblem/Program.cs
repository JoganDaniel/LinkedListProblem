using LinkedList;
using System;
namespace LinkedListProblem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked List program!");
            //LinkedList list = new LinkedList();
            //LinkedListStack stack = new LinkedListStack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Display();
            //stack.Peek();
            //stack.Pop();
            //stack.Display();
            Queue queue = new Queue();
            queue.Enqueue(40);
            queue.Enqueue(30);
            queue.Enqueue(56);
            queue.Display();
            queue.Dequeue();
            queue.Display();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Add(90);
            ////list.RemoveFirstNode();
            ////Console.WriteLine(list.Search(70));
            ////list.Display();
            //list.DeleteNodeAtParticularPosition(2);
            //list.Display();
            //list.Size();
            //list.RemoveLastNode();
            //list.Display();
            //list.AddInReverseOrder(56);
            //list.AddInReverseOrder(30);
            //list.AddInReverseOrder(70);
            //list.InsertAtParticularPosition(2, 40);
            //list.Display();   
        }
    }
}