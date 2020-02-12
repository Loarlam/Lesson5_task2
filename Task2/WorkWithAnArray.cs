using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class WorkWithAnArray
    {
        int _numberOfArrayElements;
        int[] _array;

        public WorkWithAnArray(int numberOfArrayElements)
        {
            _numberOfArrayElements = numberOfArrayElements;
            _array = new int[_numberOfArrayElements];
        }

        public int this[int index]
        {
            get { return _array[index]; }
        }
    }
}
