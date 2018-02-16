using System;
using System.Collections.Generic;

namespace Glubglub
{
    class Program
    {

        static void Main(string[] args)
        {
            int valueColumn = 0;
            int valueRow = 0;
            Boolean isInArray = false;

            string signal = "A";      // initialize to neutral
            while (signal != "X")      // X indicates stop
            {
                Console.WriteLine("|".PadRight(4) + "-----------------<MAIN MENU>----------------" + " ".PadRight(5) + "|");
                Console.WriteLine("|".PadRight(15) + " " + " ".PadRight(37) + "|");
                Console.WriteLine("|".PadRight(4) + "Welkom bij Glubglub applicatie" + " ".PadRight(19) + "|");
                Console.WriteLine("|".PadRight(4) + "Enter a signal. X = Stop. A = Abort:" + " ".PadRight(12) + " | ");
                Console.WriteLine("|".PadRight(4) + "--------------------------------------------" + " ".PadRight(5) + "|");

                signal = Console.ReadLine();

                // do some work here, no matter what signal you

                Console.WriteLine("");
                Console.WriteLine("|".PadRight(4) + "-----------------<SUB MENU>-----------------" + " ".PadRight(5) + "|");
                Console.WriteLine("1. check if element is available for gridArray[column, row]");
                Console.WriteLine("|".PadRight(4) + "--------------------------------------------" + " ".PadRight(5) + "|");
                Console.WriteLine("2. fill number in for column");
                valueColumn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("3. fill in number for row gridArray[" + valueColumn + ",row]");
                valueRow = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("4. you have selected gridArray[" + valueColumn + "," + valueRow + "]");

                // receive
                Console.WriteLine("Received: {0}", signal);

                if (signal == "A")
                {
                    // faulty - abort signal processing
                    // Log the problem and abort.
                    Console.WriteLine("Fault! Abort\n");
                    break;
                }

                if (signal == "S")
                {
                    // normal traffic condition
                    // log and continue on
                    Console.WriteLine("All is well.\n");
                    continue;
                }

                // Problem. Take action and then log the problem
                // and then continue on
                Console.WriteLine("{0} -- raise Signal!\n", signal);

                //     Console.Clear();
                //lijst met alle bestaande objecten 
                List<Verkeersobject> verkeersobjecten = new List<Verkeersobject>();
                Verkeersobject Moeder = new Moeder();
                Verkeersobject Kind = new Kind();
                Verkeersobject Auto = new Auto();
                Verkeersobject Brommer = new Brommer();
                Verkeersobject Racefiets = new Racefiets();
                Verkeersobject Ligfiets = new Ligfiets();
                Verkeersobject Elektrischefiets = new Elektrischefiets();
                Verkeersobject Stopbord = new Stopbord();
                Verkeersobject Stoplicht = new Stoplicht();
                Verkeersobject Voorangsbord = new Voorangsbord();
                Verkeersobject Thuisbasis = new Thuisbasis();
                Verkeersobject Zebrapad = new Zebrapad();

                //creating all verkeersobjects
                for (int i = 0; i <= 32; i++)
                {
                    //5%
                    if (i > 12)
                    {
                        verkeersobjecten.Add(Stoplicht);
                        verkeersobjecten.Add(Brommer);
                        verkeersobjecten.Add(Voorangsbord);
                        verkeersobjecten.Add(Moeder);
                    }
                    //3%
                    if (i > 20)
                    {
                        verkeersobjecten.Add(Stopbord);
                        verkeersobjecten.Add(Racefiets);
                        verkeersobjecten.Add(Elektrischefiets);
                    }
                    //2%
                    if (i > 24)
                    {
                        verkeersobjecten.Add(Zebrapad);
                        verkeersobjecten.Add(Thuisbasis);
                        verkeersobjecten.Add(Ligfiets);
                    }

                    //verkeersobjecten.Add(Racefiets);
                    verkeersobjecten.Add(Auto);
                    verkeersobjecten.Add(Kind);
                }

                /*
                int z = 0;

                Console.WriteLine();
                Console.WriteLine("Number\tKarakter\tRichting");

                foreach (Verkeersobject v in verkeersobjecten)
                    if (v != null)
                    {
                        z++;
                        Console.WriteLine((z) + "\t " + v.Karakter + "\t\t" + v.Richting);

                    }
                    else
                    {
                        Console.WriteLine("List element has null value.");
                    }
                    */

                Verkeersobject[,] gridArray = new Verkeersobject[20, 20];

                for (int fillArray = 0; fillArray < verkeersobjecten.Count; fillArray++)
                {
                    int row = Utils.row.Next(0, 20);
                    int column = Utils.column.Next(0, 20);

                    gridArray[row, column] = verkeersobjecten[fillArray];

                    if (gridArray[valueColumn, valueRow] == gridArray[row, column])
                    {
                        //    Console.WriteLine("THIS ITEM IS IN GRID");
                        //   Console.Write(" karakter is "+ gridArray[row, column].Karakter);
                    }
                    else
                    {
                        //Console.Write(0);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("List.verkeersobjecten (number of created elements): " + verkeersobjecten.Count);
                Console.WriteLine("empArray.Rank (number of dimensions) = " + gridArray.Rank);
                Console.WriteLine("empArray.Length (number of elements) = " + gridArray.Length);

                for (int d = 0; d < 20; d++)
                {
                    if (d == 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("  ".PadRight(2) + (d + 1));
                }
                Console.WriteLine();

                // int waarde = 0;
                //looping through column
                for (int x = 0; x < gridArray.GetLength(1); x++)
                {
                    if (x < 9)
                    {
                        Console.Write((x + 1) + "".PadRight(2));
                    }
                    else
                    {
                        Console.Write((x + 1) + "".PadRight(1));
                    }
                    //looping through rows
                    for (int y = 0; y < gridArray.GetLength(0); y++)
                    {
                        if (gridArray[x, y] != null)
                        {
                            //als we het getal 10 benaderen en het een verkeersobject bevat dan doen, we een spatie extra voor de uitlijning
                            if (y < 10)
                            {
                                Console.Write("  " + gridArray[x, y].Karakter + " ".PadRight(0));
                            }
                            else
                            {
                                Console.Write(" " + gridArray[x, y].Karakter + " ".PadRight(1));
                            }

                            if (gridArray[valueColumn, valueRow] == gridArray[x, y])
                            {
                                isInArray = true;
                            }
                            else
                            {
                                isInArray = false;
                            }
                        }
                        else
                        {
                            //als we het getal 10 benaderen en het een geen verkeersobject bevat, dan doen we een spatie extra voor de uitlijning
                            if (y < 10)
                            {
                                Console.Write("  " + gridArray[x, y] + "-" + " ".PadRight(0));
                            }
                            else
                            {
                                Console.Write(" " + gridArray[x, y] + "-" + " ".PadRight(1));
                            }
                        }
                    }
                    Console.WriteLine();
                }
                if (isInArray)
                {
                    Console.WriteLine(gridArray[valueColumn, valueRow].Karakter + "   " + isInArray);
                    if(gridArray[valueColumn, valueRow].Karakter == 'm')
                    {
                        Console.WriteLine("Ik heb een kind");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();                  
                    Console.WriteLine("4. you have selected gridArray[" + valueColumn + "," + valueRow + "] komt er niet in voor probeer opnieuw" + isInArray);
                    Console.WriteLine();
                    //      Console.Clear();

                }
            }
        }

    }
    public static class Utils
    {
        public static readonly Random random = new Random();
        public static readonly Random column = new Random();
        public static readonly Random row = new Random();
    }

    public class Verkeersobject
    {
        public int Richting { get; private set; }
        public char Karakter { get; set; }

        public Verkeersobject()
        {
            Richting = Utils.random.Next(1, 5);
            Karakter = '-';
        }
    }

    class Dynamisch : Verkeersobject
    {
        public int Snelheid { get; set; }
    }

    class Statisch : Verkeersobject
    {
        public int Leeftijd { get; set; }
    }

    class Moeder : Dynamisch
    {
        public Moeder() : base()
        {
            Karakter = 'm';
        }

        public void Roepen()
        {

        }

        public void Tellen()
        {

        }
    }

    class Kind : Dynamisch
    {
        public Kind() : base()
        {
            Karakter = 'k';
        }
    }

    class Auto : Dynamisch
    {
        public Auto() : base()
        {
            Karakter = 'a';
        }
    }

    class Fiets : Dynamisch
    {
        public string Merk { get; set; }
    }

    class Brommer : Dynamisch
    {
        public Brommer() : base()
        {
            Karakter = 'b';
        }
    }
    //parent class fiets
    class Ligfiets : Fiets
    {
        public Ligfiets() : base()
        {
            Karakter = 'l';
            Snelheid = 1;
            Merk = "Lekker";
        }

    }
    //parent class fiets
    class Racefiets : Fiets
    {
        public Racefiets() : base()
        {
            Karakter = 'r';
        }
    }

    class Elektrischefiets : Fiets
    {
        public Elektrischefiets() : base()
        {
            Karakter = 'e';
        }
    }

    class Stopbord : Statisch
    {
        public Stopbord() : base()
        {
            Karakter = 's';
        }

    }
    class Voorangsbord : Statisch
    {
        public Voorangsbord() : base()
        {
            Karakter = 'v';

        }
    }
    class Stoplicht : Statisch
    {
        public Stoplicht() : base()
        {
            Karakter = 'x';

        }
    }

    class Thuisbasis : Statisch
    {
        public Thuisbasis() : base()
        {
            Karakter = 't';

        }

    }

    class Zebrapad : Statisch
    {
        public Zebrapad() : base()
        {
            Karakter = '*';
        }
    }
}


