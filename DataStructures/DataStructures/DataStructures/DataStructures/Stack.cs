using System;
using System.Collections.Generic;
using System.Text;
namespace DataStructures
{
    /// <summary>
    /// This class contains code for generic implementation of stack
    /// </summary>
    /// <typeparam name="char"></typeparam>
    public class Stack<T>
    {
        private T[] element;             //// to create a Array of element
        private int top;                 //// for index pf queue
        private int max;                 //// maximum size of queue

        /// <summary>
        /// Initialize value instance of class.
        /// </summary>
        /// <param name="size">The size.</param>
        public Stack(int size)
        {
            this.element = new T[size];
            this.top = -1;
            this.max = size;
        }

        /// <summary>
        /// Pushes the specified data in stack.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(T data)
        {
            if (this.top == (this.max - 1))
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                this.element[++this.top] = data;
            }
        }

        /// <summary>
        /// Pops the last data from queue.
        /// </summary>
        /// <returns>Generic type data</returns>
        public T Pop()
        {
            if (this.top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            else
            {
               // Console.WriteLine("Popped from stack " + this.ele[this.top]);
                return this.element[this.top--];
            }
        }

        /// <summary>
        /// Peeks the data from stack.
        /// </summary>
        /// <returns>the data</returns>
        public T Peek()
        {
            if (this.top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("Peeked from stack " + this.element[this.top]);
                return this.element[this.top];
            }
        }

        /// <summary>
        /// Determines whether this instance is empty or not.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Returns Size of the stack.
        /// </summary>
        /// <returns>the size</returns>
        public int Size()
        {
            return this.top + 1;
        }
    }
}