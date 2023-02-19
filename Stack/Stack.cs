using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_
{
    internal class Stack<T>
    {
        int capacity;
       public T[] St;
        int top = -1;
        public Stack(int capacity)
        {
            this.capacity = capacity;
            St = new T[capacity];
        }
        public bool Push(T data)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack overFlow");
                return false;
            }
            St[++top] = data;
            return true;
        }
        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return default (T);
            }
            return St[top--];
        }
        public bool IsEmpty()
        {

            if (top == -1)
                return true;
            else return false;
        }
        public T Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is UnderFlow");
                return (T) default;
            }
            return St[top];
        }

    }
}
