﻿using System;

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
            ln.Display();
            int pos = ln.Search(40);
            ln.DeleteNodeAtParticularPosition(pos);
        }
    }
}