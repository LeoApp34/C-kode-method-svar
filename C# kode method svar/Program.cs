// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Slett9999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kall på metodene som er definert under.
            SkrivHei();
            //Der hvor det er en return, opprett variabel for å holde på returverdien
            string Hilsen = ReturnerHei();
            Console.WriteLine("Returert Hilsen" + Hilsen);
            SkrivNoe(Hilsen);

            //Liten ekstra i forhold til tall bruk hvor jeg bruker Add metode for addisjon
            int sum = Add(5, 7);
            Console.WriteLine("Summen av 5 og 7 er:" + sum);
            //Kan også bare skrive sum
            Console.WriteLine(sum);

            // Liten ekstra fin måtte og skrive ut summen av to verdier uten og måtte bruke Console.WriteLine return kode, bra innebygd kode
            AddNoReturn(10, 20);

            Console.ReadLine();//for at consolet ikke skal stenges
        }

        public static void SkrivHei()
        {

            //Skriv kodelinjen som skriver hei ut til console
            SkrivNoe("hei");
        }


        public static string ReturnerHei()
        {
            string bolle = "Hei";
            return bolle;
            Console.WriteLine(bolle);
        }

        public static void SkrivNoe(string tekst)
        {
            Console.WriteLine(tekst);
        }


        public static int Add(int tall1, int tall2)
        {
            return tall1 + tall2;
        }

        public static void AddNoReturn(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}

