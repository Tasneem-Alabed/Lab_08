using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab_08
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> lists;

        public Backpack()
        {
            lists = new List<T>();
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var x in lists)
            {
                yield return x;
            }
        }

        public void Pack(T item)
        {
            lists.Add(item);
        }

        public T Unpack(int point)
        {
            var book = lists[point];
            lists.RemoveAt(point);
            return book;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var book in lists)
            {
                yield return book;
            }
        }
    }
}
