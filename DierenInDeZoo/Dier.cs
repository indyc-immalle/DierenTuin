﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DierenInDeZoo
{
    abstract class Dier
    {
        public double Gewicht { get; set; }
        
       public string GewichtBeschrijving
       {
           get
           {
               if (Gewicht > 100)
              {
                  return "Dat is een zwaargewicht";
               }
               else
               {
                    return "Dat is een lichtgewicht";
                }
            }

        }

        public void PrintBeschrijving()
        {

            if (Gewicht > 100)
            {
                Console.WriteLine("Dat is een zwaargewicht");
            }
            else
            {
                Console.WriteLine("Dat is een lichtgewicht");
            }
        }

        public virtual void MaakGeluid()
        {
            Console.WriteLine("<stilte>");
           
        }

        public virtual void PrintNaamDier()
        {
            Console.WriteLine("dat is een dier");
        }

        public virtual void Lijntjes()
        {
            Console.WriteLine("-----------------------------");
        }
    }


}
