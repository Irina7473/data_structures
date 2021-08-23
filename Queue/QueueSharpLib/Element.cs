using System;

namespace QueueSharpLib
{
    public class Element<T>
    {
        public readonly T Value;
        public Element<T> Prev;
        public readonly Element<T> Next;

        public Element(T value)
        {
            Value = value;
            Prev = null;
            Next = null;
        }

        public Element(T value, Element<T> prev, Element<T> next)
        {
            Value = value;
            Prev = prev;
            Next = next;
        }
    }
}
