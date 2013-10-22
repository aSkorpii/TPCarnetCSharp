using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCarnetCSharp
{
    class Ami:Personne
    {
        #region Constructors

        public Ami()
            : base()
        {
        } 
        #endregion

        public override bool Contenir(string search)
        {
            return base.Contenir(search);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void ModifierPersonne()
        {
            base.ModifierPersonne();
        }

        public override void ChoisirModifications(int choix)
        {
            base.ChoisirModifications(choix);
        }
    }
}
