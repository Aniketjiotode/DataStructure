using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_
{
    internal class Cash_Counter
    {
        public Cash_Counter()
        {
            Deposit_Withdraw();
        }
        public void Deposit_Withdraw()
        {
            Console.WriteLine("Enter the people in the Que");
            int number = int.Parse(Console.ReadLine());
            Queue<string> q = new Queue<string>(number);
            int amount = 10000;
            while (q.Size() < number)
            {
                Console.Write("Enter the name of the Customer: ");
                q.Enqueue(Console.ReadLine());
            }

            Console.WriteLine("Current Balance available is " + amount);
            while (!q.IsEmpty())
            {
                Console.WriteLine(q.Dequeue() + " Enter 'W' to Withdraw money or \n" + "Enter 'D' to Deposit money");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Enter the  amount : ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (ch == 'D' || ch == 'd')
                {
                    amount += input;
                    Console.WriteLine("Succesfully Deposited the amount");
                }
                else if (ch == 'W' || ch == 'w')
                {
                    if (input > amount)
                        Console.WriteLine("Amount exceeds the Bank Balance");
                    else
                    {
                        Console.WriteLine("Succesfully Withdraw the amount");
                        amount -= input;
                    }
                }
                else Console.WriteLine("invalid Entry");
                Console.WriteLine("Available Bank Balance is: " + amount);
            }

        }

    }
}

