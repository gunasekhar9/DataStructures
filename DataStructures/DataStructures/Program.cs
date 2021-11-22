using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ln = new LinkedList();
            ln.Add(56);
            ln.Add(30);
            ln.Add(70);
            int position = ln.Search(30);
            position++;
            ln.InsertAtParticularPosition(position, 40);
            ln.Display();
        }
    }
}