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

            Print();
       
            Console.ReadKey();
        }


        static void Dz_1()
            //пользователь вводит 5 чисел найти МИН и МАХ
        {
            Console.WriteLine("Задание первое: ");

            //Ввод данных 
            Console.Write("Введите 1-e число ");
            int Number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 2-e число ");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 3-e число ");
            int Number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 4-e число ");
            int Number4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 5-e число ");
            int Number5 = Convert.ToInt32(Console.ReadLine());

            //нахождение МАХ числа

            if (Number1 > Number2 && Number1 > Number2 && Number1 > Number3 && Number1 > Number4 && Number1 > Number5)
            {
                Console.WriteLine($"Число: {Number1} больше остальных");
            }

            else if (Number2 > Number1 && Number2 > Number3 && Number2 > Number4 && Number2 > Number5)
            {
                Console.WriteLine($"Число: {Number2} больше остальных");
            }

            else if (Number3 > Number1 && Number3 > Number2 && Number3 > Number4 && Number3 > Number5)
            {
                Console.WriteLine($"Число: {Number3} больше остальных");
            }

            else if (Number4 > Number1 && Number4 > Number2 && Number4 > Number3 && Number4 > Number5)
            {
                Console.WriteLine($"Число: {Number4} больше остальных");
            }

            else
            {
                Console.WriteLine($"Число: {Number5} больше остальных");
            }


            // нахождение МИН числа

            if (Number1 < Number2 && Number1 < Number2 && Number1 < Number3 && Number1 < Number4 && Number1 < Number5)
            {
                Console.WriteLine($"Число: {Number1} меньше остальных");
            }

            else if (Number2 < Number1 && Number2 < Number3 && Number2 < Number4 && Number2 < Number5)
            {
                Console.WriteLine($"Число: {Number2} меньше остальных");
            }

            else if (Number3 < Number1 && Number3 < Number2 && Number3 < Number4 && Number3 < Number5)
            {
                Console.WriteLine($"Число: {Number3} меньше остальных");
            }

            else if (Number4 < Number1 && Number4 < Number2 && Number4 < Number3 && Number4 < Number5)
            {
                Console.WriteLine($"Число: {Number4} меньше остальных");
            }

            else
            {
                Console.WriteLine($"Число: {Number5} меньше остальных");
            }

        }


        static void Dz_2()
            
             //Написать программу вывода таблицы char символов с их hex представлением в пользовательском диапазоне 
             //пользователь указывает начало и конец диапазона (диапазон значений 0 - 65 535!)
            
        {
            Console.OutputEncoding = Encoding.UTF8;

            //диапазон
            Console.Write("Укажите диапазон значений (0 - 65 535)\nНачало:");
            int StartRange = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец: ");
            int EndRange = Convert.ToInt32(Console.ReadLine());

            //проверка значений от пользователя
            
            if (StartRange >= char.MinValue && StartRange <= char.MaxValue && EndRange <= char.MaxValue)
            {
                for (int i = 0; EndRange >= StartRange; i++)
                {
                   char X = Convert.ToChar(StartRange); //конвертация в char
                    Console.WriteLine($"значение {StartRange} Char символ {X} символ hex {StartRange.ToString("X")} "); //вывод 
                    StartRange++;
                }

            }
            else
                Console.WriteLine("Вы превысили диапазон значений :(");

         }

        static void Dz_3()

        //Пользователь вводит N целых чисел, необходимо найти минимально и максимально число среди введеных пользователем

        {
            // ввод чисел
            Console.WriteLine("Сколько чисел хотите сравнить?");
            int AmountNumbers = Convert.ToInt32(Console.ReadLine());

            if (AmountNumbers > 0)
            {
                int[] nums = new int[AmountNumbers];
                Console.WriteLine($"Введите {AmountNumbers} чисел");
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
                Console.WriteLine($"max: {nums[AmountNumbers - 1]}");
            }
            else
            {
                Console.WriteLine($"Указаное число '{AmountNumbers}' не допустимо для сравнения");
            }

        }


        static void Print()
            /*
             метод для вывода на консоль заданий
            */
        {
            for (;;)
            { 
                Console.WriteLine("Какое задание загрузить: ");
                string Text = Console.ReadLine();
                int NumberTask = Convert.ToInt32(Text);

                switch (NumberTask)
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


                    case 3:
                        Dz_3();
                        Console.WriteLine("Нажмите любую клавишу для очистки консоли");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("На данный момент доступно только 2 домашних задания\n(В дальнейшем планируется рассширение списка приложений)\nНажмите любую клавишу для очистки консоли");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }

        }
        
    }
   
}
