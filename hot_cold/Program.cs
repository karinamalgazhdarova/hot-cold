using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hot_cold
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int thoughtNumber = random.Next(1, 50);
            int previousNumber=thoughtNumber;
            while (true)
            {

                string userInput;
                Console.WriteLine("Введите случайное число от 1 до 50");
                userInput = Console.ReadLine();
                int userNumber = Int16.Parse(userInput);

                if (userNumber == thoughtNumber)
                {
                    Console.WriteLine("Успех! Вы угадали число " + userNumber);
                    break;
                }
                else if (Math.Abs(userNumber-thoughtNumber)< Math.Abs(previousNumber-thoughtNumber))
                {
                    Console.WriteLine("Горячо");
                }
                else
                {
                    Console.WriteLine("{Холодно");
                }
                previousNumber = userNumber;


            }
            Console.ReadKey();

        }


    }
    
}
