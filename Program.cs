using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int[] xAleatoires = new int[1000];
            int[] yAleatoires = new int[1000];
            int[] xfAleatoires = new int[1000];
            int[] yfAleatoires = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                xAleatoires[i] = aleatoire.Next(0, 19);
                yAleatoires[i] = aleatoire.Next(0, 19);
                xfAleatoires[i] = aleatoire.Next(0, 19);
                yfAleatoires[i] = aleatoire.Next(0, 19);

                //Environnement 1
                /*if ((xAleatoires[i] == 5 && (yAleatoires[i]>=5 && yAleatoires[i]<=10))|| (xAleatoires[i] == 10 && (yAleatoires[i] >= 8 && yAleatoires[i] <= 13)))
                {
                    xAleatoires[i] += aleatoire.Next(1, 4);
                    yAleatoires[i] += aleatoire.Next(5, 6);
                }
                if ((xfAleatoires[i] == 5 && (yfAleatoires[i] >= 5 && yfAleatoires[i] <= 10)) || (xfAleatoires[i] == 10 && (yfAleatoires[i] >= 8 && yfAleatoires[i] <= 13)))
                {
                    xfAleatoires[i] += aleatoire.Next(1, 4);
                    yfAleatoires[i] += aleatoire.Next(5, 6);
                }*/

                //Environnement 2
                /*if ((xAleatoires[i] == 10 && yAleatoires[i]!=8))
                {
                    if (aleatoire.Next(0, 2) == 0)
                        xAleatoires[i] += aleatoire.Next(1, 5);
                    else
                        xAleatoires[i] -= aleatoire.Next(1, 5);
                }
                if ((xfAleatoires[i] == 10 && yfAleatoires[i] != 8))
                {
                    if (aleatoire.Next(0, 2) == 0)
                        xfAleatoires[i] += aleatoire.Next(1, 5);
                    else
                        xfAleatoires[i] -= aleatoire.Next(1, 5);
                }*/

                //Environnement 3
                //Cercle haut
                if ((yAleatoires[i] == 3) && ((xAleatoires[i] == 4) || (xAleatoires[i] == 5) || (xAleatoires[i] == 6) || (xAleatoires[i] == 7)))
                    yAleatoires[i]--;
                    
                else if ((yAleatoires[i] == 4) && ((xAleatoires[i] == 3) || (xAleatoires[i] == 4) || (xAleatoires[i] == 7) || (xAleatoires[i] == 8)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 5) && ((xAleatoires[i] == 2) || (xAleatoires[i] == 3) || (xAleatoires[i] == 8) || (xAleatoires[i] == 9)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 6) && ((xAleatoires[i] == 9)))
                    xAleatoires[i]--;
                else if ((yAleatoires[i] == 7) && ((xAleatoires[i] == 2) || (xAleatoires[i] == 9)))
                    xAleatoires[i]--;
                else if ((yAleatoires[i] == 8) && ((xAleatoires[i] == 2) || (xAleatoires[i] == 3) || (xAleatoires[i] == 8) || (xAleatoires[i] == 9)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 9) && ((xAleatoires[i] == 3) || (xAleatoires[i] == 4) || (xAleatoires[i] == 7) || (xAleatoires[i] == 8)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 10) && ((xAleatoires[i] == 4) || (xAleatoires[i] == 5) || (xAleatoires[i] == 6) || (xAleatoires[i] == 7)))
                    yAleatoires[i]++;
                //Cercle bas 
                else if ((yAleatoires[i] == 11) && ((xAleatoires[i] == 12) || (xAleatoires[i] == 13) || (xAleatoires[i] == 14) || (xAleatoires[i] == 15)))
                    yAleatoires[i]--;
                else if ((yAleatoires[i] == 12) && ((xAleatoires[i] == 11) || (xAleatoires[i] == 12) || (xAleatoires[i] == 15) || (xAleatoires[i] == 16)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 13) && ((xAleatoires[i] == 10) || (xAleatoires[i] == 11) || (xAleatoires[i] == 16) || (xAleatoires[i] == 17)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 14) && ((xAleatoires[i] == 10) || (xAleatoires[i] == 17)))
                    xAleatoires[i]--;
                else if ((yAleatoires[i] == 15) && ((xAleatoires[i] == 10)))
                    xAleatoires[i]--;
                else if ((yAleatoires[i] == 16) && ((xAleatoires[i] == 10) || (xAleatoires[i] == 11) || (xAleatoires[i] == 16) || (xAleatoires[i] == 17)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 17) && ((xAleatoires[i] == 11) || (xAleatoires[i] == 12) || (xAleatoires[i] == 15) || (xAleatoires[i] == 16)))
                    xAleatoires[i] += 2;
                else if ((yAleatoires[i] == 18) && ((xAleatoires[i] == 12) || (xAleatoires[i] == 13) || (xAleatoires[i] == 14) || (xAleatoires[i] == 15)))
                    yAleatoires[i]++;

                if ((yfAleatoires[i] == 3) && ((xfAleatoires[i] == 4) || (xfAleatoires[i] == 5) || (xfAleatoires[i] == 6) || (xfAleatoires[i] == 7)))
                    yfAleatoires[i]--;
                else if ((yfAleatoires[i] == 4) && ((xfAleatoires[i] == 3) || (xfAleatoires[i] == 4) || (xfAleatoires[i] == 7) || (xfAleatoires[i] == 8)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 5) && ((xfAleatoires[i] == 2) || (xfAleatoires[i] == 3) || (xfAleatoires[i] == 8) || (xfAleatoires[i] == 9)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 6) && ((xfAleatoires[i] == 9)))
                    xfAleatoires[i]--;
                else if ((yfAleatoires[i] == 7) && ((xfAleatoires[i] == 2) || (xfAleatoires[i] == 9)))
                    xfAleatoires[i]--;
                else if ((yfAleatoires[i] == 8) && ((xfAleatoires[i] == 2) || (xfAleatoires[i] == 3) || (xfAleatoires[i] == 8) || (xfAleatoires[i] == 9)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 9) && ((xfAleatoires[i] == 3) || (xfAleatoires[i] == 4) || (xfAleatoires[i] == 7) || (xfAleatoires[i] == 8)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 10) && ((xfAleatoires[i] == 4) || (xfAleatoires[i] == 5) || (xfAleatoires[i] == 6) || (xfAleatoires[i] == 7)))
                    yfAleatoires[i]++;

                else if ((yfAleatoires[i] == 11) && ((xfAleatoires[i] == 12) || (xfAleatoires[i] == 13) || (xfAleatoires[i] == 14) || (xfAleatoires[i] == 15)))
                    yfAleatoires[i]--;
                else if ((yfAleatoires[i] == 12) && ((xfAleatoires[i] == 11) || (xfAleatoires[i] == 12) || (xfAleatoires[i] == 15) || (xfAleatoires[i] == 16)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 13) && ((xfAleatoires[i] == 10) || (xfAleatoires[i] == 11) || (xfAleatoires[i] == 16) || (xfAleatoires[i] == 17)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 14) && ((xfAleatoires[i] == 10) || (xfAleatoires[i] == 17)))
                    xfAleatoires[i]--;
                else if ((yfAleatoires[i] == 15) && ((xfAleatoires[i] == 10)))
                    xfAleatoires[i]--;
                else if ((yfAleatoires[i] == 16) && ((xfAleatoires[i] == 10) || (xfAleatoires[i] == 11) || (xfAleatoires[i] == 16) || (xfAleatoires[i] == 17)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 17) && ((xfAleatoires[i] == 11) || (xfAleatoires[i] == 12) || (xfAleatoires[i] == 15) || (xfAleatoires[i] == 16)))
                    xfAleatoires[i] += 2;
                else if ((yfAleatoires[i] == 18) && ((xfAleatoires[i] == 12) || (xfAleatoires[i] == 13) || (xfAleatoires[i] == 14) || (xfAleatoires[i] == 15)))
                    yfAleatoires[i]++;
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("{0},", xAleatoires[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("{0},", yAleatoires[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("{0},", xfAleatoires[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("{0},", yfAleatoires[i]);
            }
            Console.ReadKey();
        }
    }
}