using System;

namespace TaskJunior2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput = "start";

            while (userInput != password)
            {
            Console.WriteLine("Приветствую тебя супер секретный агент, введи пароль : ");
            userInput = Console.ReadLine();

                if (userInput != password)
                { 
                    Console.WriteLine("Вы ввели неправельный пароль, попробуйте еще раз!\n"); 
                }
                else if (userInput == password)
                {
                    Console.WriteLine("\nУрааа!!!, вот ваши самые секретные данные)))");
                }
            }  
        }
    }
}
