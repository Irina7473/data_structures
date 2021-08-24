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
            Console.WriteLine($"size = {queue.Size} \t first={queue.First} \t last={queue.Last}");
            queue.Push(2);
            Console.WriteLine($"size = {queue.Size} \t first={queue.First} \t last={queue.Last}");
            queue.Push(3);
            Console.WriteLine($"size = {queue.Size} \t first={queue.First} \t last={queue.Last}");
            queue.Push(4);
            Console.WriteLine($"size = {queue.Size} \t first={queue.First} \t last={queue.Last}");
            queue.Push(5);
            Console.WriteLine($"size = {queue.Size} \t first={queue.First} \t last={queue.Last}");

            while (!queue.IsEmpty())
            {
                Console.Write("Удаляю 1 элемент в очереди, его значение = ");
                Console.Write(queue.Pop());
                Console.WriteLine($",  size = {queue.Size}");
            }
        }
    }
}
