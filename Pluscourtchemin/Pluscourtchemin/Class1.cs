using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pluscourtchemin
{
    public class Class1 : GenericNode 
    {
        public int x;
        public int y;

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            Class1 N2bis = (Class1)N2;

            return (x == N2bis.x) && (y == N2bis.y);
        }

        public override double GetArcCost(GenericNode N2)
        {
            // Ici, N2 ne peut être qu'1 des 8 voisins, inutile de le vérifier
            Class1 N2bis = (Class1)N2;
            return Math.Sqrt((N2bis.x-x)*(N2bis.x-x)+(N2bis.y-y)*(N2bis.y-y));
        }

        public override bool EndState()
        {
            return (x == Form1.xfinal) && (y == Form1.yfinal);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int dx=-1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if ((x + dx >= 0) && (x + dx < Form1.nbcolonnes)
                            && (y + dy >= 0) && (y + dy < Form1.nblignes) && ((dx != 0) || (dy != 0)))
                        if (Form1.matrice[x + dx, y + dy] != -1)
                        {
                            Class1 newnode2 = new Class1();
                            newnode2.x = x + dx;
                            newnode2.y = y + dy;
                            lsucc.Add(newnode2);
                        }
                }

            }
            return lsucc;
        }

        private double CalculeEuclideanDistance(int xActuel, int yActuel, int xFinal, int yFinal)
        {
            return Math.Sqrt(Math.Pow((xFinal - xActuel), 2) + Math.Pow((yFinal - yActuel), 2));
        }

        private double CalculEuclideanDistance2(int xIntermediaire, int yIntermediaire)
        {
            return CalculeEuclideanDistance(this.x, this.y, xIntermediaire, yIntermediaire) 
                + CalculeEuclideanDistance(xIntermediaire, yIntermediaire, Form1.xfinal, Form1.yfinal);
        }

        private bool estDansObstacleHaut(int x,int y)
        {
            if ((y == 4) && ((x == 5) || (x == 6)))
                return true;
            else if ((y == 5) && ((x == 4)||(x == 5) || (x == 6)|| (x == 7)))
                return true;
            else if ((y == 6) && ((x == 2) || (x == 3)||(x == 4) || (x == 5) || (x == 6) || (x == 7) ||(x==8)))
                return true;
            else if ((y == 7) && ((x == 3) || (x == 4) || (x == 5) || (x == 6) || (x == 7) || (x == 8)))
                return true;
            else if ((y == 8) && ((x == 4) || (x == 5) || (x == 6) || (x == 7)))
                return true;
            else if ((y == 9) && ((x == 5) || (x == 6)))
                return true;
            return false;
        }

        private bool estDansObstacleBas(int x, int y)
        {
            if ((y == 12) && ((x == 13) || (x == 14)))
                return true;
            else if ((y == 13) && ((x == 12) || (x == 13) || (x == 14) || (x == 15)))
                return true;
            else if ((y == 14) && ((x == 11) || (x == 12) || (x == 13) || (x == 14) || (x == 15) || (x == 16) ))
                return true;
            else if ((y == 15) && ((x == 11) || (x == 12) || (x == 13) || (x == 14) || (x == 15) || (x == 16) || (x == 17)))
                return true;
            else if ((y == 16) && ((x == 12) || (x == 13) || (x == 14) || (x == 15)))
                return true;
            if ((y == 17) && ((x == 13) || (x == 14)))
                return true;
            return false;
        }

        public double Manhattan(int xFinal, int yFinal)
        {
            return Math.Abs(this.x - xFinal)+Math.Abs(this.y - yFinal);
        }
        public double Manhattan2 (int xInt, int yInt)
        {
            return Manhattan(xInt, yInt) + Math.Abs(xInt - Form1.xfinal) + Math.Abs(yInt - Form1.yfinal);
        }

        public override double CalculeHCost()
        {
            double heuristique = 0;

            int xFinal = Form1.xfinal;
            int yFinal = Form1.yfinal;

            int dx = Math.Abs(this.x - xFinal);
            int dy = Math.Abs(this.y - yFinal);

            int xMilieuEnvironnement2 = 10;
            int yMilieuEnvironnement2 = 8;

            if (Form1.environnementLoaded == "environnement1.txt")
            {
                //Algorithme de Dijsktra
                //return 0;

                //Heuristique Manhattan distance
                //heuristique = Manhattan(xFinal, yFinal);
                //return heuristique;


                //Heuristique distance diagonale
                //heuristique = 1 * (Math.Abs(this.x - xFinal) + Math.Abs(this.y - yFinal)) + (1 - 2 * 1) * Math.Min(Math.Abs(this.x - xFinal), Math.Abs(this.y - yFinal));
                //return heuristique;

                //Heuristique Euclidean distance
                heuristique = CalculeEuclideanDistance(x, y, xFinal, yFinal);
                heuristique *= (1 + (1 % 100));
                return heuristique;

            }
            else if (Form1.environnementLoaded == "environnement2.txt")
            {
                //Algorithme de Dijsktra
                //return 0;

                if ((x < 10 && xFinal < 10) || (x > 10 && xFinal > 10))
                {
                    heuristique = CalculeEuclideanDistance(x, y, xFinal, yFinal);
                    //heuristique = dx + dy;
                    heuristique *= (1 + (1 % 100));
                    return heuristique;
                }

                else if ((x < 10 && xFinal > 10) || (x > 10 && xFinal < 10))
                {
                    heuristique = CalculeEuclideanDistance(x, y, xMilieuEnvironnement2, yMilieuEnvironnement2) + CalculeEuclideanDistance(xMilieuEnvironnement2, yMilieuEnvironnement2, xFinal, yFinal);
                    //heuristique = dx + dy;
                   heuristique *= (1 + (1 % 100));
                    return heuristique;
                }
                heuristique = CalculeEuclideanDistance(x,y,xFinal,yFinal);
                heuristique *= (1 + (1 % 100));
                return heuristique;
            }
            else
            {
                bool estXYDansObstacleHaut = estDansObstacleHaut(x, y);
                bool estXfYfDansObstacleHaut = estDansObstacleHaut(xFinal, yFinal);
                bool estXYDansObstacleBas = estDansObstacleBas(x, y);
                bool estXfYfDansObstacleBas = estDansObstacleBas(xFinal, yFinal);

                double heuristiqueMan = 0;
                //CODE Manhattan
                if (estXYDansObstacleHaut)
                     heuristiqueMan +=  10*Manhattan2(2, 6);
                 else if (estXYDansObstacleBas)
                     heuristiqueMan +=  10*Manhattan2(17, 15);
                 else if (estXfYfDansObstacleHaut)
                {
                     Form1.matrice[17, 15] = -1;
                     heuristiqueMan +=  10*Manhattan2(2, 6);
                }
                 else if (estXfYfDansObstacleBas)
                 {
                    Form1.matrice[2, 6] = -1;
                     heuristiqueMan +=  10*Manhattan2(17, 15);
                 }

                 heuristiqueMan = heuristiqueMan + Manhattan(xFinal,yFinal);
                 heuristiqueMan*=(1+(1%100));
                 //return heuristique + Manhattan(xFinal, yFinal);

                //CODE EUCLIDEAN
                if (estXYDansObstacleHaut)
                    heuristique += CalculEuclideanDistance2(2, 6);
                else if (estXYDansObstacleBas)
                    heuristique += CalculEuclideanDistance2(17, 15);
                else if (estXfYfDansObstacleHaut)
                {
                    Form1.matrice[17, 15] = -1;
                    heuristique += CalculEuclideanDistance2(2, 6);
                }
                     
                else if (estXfYfDansObstacleBas)
                {
                    Form1.matrice[2, 6] = -1;
                    heuristique += CalculEuclideanDistance2(17, 15);
                }
                heuristique = heuristique + CalculeEuclideanDistance(x,y,xFinal,yFinal);
                heuristique *= (1 + (1 % 100));
                return Math.Min(heuristique, heuristiqueMan);
            }
        }

        public override string ToString()
        {
            return Convert.ToString(x)+","+ Convert.ToString(y);
        }
    }
}
