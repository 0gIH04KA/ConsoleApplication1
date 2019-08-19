﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApplication1
{
    class Test
    {
        static void Main()
        {
            
            Print();
                        
            Console.ReadKey();
        }

       
        static void Dz_1()
             /*
             Пользователь вводит N целых чисел, необходимо найти минимально и максимально число среди введеных пользователем
             */
        {
            // ввод чисел
            Console.WriteLine("Сколько чисел хотите сравнить?");
            int K = Convert.ToInt32(Console.ReadLine());

            if (K > 0)
            {
                int[] nums = new int[K];
                Console.WriteLine($"Введите {K} чисел");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("{0}-е число: ", i + 1);
                    nums[i] = Int32.Parse(Console.ReadLine());
                }

                // сортировка
                int temp;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }

                // вывод
                Console.WriteLine("Вывод отсортированного массива");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i]);
                }
                Console.WriteLine($"min: {nums[0]}");
                Console.WriteLine($"max: {nums[K - 1]}");
            }
            else
            {
                Console.WriteLine($"Указаное число '{K}' не допустимо для сравнения");
            }
        }

        static void Dz_2()
            /*
             Написать программу вывода таблицы char символов с их hex представлением в пользовательском диапазоне 
             пользователь указывает начало и конец диапазона (диапазон значений 0 - 65 535!)
            */
        {
            Console.OutputEncoding = Encoding.UTF8;

            //диапазон
            Console.Write("Укажите диапазон значений (0 - 65 535)\nНачало:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец: ");
            int y = Convert.ToInt32(Console.ReadLine());

            //проверка значений от пользователя
            
            if (x >= char.MinValue && x <= char.MaxValue && y <= char.MaxValue)
            {
                for (int i = 0; y >= x; i++)
                {
                   char X = Convert.ToChar(x); //конвертация в char
                    Console.WriteLine($"значение {x} Char символ {X} символ hex {x.ToString("X")} "); //вывод 
                    x++;
                }

            }
            else
                Console.WriteLine("Вы превысили диапазон значений :(");

         }
        static void Print()
            /*
             метод для вывода на консоль заданий
            */
        {
            for (;;)
            { 
                Console.WriteLine("Какое задание загрузить: ");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Dz_1();
                        Console.WriteLine("Нажмите любую клавишу для очистки консоли");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Dz_2();
                        Console.WriteLine("Нажмите любую клавишу для очистки консоли");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Введите 1 или 2!\nНажмите любую клавишу для очистки консоли");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }

        }





        static void IFFF()
        {
            Console.WriteLine("Задание первое: ");

            //Ввод данных 
            Console.Write("Введите первое число ");
            int A1 = Convert.ToInt32(Console.ReadLine()) ;

            Console.Write("Введите второе число ");
            int A2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число ");
            int A3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите четвертое число ");
            int A4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите пятое число ");
            int A5 = Convert.ToInt32(Console.ReadLine());

            //нахождение МАХ числа

            if (A1 > A2 && A1 > A2 && A1 > A3 && A1 > A4 && A1 > A5)
            {
                Console.WriteLine($"Число: {A1} больше остальных");
            }

            else if (A2 > A1 && A2 > A3 && A2 > A4 && A2 > A5)
            {
                Console.WriteLine($"Число: {A2} больше остальных");
            }

            else if (A3 > A1 && A3 > A2 && A3 > A4 && A3 > A5)
            {
                Console.WriteLine($"Число: {A3} больше остальных");
            }

            else if (A4 > A1 && A4 > A2 && A4 > A3 && A4 > A5)
            {
                Console.WriteLine($"Число: {A4} больше остальных");
            }

            else
            {
                Console.WriteLine($"Число: {A5} больше остальных");
            }


            // нахождение МИН числа

            if (A1 < A2 && A1 < A2 && A1 < A3 && A1 < A4 && A1 < A5)
            {
                Console.WriteLine($"Число: {A1} меньше остальных");
            }

            else if (A2 < A1 && A2 < A3 && A2 < A4 && A2 < A5)
            {
                Console.WriteLine($"Число: {A2} меньше остальных");
            }

            else if (A3 < A1 && A3 < A2 && A3 < A4 && A3 < A5)
            {
                Console.WriteLine($"Число: {A3} меньше остальных");
            }

            else if (A4 < A1 && A4 < A2 && A4 < A3 && A4 < A5)
            {
                Console.WriteLine($"Число: {A4} меньше остальных");
            }

            else
            {
                Console.WriteLine($"Число: {A5} меньше остальных");
            }
        }
    }
   
}
