using System;

namespace Task2
{
    class WorkWithAnArray
    {
        readonly int[] _array;

        public WorkWithAnArray(int[] filledArray)
        {
            _array = filledArray;
        }

        public int this[int index]
        {
            get => _array[index];
        }

        public int MaxElemntInArray { get => FindMaxElementInArray(); }
        public int MinElementInArray { get => FindMinElementInArray(); }
        public int SumOfElements { get => SumOfArrayElements(); }
        public string AverageOfElements { get => AverageOfArrayElements(); }
        public string OddElementsInArray { get => FindOddElementInArray(); }

        int FindMaxElementInArray()
        {
            int max = _array[0];
            for (int i = 0; i < _array.Length - 1; i++)
                max = Math.Max(max, _array[i + 1]);
            return max;
        }

        int FindMinElementInArray()
        {
            int min = _array[0];
            for (int i = 0; i < _array.Length - 1; i++)
                min = Math.Min(min, _array[i + 1]);
            return min;
        }

        int SumOfArrayElements()
        {
            int sumOfElements = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                sumOfElements += _array[i];
            }
            return sumOfElements;
        }

        string AverageOfArrayElements()
        {
            if (SumOfArrayElements() % _array.Length != 0)
                return SumOfArrayElements() / _array.Length + "," + SumOfArrayElements() % _array.Length;
            else
                return (SumOfArrayElements() / _array.Length).ToString();
        }

        string FindOddElementInArray()
        {
            string oddNumber = null;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 != 0)
                    oddNumber += _array[i] + " ";
            }
            return oddNumber;
        }
    }
}
