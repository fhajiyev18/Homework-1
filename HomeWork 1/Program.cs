using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Условие. Написать программу, которая спрашивает какая погода на улице. При вводе от -20 до 5 говорит, 
              что холодно. От 6 до 15 - прохладно, от 16 до 20 - тепло, от 21 до 35 - жарко, от 36 до 45 - очень жарко. 
              При вводе других значений говорит, что не верит, что такая температура может быть.*/

            Console.WriteLine("Привет, Siri! Какая сегодня погода? Чтобы узнать состояние погоды введите температуру.");

            sbyte weather = Convert.ToSByte(Console.ReadLine());

            
                if (weather <= -20 && weather >= 5)
                {
                    Console.WriteLine("Сегодня холодно, одевайтесь теплее.");
                }


                else if (weather >= 6 && weather <= 15)
                {
                    Console.WriteLine("Сегодня прохладно, одевайтесь теплее.");

                }


                else if (weather >= 16 && weather <= 20)
                {
                    Console.WriteLine("Сегодня тепло, можно выйти на прогулку!");

                }

                else if (weather >= 21 && weather <= 35)
                {
                    Console.WriteLine("Сегодня жарко, советую пойти на море и освежиться!");

                }

                else if (weather >= 36 && weather <= 45)
                {
                    Console.WriteLine("Сегодня очень жарко, не советую выходить из дома, можете сгореть!");

                }

                else
                {
                    Console.WriteLine("Хмм, я думаю вы перепутали что-то. Я вам не верю!");

                }

            }
        
    }
    }
