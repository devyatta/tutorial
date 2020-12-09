using System;

namespace kek
{
    class Program
    {
        static void Main(string[] args)
        {
           
           // я не разобрался как сделать 3 повтора , а потом что бы программа выключалась :(
            while (true)
            {


                Console.WriteLine("введите любое число");
                int number = Convert.ToInt32(Console.ReadLine());




                if (number <= 5)
                {
                    switch (number)
                    {

                        case (1):
                            Console.WriteLine("Ю-ху");
                            break;

                        case (2):
                            Console.WriteLine("Ю-ху");
                            break;

                        case (3):
                            Console.WriteLine("Ю-ху");
                            break;

                        case (4):
                            Console.WriteLine("Ю-ху");
                            break;

                        case (5):
                            Console.WriteLine("Ю-ху");
                            break;

                    }
                }




                else if (number == 6 || number == 7)
                {
                    switch (number)
                    {
                        case (6):
                            Console.WriteLine("=(");
                            break;

                        case (7):
                            Console.WriteLine("=(");
                            break;
                    }

                }

                else
                {

                    switch (number)
                    {
                        default:
                            Console.WriteLine("попробуй снова");
                            break;
                    }

                }

            }


            



        }

    }
            
            
            
}

                 





