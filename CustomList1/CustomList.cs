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
        T[] mainArray;
        private int count;
        private int capacity;

        public CustomList(int c = 5)
        {
            capacity = c;
            count = 0;
            mainArray = new T[capacity];
        }

        public void Add(T value)
        {
            if (count > (capacity / 2))
            {
                capacity *= 2;
                T[] newArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = mainArray[i];
                }
                mainArray = newArray;
            }
            mainArray[count] = value;
            count++;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return mainArray[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            CustomList<T> list = obj as CustomList<T>;
            if (count.Equals(list.Count))
            {
                for(int index = 0; index < count; index++)
                {
                    if (!list[index].Equals(mainArray[index]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool Remove(T value, int start = 0)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (!found)
                {
                    if (mainArray[i].Equals(value))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    mainArray[i] = mainArray[i + 1];
                }
            }
            count--;
            return found;
        }

        public override string ToString()
        {
            string toString = "";
            for (int index = 0; index < count; index++)
            {
                if (index > 0)
                {
                    toString += ", " + mainArray[index].ToString();
                }
                else
                {
                    toString += mainArray[index].ToString();
                }
            }
            return toString;
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            for(int index = 0; index < listTwo.Count; index++)
            {
                listOne.Add(listTwo[index]);
            }
            return listOne;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int index = 0; index < listTwo.Count; index++)
            {
                listOne.Remove(listTwo[index]);
            }
            return listOne;
        }

        public CustomList<T> Zipper(CustomList<T> list)
        {
            return list;
        }

        public T this[int index]
        {
            get
            {
                if (index > count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return mainArray[index];
                }
            }
        }
    }
}