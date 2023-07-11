using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArry = items;
            items=new T[items.Length+1];
            for (int i = 0; i < tempArry.Length; i++)
            {
                items[i] = tempArry[i];
            }
            items[items.Length-1] = item;  // son elemanı eklemek için yani bizim eklediğimiz değer
        }
        public int Length
        {
            get { return items.Length; }
        } 
        public T[] Items
        {
            get { return items; }
        }
    }
}
