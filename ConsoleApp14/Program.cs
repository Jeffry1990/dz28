using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit=true;

            while (isExit==true)
            {
                string day;
                Console.Write("Напишите любой день недели или exit чтобы завершить: ");
                day = Console.ReadLine();

                switch (day)
                {
                    case "понедельник":
                    case "вторник":
                    case "среда":
                    case "четверг":
                    case "пятница":
                    case "суббота":
                    case "воскресенье":
                        Console.WriteLine("день недели");
                        break;
                    case "exit":
                        Console.WriteLine("Выход из программы");
                        isExit = false;
                        break; 
                    default:
                        Console.WriteLine("Я такого дня недели не знаю");
                        break;
                }
            }
        }
        }
    }
    

