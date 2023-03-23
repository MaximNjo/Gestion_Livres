using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Livres
{
    class Livre
    {
        private string cod;
        private string titre;
        private int an;
        private string ed;
        private string aut;

        public string Cod { get => cod; set => cod = value; }
        public string Titre { get => titre; set => titre = value; }
        public int An { get => an; set => an = value; }
        public string Ed { get => ed; set => ed = value; }
        public string Aut { get => aut; set => aut = value; }

        public Livre(string co, string ti, int an, string ed, string aut)
        {
            this.cod = co;
            this.titre = ti;
            this.an = an;
            this.ed = ed;
            this.aut = aut;
        }

        public override string ToString()
        {
            return ("Le code du livre : " + this.cod + "Titre du livre: " + this.titre  + "annee du livre: " + this.an + "Editeur du livre: " + this.ed + "Auteur du livre: " + this.aut);
        }

    }
}
