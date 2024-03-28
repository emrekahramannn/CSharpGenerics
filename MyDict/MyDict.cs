using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    public class MyDict<TKeys, TValues>
    {
        TKeys[] _keys;
        TValues[] _values;

        TKeys[] _tempKeys;
        TValues[] _tempVals;

        public MyDict()
        {
            _keys = new TKeys[0];
            _values = new TValues[0];
        }

        public void Add(TKeys key, TValues value)
        {
            _tempKeys = _keys;
            _tempVals = _values;

            _keys = new TKeys[_keys.Length + 1];
            _values = new TValues[_values.Length + 1];

            for(int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempVals[i];  
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        public void Remove(TKeys key)
        {
            _tempKeys = _keys;
            _tempVals = _values;

            _keys = new TKeys[_keys.Length - 1];
            _values = new TValues[_values.Length - 1];

            for(int i = 0, j = 0; i < _tempKeys.Length; i++)
            {
                if (Array.IndexOf(_tempKeys, key) == i)
                {
                    continue;
                }
                else
                {
                    _keys[j] = _tempKeys[i];
                    _values[j] = _tempVals[i];
                    j++;
                }
            }
        }

        public void Clear()
        {
            _keys = new TKeys[0];
            _values = new TValues[0];
        }

        public int Count
        {
            get { return _keys.Length; }
        }

        public TKeys[] Keys
        {
            get { return _keys; }
        }

        public TValues[] Values
        {
            get { return _values; }
        }
       
        public void ListItems()
        {
            for(int i = 0; i < _keys.Length;i++)
            {
                Console.WriteLine($"{_keys[i]} : {_values[i]}");
            }
        }
    }
}
