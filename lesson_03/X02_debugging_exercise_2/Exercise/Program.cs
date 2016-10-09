using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberNotFound = false;
            int number = 2520;

            while(numberNotFound)
            {
                for(int devider = 0; devider < 20; devider++)
                {
                    if(number % devider != 0)
                        break;
                    else
                        numberNotFound = true;
                }
                number += 2;
            }

            // 232792560 ist das Ergebnis
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}