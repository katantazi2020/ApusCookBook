using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApusCookBook
{
   public  class Recipe
    {
        //List for saving Ingredients
        private string[] ingredientArray;
        private string name;                //name of the recipe
        private FoodCategory category;     // See the enum food category
        private string description;        // Cooking instructions and other info 
        private const int numOfIngredients = 20;

        
        //Max num of ingredients is important because the array is to be sized  for 
        // The number. To make this  class more  flexible we let this value come to this 
        // object as a parameter.
        public Recipe(int maxNumOfIngredients)
        {
            ingredientArray = new string[maxNumOfIngredients];
            DefaultValues();
        }
        
        // Property onnectected to instance variable name
        //Read and write access
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value; 
            }
        }
        public FoodCategory Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public  string Ingredients
        {
            get
            {
                return ingredientArray;

            }
            set
            {
               
                ingredientArray = 
            }
        }
        public int maxNumOfIngredients
        {
            get { return ingredientArray.Length; }
        }
        //This Method Does all the necessary initializations. It can be called from the constructor 
        // to initiate Instance variables
        public void DefaultValues()
        {     //The for-loop sets the array elements to null
            for (int index = 0; index < ingredientArray.Length; index++)
                ingredientArray[index] = string.Empty;
            name = string.Empty;
            category = FoodCategory.SeaFood;
            description = String.Empty;
        }
        //Method that runs through the and returns the first vacant position
        public int FindVacantPosition()
        {
            int freepos = -1; // For no position available in the array
                for (int index = 0; index < ingredientArray.Length; index++)
            {
                if (string.IsNullOrEmpty (ingredientArray[index]))
                {
                    freepos = index;
                    break;
                   
                }
              
            }
            return freepos;
        }
        public bool AddIngredient(string value)
        {
           
            // Search for a a vacant position for saving new element
                int vacpos = FindVacantPosition();
            bool ok = vacpos >= 0;
                
            if (ok)
            {
                this.ingredientArray[vacpos] = value;
            }
            return ok;
        }
        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < ingredientArray.Length);
            return ok;
        }
        public int CurrentNumOfIngredients()
        {
            int count = 0;
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[index]))
                    count++;
            }
            return count;
        }
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

                if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description";
                string textout = string.Format("{0, -20} {1, 4}    {2, -12} {3, -15}", name, CurrentNumOfIngredients(),
                        category.ToString(), descriptionText);


            return textout;
        }
        public bool ChangeIngredientAt(int index, string value)
        {
            bool ok = true;
            // Check validity of the index
                if (CheckIndex(index))
            {
                ingredientArray[index] = value;
                return true;
            }
            return false;
        }
        public bool DeleteIngredientsAt(int index)
        {
            bool ok = true;
            if (CheckIndex(index))
                ingredientArray[index] = string.Empty;
            return ok; 
        }

    }
}
