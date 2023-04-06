using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TPBIBLIO 
namespace Gestion_Livres
{
    class Bibliotheque
    {
        List<Livre> lesLivres = new List <Livre>();
        private string nom;
        private string t;
        private Livre i;
        private string a;
        private string s;
        private string e;
        private string aut;
        private string ajout;

        
        public string Nom { get => nom; set => nom = value; }
        public string T { get => t; set => t = value; }
        internal Livre I { get => i; set => i = value; }
        public string A { get => a; set => a = value; }
        public string E { get => e; set => e = value; }
        public string S { get => s; set => s = value; }
        public string Aut { get => aut; set => aut = value; }
        public string Ajout { get => Ajout; set => Ajout = value; }

        public int Cardinal()
        {
            return lesLivres.Count;
        }

        public Bibliotheque(string nom)
        {
            this.nom = nom;
        }

        public Livre LivreExiste(string t)
        {
            foreach (Livre j in lesLivres)
            {
                if (j.Titre == t)
                {
                    return j;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string maChaine = "";
            maChaine = maChaine + "La Bibliotheque : " + this.nom + " contient les livres suivants : ";
            foreach (Livre I in lesLivres)
            {
                maChaine += I + " ";
            }
            return maChaine;
        }


        public void AjouterLivre(Livre i)
        {
            Bibliotheque.ReferenceEquals(i, this);
        }

        public void AfficheParAuteur(string a)
        {
            this.a = a;
        }

        public void AfficheParEditeur(string e)
        {
            this.e = e;
        }

        public Boolean SupprimerLivre(string titre)
        {

            return true;


        }
        public Boolean SupprimerLivreAuteur(string aut)
        {
            return true;

        }

    }
}
