
namespace ApusCookBook
{
    partial class FormIngredients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaxNum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lstIgredients = new System.Windows.Forms.ListBox();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.txtIgredient = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaxNum
            // 
            this.lblMaxNum.AutoSize = true;
            this.lblMaxNum.Location = new System.Drawing.Point(32, 29);
            this.lblMaxNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxNum.Name = "lblMaxNum";
            this.lblMaxNum.Size = new System.Drawing.Size(180, 25);
            this.lblMaxNum.TabIndex = 0;
            this.lblMaxNum.Text = "Num of Igredients";
            this.lblMaxNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.lstIgredients);
            this.groupBox1.Controls.Add(this.btnAddIngr);
            this.groupBox1.Controls.Add(this.txtIgredient);
            this.groupBox1.Location = new System.Drawing.Point(51, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(947, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredients";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(788, 205);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(788, 156);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstIgredients
            // 
            this.lstIgredients.FormattingEnabled = true;
            this.lstIgredients.ItemHeight = 25;
            this.lstIgredients.Location = new System.Drawing.Point(29, 100);
            this.lstIgredients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstIgredients.Name = "lstIgredients";
            this.lstIgredients.Size = new System.Drawing.Size(731, 254);
            this.lstIgredients.TabIndex = 2;
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.Location = new System.Drawing.Point(788, 54);
            this.btnAddIngr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(100, 38);
            this.btnAddIngr.TabIndex = 1;
            this.btnAddIngr.Text = "Add";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // txtIgredient
            // 
            this.txtIgredient.Location = new System.Drawing.Point(29, 54);
            this.txtIgredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIgredient.Name = "txtIgredient";
            this.txtIgredient.Size = new System.Drawing.Size(731, 31);
            this.txtIgredient.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(228, 495);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(559, 495);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMaxNum);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.Load += new System.EventHandler(this.FormIngredients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lstIgredients;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.TextBox txtIgredient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}