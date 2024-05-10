using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listTest = new List<int>();
            Stack<int> stackTest = new Stack<int>();
            Queue<int> queueTest = new Queue<int>();
            HashSet<int> setTest = new HashSet<int>();

            int[] numberArray = new int[] {1, 10, -30, 10, -5};

            foreach (int number in numberArray)
            {
                listTest.Add(number);
                stackTest.Push(number);
                queueTest.Enqueue(number);
                setTest.Add(number);

            }
        }
    }
}
