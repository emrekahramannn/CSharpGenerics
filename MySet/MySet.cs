using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySet
{
    public class MySet<T>
    {
        T[] _array;
        T[] _tempArray;

        public MySet()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            if (_array.Contains(item))
            {
                return;
            }
            else
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;
            }
        }

        public void Remove(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length - 1];

            for(int i = 0, j = 0; i < _tempArray.Length; i++)
            {
                if (Array.IndexOf(_tempArray, item) == i)
                {
                    continue;
                }
                else
                {
                    _array[j] = _tempArray[i];
                    j++;
                }
            }
        }

        public void Clear()
        {
            _array = new T[0];
        }
        
        public bool Contains(T item)
        {
            return _array.Contains(item);
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get { return _array; }
        }
    }
}
