using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static List<string[]> frame = new List<string[]>();

        static bool gameStatus = true;
        static string hero = "X"; //plauer
        static string wall = "#"; //wall
        static string target = "$"; //target
        static string emptyCell = " ";
        static string monster = "M";

        static void Main(string[] args)
        {
            //blauw is ook grappig
            Console.ForegroundColor = ConsoleColor.White;
            frame.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", " ", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "$", " ", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#", "#", "#", "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "#" });
            frame.Add(new string[] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });

            render();
            while (gameStatus)
            {
                var keyInfo = Console.ReadKey();
                moveHero(keyInfo);
                render();
            }
            Console.ReadKey();
        }
        static void render()
        {
            Console.Clear();
            for (int x = 0; x < frame.Count; x++)
            {
                //the cheat way
                Console.WriteLine(string.Join("", frame[x]));
            }
        }

        static void youWin()
        {
            Console.Clear();
            Console.WriteLine("Yeeeeeeejjj");
            Console.Beep();
            gameStatus = false;
            Console.ReadKey();

        }

        static void moveHero(ConsoleKeyInfo keyInfo)
        {
            //looping through column
            for (int x = frame.Count - 1; x >= 0; x--)
            {
                //looping through rows
                for (int y = 0; y < frame[x].Length; y++)
                {
                    //checking where X is
                    if (frame[x][y] == hero)
                    {
                        //if we press up
                        if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            //if we don't hit the wall we move
                            if ((x - 1) >= 0 && frame[x - 1][y] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x - 1][y] = hero;
                                return;
                            }
                            else if ((x - 1 >= 0 && frame[x - 1][y] == target))
                            {
                                frame[x][y] = emptyCell;
                                frame[x - 1][y] = hero;
                                youWin();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            //if we don't hit the wall we move
                            if ((x + 1) <= (frame.Count - 1) && frame[x + 1][y] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x + 1][y] = hero;
                                return;
                            }
                            else if ((x + 1) <= frame.Count - 1 && frame[x + 1][y] == target)
                            {
                                frame[x][y] = emptyCell;
                                frame[x + 1][y] = hero;
                                youWin();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            //if we don't hit the wall we move
                            if ((y - 1) >= 0 && frame[x][y - 1] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y - 1] = hero;
                                return;
                            }
                            else if ((y - 1) >= 0 && frame[x][y - 1] == target)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y - 1] = hero;
                                youWin();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            //if we don't hit the wall we move
                            if ((y + 1) <= frame[x].Length - 1 && frame[x][y + 1] == emptyCell)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y + 1] = hero;
                                return;
                            }
                            else if ((y + 1) <= (frame[x].Length - 1) && frame[x][y + 1] == target)
                            {
                                frame[x][y] = emptyCell;
                                frame[x][y + 1] = hero;
                                youWin();
                                return;
                            }

                        }
                    }
                }
            }
        }
    }
}
