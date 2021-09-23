using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QueueSharpLib
{
    public class ListStruct
    {
        public string Name { get; set; }
        public QueueStruct <int> Qs { get; set; }

        public ListStruct() { }
        public ListStruct(string name, QueueStruct<int> qs) 
        {
            Name = name;
            Qs = qs;
        }

        public void Shou_ListSturct(string message)
        {
            if (Qs.Size!=0)
            {
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.Write(Name);
                Console.Write($"\t Первый в очереди {Qs.First}");
                Console.WriteLine($"\t Последний в очереди {Qs.Last}");
                Console.ResetColor();
            }
        }

    }
}