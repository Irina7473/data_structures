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
            var element = new Element<T>(value);
            if (_head == null)  //  или  Size == 0
            {
                _head = element;
                _tail = _head;               
            }
            else if (_head != null &&_tail == null) //  или  Size == 1
            {                
                _tail = element;
                _head.Next = _tail;               
            }
            else
            {
                var temp = _tail;
                _tail = element;
                temp.Next= _tail;              
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
            _head = _head.Next;            
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

        public T First
        {
            get
            {
                if (IsEmpty()) throw new InvalidOperationException();
                return _head.Value;
            }
        }
        
        public T Last
        {
            get
            {
                if (IsEmpty()) throw new InvalidOperationException();
                return _tail.Value;
            }
        }
    }
}
