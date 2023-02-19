using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_
{
    internal class Queue<T>
    {
        int capacity;
        public T[] obj;
        int front = -1, rear = -1;
        public Queue(int capacity)
        {
            this.capacity = capacity;
            obj = new T[capacity];
        }
        public bool Enqueue(T data)
        {
            if (rear == capacity - 1)
            {
                Console.WriteLine("Que is full");
                return false;
            }
            if (rear == -1)
            {
                front++;
            }
            obj[++rear] = data;
            return true;
        }
        public T Dequeue()
        {
            if (front == -1)
            {
                Console.WriteLine("Que is empty");
                return default(T);
            }
            T res = obj[front++];
            if (front > rear)
                front = rear = -1;
            return res;
        }
        public bool IsEmpty()
        {
            if (rear == -1)
                return true;
            else 
                return false;
        }
        public int Size()
        {
            if (rear == -1)
            {
                return 0;
            }
            return rear - front + 1;
        }
    }
}
