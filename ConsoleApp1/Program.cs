using System;
using System.Collections.Generic;

namespace Glubglub
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random();

            List<Verkeersobject> verkeersobjecten = new List<Verkeersobject>
            {
             new Moeder(),
             new Kind(),
             new Auto(),
             new Brommer(),
             new Racefiets(),
             new Ligfiets(),
             new Elektrischefiets(),
             new Stopbord(),
             new Stoplicht(),
             new Voorangsbord(),
             new Workshop(),
             new Zebrapad(),
            };

            //Your Array
            Verkeersobject[] parametersToInput = new Verkeersobject[verkeersobjecten.Count];

            //Filling Your Array from Your List
            int index = 0;
            verkeersobjecten.ForEach(e => parametersToInput[index++] = e);
           
            for (int i = 0; i < parametersToInput.GetLength(0); i++)
            {
                Console.Write(parametersToInput[i].Karakter + " ".PadRight(3));
            }
           

            foreach (Verkeersobject v in verkeersobjecten)
                if (v != null)
                {
                    Console.Write(v.Richting);
                    Console.WriteLine(v.Karakter);
                }
                else
                {
                    Console.WriteLine("List element has null value.");
                }


            Console.WriteLine(verkeersobjecten[0].Karakter + " test");




            Voorangsbord voorrang = new Voorangsbord();
            Stoplicht stoplicht = new Stoplicht();


            Console.WriteLine("test voorrang" + voorrang.Karakter);
            Console.WriteLine("test stoplicht" + stoplicht.Karakter);

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


            int randomNummer = Utils.random.Next(0, 20);
            int listRand = Utils.random.Next(0, 12);

            Verkeersobject[,] empArray = new Verkeersobject[20, 20];


            empArray[randomNummer, randomNummer] = verkeersobjecten[listRand];
            empArray[4, 1] = new Verkeersobject();

            Console.WriteLine("empArray.Rank (number of dimensions) = " + empArray.Rank);
            Console.WriteLine("empArray.Length (number of elements) = " + empArray.Length);

           


            for (int d = 0; d < 20; d++)
            {
                Console.Write(" ".PadRight(2) + (d + 1));

            }
            Console.WriteLine();
            for (int x = 0; x < empArray.GetLength(1); x++)
            {
                if (x < 9)
                {
                    Console.Write((x + 1) + " ".PadRight(3));
                }
                else
                {
                    Console.Write((x + 1) + " ".PadRight(2));
                }             
                for (int y = 0; y < empArray.GetLength(0); y++)
                {


                    if (empArray[x, y] != null)
                    {
                      
                        Console.Write("empArray[" + (x + 1) + ", " + (y + 1) + "].karakter is " + empArray[x, y].Karakter);              
                    }
                    else
                    {
                        Console.Write(empArray[x, y] + "-".PadRight(2) );
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

    public class Verkeersobject
    {
        public int Richting { get; private set; }
        public char Karakter { get; set; }

        public Verkeersobject()
        {
            Richting = Utils.random.Next(1, 4);
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
            Karakter = 's';

        }
    }

    class Workshop : Statisch
    {
        public Workshop() : base()
        {
            Karakter = 'w';

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


