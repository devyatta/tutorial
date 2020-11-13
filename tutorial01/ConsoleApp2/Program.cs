using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Text.Json;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {





            // написать программу , запрос х(любое число) запрос второго числа, если сумма предыдущих чисел меньше второго числа , введите заного второе число , если верно то суммировать 
            // int a . int b  int sum
            // 1 ЧИСЛО 10 второе 11 то все верно будет 21 , и ввод 2 рого числа должен повториться , с основным условие , т.е. число должно быть больше чем сумма пред чисел


            Console.WriteLine("введите число");
            int num = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("введитие второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num + num2;
            Console.WriteLine($"результат {sum}");

            while (true)
            {

                Console.WriteLine("введите следуюющее число");

                int num3 = Convert.ToInt32(Console.ReadLine());


                while (num3 <= sum || num3 < sum)
                {

                    Console.WriteLine("не соответствует требованию");

                    num3 = Convert.ToInt32(Console.ReadLine());
                }

                int result = sum + num3;
                Console.WriteLine($"сумма двух предыдущих чисел {result}");
            }
            

                
                
            
        }

            


              
            




        }

                
            









            


             
                
            }
        

            



        



    


            


                 








        

            
        
   
    
    

         





        
          

            
           
            
            
            
                
            

            
            


            
            
            
        
           


        
    

