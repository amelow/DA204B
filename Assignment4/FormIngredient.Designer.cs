namespace Assignment4
{
    partial class FormIngredient
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numOfIngredientsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 225);
            this.listBox1.TabIndex = 0;
            // 
            // OKbtn
            // 
            this.OKbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbtn.Location = new System.Drawing.Point(50, 382);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 1;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(258, 382);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // numOfIngredientsLabel
            // 
            this.numOfIngredientsLabel.AutoSize = true;
            this.numOfIngredientsLabel.Location = new System.Drawing.Point(29, 31);
            this.numOfIngredientsLabel.Name = "numOfIngredientsLabel";
            this.numOfIngredientsLabel.Size = new System.Drawing.Size(96, 13);
            this.numOfIngredientsLabel.TabIndex = 3;
            this.numOfIngredientsLabel.Text = "Num of Ingredients";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 329);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(404, 85);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // FormIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numOfIngredientsLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKbtn);
            this.Name = "FormIngredient";
            this.Text = "FormIngredient";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label numOfIngredientsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
    }
}