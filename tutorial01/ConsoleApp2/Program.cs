using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {
            int result = 0;
            Console.WriteLine($"Введите любое первое число");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите любое второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int name = Convert.ToInt32(Console.ReadLine());
            switch (name)
            {
                case 1:
                    Console.WriteLine("сложение");
                    result = number + number2;
                    break;
                case 2:
                    Console.WriteLine("вычитание");
                    result = number - number2;
                    break;
                case 3:
                    Console.WriteLine("умножение");
                    result = number * number2;
                    break;
                default:
                    Console.WriteLine("что ты ввел?");
                    break;
            }

            Console.WriteLine($"ответ {result}");








        }

            
        }
    }

         





        
          

            
           
            
            
            
                
            

            
            


            
            
            
        
           


        
    

