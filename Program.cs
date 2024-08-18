using System;

namespace TaskJunior2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput = "start";

            Console.WriteLine("Приветствую тебя супер секретный агент, введи пароль : ");

            while (userInput != password)
            {
                userInput = Console.ReadLine();

                if (userInput != password)
                {
                    Console.WriteLine("Вы ввели неправельный пароль, попробуйте еще раз!\n");
                }
            }
                Console.WriteLine("\nУрааа!!!, вот ваши самые секретные данные)))");
        }
    }
}
