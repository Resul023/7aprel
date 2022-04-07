using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyList <T>
    {
        public T Name { get; set; }
        public T NameTwo { get; set; }
        public T[] MyTestArray;

       /* public T this[int index]
        {
            get { return MyTestArray[index]; }
            set { MyTestArray[index] = value; }

        }*/

    }
}
