using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        // member methods (HAS A)
        T[] Data;
        int count;
        int capacity;
        private readonly object value;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int i]
        {
            get
            {
                return Data[i];
            }
            set
            {
                Data[i] = value;
            }
        }
        
        
        // Constructor (SPAWNER)
        public CustomList()
        {
            capacity = 5;
            Data = new T[capacity];
        }
        
        
        // Memeber Methods (CAN DO)
        public void Add(T thingToAdd)
        {
            if (count > capacity / 2)
            {
                IncreaseArray();
            }
            Data[count] = thingToAdd;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return Data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void IncreaseArray()
        {
            T[] increaseSize = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                increaseSize[i] = Data[i];
            }
            Data = increaseSize;
        }

            public override string ToString()
            {
            StringBuilder toString = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                toString.Append(Data[i]);
            }
            return toString.ToString();
            }
    }
}
