using System;

namespace QueueSharpLib
{
    public class Element<T>
    {               
        public readonly T Value;
        public Element<T> Next { get; set; }

        public Element(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
