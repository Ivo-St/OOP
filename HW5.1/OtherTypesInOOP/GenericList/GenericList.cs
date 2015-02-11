namespace GenericList
{
    using System;
    using System.Text;
    using System.Linq;

    [Version(1,0)]
    public class GenericList<T>
        where T : IComparable<T>
    {
        private const int CAPACITY = 16;

        private int size = 0;

        public GenericList(int capacity = CAPACITY)
        {
            this.Capacity = capacity;
            this.InnerArray = new T[this.Capacity];
        }

        private T[] InnerArray { get; set; }

        public int Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Array size cannot be negative number");
                }

                this.size = value;
            }
        }

        private int Capacity { get; set; }

        private void GrowArray()
        {
            this.Capacity = this.Capacity * 2;
            T[] newArray = new T[this.Capacity];
            this.InnerArray.CopyTo(newArray, 0);
            this.InnerArray = newArray;
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Size)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.Size == 0)
            {
                throw new IndexOutOfRangeException("The list is empty");
            }
        }

        private T ElementAt(int index)
        {
            CheckIndex(index);

            return this.InnerArray[index];
        }

        private void AutoGrowArray(int? size=null)
        {
            if ((size ?? this.Size) >= this.Capacity)
            {
                GrowArray();
            }
        }

        public void AddElement(T element)
        {
            AutoGrowArray();

            this.InnerArray[this.Size] = element;
            this.Size++;
        }

        public T this[int index]
        {
            get
            {
                return ElementAt(index);
            }
            set
            {
                CheckIndex(index);

                this.InnerArray[index] = value;
            }
        }

        public void InsertElementAt(int index, T element)
        {
            CheckIndex(index);

            AutoGrowArray(this.Size + 1);

            T[] newArray = new T[this.Size + 1];

            int i=0;
            for (; i < index; i++)
            {
                newArray[i] = this.InnerArray[i];
            }

            newArray[index] = element;

            for (; i < this.Size; i++)
            {
                newArray[i + 1] = this.InnerArray[i];
            }

            this.Size++;
            this.InnerArray = newArray;
        }

        public int FindIndexOf(T value)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (this.InnerArray[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T value)
        {
            return Array.Exists<T>(this.InnerArray, x => x.Equals(value));
        }

        public void ClearList()
        {
            this.InnerArray = new T[CAPACITY];
            this.Size = 0;
            this.Capacity = CAPACITY;
        }

        public void RemoveElementByIndex(int index)
        {
            CheckIndex(index);

            T[] newArray = new T[this.Size - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = this.InnerArray[i];
            }

            for (int i = index + 1; i < this.Size; i++)
            {
                newArray[i - 1] = this.InnerArray[i];
            }

            this.InnerArray = newArray;
            this.Size--;
        }

        public T Min<B>()
        {
            return this.InnerArray.Min();
        }

        public T Max<B>()
        {
            return this.InnerArray.Max();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Size; i++)
            {
                result.AppendFormat("{0}: {1}\n",i,this.InnerArray[i]);
            }
            return result.ToString();
        }
    }
}
