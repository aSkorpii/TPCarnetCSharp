using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCarnetCSharp
{
    abstract class Personne
    {
        #region Fields
        private string _FirstName;
        private string _LastName;
        private DateTime _Birthday; 
        #endregion

        #region Properties
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }


        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        #endregion

        #region Constructors
        public Personne()
        {
            DateTime date;
            Console.WriteLine("Saisissez le nom de la personne:");
            LastName = Console.ReadLine();
            Console.WriteLine("Saisissez le prenom de la personne:");
            FirstName = Console.ReadLine();
            do{
            Console.WriteLine("Saisissez la date de naissance de la personne:");
            }while (!DateTime.TryParse(Console.ReadLine(), out date));
            Birthday = date;
        }

        #endregion

        #region Methods

        public virtual bool Contenir(string search)
        {
            DateTime date;
            if (DateTime.TryParse(search, out date))
            {
                return this.FirstName.Contains(search) || this.LastName.Contains(search) || this.Birthday == date;
            }
            else
            {
                return this.FirstName.Contains(search) || this.LastName.Contains(search);
            }
        }

        public override string ToString()
        {
            return "NOM " + this.LastName + " PRENOM " + this.FirstName + " NE LE " + this.Birthday.Date;
        }

        public virtual void ModifierPersonne()
        {
            Console.WriteLine("Que voulez vous modifier ?");
            Console.WriteLine("1-Le nom");
            Console.WriteLine("2-Le prénom");
            Console.WriteLine("3-La date de naissance");
        }

        public virtual void ModifierNom()
        {
            Console.WriteLine("Saisissez le nouveau nom");
            LastName = Console.ReadLine();
        }

        public virtual void ModifierPrenom()
        {
            Console.WriteLine("Saisissez le nouveau prenom");
            FirstName = Console.ReadLine();
        }

        public virtual void ModifierDateDeNaissance()
        {
            DateTime date;
            do
            {
                Console.WriteLine("Saisissez la date de naissance de la personne:");
            } while (!DateTime.TryParse(Console.ReadLine(), out date));
            Birthday = date;

        }

        public virtual void ChoisirModifications(int choix)
        {
            switch (choix)
            {
                case 1:
                    this.ModifierNom();
                    break;
                case 2:
                    this.ModifierPrenom();
                    break;
                case 3:
                    this.ModifierDateDeNaissance();
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}
