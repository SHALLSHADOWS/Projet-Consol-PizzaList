using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPoo
{
   public class Pizza
    {
        private string nom;
        private int prix;
        private string[] ingredients;
       
        public Pizza(string nom, int prix, string[] ingredients)
        {
            this.nom = nom;
            this.prix = prix;

            this.ingredients = ingredients;


        }

        public string Afficher()
        {
            string ingr = (ingredients != null) ? string.Join(", ", ingredients) : string.Empty;
            return $"Pizza: {this.nom} -- Prix: {this.prix} euro -- Ingrédients: {ingr}";

        }

        public int GetPrix()
        {
            return this.prix;
        }

        public string GetNom()
        {
            return this.nom;
        }

        }

    }

