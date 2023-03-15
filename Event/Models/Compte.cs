using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Models
{

    public delegate void NotificationDelegate(double a, double b);

    public class Compte
    {

        public event NotificationDelegate changeMontantDelegate = null;
        public event NotificationDelegate SoldeBasDelegate = null;

        private double _solde = 0;

        private double Solde { 
            get 
            { 
                return _solde;
            } 
            set 
            {
                if(changeMontantDelegate!= null)
                {
                    changeMontantDelegate(_solde, value);
                }
                

                if (value < SeuilAlert && SoldeBasDelegate != null)
                {
                    SoldeBasDelegate(SeuilAlert, value);
                }

                _solde = value;
            } 
        }

        public double SeuilAlert { get; set; }

        public Compte(double seuilMini, double montant)
        {
            SeuilAlert = seuilMini;
            Solde = montant;
        }

        public void AjouterValeur(double valeur)
        {
            Solde += valeur;
        }

        public void EnleverValeur(double valeur)
        {
            Solde -= valeur;
        }

    }
}
