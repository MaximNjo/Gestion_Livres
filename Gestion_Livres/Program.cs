namespace Gestion_Livres
{


class Program
    {
        static void Main(string[] args)
        {
            
            Bibliotheque bi = new Bibliotheque("Gutenberg");
            bi.AjouterLivre(new Livre("L1", "Quatre vingt treize", 1870, "Dunod", "Victor Hugo"));
            bi.AjouterLivre(new Livre("L2", "Les misérables", 1873, "Folio", "Victor Hugo"));
            bi.AjouterLivre(new Livre("L3", "l'ame du mal", 2005, "poche", "maxime Chatam"));
            bi.AjouterLivre(new Livre("L4", "Desert", 1980, "Folio", "Le clezio"));
            bi.AjouterLivre(new Livre("L5", "Diego et Fida", 1975, "poche", "Le clezio"));
            bi.AjouterLivre(new Livre("L6", "L'etranger", 1950, "Folio", "Camus"));

            // Affichache de tout 

            Console.WriteLine(bi);
            Console.ReadKey();
            bi.AfficheAuteur("Victor Hugo");
            Console.ReadKey();
            bi.AfficheEditeur("poche");
            Console.ReadKey();
            bi.SupprimerLivre("Desert");
            Console.WriteLine(bi);
            Console.ReadKey();
            bi.SupprimerAuteur("Victor Hugo");
            Console.WriteLine(bi);
            Console.ReadKey();

          

        }


    }



}
