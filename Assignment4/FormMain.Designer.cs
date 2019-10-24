namespace Assignment4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
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
            this.recipeBox = new System.Windows.Forms.GroupBox();
            this.recipeTxtBox = new System.Windows.Forms.TextBox();
            this.addIngredientsBtn = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.recipeBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.noOfingreLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.recipeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeBox
            // 
            this.recipeBox.Controls.Add(this.recipeTxtBox);
            this.recipeBox.Controls.Add(this.addIngredientsBtn);
            this.recipeBox.Controls.Add(this.categoryBox);
            this.recipeBox.Controls.Add(this.CategoryLabel);
            this.recipeBox.Controls.Add(this.nameTxtBox);
            this.recipeBox.Controls.Add(this.recipeNameLabel);
            this.recipeBox.Location = new System.Drawing.Point(12, 12);
            this.recipeBox.Name = "recipeBox";
            this.recipeBox.Size = new System.Drawing.Size(394, 320);
            this.recipeBox.TabIndex = 0;
            this.recipeBox.TabStop = false;
            this.recipeBox.Text = "Add new recipe";
            // 
            // recipeTxtBox
            // 
            this.recipeTxtBox.Location = new System.Drawing.Point(16, 102);
            this.recipeTxtBox.Multiline = true;
            this.recipeTxtBox.Name = "recipeTxtBox";
            this.recipeTxtBox.Size = new System.Drawing.Size(352, 203);
            this.recipeTxtBox.TabIndex = 5;
            // 
            // addIngredientsBtn
            // 
            this.addIngredientsBtn.Location = new System.Drawing.Point(272, 61);
            this.addIngredientsBtn.Name = "addIngredientsBtn";
            this.addIngredientsBtn.Size = new System.Drawing.Size(96, 23);
            this.addIngredientsBtn.TabIndex = 4;
            this.addIngredientsBtn.Text = "Add Ingredients";
            this.addIngredientsBtn.UseVisualStyleBackColor = true;
            this.addIngredientsBtn.Click += new System.EventHandler(this.addIngredientsBtn_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(123, 62);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(140, 21);
            this.categoryBox.TabIndex = 3;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(7, 71);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(123, 31);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(245, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Location = new System.Drawing.Point(7, 34);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(79, 13);
            this.recipeNameLabel.TabIndex = 0;
            this.recipeNameLabel.Text = "Name of recipe";
            // 
            // recipeBtn
            // 
            this.recipeBtn.Location = new System.Drawing.Point(28, 347);
            this.recipeBtn.Name = "recipeBtn";
            this.recipeBtn.Size = new System.Drawing.Size(352, 23);
            this.recipeBtn.TabIndex = 1;
            this.recipeBtn.Text = "Add recipe";
            this.recipeBtn.UseVisualStyleBackColor = true;
            this.recipeBtn.Click += new System.EventHandler(this.recipeBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(412, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(412, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 303);
            this.listBox1.TabIndex = 3;
            // 
            // noOfingreLabel
            // 
            this.noOfingreLabel.AutoSize = true;
            this.noOfingreLabel.Location = new System.Drawing.Point(508, 61);
            this.noOfingreLabel.Name = "noOfingreLabel";
            this.noOfingreLabel.Size = new System.Drawing.Size(87, 13);
            this.noOfingreLabel.TabIndex = 4;
            this.noOfingreLabel.Text = "No.of ingredients";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(714, 61);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Location = new System.Drawing.Point(637, 61);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(49, 13);
            this.catLabel.TabIndex = 6;
            this.catLabel.Text = "Category";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.noOfingreLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.recipeBtn);
            this.Controls.Add(this.recipeBox);
            this.Name = "FormMain";
            this.Text = " ";
            this.recipeBox.ResumeLayout(false);
            this.recipeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox recipeBox;
        private System.Windows.Forms.Button recipeBtn;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button addIngredientsBtn;
        private System.Windows.Forms.TextBox recipeTxtBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label noOfingreLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label catLabel;
    }
}

