using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(70);
            qu.Enqueue(30);
            qu.Enqueue(56);
            qu.Dequeue();
            qu.Display();
        }
    }
}