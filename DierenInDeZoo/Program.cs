using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DierenInDeZoo
{

    class Paard : Dier
    {
        string Soort = "Paard";
        string Naam;

        public override void MaakGeluid()
        {
            Console.WriteLine("{0} maak het geluid hinnik hinnik",Naam );
        }

        public override void PrintNaamDier()
        {
            

            Console.WriteLine("Dit is een {0}", Soort);
            Console.Write("Geef het paard een naam:  ");
            Naam = Console.ReadLine();
            Console.WriteLine("De naam die je gekozen hebt is {0}", Naam);
        }
    }
    
    class Varken : Dier
    {
        string Soort = "Varken";
        string Naam;

        public override void MaakGeluid()
        {
            Console.WriteLine("{0} maak het geluid Knor knor", Naam);
        }

        public override void PrintNaamDier()
        {


            Console.WriteLine("Dit is een {0}", Soort);
            Console.Write("Geef het varken een naam:  ");
            Naam = Console.ReadLine();
            Console.WriteLine("De naam die je gekozen hebt is {0}", Naam);
        }
    }

    class Koe : Dier
    {
        string Soort = "Koe";
        string Naam;

        public override void MaakGeluid()
        {
            Console.WriteLine("{0} maak het geluid moeeeeeee", Naam);
        }

        public override void PrintNaamDier()
        {


            Console.WriteLine("Dit is een {0}", Soort);
            Console.Write("Geef het koe een naam:  ");
            Naam = Console.ReadLine();
            Console.WriteLine("De naam die je gekozen hebt is {0}", Naam);
        }
    }

    class Mol : Dier
    {
        string Soort = "Mol";
        string Naam;

        public override void MaakGeluid()
        {
            Console.WriteLine("{0} maak het geluid *graaf* *graaf*", Naam);
        }

        public override void PrintNaamDier()
        {


            Console.WriteLine("Dit is een {0}", Soort);
            Console.Write("Geef het mol een naam:  ");
            Naam = Console.ReadLine();
            Console.WriteLine("De naam die je gekozen hebt is {0}", Naam);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dier p = new Paard();
            Dier v = new Varken();
            Dier k = new Koe();
            Dier m = new Mol();

            p.Gewicht = 100;
            v.Gewicht = 67.3;
            k.Gewicht = 75.8;
            m.Gewicht = 5.8;

            p.Lijntjes();
            p.PrintNaamDier();
            p.MaakGeluid();
            p.PrintBeschrijving();
            Console.WriteLine(p.GewichtBeschrijving);
            
            v.Lijntjes();
            v.PrintNaamDier();
            v.MaakGeluid();

            v.Lijntjes();
            k.PrintNaamDier();

            v.Lijntjes();
            m.PrintNaamDier();
        }
    }
}
