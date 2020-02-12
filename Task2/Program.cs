/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.  
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 
*/
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            Random randomIntValue = new Random();

            Console.Write("Количество элементов массива = ");
            int arraySize = Int32.Parse(Console.ReadLine());
            WorkWithAnArray findInArray = new WorkWithAnArray(arraySize);

            array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomIntValue.Next(1,100);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
