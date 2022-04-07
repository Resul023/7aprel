using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Collections;
namespace _7Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MyList<string> myTestProject = new MyList<string>();
            myTestProject.Name = "salam";
            myTestProject[0] = "salam";*/
            foreach (var item in GetInt())
            {
                Console.WriteLine(item);
            }

        }
        static IEnumerable<int> GetInt() 
        {
            yield return 5;
            yield return 6;
            yield return 7;
        }
        ArrayList arrayForTest1 = new ArrayList();

        SortedList sortedList = new SortedList();
        
        
    }
}
