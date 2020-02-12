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

            Console.Write("Количество элементов массива = ");
            int arraySize = Int32.Parse(Console.ReadLine());
            array = new int[arraySize];

            Random randomIntValue = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = randomIntValue.Next(1, 100);

            WorkWithAnArray workWithAnArray = new WorkWithAnArray(array);

            Console.Write("Элементы массива = ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(workWithAnArray[i] + " ");

            Console.WriteLine("\nНаибольшее значение массива = " + workWithAnArray.MaxElemntInArray);
            Console.WriteLine("Наименьшее значение массива = " + workWithAnArray.MinElementInArray);
            Console.WriteLine("Общая сумма элементов массива = " + workWithAnArray.SumOfElements);
            Console.WriteLine("Среднее арифметическое всех элементов массива = " + workWithAnArray.AverageOfElements);
            Console.WriteLine("Нечетные значения массива = " + workWithAnArray.OddElementsInArray);

            Console.ReadKey();
        }
    }
}
