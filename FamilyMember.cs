using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCarnetCSharp
{
    class FamilyMember:Personne
    {
        #region Fields
        private string _FamilyLink;
        
        #endregion

        #region Properties

        public string FamilyLink
        {
            get { return _FamilyLink; }
            set { _FamilyLink = value; }
        } 
        #endregion

        #region Constructors
        public FamilyMember()
            : base()
        {
            Console.WriteLine("Saisissez le lien avec la personne:");
            FamilyLink = Console.ReadLine();
        } 
        #endregion

        public override bool Contenir(string search)
        {
            return base.Contenir(search) || this.FamilyLink.Contains(search);
        }

        public override string ToString()
        {
            return base.ToString() + " LIEN " + this.FamilyLink;
        }

        public override void ModifierPersonne()
        {
            base.ModifierPersonne();
            Console.WriteLine("4-Le lien de parenté");
        }

        public void ModifierFamilyLink()
        {
            Console.WriteLine("Saisissez le nouveau lien de parenté");
            FamilyLink = Console.ReadLine();
        }


        public override void ChoisirModifications(int choix)
        {
            base.ChoisirModifications(choix);
            switch (choix)
            {
                case 4:
                    this.ModifierFamilyLink();
                    break;
                default:
                    break;
            }
        }
    }
}
