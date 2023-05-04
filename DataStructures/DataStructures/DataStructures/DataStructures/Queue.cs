namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Purpose of this class is to create implementation of queue 
    /// </summary>
    /// <typeparam name="T">the t type data</typeparam>

    public class Queue<T>
    {
        private T[] queue;
        private int qsize;
        private int front;
        private int rear;
        private int size;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue{T}"/> class.
        /// </summary>
        /// <param name="qsize">The qsize.</param>
        public Queue(int qsize)
        {
            this.qsize = qsize;
            this.queue = new T[qsize];
            this.front = 0;
            this.rear = 0;
            this.size = 0;
        }

        /// <summary>
        /// Adding the particular data in queue.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(T data)
        {
            this.queue[this.rear] = data;
            this.rear++;
            this.size++;
        }

        /// <summary>
        /// Popping the data from queue
        /// </summary>
        /// <returns>the data</returns>
        public T Dequeue()
        {
            if (this.front == this.rear)
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }
            else
            {
                T data = this.queue[this.front++];
                this.size--;
                return data;
            }
        }

        /// <summary>
        /// It returns the Size of queue 
        /// </summary>
        /// <returns>size of queue</returns>
        public int Size()
        {
            return this.size;
        }

        /// <summary>
        /// Determines whether queue is empty or not.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (this.size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// returning the final value of string
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            String s = "";
            for (int i = front; i < rear && front != -1; i++)
            {
                s = s + queue[i] + " ";

            }
            return s;
        }
    }
}
