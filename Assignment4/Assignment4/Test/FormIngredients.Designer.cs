namespace WindowsFormsApp1
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
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.gboIngredientsList = new System.Windows.Forms.GroupBox();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.lblNumOfIngredients = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblNumOfIngredientsText = new System.Windows.Forms.Label();
            this.OKbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.toolTipIngredient = new System.Windows.Forms.ToolTip(this.components);
            this.gboIngredientsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(0, 19);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(349, 20);
            this.txtIngredient.TabIndex = 0;
          //  this.txtIngredient.TextChanged += new System.EventHandler(this.txtIngredient_TextChanged);
            // 
            // gboIngredientsList
            // 
            this.gboIngredientsList.Controls.Add(this.btnAddIngr);
            this.gboIngredientsList.Controls.Add(this.txtIngredient);
            this.gboIngredientsList.Controls.Add(this.lstIngredients);
            this.gboIngredientsList.Location = new System.Drawing.Point(111, 83);
            this.gboIngredientsList.Name = "gboIngredientsList";
            this.gboIngredientsList.Size = new System.Drawing.Size(773, 283);
            this.gboIngredientsList.TabIndex = 3;
            this.gboIngredientsList.TabStop = false;
            this.gboIngredientsList.Text = "Ingredients list";
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.Location = new System.Drawing.Point(368, 12);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(133, 33);
            this.btnAddIngr.TabIndex = 1;
            this.btnAddIngr.Text = "Add ingredient";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // lblNumOfIngredients
            // 
            this.lblNumOfIngredients.AutoSize = true;
            this.lblNumOfIngredients.Location = new System.Drawing.Point(236, 33);
            this.lblNumOfIngredients.Name = "lblNumOfIngredients";
            this.lblNumOfIngredients.Size = new System.Drawing.Size(13, 13);
            this.lblNumOfIngredients.TabIndex = 8;
            this.lblNumOfIngredients.Text = "0";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(0, 66);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(349, 186);
            this.lstIngredients.TabIndex = 0;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // lblNumOfIngredientsText
            // 
            this.lblNumOfIngredientsText.AutoSize = true;
            this.lblNumOfIngredientsText.Location = new System.Drawing.Point(108, 33);
            this.lblNumOfIngredientsText.Name = "lblNumOfIngredientsText";
            this.lblNumOfIngredientsText.Size = new System.Drawing.Size(110, 13);
            this.lblNumOfIngredientsText.TabIndex = 7;
            this.lblNumOfIngredientsText.Text = "Number of ingredients";
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(122, 382);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(157, 43);
            this.OKbtn.TabIndex = 5;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.btnEndAddIngr_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(290, 382);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(157, 43);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.btnCancelAddIngr_Click);
            // 
            // FormIngredients
            // 
            this.ClientSize = new System.Drawing.Size(1164, 620);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.lblNumOfIngredients);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.gboIngredientsList);
            this.Controls.Add(this.lblNumOfIngredientsText);
            this.Name = "FormIngredients";
            this.gboIngredientsList.ResumeLayout(false);
            this.gboIngredientsList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfIngredientsText;
        private System.Windows.Forms.Label lblNumOfIngredients;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.GroupBox gboIngredientsList;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ToolTip toolTipIngredient;
    }
}