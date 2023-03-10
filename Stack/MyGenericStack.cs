using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyGenericStack<T>
    {
        /// <summary>
        /// Defines the size of the stack
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Shows the index of the highest element in the stack
        /// </summary>
        private int index { get; set; } = -1;
        /// <summary>
        /// Is the stack itself
        /// </summary>
        private T[] data;
        public MyGenericStack(int size)
        {
            Size = size;
            data = new T[Size];
        }

        /// <summary>
        /// Adds a value to the Stack
        /// </summary>
        /// <param name="value">Takes an int as value to add</param>
        /// <exception cref="Exception">Exception if maximum is reached</exception>
        public void push(T value)
        {
            if (index + 1 == Size)
            {
                throw new Exception("Array has reached its maximum");
            }
            index++;
            data[index] = value;
        }

        /// <summary>
        /// Takes the highest element of the stack and removes it
        /// </summary>
        /// <returns>Returns the value of the element</returns>
        public T Pop()
        {
            var lastNumber = data[index];
            index--;
            return lastNumber;
        }

        /// <summary>
        /// Removes every element in the stack
        /// </summary>
        public void Clear()
        {
            Array.Clear(data, 0, Size);
            index = -1;
        }

        /// <summary>
        /// Swaps the two highest elements of the stack
        /// </summary>
        public void SwappXY()
        {
            var leastElement = data[index];
            var secondLeastElement = data[index - 1];
            data[index - 1] = leastElement;
            data[index] = secondLeastElement;
        }

        /// <summary>
        /// Checks if stack is empty
        /// </summary>
        /// <returns>Returns true or false</returns>
        public bool isEmpty()
        {
            if (index == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if stack is full
        /// </summary>
        /// <returns>Returns true or false</returns>
        public bool isFull()
        {
            if (index + 1 == Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Puts the whole stack inside of a string seperated with commas
        /// </summary>
        /// <returns>Returns the string</returns>
        public string ToString()
        {
            return string.Join(", ", data);
        }
    }
}
