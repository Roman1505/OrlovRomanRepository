using System;


namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод чисел.
            Console.WriteLine("Введите размерность массива");
            int dim = Int32.Parse(Console.ReadLine());
            // Инициализация массива.
            int[] nums = new int[dim];
            string word;
            if (dim < 5)
                word = "числа";
            else
                word = "чисел";
            Console.WriteLine($"Введите {dim} {word}");
            for (int i = 0; i < nums.Length; i++)
                nums[i] = Program.InputArray(i);

            // Сортировка.
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

            // Вывод.
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }

        // Метод ввода.
        private static int InputArray(int k)
        {
            Console.Write("{0}-е число: ", k + 1);
            return Int32.Parse(Console.ReadLine());
        }


    }
}



