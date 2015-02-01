using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    [Version(0, 1)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int CAPPACITY = 16;
        private T[] elements;
        private int count = 0;

        public GenericList(int capacity = CAPPACITY)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("The capacity of the List must be >= 0");
            this.elements = new T[capacity];
        }

        public void Add(T element)
        {
            if (count >= elements.Count())
            {
                int newSize = elements.Count() * 2;
                T[] newArray = new T[newSize];

                for (int i = 0; i < count; i++)
                {
                    newArray[i] = elements[i];
                }
                elements = newArray;
            }
            this.elements[count] = element;
            this.count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("There is no such index, " + count);
                }
                return this.elements[index];
            }
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("There is no such index, " + count);
            }
            
            int counter = 0;
            int newArrayCounter = 0;
            T[] newArray = new T[this.elements.Count()];

            while (counter < count)
            {
                if (counter == index)
                {
                    counter++;
                    continue;
                }
                newArray[newArrayCounter] = this.elements[counter];
                counter++;
                newArrayCounter++;
            }
            this.elements = newArray;
            this.count--;
        }

        public void Insert(int index, T element)
        {
            int counter = 0;
            int newArrayCounter = 0;
            int newSize = this.elements.Count() + 1;
            T[] newArray = new T[newSize];

            if (index < 0 || index >= elements.Count())
            {
                throw new ArgumentOutOfRangeException("There is no such index, " + index + ". You can insert in the range of [0.." + (newArray.Count() - 2) + "] ");
            }

            while (newArrayCounter < newSize)
            {
                if (newArrayCounter == index)
                {
                    newArray[newArrayCounter] = element;
                    newArrayCounter++;
                    continue;
                }
                newArray[newArrayCounter] = this.elements[counter];
                counter++;
                newArrayCounter++;
            }

            this.elements = newArray;

            if (count <= index)
                count = index + 1;
            else
                count++;
        }

        public void Clear()
        {
            T[] newArray = new T[elements.Count()];
            this.elements = newArray;
            this.count = 0;
        }

        public void Find(T element)
        {
            List<int> indexes = new List<int>();
            string index = "The element: " + element + " has an index of: ";
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(element))
                    indexes.Add(i);
            }

            if (indexes.Count() == 0)
                Console.WriteLine("No matches found.");
            else
                Console.WriteLine(index + string.Join(", ", indexes.ToArray()));
        }

        public bool Contains(T element)
        {
            bool containsValue = false;

            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(element))
                    containsValue = true;
            }

            return containsValue;
        }
        
        public T Min()
        {
            if (count < 1)
                throw new InvalidOperationException("The list is empty! ");

            T min = this.elements[0];
            foreach (var item in this.elements)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
            }

            return min;
        }

        public T Max()
        {
            if (count < 1)
                throw new InvalidOperationException("The list is empty! ");

            T max = this.elements[0];
            foreach (var item in this.elements)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }

            return max;
        }
        
        public override string ToString()
        {
            string output = String.Empty;

            for (int i = 0; i < this.elements.Count(); i++)
            {
                output += i + " : " + this.elements[i] + "\n";
            }

            return output;
        }
        
    }
}
