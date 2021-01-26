using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class myKeyValuePair<TKey, TValue>
    {
        private TKey key;
        public TKey Key
        {
            get { return key; }
            set { key = value; }
        }

        private TValue val;

        public TValue Value
        {
            get { return val; }
            set { val = value; }
        }
    }
    class MyDictionary<TKey, TValue> : IEnumerator, IEnumerable
    {
        myKeyValuePair<TKey, TValue>[] _keyValuePairs;
        myKeyValuePair<TKey, TValue>[] _tempKeyValuePairs;

        int position = -1;

        public MyDictionary()
        {
            _keyValuePairs = new myKeyValuePair<TKey, TValue>[0];

        }

        public void Add(TKey key, TValue val)
        {
            myKeyValuePair<TKey, TValue> newItem = new myKeyValuePair<TKey, TValue>();
            newItem.Key = key;
            newItem.Value = val;

            _tempKeyValuePairs = _keyValuePairs;
            _keyValuePairs = new myKeyValuePair<TKey, TValue>[_keyValuePairs.Length + 1];

            for (int i = 0; i < _tempKeyValuePairs.Length; i++)
            {
                _keyValuePairs[i] = _tempKeyValuePairs[i];
            }

            _keyValuePairs[_keyValuePairs.Length - 1] = newItem;

        }

        public int Length
        {
            get { return _keyValuePairs.Length; }
        }


        // Buradan sonrasını copy-paste yaptım :)


        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < _keyValuePairs.Length);
        }
        //IEnumerable
        public void Reset()
        {
            position = 0;
        }
        //IEnumerable
        public object Current
        {
            get { return _keyValuePairs[position]; }
        }
    }
}
