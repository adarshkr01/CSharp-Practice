using System;

namespace Generics
{
    public class GenericList<T> // T is a convention but we can any name. Any number of values can be passed
    {
        public void Add(T value)
        {
            // logic to add value
        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
