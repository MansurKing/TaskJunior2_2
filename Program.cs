using System;

namespace TaskJunior2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Извиняюсь, я случайно еще раз отправил, сейчас буду доделывать данное задание
            /// по этим замечания : 1.  if (userInput != password)- не нужно проверять одно и тоже 2 раза. Посмотрите do while, а также вы можете не делать переменную для ввода пользователя
            /// Спасибо!
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
