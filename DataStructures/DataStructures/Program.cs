using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueu(70);
            qu.Enqueu(30);
            qu.Enqueu(56);
            qu.Dequeu();
            qu.Display();
        }
    }
}