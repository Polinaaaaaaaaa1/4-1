using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    using System;
    using System.Collections.Generic;

    public class OneDimensionalArray<T>
    {
        private List<T> list;
        public OneDimensionalArray()
        {
            list = new List<T>();
        }
        public OneDimensionalArray(int capacity)
        {
            list = new List<T>(capacity);
        }
        public void Add(T item)
        {
            list.Add(item);
        }
        public void RemoveAt(int index)
        {
            try
            {
                list.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public T GetElementAt(int index)
        {
            try
            {
                return list[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
        public void Sort()
        {
            list.Sort();
        }
        public int Count()
        {
            return list.Count;
        }

        public int Count(Func<T, bool> predicate)
        {
            return list.Count(predicate);
        }
        public bool Any(Func<T, bool> predicate)
        {
            return list.Any(predicate);
        }

        public bool All(Func<T, bool> predicate)
        {
            return list.All(predicate);
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void ForEach(Action<T> action)
        {
            list.ForEach(action);
        }
        public T First(Func<T, bool> predicate)
        {
            return list.First(predicate);
        }

 

        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            return list.Where(predicate);
        }

        public IEnumerable<f> OfType<f>()
        {
            return list.OfType<f>();
        }

        public void Reverse()
        {
            list.Reverse();
        }
        public T Min()
        {
            return list.Min();
        }
        public T Max()
        {
            return list.Max();
        }
        public f Min<f>(Func<T, f> selector)
        {
            return list.Min(selector);
        }

        public f Max<f>(Func<T, f> selector)
        {
            return list.Max(selector);
        }

        public IEnumerable<U> Select<U>(Func<T, U> selector)
        {
            return list.Select(selector);
        }

        public IEnumerable<T> GetRange(int startIndex, int count)
        {
            try { return list.Skip(startIndex).Take(count); }
            catch
            {
                throw new ArgumentOutOfRangeException("index out of range");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

}
