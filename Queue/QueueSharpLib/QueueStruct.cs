using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSharpLib
{
   public class QueueStruct<T>
    {
        private Element<T> _head;
        private Element<T> _tail;
        public int Size { get; private set; }

        public QueueStruct()
        {
            _head = null;
            _tail = null;
            Size = 0;
        }

        public void Push(T value)
        {
            if (_head == null)
            {
                _head = new Element<T>(value);
                Console.WriteLine($"head = {_head.Value}");
            }
            else if (_tail == null)
            {                
                _tail = new Element<T>(value, _head, null);
                _head = new Element<T>(_head.Value, null, _tail);
                Console.WriteLine($"head = {_head.Value} \t tail={_tail.Value}");
            }
            else
            {
                var e = new Element<T>(value, _head, null);
                _tail = e;
                Console.WriteLine($"head = {_head.Value} \t tail={_tail.Value}");
            }

            Size++;            
        }
               
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }
                        
            var result = _head.Value;            
            Console.WriteLine($"result = {result}");
            _head = _head.Next;
            //_head.Prev = null;
            
            Console.WriteLine($"head = {_head.Value}");
            
            Size--;
            return result;
        }
               
        public void Clear()
        {
            while (!IsEmpty()) Pop();
        }
        
        public bool IsEmpty()
        {
            return Size == 0 ? true : false;
        }
    }
}
