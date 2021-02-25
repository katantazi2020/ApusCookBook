using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApusCookBook
{
    public class RecipeManager
    {
        //Declair an array for storing a number of recipes.
        private Recipe[] Recipelist;
        //private const int maxNumOfElements = 20;


        public RecipeManager(int maxNumofElements)
        {
            //Array object with the size equal to 
            //maxNumOfElements. Array elements will still be null
            Recipelist = new Recipe[maxNumofElements];

            for (int index = 0; index < maxNumofElements; index++)
                Recipelist[index] = null;

        }


        public bool Add(Recipe newRecipe)
        {
            //Find the empty position to add new element
            int emptypos = FindVacantPsition();
            bool ok = emptypos >= 0;

            if (ok)
            {
                this.Recipelist[emptypos] = newRecipe;


            }
            return ok;

        }
        // OverLoaded add Method
        public bool add(string name, FoodCategory category, string[] ingredientsArray)
        {
            bool ok = false;//initialisation
            int index = FindVacantPsition();

            if (index >= 0)
            {
                Recipe recipe = new Recipe(ingredientsArray.Length);
                recipe.NameOfRecipe = name;
                recipe.RecipeIngredients = ingredientsArray;
                recipe.Category = category;

                Recipelist[index] = recipe;
                ok = true;

            }
            return ok;
        }
        public bool ChangeElement(int index, Recipe recipe)
        {
            bool ok = true;
            // check if index is a valid element
            if (CheckIndex(index))
            {
                Recipelist[index] = recipe;

                return ok;
            }
            return false;
        }
        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < Recipelist.Length);
            return ok;
        }
        public bool DeleteElement(int index)
        {
            bool ok = true;
            if (CheckIndex(index))

                Recipelist[index] = null;




            return ok;


        }

        private int FindVacantPsition()
        {
            for (int index = 0; index < Recipelist.Length; index++)
            {
                if (Recipelist[index] == null)
                    return index;
            }
            return -1;
        }
        public int GetCurrentNumOfItems()
        {
            int count = 0;
            for (int index = 0; index < Recipelist.Length; index++)
            {
                if (Recipelist[index] != null)
                    count++;
            }
            return count;
        }
        public string[] GetIngredients(int index)
        {
            int numofingredients = GetCurrentNumOfItems();
            if (numofingredients <= 0)
                return null;
            string[] stringreds = new string[numofingredients];
            int y = 0;
            for (index = 0; index < Recipelist.Length; index++)
            {
                if (!Recipelist[index].Equals(string.Empty))
                {
                    stringreds[y] = string.Format("{0 -15}", Recipelist[index]);
                    y++;
                }
            }
            return stringreds;



        }
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return Recipelist[index];
            else
                return null;

        }
        public string[] RecipeListToString()
        {
            string[] listitems = new string[Recipelist.Length];
            int i = 0;
            foreach(Recipe items in Recipelist)
            {
                listitems[i++] = items.ToString();
            }
            return listitems;
        }
         
        
        

    }
} 