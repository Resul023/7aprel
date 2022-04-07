using System;

using System.Collections.Generic;
using System.Collections;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
  
            ArrayList arrayList = new ArrayList();
            arrayList.Add("salam");
            arrayList.Add("necesen");
            arrayList.Add(23);
            arrayList.Remove(23);
            arrayList.Sort();
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Stack arrayStack = new Stack();
            arrayStack.Push(45);
            arrayStack.Push(35);
            arrayStack.Push(12);
            arrayStack.Push(98);
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            foreach (var item in arrayStack)
            {
                Console.WriteLine(item);
            }
            List<int> newList = new List<int>();
            newList.Add(55);
            newList.Add(45);
            newList.Add(23);
            newList.Remove(23);
            newList.Sort();
            newList.Reverse();
            Console.WriteLine(newList.Contains(55)); 
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            Hashtable newHashTable = new Hashtable();
            newHashTable.Add("a", "alma");
            newHashTable.Add("b", "Banan");
            newHashTable.Add("c", "baliq");
            foreach (DictionaryEntry item in newHashTable)
            {
                Console.WriteLine(item.Value+" "+item.Key);
            }
        }
    }
}
