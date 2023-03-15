using Event.Models;

Compte compte = new Compte(100, 1000);

Console.WriteLine("Voulez vous etre alerté pour les changement de valeur ? y/n");

if (Console.ReadLine() == "y")
{
    compte.changeMontantDelegate += Notification.ChangementMontant;
}

Console.WriteLine("Voulez vous etre alerté pour le montant minimum de votre compte ? y/n");

if (Console.ReadLine() == "y")
{
    compte.SoldeBasDelegate += Notification.AlertMontantFaible;
}


while (true)
{
    Console.WriteLine("Que voulez vous faire ?");
    Console.WriteLine("1. Ajouter de l'argent.");
    Console.WriteLine("2. Enlever de l'argent.");

    int selected = 0;

    int.TryParse(Console.ReadLine(), out selected);

    switch (selected)
    {
        case 1: compte.AjouterValeur(entrermontant());
            break;
        case 2:
            compte.EnleverValeur(entrermontant());
            break;
    }
}

double entrermontant()
{
    Console.WriteLine("Entrez montant :");
    double montant;
    double.TryParse(Console.ReadLine(), out montant);
    return montant;
}
