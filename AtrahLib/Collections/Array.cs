using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtrahLib.Collections
{
    public class Array<T>//: ICollection<T>, IEnumerator<T>
    {
        private int lenght = 0;
        public T this[int i]
        {
            get
            {
                if (this.IsSet())
                    return GetAt(i);
                else
                    throw new IndexOutOfRangeException("Array out of bound. Array size = " + lenght);
            }
            set
            {
                if (this.IsSet())
                    SetValue(i, value);
                else
                    throw new IndexOutOfRangeException("Array out of bound. Array size = " + lenght);
            }
        }

        private void SetValue(int i, T value)
        {
            throw new NotImplementedException();
        }

        private T GetAt(int i)
        {
            throw new NotImplementedException();
        }

        internal bool IsSet()
        {
            return this.lenght > 0;
        }
    }
}
