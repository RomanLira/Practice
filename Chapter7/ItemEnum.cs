using System;
using System.Collections;

namespace Chapter7
{
    public class ItemEnum: IEnumerator
    {
        public Item[] _items;
        int _position = -1;

        public ItemEnum(Item[] list)
        {
            _items = list;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Length;
        }

        public void Reset()
        {
            _position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Item Current
        {
            get
            {
                try
                {
                    return _items[_position];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}