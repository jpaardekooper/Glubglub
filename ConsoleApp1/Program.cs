using System;

namespace Glubglub
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Maak een nieuw project(console) voor de opdracht verkeer. Bewaar deze voor de rest van de UML Practica
            2.Programmeer straks het hele diagram uit.Hierbij geldt:
                a.Je mag voor ieder element zelf bepalen hoe welk karakter erbij hoort.
                b.Elk element begint met een random kijkrichting(1, 2, 3, 4).Zoek zelf uit hoe je met random getallen werkt.
                c.Methoden mogen nu leeg blijven.
            3.Maak in Main een 2D - array van Verkeersobjecten(20x20)
            4.Schrijf(in de main - klasse) een methode die het array afdrukt met aan de zij-en bovenkant de coördinaten(in mensentaal, dus beginnend bij 1).Lege vakjes(nu nog allemaal) worden weergegeven door ‘_’ Laat het lijken op: 
            5.Pas de afdrukmethode zo aan dat bij het afdrukken het karakter van het juiste object op het scherm komt, als er zich op die plaats een verkeersobject bevindt.
            6.Test handmatig door op plekken in het array elementen te plaatsen en dan te kijken of deze ook verschijnen bij het afdrukken.
            */

            // Two-dimensional array.
            // The first number indicates the number of columns, the second is the number of rows
            int[,] grid = new int[20, 20];

            grid[2, 2] = 1; // center

            //filling grid
            for (int i = 1; i < 4; i++) // fourth row
            {
                grid[i, 3] = 1;
            }
            //filling grid
            for (int i = 0; i < 5; i++) // the last row
            {
                grid[i, 4] = 1;
            }

            //output for the grid
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    Console.Write(" " + grid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Verkeersobject
    {
        public char karakter { get; set; }
        public int richting { get; set; }
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
    // nog één fiets

    class Stopbord : Statisch
    {

    }

    // nog 2 borden
}


