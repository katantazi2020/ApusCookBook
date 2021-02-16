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
           
            InitializeComponent();
           m_recipe = recipe;
             if (string.IsNullOrEmpty(recipe.Name))
                this.Text = "No Recipe Name";
            else
            this.Text =  recipe.Name + "Add Ingredients";
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
            if (m_recipe.Ingredients == null)
                m_recipe.Ingredients = new string[m_recipe.maxNumOfIngredients];
            lstIgredients.Items.Clear();
            toolTip1.SetToolTip(txtIgredient, "Example: 2 dl milk");
            lblMaxNum.Text = m_recipe.CurrentNumOfIngredients().ToString();

        }
        public void UpdateGUI()
        {

        }

        private void btnAddIngr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(recipe))
                string[] addingvalue = new string
        }

        private void FormIngredients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
