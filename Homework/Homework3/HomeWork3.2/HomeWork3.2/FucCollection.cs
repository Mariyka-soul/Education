using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
    internal class FucCollection<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _count;

        public FucCollection(int count)
        {
            _items = new T[count];
            _count = 0;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach(T item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Add(T item)
        {
            if (_count < _items.Length)
            {
                _items[_count] = item;
                _count++;
                return true;
            }

            return false;
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(_items, item);

            if (index >= 0)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _count--;

                return true;
            }

            return false;
        }

        public int Search(T item)
        {
            return Array.IndexOf(_items, item);
        }

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                if (index >= 0 && index < _count)
                {
                    _items[index] = value;
                }
            }
        }
    }
}
