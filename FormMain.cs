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
    public partial class FormMain : Form
    {
       // private Recipe currRecipe;
        private int maxNumOfIngridients;
       // private RecipeManager recipemngr;
        private const int numOfIngredients = 20;//Max number of ingredients for each recipe
        private const int maxNumOfElements = 50; //Max num of recipes
        
        //Object of the Recipe class for storing data  the recipe being processed
        Recipe currRecipe = new Recipe(numOfIngredients);
        
        // The registry responsible for handling all recipes
        RecipeManager recipemngr = new RecipeManager(maxNumOfElements);

        

        public FormMain()
        {
            InitializeComponent();
            InitializeGui();
            IntializeOutPut();


            currRecipe.DefaultValues();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            FormIngredients dlg = new FormIngredients(currRecipe);
              DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                if (currRecipe.CurrentNumOfIngredients() <= 0)
                {
                    MessageBox.Show("No Ingriedients specified!");
                    recipemngr.Add(currRecipe);
                    UpdateGUI();
                }
            }
        }
        public void InitializeGui()
        {
            //clear input controls
            
            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            cmbCategory.Items.Add(FoodCategory.Fish);
            cmbCategory.Items.Add(FoodCategory.Meat);
            cmbCategory.Items.Add(FoodCategory.SeaFood);
            cmbCategory.Items.Add(FoodCategory.Vegeterian);

            groupBox1.Enabled = true; 
        }
        public void UpdateGUI()
        {
            listBox1.Items.Clear();
           
            
            txtName.Text = recipemngr.GetCurrentNumOfItems().ToString();
            listBox1.Text = listBox1.Items.Count.ToString();
            txtDescription.Text = recipemngr.GetIngredients(maxNumOfElements).ToString();

            string[] recipelststr = recipemngr.RecipeListToString();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(recipelststr);

            

           
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            currRecipe.Category = (FoodCategory)cmbCategory.SelectedIndex; // Sets index of selected item
            currRecipe.NameOfRecipe = txtName.Text.Trim();
            currRecipe.CookingIntructions = txtDescription.Text.Trim();
            recipemngr.Add(currRecipe);
            UpdateGUI();
            currRecipe.DefaultValues();//Reset to default values after adding the recipe
        }
        public bool CheckInput()
        {
            if (string.IsNullOrEmpty(currRecipe.ToString()))
            {
                MessageBox.Show("Please enter the right recipe name", "Error");
                return false;
            } 
            else
            {
                return true;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void IntializeOutPut()
        {
            if (currRecipe.RecipeIngredients == null)
            // if (recipeMngr.RecipeListToString != null)
                currRecipe.RecipeIngredients = new string[numOfIngredients];
          
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
