using System;

namespace sortirovka_massiva
{
    class Program
    {
        static void Main(string[] args)
        {


            // ввод чисел
            int[] num = new int[3];
            Console.WriteLine("введите числа");

            for(int i = 0; i<num.Length;i++)
            {
                Console.Write("{0} число: ", i+1);
                num[i] = Int32.Parse(Console.ReadLine());
            }



            // сортировка
            int c;
            for (int i = num.Length-1; i>=1; i--)
            {
               

                for (int j = i-1; j>=0 ; j--)
                {
                    
                  if(num[j]<num[i])
                    {
                        c = num[j];
                        num[j] = num[i];
                        num[i] = c;
                        
                    }

                }
            }
            // вывод
            Console.WriteLine("числа по возрастанию в обратно порядке");
            for(int i = 0; i<num.Length;i++)
            {
                Console.WriteLine( num[i]);

            }

        }      
    }
}