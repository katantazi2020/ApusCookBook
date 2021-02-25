using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApusCookBook
{
    public partial class FormIngredients : Form
    {
        private Recipe m_recipe;
       // private Recipe newrecipe;

        public FormIngredients(Recipe recipe)
        {
            //Recipe recp = new Recipe(maxNumOfIngredients);
            InitializeComponent();
           m_recipe = recipe;
             if (string.IsNullOrEmpty(recipe.NameOfRecipe))
                this.Text = "No Recipe Name";
            else
            this.Text =  recipe.NameOfRecipe + "Add Ingredients";
            InitializeGUI();
            
        }
        public String recipe
        {
            get
            {
                return recipe;
            }
            set
            {
                if ( string.IsNullOrEmpty(value))
                      recipe = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void InitializeGUI()
        {
            //Create Ingredientlist in the object recipe
            if (m_recipe.RecipeIngredients == null)
                m_recipe.RecipeIngredients = new string[m_recipe.MaxIngredients];
            lstIgredients.Items.Clear();
            toolTip1.SetToolTip(txtIgredient, "Example: 2 dl milk");
            lblMaxNum.Text = m_recipe.CurrentNumOfIngredients().ToString();

        }
        public void UpdateGUI()
        {

        }

        private void btnAddIngr_Click(object sender, EventArgs e)
        {
            lstIgredients.Items.Clear();
            
           if (string.IsNullOrEmpty(txtIgredient.Text))
            {
                string[] addingvalue = new string ;
                InitializeGUI();
                lstIgredients.Items.Add(txtIgredient.Text);
            }


            
               // txtIgredient.Text = "";
               
               
                
            
                
                
        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
