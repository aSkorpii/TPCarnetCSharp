using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCarnetCSharp
{
    class Carnet : List<Personne>
    {
        #region Methods

        /// <summary>
        /// Methode qui permet d'ajouter une personne
        /// </summary>
        public void AjouterUnePersonne()
        {
            int cas = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Quel type de personne voulez-vous ajouter ?");
                Console.WriteLine("1-Ami");
                Console.WriteLine("2-Collègue");
                Console.WriteLine("3-Membre de la Famille");
            } while (!int.TryParse(Console.ReadLine(), out cas));
            switch (cas)
            {
                case 1:
                    this.Add(new Ami());
                    break;
                case 2:
                    this.Add(new Collegue());
                    break;
                case 3:
                    this.Add(new FamilyMember());
                    break;
                default:
                    Console.WriteLine("Erreur d'instruction");
                    break;
            }
        }

        /// <summary>
        /// Methode qui permet de rechercher une personne
        /// </summary>
        public void RechercherUnePersonne()
        {
            string recherche = "";
            Console.WriteLine("Saisissez votre recherche :");
            recherche = Console.ReadLine();


            foreach (var item in this.FindAll(p => p.Contenir(recherche)))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Methode qui affiche le menu
        /// </summary>
        public void Menu()
        {
            int saisie = 0;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Que voulez vous faire :");
                    Console.WriteLine("1 - Ajouter une personne");
                    Console.WriteLine("2 - Rechercher une personne");
                    Console.WriteLine("3 - Parcourir le carnet");
                } while (!int.TryParse(Console.ReadLine(), out saisie));
                switch (saisie)
                {
                    case 1:
                        this.AjouterUnePersonne();
                        break;
                    case 2:
                        this.RechercherUnePersonne();
                        break;
                    case 3:
                        if (this.Count != 0)
                        {
                            this.ParcourirCarnet();
                        }
                        else
                        {
                            Console.WriteLine("Aucune personne dans le carnet");
                            Console.ReadLine();
                        }

                        break;
                    default:
                        Console.WriteLine("Erreur de saisie");
                        Console.ReadLine();
                        break;
                }
            } while (saisie != 0);
        }

        /// <summary>
        /// Methode qui permet de parcourir la liste de personnes
        /// </summary>
        public void ParcourirCarnet()
        {
            int i = 0;
            int cas = 0;
            Personne p;
            do
            {
                Console.Clear();
                Console.WriteLine(this[i]);
                p = this[i];
                Console.WriteLine();
                do
                {
                    Console.WriteLine("1-Suivant");
                    Console.WriteLine("2-Precedent");
                    Console.WriteLine("3-Modifier");
                    Console.WriteLine("4-Supprimer");
                    Console.WriteLine("0-Retour");
                } while (!int.TryParse(Console.ReadLine(), out cas));
                switch (cas)
                {
                    case 1:
                        if (i >= this.Count - 1)
                        {
                            i = 0;
                        }
                        else
                        {
                            i++;
                        }
                        break;
                    case 2:
                        if (i <= 0)
                        {
                            i = this.Count - 1;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 3:
                        int choix = 0;
                        do
                        {
                            this[i].ModifierPersonne();
                        } while (!int.TryParse(Console.ReadLine(), out choix));
                        this[i].ChoisirModifications(choix);
                        break;
                    case 4:
                        this.Remove(p);
                        break;
                    default:
                        Console.WriteLine("Erreur d'instructions");
                        break;
                }
            } while (cas != 0 && this.Count != 0);
        }
        #endregion
    }
}