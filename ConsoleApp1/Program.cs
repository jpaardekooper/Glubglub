using System;

namespace Glubglub
{
    class Program
    {
        static void Main(string[] args)
        {

            Verkeersobject test = new Verkeersobject();
            Voorangsbord voorrang = new Voorangsbord();
            Stoplicht stoplicht = new Stoplicht();

          
            Console.WriteLine("test voorrang" + voorrang.karakter);
            Console.WriteLine("test stoplicht" + stoplicht.karakter);

            /*
            1.Maak een nieuw project(console) voor de opdracht verkeer. Bewaar deze voor de rest van de UML Practica
            2.Programmeer straks het hele diagram uit.Hierbij geldt:
                a.Je mag voor ieder element zelf bepalen hoe welk karakter erbij hoort.
                b.Elk element begint met een random kijkrichting(1, 2, 3, 4).Zoek zelf uit hoe je met random getallen werkt.
                c.Methoden mogen nu leeg blijven.
            3.Maak in Main een 2D - array van Verkeersobjecten(20x20)
            4.Schrijf(in de main - klasse) een methode die het array afdrukt met aan de
            zij-en bovenkant de coördinaten(in mensentaal, dus beginnend bij 1).Lege vakjes(nu nog allemaal) worden weergegeven door ‘_’ Laat het lijken op: 
            5.Pas de afdrukmethode zo aan dat bij het afdrukken het karakter van het juiste object op het scherm komt, als er zich op die plaats een verkeersobject bevindt.
            6.Test handmatig door op plekken in het array elementen te plaatsen en dan te kijken of deze ook verschijnen bij het afdrukken.
            */

            // Two-dimensional array.
            // The first number indicates the number of columns, the second is the number of rows
   
            object[,] grid = new object[21, 20];

            grid[10, 10] = '1'; // center  


            //filling grid
            for (int j = 1; j < grid.GetLength(0); j++) // fourth row
            {
                grid[j, 0] = voorrang.karakter;
            }
            //filling grid
            for (int j = 0; j < grid.GetLength(1); j++) // the fifth row
            {
                for (int i = 1; i < grid.GetLength(0); i++) // fourth row
                {
                    grid[i, 8] = voorrang.karakter;
                }
            }

            //output for the grid
            for (int j = 0; j < grid.GetLength(0); j++)
            {              
                if (j < 10 && j > 0)
                {
                    Console.Write(j + " ".PadRight(1));
                }
                else
                {
                    Console.Write(j);
                }
                for (int i = 0; i < grid.GetLength(1); i++)
                {
                    if (j == 0)
                    {
                        Console.Write(" ".PadLeft(2) + (i + 1));
                    }
                    //Verkeers object characters 
                    else
                    {
                        Console.Write(" ".PadLeft(2) + grid[j,i] );
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();



            Employee[,] empArray = new Employee[10, 10];

            empArray[1, 3] = new Employee("S", 3);
            empArray[4, 1] = new Employee("A", 9);

            Console.WriteLine("empArray.Rank (number of dimensions) = " + empArray.Rank);
            Console.WriteLine("empArray.Length (number of elements) = " + empArray.Length);

            for(int d = 0; d < 10; d++){
                Console.Write(" ".PadRight(2) + (d+1) );

            }
            Console.WriteLine();
            for (int x = 0; x < empArray.GetLength(0); x++)
            {
                if (x < 9)
                {
                    Console.Write((x+1) + " ".PadRight(3));
                }
                else
                {
                    Console.Write((x+1) +" ".PadRight(2) );
                }
               // Console.Write((x+1) +" ".PadRight(3) );
                for (int y = 0; y < empArray.GetLength(1); y++)
                {
                   

                    if (empArray[x, y] != null)
                    {
                        Console.Write("test");
                       // Console.Write("empArray[" + x + ", " + y + "].name = " + empArray[x, y].name);
                      //  Console.Write("empArray[" + x + ", " + y + "].no = " + empArray[x, y].no);
                    }
                    else
                    {
                      
                            Console.Write("-".PadRight(2) + empArray[x, y]);
                     
                       
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
    public static class Utils
    {
        public static readonly Random random = new Random();
    }

    public class Verkeersobject
    {
        public Verkeersobject()
        {
            richting = Utils.random.Next(1,4);
        }
        public int richting { get; private set; }
        public char karakter { get; set; }
    }

    class Dynamisch : Verkeersobject
    {
        public int snelheid { get; set; }
    }

    class Statisch : Verkeersobject
    {
        public int leeftijd { get; set; }
    }

    class Moeder : Dynamisch
    {
        public Moeder() : base()
        {
            //doe iets
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

    }

    class Auto : Dynamisch
    {

    }

    class Fiets : Dynamisch
    {

    }

    class Brommer : Dynamisch
    {

    }
    //parent class fiets
    class Ligfiets : Fiets
    {
        public Ligfiets() : base()
        {
            //doe iets
        }
    }
    //parent class fiets
    class Racefiets : Fiets
    {
        public Racefiets() : base()
        {
            //doe iets
        }
    }

    class Elektrischefiets : Fiets
    {
        public Elektrischefiets() : base()
        {
            //doe iets
        }
    }

    class Stopbord : Statisch
    {
        public Stopbord() : base()
        {
            karakter = 's';
        }

    }
    class Voorangsbord : Statisch
    {
        public Voorangsbord() : base()
        {
            karakter = 'v';

        }
    }
    class Stoplicht : Statisch
    {
        public Stoplicht() : base()
        {
            karakter = 's';

        }
    }

    class Zebrapad : Statisch
    {
        public Zebrapad() : base()
        {
            karakter = '*';

        }
    }

    public class Employee
    {
        public string name;
        public int no;

        public Employee(string name, int no)
        {
            this.name = name;
            this.no = no;
        }
    }


}


