using QueueSharpLib;
using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new QueueStruct<int>();
            Console.WriteLine($"size = {queue.Size}");

            queue.Push(1);
            Console.WriteLine($"size = {queue.Size}");
            queue.Push(2);
            Console.WriteLine($"size = {queue.Size}");
            queue.Push(3);
            Console.WriteLine($"size = {queue.Size}");
            queue.Push(4);
            Console.WriteLine($"size = {queue.Size}");
            queue.Push(5);
            Console.WriteLine($"size = {queue.Size}");

            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Pop());
                Console.WriteLine($"size = {queue.Size}");
            }
        }
    }
}
