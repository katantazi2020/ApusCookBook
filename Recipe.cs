using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApusCookBook
{
    public class Recipe
    {
        //List for saving Ingredients
        private string[] recipeingredietsArray { get; set; }
        private string nameofrecipe;  //name of the recipe
        private FoodCategory category { get; set; }  // See the enum food category
        private string cookinginstructions { get; set; }     // Cooking instructions and other info 
       // private int MaxNumofIngredients;
       // private const int numOfIngredients = 20;
       
        
        //Max num of ingredients is important because the array is to be sized  for 
        // The number. To make this  class more  flexible we let this value come to this 
        // object as a parameter.
        public Recipe(int maxNumOfIngredients)
        {
            recipeingredietsArray = new string[maxNumOfIngredients];
            DefaultValues();
        }
        
        // Property onnectected to instance variable name
        //Read and write access
       public string NameOfRecipe
        {
           get
           {
               return nameofrecipe;
           }
          set
           {
              if (string.IsNullOrEmpty(value))
                    nameofrecipe = value;
            }
       }
        public string CookingIntructions
            {
           get
           {
               return cookinginstructions;
            }
            set
               {
                    if (string.IsNullOrEmpty(value))
                   cookinginstructions = value; 
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
        public  string[] RecipeIngredients
        {
           get
           {
               return recipeingredietsArray;

           }
           set
          {

              recipeingredietsArray = value;
          }
       }
      
        public int MaxIngredients
       {
           get { return recipeingredietsArray.Length;}

       
       }
        //This Method Does all the necessary initializations. It can be called from the constructor 
        // to initiate Instance variables
        public void DefaultValues()
        {     //The for-loop sets the array elements to null
            for (int index = 0; index < recipeingredietsArray.Length; index++)
                recipeingredietsArray[index] = string.Empty;
            nameofrecipe = string.Empty;
            category = FoodCategory.SeaFood;
            cookinginstructions = String.Empty;
        }
        //Method that runs through the and returns the first vacant position
        public int FindVacantPosition()
        {
            int freepos = -1; // For no position available in the array
                for (int index = 0; index < recipeingredietsArray.Length; index++)
            {
                if (string.IsNullOrEmpty (recipeingredietsArray[index]))
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
                this.recipeingredietsArray[vacpos] = value;
            }
            return ok;
        }

        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < recipeingredietsArray.Length);
            return ok;
        }
        //Number of Values saved in the array
        public int CurrentNumOfIngredients()
        {
            int count = 0;
            for (int index = 0; index < recipeingredietsArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(recipeingredietsArray[index]))
                    count++;
            }
            return count;
        }
        //  Method which returns formatted string with the values of name,numberof ingredients
        //and the  first 15 characters of cooking description
        public override string ToString()
        {
            int chars = Math.Min(cookinginstructions.Length, 15);
            string descriptionText = cookinginstructions.Substring(0, chars);

                if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description";
                string textout = string.Format("{0, -20} {1, 4}    {2, -12} {3, -15}", nameofrecipe, CurrentNumOfIngredients(),
                        category.ToString(), descriptionText);


            return textout;
        }
        public bool ChangeIngredientAt(int index, string value)
        {
            bool ok = true;
            // Check validity of the index
                if (CheckIndex(index))
            {
                recipeingredietsArray[index] = value;
                return ok;
            }
            return false;
        }
        public bool DeleteIngredientsAt(int index)
        {
            bool ok = true;
            if (CheckIndex(index))
                recipeingredietsArray[index] = string.Empty;
            return ok; 
        }

    }
}
