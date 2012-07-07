using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monnayeur
{
    public class Monnayeur
    {
        public double montantTotal;
        public Monnayeur()
        {
            montantTotal = 0;
        }

        public void add(double montantPiece)
        {
            if (IsAcceptPiece(montantPiece))
                montantTotal += montantPiece;
            else throw new Exception("Pièce non acceptée");
        }


        /// <summary>
        /// retourne le nombre de minute pour le montant donné
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public static int minute(int montant)
        {
            Dictionary<int, int> listDiv = new Dictionary<int, int>() { { 15, 600 }, { 11, 300 }, { 7, 120 }, { 3, 60 }, { 1, 30 } };
            foreach (var item in listDiv)
            {
                if (montant / item.Key < 1)
                {
                    continue;
                }
                else
                {
                    int reste = montant % item.Key;
                    return item.Value + minute(reste);
                }
            }
            return 0;
        }

        public DateTime date(DateTime d)
        {
            int t = (int)Math.Floor(montantTotal);

            return d.AddMinutes(minute(t));
        }

        public bool IsAcceptPiece(double p)
        {
            return p.Equals(0.1) || p.Equals(0.2) || p.Equals(0.5) || p.Equals(1) || p.Equals(2);
        }
    }
}