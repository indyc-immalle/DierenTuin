using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DierenInDeZoo
{

    class Paard : Dier
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("hinnik hinnik");
        }

        public override void NaamDier()
        {
            Console.WriteLine("Mijn Naam is Skiaaa ");
        }
    }
    
    class Varken : Dier
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("knor knor");
        }

        public override void NaamDier()
        {
            Console.WriteLine("Mijn Naam is Alfred het varken ");
        }
    }

    class Koe : Dier
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("moeeee");
        }
        public override void NaamDier()
        {
            Console.WriteLine("Mijn Naam is Skroe de koe");
        }
    }

    class Mol : Dier
    {
        public override void MaakGeluid()
        {
            Console.WriteLine("skrkrksrkrkrskrks");
        }

        public override void NaamDier()
        {
            Console.WriteLine("Mijn Naam is Pol de mol");
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

            p.Gewicht = 102.2;
            p.MaakGeluid();
            p.NaamDier();
            Console.WriteLine("Ik weeg {0}", p.Gewicht);
            Console.WriteLine(k.GewichtBeschrijving);
            p.PrintBeschrijving();


            v.Gewicht = 67.3;
            v.MaakGeluid();
            v.NaamDier();
            Console.WriteLine("Ik weeg {0}", v.Gewicht);

            k.NaamDier();

            m.NaamDier();
        }
    }
}
