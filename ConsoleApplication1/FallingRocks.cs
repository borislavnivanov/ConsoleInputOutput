/*Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace FallingRocksGame
{
    struct Rock
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public string c;
    }



    class FallingRocks
    {

        static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        //Generates random Console colours
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }




        static void Main()
        {

            Console.BufferHeight = Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth = 50;

            Rock dwarf = new Rock();
            dwarf.x = Console.WindowWidth / 2;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.color = ConsoleColor.White;
            dwarf.c = "(0)";

            List<Rock> rocks = new List<Rock>();

            Random randomGenerator = new Random();

            string[] x = new string[11];
            x[0] = "^";
            x[1] = "@";
            x[2] = "*";
            x[3] = "&";
            x[4] = "+";
            x[5] = "%";
            x[6] = "$";
            x[7] = "#";
            x[8] = "!";
            x[9] = ".";
            x[10] = ";";

            while (true)
            {
                int i = randomGenerator.Next(0, x.Length);
                string rockChar = x[i];
                // Generates a new falling rock.
                {
                    Rock newRock = new Rock();
                    newRock.color = GetRandomConsoleColor();
                    if (newRock.color == ConsoleColor.Black)
                    {
                        newRock.color = ConsoleColor.Gray;
                    }
                    newRock.x = randomGenerator.Next(0, Console.WindowWidth);
                    newRock.y = 0;
                    newRock.c = rockChar;
                    rocks.Add(newRock);
                }



                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedkey = Console.ReadKey(true);

                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey();
                    }

                    if (pressedkey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.x - 1 >= 0)
                        {
                            dwarf.x = dwarf.x - 1;
                        }
                    }

                    if (pressedkey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.x + dwarf.c.Length + 1 < Console.WindowWidth) //TODO: dwarf.c.Lenght + 1 makes the last colum unusable
                        {
                            dwarf.x = dwarf.x + 1;
                        }
                    }

                }

                List<Rock> newList = new List<Rock>();

                for (int j = 0; j < rocks.Count; j++)
                {
                    Rock oldRock = rocks[j];
                    Rock newRock = new Rock();
                    newRock.x = oldRock.x;
                    newRock.y = oldRock.y + 1;
                    newRock.c = oldRock.c;
                    newRock.color = oldRock.color;
                    if (newRock.y < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }
                }
                rocks = newList;

                // TODO: Collision detection system
                Console.Clear();

                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);

                foreach (Rock rock in rocks)
                {
                    PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
                }


                // TODO: Scoring system

                Thread.Sleep(150);

            }
        }
    }
}
