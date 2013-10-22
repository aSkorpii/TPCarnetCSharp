using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCarnetCSharp
{
    class Collegue:Personne
    {
        #region Fields
        private string _Entreprise;

        private string _Poste; 
        #endregion

        #region Properties
        public string Poste
        {
            get { return _Poste; }
            set { _Poste = value; }
        }


        public string Entreprise
        {
            get { return _Entreprise; }
            set { _Entreprise = value; }
        } 
        #endregion

        #region Constructors

        public Collegue()
            :base()
        {
            Console.WriteLine("Saisissez le nom de l'entreprise:");
            Entreprise = Console.ReadLine();
            Console.WriteLine("Saisissez le poste dans l'entreprise:");
            Poste = Console.ReadLine();
        }

        #endregion

        #region Methods

        public override bool Contenir(string search)
        {
            return base.Contenir(search) || this.Entreprise.Contains(search) || this.Poste.Contains(search);
        }

        public override string ToString()
        {
            return base.ToString() + " ENTREPRISE " + this.Entreprise + " POSTE " + this.Poste;
        }

        public override void ModifierPersonne()
        {
            base.ModifierPersonne();
            Console.WriteLine("4-L'entreprise");
            Console.WriteLine("5-Le poste dans l'entreprise");
        }

        public void ModifierEntreprise()
        {
            Console.WriteLine("Saisissez la nouvelle entreprise");
            Entreprise = Console.ReadLine();
        }

        public void ModifierPoste()
        {
            Console.WriteLine("Saisissez le nouveau poste dans l'entreprise");
            Poste = Console.ReadLine();
        }

        public override void ChoisirModifications(int choix)
        {
            base.ChoisirModifications(choix);
            switch (choix)
            {
                case 4:
                    this.ModifierEntreprise();
                    break;
                case 5:
                    this.ModifierPoste();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
