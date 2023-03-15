using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Models
{
    internal static class Notification
    {

        public static void ChangementMontant(double montantInit, double nouveauMontant)
        {
            Console.WriteLine($"Le montant du compte à changé de {montantInit} à {nouveauMontant}. Difference : {nouveauMontant - montantInit}");
        }

        public static void AlertMontantFaible(double seuilMini, double montantActuel)
        {
            Console.WriteLine($"ALERTE : Montant inferieur à {seuilMini}. Montant actuel : {montantActuel}");
        }

    }
}
