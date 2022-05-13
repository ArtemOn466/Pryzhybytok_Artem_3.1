using System.Collections.Generic;
using System;

// 25 Варіант

namespace laba
{
    class Onearr
    {
        public Onearr()
        {

        }
    }

    public class Array
    {
        public int[] amount;

        public Array()
        {

        }
    }

    public class Element
    {
        public int element1;
        public int element2;
        public int element3;
        public int[] array;
        public Element() // конструктор де ми вводимо елементи до масива і створюємо сам масив
        {

            element1 = int.Parse(Console.ReadLine());
            element2 = int.Parse(Console.ReadLine());
            element3 = int.Parse(Console.ReadLine());
            this.array = new int[] { element1, element2, element3 };
        }

        public void Plus() // метод додавання
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Summa elementiv = " + sum);
        }

        public void Minus() // метод віднімання найменшого елемента від найбільшого елемента
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];

                if (array[i] < min)
                    min = array[i];
            }

            int rizn = max - min;

            Console.WriteLine("Riznuzya elementiv = " + rizn);
        }

        public void Multiple() // метод множення
        {
            int mult = 0;
            for (int i = 0; i < array.Length; i++)
            {
                mult = mult * array[i];
            }
            Console.WriteLine("Dobytok elementiv = " + mult);
        }
        public void Print() // метод виводу масива
        {
            Console.Write("Your array is : " + element1 + " " + element2 + " " + element3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 elements");
            Element element = new Element(); // створення об'єкта класу


            Console.WriteLine("Enter what do you want to test : ");
            Console.WriteLine("1 - Show array");
            Console.WriteLine("2 - Plus");
            Console.WriteLine("3 - Minus");
            Console.WriteLine("4 - Multiple");

            int n = int.Parse(Console.ReadLine());

            switch (n) // за допомогою свічу викликаємо методи відповідно до вибору користувача
            {
                case 1:
                    element.Print();
                    break;
                case 2:
                    element.Plus();
                    break;
                case 3:
                    element.Minus();
                    break;
                case 4:
                    element.Multiple();
                    break;
            }
        }
    }
}




