using System;

namespace sortirovka_massiva
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Ввод чисел
                int[] nums = new int[7];
                Console.WriteLine("введите семь чисел");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("{0}-e число:", i + 1);
                    nums[i] = Int32.Parse(Console.ReadLine());

                }
                // сортировка

                int temp;
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)

                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                }
                // вывод
                Console.WriteLine("Вывод отсартированного массива");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }
    }
}
