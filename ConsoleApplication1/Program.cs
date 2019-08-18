using System;
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
           
             Console.WriteLine("Какое задание загрузить: ");
             int a = Convert.ToInt32(Console.ReadLine());
             switch (a)
             {
                 case 1:
                     Test.Dz_1();
                     break;

                 case 2:
                     Test.Dz_2();
                     break;
             }
                                
            Console.ReadKey();
        }

       
        static void Dz_1()
        {
            // ввод чисел
            Console.WriteLine("Сколько чисел хотите сравнить?");
            int K = Convert.ToInt32(Console.ReadLine());

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

        static void Dz_2()
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

    }
   
}
