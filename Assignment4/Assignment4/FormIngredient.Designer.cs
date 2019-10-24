using System;

namespace Assignment4
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ingredientTxtBox = new System.Windows.Forms.TextBox();
            this.ingrGroupBox = new System.Windows.Forms.GroupBox();
            this.addIngrBtn = new System.Windows.Forms.Button();
            this.ingrListBox = new System.Windows.Forms.ListBox();
            this.numOfIngrLbl = new System.Windows.Forms.Label();
            this.numOfingredientsTextTop = new System.Windows.Forms.Label();
            this.OKbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ingrGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingredientTxtBox
            // 
            this.ingredientTxtBox.Location = new System.Drawing.Point(21, 51);
            this.ingredientTxtBox.Name = "ingredientTxtBox";
            this.ingredientTxtBox.Size = new System.Drawing.Size(349, 20);
            this.ingredientTxtBox.TabIndex = 0;
            // 
            // ingrGroupBox
            // 
            this.ingrGroupBox.Controls.Add(this.addIngrBtn);
            this.ingrGroupBox.Controls.Add(this.ingredientTxtBox);
            this.ingrGroupBox.Controls.Add(this.ingrListBox);
            this.ingrGroupBox.Location = new System.Drawing.Point(23, 61);
            this.ingrGroupBox.Name = "ingrGroupBox";
            this.ingrGroupBox.Size = new System.Drawing.Size(479, 301);
            this.ingrGroupBox.TabIndex = 3;
            this.ingrGroupBox.TabStop = false;
            this.ingrGroupBox.Text = "Ingredient";
            // 
            // addIngrBtn
            // 
            this.addIngrBtn.Location = new System.Drawing.Point(387, 47);
            this.addIngrBtn.Name = "addIngrBtn";
            this.addIngrBtn.Size = new System.Drawing.Size(57, 27);
            this.addIngrBtn.TabIndex = 1;
            this.addIngrBtn.Text = "Add";
            this.addIngrBtn.UseVisualStyleBackColor = true;
            this.addIngrBtn.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // ingrListBox
            // 
            this.ingrListBox.FormattingEnabled = true;
            this.ingrListBox.Location = new System.Drawing.Point(21, 83);
            this.ingrListBox.Name = "ingrListBox";
            this.ingrListBox.Size = new System.Drawing.Size(349, 199);
            this.ingrListBox.TabIndex = 0;
            // 
            // numOfIngrLbl
            // 
            this.numOfIngrLbl.AutoSize = true;
            this.numOfIngrLbl.Location = new System.Drawing.Point(454, 33);
            this.numOfIngrLbl.Name = "numOfIngrLbl";
            this.numOfIngrLbl.Size = new System.Drawing.Size(13, 13);
            this.numOfIngrLbl.TabIndex = 8;
            this.numOfIngrLbl.Text = "0";
            // 
            // numOfingredientsTextTop
            // 
            this.numOfingredientsTextTop.AutoSize = true;
            this.numOfingredientsTextTop.Location = new System.Drawing.Point(20, 33);
            this.numOfingredientsTextTop.Name = "numOfingredientsTextTop";
            this.numOfingredientsTextTop.Size = new System.Drawing.Size(110, 13);
            this.numOfingredientsTextTop.TabIndex = 7;
            this.numOfingredientsTextTop.Text = "Number of ingredients";
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(78, 382);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(83, 31);
            this.OKbtn.TabIndex = 5;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(269, 382);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 31);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.btnCancelAddIngr_Click);
            // 
            // FormIngredients
            // 
            this.ClientSize = new System.Drawing.Size(557, 446);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.numOfIngrLbl);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.ingrGroupBox);
            this.Controls.Add(this.numOfingredientsTextTop);
            this.Name = "FormIngredients";
            this.ingrGroupBox.ResumeLayout(false);
            this.ingrGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfingredientsTextTop;
        private System.Windows.Forms.Label numOfIngrLbl;
        private System.Windows.Forms.TextBox ingredientTxtBox;
        private System.Windows.Forms.Button addIngrBtn;
        private System.Windows.Forms.GroupBox ingrGroupBox;
        private System.Windows.Forms.ListBox ingrListBox;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}