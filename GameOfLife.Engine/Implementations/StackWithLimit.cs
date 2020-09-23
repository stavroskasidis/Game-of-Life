using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Engine.Implementations
{
    public class StackWithLimit<T> : IEnumerable<T>
    {
        private int _limit;
        private LinkedList<T> _list;

        public StackWithLimit(int maxSize)
        {
            _limit = maxSize;
            _list = new LinkedList<T>();

        }

        public void Push(T value)
        {
            if (_list.Count == _limit)
            {
                _list.RemoveLast();
            }
            _list.AddFirst(value);
        }

        public T Pop()
        {
            if (_list.Count > 0)
            {
                T value = _list.First.Value;
                _list.RemoveFirst();
                return value;
            }
            else
            {
                return default;
            }

        }

        public void Clear()
        {
            _list.Clear();

        }

        public int Count
        {
            get { return _list.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
