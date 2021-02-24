using System.Collections;

namespace Chapter7
{
    public class Basket : IEnumerable

    {
        private Item[] _items;

        public Basket(Item[] value)
        {
            _items = value;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public ItemEnum GetEnumerator()
        {
            return new ItemEnum(_items);
        }
    }
}