/*
Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.
*/

namespace FallingRocksGame
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;

    struct Rock
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public string c;
    }

    class FallingRocks
    {
        // Printing an object on specific cordinates on the console.
        static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        // Generates random Console colours.
        private static Random random = new Random();

        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(random.Next(consoleColors.Length));
        }

        static int lives = 5;

        static int speed = 0;

        static int indexOfLevel = 0;

        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 35;
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.CursorVisible = false;

            bool colision = false;

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
                //// Generates a new falling rock.
                {
                    Rock newRock = new Rock();
                    newRock.color = GetRandomConsoleColor();
                    if (newRock.color == ConsoleColor.Black)
                    {
                        newRock.color = ConsoleColor.Gray;
                    }

                    newRock.x = randomGenerator.Next(0, Console.WindowWidth);
                    newRock.y = 3;
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
                        if (dwarf.x + dwarf.c.Length < Console.WindowWidth - 1)
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
                    if ((newRock.x == dwarf.x || newRock.x == dwarf.x + 1 || newRock.x == dwarf.x + 2) && newRock.y == dwarf.y)
                    {
                        lives--;
                        if (speed > 75)
                        {
                            speed = speed - 50;
                        }

                        colision = true;
                        if (lives <= 0)
                        {
                            Console.Clear();
                            PrintOnPosition((Console.WindowWidth / 2) - 6, Console.WindowHeight / 2, "GAME OVER!!!", ConsoleColor.DarkRed);
                            PrintOnPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 2, "You reached level " + indexOfLevel, ConsoleColor.DarkRed);
                            Console.ReadLine();
                            return;
                        }
                    }

                    if (speed <= 25)
                    {
                        indexOfLevel = 1;
                    }

                    if (speed >= 26 && speed <= 50)
                    {
                        indexOfLevel = 2;
                    }

                    if (speed >= 51 && speed <= 75)
                    {
                        indexOfLevel = 3;
                    }

                    if (speed >= 76 && speed <= 100)
                    {
                        indexOfLevel = 4;
                    }

                    if (speed >= 101 && speed <= 125)
                    {
                        indexOfLevel = 5;
                    }

                    if (speed >= 126 && speed <= 150)
                    {
                        indexOfLevel = 6;
                    }

                    if (speed >= 151 && speed <= 175)
                    {
                        indexOfLevel = 7;
                    }

                    if (speed >= 176 && speed <= 200)
                    {
                        indexOfLevel = 8;
                    }

                    if (speed >= 201 && speed <= 225)
                    {
                        indexOfLevel = 9;
                    }

                    if (speed >= 226 && speed <= 250)
                    {
                        indexOfLevel = 10;
                    }

                    if (speed >= 251 && speed <= 275)
                    {
                        indexOfLevel = 11;
                    }

                    if (speed >= 276 && speed <= 300)
                    {
                        indexOfLevel = 12;
                    }

                    if (speed >= 301 && speed <= 325)
                    {
                        indexOfLevel = 13;
                    }

                    if (speed >= 326 && speed <= 350)
                    {
                        indexOfLevel = 14;
                    }

                    if (speed >= 351 && speed <= 375)
                    {
                        indexOfLevel = 15;
                    }

                    if (speed >= 376)
                    {
                        indexOfLevel = 16;
                    }

                    if (newRock.y < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }
                }

                rocks = newList;

                Console.Clear();

                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);

                foreach (Rock rock in rocks)
                {
                    PrintOnPosition(rock.x, rock.y, rock.c, rock.color);
                }

                PrintOnPosition(0, 0, "FALLING ROCKS GAME", ConsoleColor.White);

                PrintOnPosition(Console.WindowWidth - 14, 0, "Lives count: " + lives, ConsoleColor.White);

                PrintOnPosition(0, 1, "You are at level " + indexOfLevel, ConsoleColor.White);

                PrintOnPosition(Console.WindowWidth - 14, 1, "Speed is: " + speed, ConsoleColor.White);

                char pad = '-';
                string str = "-";
                PrintOnPosition(0, 2, str.PadLeft(Console.WindowHeight + 4, pad), ConsoleColor.White);

                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);

                if (colision)
                {
                    rocks.Clear();

                    colision = false;
                }

                if (speed > 399)
                {
                    speed = 400;
                }
                else
                {
                    speed++;
                }

                Thread.Sleep(500 - speed);
            }
        }
    }
}