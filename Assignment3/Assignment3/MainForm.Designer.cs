using System;

namespace Assignment3{
 /* This is the Third Assignment for the Introduction to C#(DA204B) course at the University of Malmö
  * Author: Amelie Löwe
  * Date: 2019-03-17
 */
    partial class MainForm{
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
        private void InitializeComponent(){
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pricePerLitTextBox = new System.Windows.Forms.TextBox();
            this.currFuelTankedTextBox = new System.Windows.Forms.TextBox();
            this.prevOdometerTextBox = new System.Windows.Forms.TextBox();
            this.currOdometerTextBox = new System.Windows.Forms.TextBox();
            this.fuelcalcBtn = new System.Windows.Forms.Button();
            this.pricePerLiterLabel = new System.Windows.Forms.Label();
            this.currFuelTankedLabel = new System.Windows.Forms.Label();
            this.prevOdometerLabel = new System.Windows.Forms.Label();
            this.currOdometerLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.costPerKmResultLabel = new System.Windows.Forms.Label();
            this.fuelConSweResultLabel = new System.Windows.Forms.Label();
            this.fuelConMetricLabel = new System.Windows.Forms.Label();
            this.fuelConMetricResultLabel = new System.Windows.Forms.Label();
            this.fuelConKmResultLabel = new System.Windows.Forms.Label();
            this.costPerKmLabel = new System.Windows.Forms.Label();
            this.fuelConsumptionSweLabel = new System.Windows.Forms.Label();
            this.fuelConsumptionMetricLabel = new System.Windows.Forms.Label();
            this.fuelConsumptionKmLabel = new System.Windows.Forms.Label();
            this.fuelConsumptionKmLitLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.USRadioBtn = new System.Windows.Forms.RadioButton();
            this.metricRadioBtn = new System.Windows.Forms.RadioButton();
            this.BMICalcBtn = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.weightCategoryResultLabel = new System.Windows.Forms.Label();
            this.yourBMIResultLabel = new System.Windows.Forms.Label();
            this.WeightResultLabel = new System.Windows.Forms.Label();
            this.yourBMILabel = new System.Windows.Forms.Label();
            this.WeightCategoryLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pricePerLitTextBox);
            this.groupBox1.Controls.Add(this.currFuelTankedTextBox);
            this.groupBox1.Controls.Add(this.prevOdometerTextBox);
            this.groupBox1.Controls.Add(this.currOdometerTextBox);
            this.groupBox1.Controls.Add(this.fuelcalcBtn);
            this.groupBox1.Controls.Add(this.pricePerLiterLabel);
            this.groupBox1.Controls.Add(this.currFuelTankedLabel);
            this.groupBox1.Controls.Add(this.prevOdometerLabel);
            this.groupBox1.Controls.Add(this.currOdometerLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel";
            // 
            // pricePerLitTextBox
            // 
            this.pricePerLitTextBox.Location = new System.Drawing.Point(215, 143);
            this.pricePerLitTextBox.Name = "pricePerLitTextBox";
            this.pricePerLitTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricePerLitTextBox.TabIndex = 8;
            // 
            // currFuelTankedTextBox
            // 
            this.currFuelTankedTextBox.Location = new System.Drawing.Point(215, 107);
            this.currFuelTankedTextBox.Name = "currFuelTankedTextBox";
            this.currFuelTankedTextBox.Size = new System.Drawing.Size(100, 20);
            this.currFuelTankedTextBox.TabIndex = 7;
            // 
            // prevOdometerTextBox
            // 
            this.prevOdometerTextBox.Location = new System.Drawing.Point(215, 66);
            this.prevOdometerTextBox.Name = "prevOdometerTextBox";
            this.prevOdometerTextBox.Size = new System.Drawing.Size(100, 20);
            this.prevOdometerTextBox.TabIndex = 6;
            // 
            // currOdometerTextBox
            // 
            this.currOdometerTextBox.Location = new System.Drawing.Point(215, 30);
            this.currOdometerTextBox.Name = "currOdometerTextBox";
            this.currOdometerTextBox.Size = new System.Drawing.Size(100, 20);
            this.currOdometerTextBox.TabIndex = 5;
            // 
            // fuelcalcBtn
            // 
            this.fuelcalcBtn.Location = new System.Drawing.Point(96, 179);
            this.fuelcalcBtn.Name = "fuelcalcBtn";
            this.fuelcalcBtn.Size = new System.Drawing.Size(131, 23);
            this.fuelcalcBtn.TabIndex = 4;
            this.fuelcalcBtn.Text = "Calculate";
            this.fuelcalcBtn.UseVisualStyleBackColor = true;
            this.fuelcalcBtn.Click += new System.EventHandler(this.fuelcalcBtn_Click);
            // 
            // pricePerLiterLabel
            // 
            this.pricePerLiterLabel.AutoSize = true;
            this.pricePerLiterLabel.Location = new System.Drawing.Point(6, 150);
            this.pricePerLiterLabel.Name = "pricePerLiterLabel";
            this.pricePerLiterLabel.Size = new System.Drawing.Size(86, 13);
            this.pricePerLiterLabel.TabIndex = 3;
            this.pricePerLiterLabel.Text = "Price per liter (kr)";
            // 
            // currFuelTankedLabel
            // 
            this.currFuelTankedLabel.AutoSize = true;
            this.currFuelTankedLabel.Location = new System.Drawing.Point(6, 114);
            this.currFuelTankedLabel.Name = "currFuelTankedLabel";
            this.currFuelTankedLabel.Size = new System.Drawing.Size(180, 13);
            this.currFuelTankedLabel.TabIndex = 2;
            this.currFuelTankedLabel.Text = "Current amount of fuel tanked (liters) ";
            // 
            // prevOdometerLabel
            // 
            this.prevOdometerLabel.AutoSize = true;
            this.prevOdometerLabel.Location = new System.Drawing.Point(6, 73);
            this.prevOdometerLabel.Name = "prevOdometerLabel";
            this.prevOdometerLabel.Size = new System.Drawing.Size(156, 13);
            this.prevOdometerLabel.TabIndex = 1;
            this.prevOdometerLabel.Text = "Previous odometer reading (km)";
            // 
            // currOdometerLabel
            // 
            this.currOdometerLabel.AutoSize = true;
            this.currOdometerLabel.Location = new System.Drawing.Point(6, 37);
            this.currOdometerLabel.Name = "currOdometerLabel";
            this.currOdometerLabel.Size = new System.Drawing.Size(149, 13);
            this.currOdometerLabel.TabIndex = 0;
            this.currOdometerLabel.Text = "Current odometer reading (km)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.costPerKmResultLabel);
            this.groupBox2.Controls.Add(this.fuelConSweResultLabel);
            this.groupBox2.Controls.Add(this.fuelConMetricLabel);
            this.groupBox2.Controls.Add(this.fuelConMetricResultLabel);
            this.groupBox2.Controls.Add(this.fuelConKmResultLabel);
            this.groupBox2.Controls.Add(this.costPerKmLabel);
            this.groupBox2.Controls.Add(this.fuelConsumptionSweLabel);
            this.groupBox2.Controls.Add(this.fuelConsumptionMetricLabel);
            this.groupBox2.Controls.Add(this.fuelConsumptionKmLabel);
            this.groupBox2.Controls.Add(this.fuelConsumptionKmLitLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // costPerKmResultLabel
            // 
            this.costPerKmResultLabel.AutoSize = true;
            this.costPerKmResultLabel.Location = new System.Drawing.Point(200, 173);
            this.costPerKmResultLabel.Name = "costPerKmResultLabel";
            this.costPerKmResultLabel.Size = new System.Drawing.Size(43, 13);
            this.costPerKmResultLabel.TabIndex = 17;
            this.costPerKmResultLabel.Text = "Result..";
            // 
            // fuelConSweResultLabel
            // 
            this.fuelConSweResultLabel.AutoSize = true;
            this.fuelConSweResultLabel.Location = new System.Drawing.Point(200, 137);
            this.fuelConSweResultLabel.Name = "fuelConSweResultLabel";
            this.fuelConSweResultLabel.Size = new System.Drawing.Size(43, 13);
            this.fuelConSweResultLabel.TabIndex = 16;
            this.fuelConSweResultLabel.Text = "Result..";
            // 
            // fuelConMetricLabel
            // 
            this.fuelConMetricLabel.AutoSize = true;
            this.fuelConMetricLabel.Location = new System.Drawing.Point(200, 104);
            this.fuelConMetricLabel.Name = "fuelConMetricLabel";
            this.fuelConMetricLabel.Size = new System.Drawing.Size(43, 13);
            this.fuelConMetricLabel.TabIndex = 15;
            this.fuelConMetricLabel.Text = "Result..";
            // 
            // fuelConMetricResultLabel
            // 
            this.fuelConMetricResultLabel.AutoSize = true;
            this.fuelConMetricResultLabel.Location = new System.Drawing.Point(200, 67);
            this.fuelConMetricResultLabel.Name = "fuelConMetricResultLabel";
            this.fuelConMetricResultLabel.Size = new System.Drawing.Size(43, 13);
            this.fuelConMetricResultLabel.TabIndex = 14;
            this.fuelConMetricResultLabel.Text = "Result..";
            // 
            // fuelConKmResultLabel
            // 
            this.fuelConKmResultLabel.AutoSize = true;
            this.fuelConKmResultLabel.Location = new System.Drawing.Point(200, 32);
            this.fuelConKmResultLabel.Name = "fuelConKmResultLabel";
            this.fuelConKmResultLabel.Size = new System.Drawing.Size(43, 13);
            this.fuelConKmResultLabel.TabIndex = 13;
            this.fuelConKmResultLabel.Text = "Result..";
            // 
            // costPerKmLabel
            // 
            this.costPerKmLabel.AutoSize = true;
            this.costPerKmLabel.Location = new System.Drawing.Point(6, 173);
            this.costPerKmLabel.Name = "costPerKmLabel";
            this.costPerKmLabel.Size = new System.Drawing.Size(91, 13);
            this.costPerKmLabel.TabIndex = 4;
            this.costPerKmLabel.Text = "Cost per kilometer";
            // 
            // fuelConsumptionSweLabel
            // 
            this.fuelConsumptionSweLabel.AutoSize = true;
            this.fuelConsumptionSweLabel.Location = new System.Drawing.Point(6, 137);
            this.fuelConsumptionSweLabel.Name = "fuelConsumptionSweLabel";
            this.fuelConsumptionSweLabel.Size = new System.Drawing.Size(147, 13);
            this.fuelConsumptionSweLabel.TabIndex = 3;
            this.fuelConsumptionSweLabel.Text = "Fuel consumption (lit/Swe mil)";
            // 
            // fuelConsumptionMetricLabel
            // 
            this.fuelConsumptionMetricLabel.AutoSize = true;
            this.fuelConsumptionMetricLabel.Location = new System.Drawing.Point(6, 104);
            this.fuelConsumptionMetricLabel.Name = "fuelConsumptionMetricLabel";
            this.fuelConsumptionMetricLabel.Size = new System.Drawing.Size(160, 13);
            this.fuelConsumptionMetricLabel.TabIndex = 2;
            this.fuelConsumptionMetricLabel.Text = "Fuel consumption (lit/metric mile)";
            // 
            // fuelConsumptionKmLabel
            // 
            this.fuelConsumptionKmLabel.AutoSize = true;
            this.fuelConsumptionKmLabel.Location = new System.Drawing.Point(6, 70);
            this.fuelConsumptionKmLabel.Name = "fuelConsumptionKmLabel";
            this.fuelConsumptionKmLabel.Size = new System.Drawing.Size(125, 13);
            this.fuelConsumptionKmLabel.TabIndex = 1;
            this.fuelConsumptionKmLabel.Text = "Fuel consumption (lit/km)";
            // 
            // fuelConsumptionKmLitLabel
            // 
            this.fuelConsumptionKmLitLabel.AutoSize = true;
            this.fuelConsumptionKmLitLabel.Location = new System.Drawing.Point(6, 35);
            this.fuelConsumptionKmLitLabel.Name = "fuelConsumptionKmLitLabel";
            this.fuelConsumptionKmLitLabel.Size = new System.Drawing.Size(125, 13);
            this.fuelConsumptionKmLitLabel.TabIndex = 0;
            this.fuelConsumptionKmLitLabel.Text = "Fuel consumption (km/lit)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.weightTextBox);
            this.groupBox3.Controls.Add(this.heightTextBox);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(this.USRadioBtn);
            this.groupBox3.Controls.Add(this.metricRadioBtn);
            this.groupBox3.Controls.Add(this.BMICalcBtn);
            this.groupBox3.Controls.Add(this.weightLabel);
            this.groupBox3.Controls.Add(this.heightLabel);
            this.groupBox3.Controls.Add(this.nameLabel);
            this.groupBox3.Location = new System.Drawing.Point(362, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BMI";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(132, 111);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 10;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(132, 66);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // USRadioBtn
            // 
            this.USRadioBtn.AutoSize = true;
            this.USRadioBtn.Location = new System.Drawing.Point(315, 114);
            this.USRadioBtn.Name = "USRadioBtn";
            this.USRadioBtn.Size = new System.Drawing.Size(105, 17);
            this.USRadioBtn.TabIndex = 5;
            this.USRadioBtn.TabStop = true;
            this.USRadioBtn.Text = "US Unit ( lb,inch)";
            this.USRadioBtn.UseVisualStyleBackColor = true;
            this.USRadioBtn.CheckedChanged += new System.EventHandler(this.USRadioBtn_CheckedChanged);
            // 
            // metricRadioBtn
            // 
            this.metricRadioBtn.AutoSize = true;
            this.metricRadioBtn.Location = new System.Drawing.Point(315, 71);
            this.metricRadioBtn.Name = "metricRadioBtn";
            this.metricRadioBtn.Size = new System.Drawing.Size(114, 17);
            this.metricRadioBtn.TabIndex = 4;
            this.metricRadioBtn.TabStop = true;
            this.metricRadioBtn.Text = "Metric Unit (kg,cm)";
            this.metricRadioBtn.UseVisualStyleBackColor = true;
            this.metricRadioBtn.CheckedChanged += new System.EventHandler(this.metricRadioBtn_CheckedChanged);
            // 
            // BMICalcBtn
            // 
            this.BMICalcBtn.Location = new System.Drawing.Point(150, 179);
            this.BMICalcBtn.Name = "BMICalcBtn";
            this.BMICalcBtn.Size = new System.Drawing.Size(131, 23);
            this.BMICalcBtn.TabIndex = 3;
            this.BMICalcBtn.Text = "Calculate";
            this.BMICalcBtn.UseVisualStyleBackColor = true;
            this.BMICalcBtn.Click += new System.EventHandler(this.BMICalcBtn_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(6, 114);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(62, 13);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "Weight (kg)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 73);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(61, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height (cm)";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Your name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClearAll);
            this.groupBox4.Controls.Add(this.weightCategoryResultLabel);
            this.groupBox4.Controls.Add(this.yourBMIResultLabel);
            this.groupBox4.Controls.Add(this.WeightResultLabel);
            this.groupBox4.Controls.Add(this.yourBMILabel);
            this.groupBox4.Controls.Add(this.WeightCategoryLabel);
            this.groupBox4.Location = new System.Drawing.Point(362, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 202);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results for NoName";
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(9, 168);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(41, 23);
            this.ClearAll.TabIndex = 12;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // weightCategoryResultLabel
            // 
            this.weightCategoryResultLabel.AutoSize = true;
            this.weightCategoryResultLabel.Location = new System.Drawing.Point(275, 70);
            this.weightCategoryResultLabel.Name = "weightCategoryResultLabel";
            this.weightCategoryResultLabel.Size = new System.Drawing.Size(43, 13);
            this.weightCategoryResultLabel.TabIndex = 11;
            this.weightCategoryResultLabel.Text = "Result..";
            // 
            // yourBMIResultLabel
            // 
            this.yourBMIResultLabel.AutoSize = true;
            this.yourBMIResultLabel.Location = new System.Drawing.Point(275, 35);
            this.yourBMIResultLabel.Name = "yourBMIResultLabel";
            this.yourBMIResultLabel.Size = new System.Drawing.Size(43, 13);
            this.yourBMIResultLabel.TabIndex = 10;
            this.yourBMIResultLabel.Text = "Result..";
            // 
            // WeightResultLabel
            // 
            this.WeightResultLabel.AutoSize = true;
            this.WeightResultLabel.Location = new System.Drawing.Point(218, 173);
            this.WeightResultLabel.Name = "WeightResultLabel";
            this.WeightResultLabel.Size = new System.Drawing.Size(191, 13);
            this.WeightResultLabel.TabIndex = 9;
            this.WeightResultLabel.Text = "Normal BMI is between 18.5 and 24.96";
            // 
            // yourBMILabel
            // 
            this.yourBMILabel.AutoSize = true;
            this.yourBMILabel.Location = new System.Drawing.Point(16, 35);
            this.yourBMILabel.Name = "yourBMILabel";
            this.yourBMILabel.Size = new System.Drawing.Size(51, 13);
            this.yourBMILabel.TabIndex = 1;
            this.yourBMILabel.Text = "Your BMI";
            // 
            // WeightCategoryLabel
            // 
            this.WeightCategoryLabel.AutoSize = true;
            this.WeightCategoryLabel.Location = new System.Drawing.Point(13, 70);
            this.WeightCategoryLabel.Name = "WeightCategoryLabel";
            this.WeightCategoryLabel.Size = new System.Drawing.Size(86, 13);
            this.WeightCategoryLabel.TabIndex = 0;
            this.WeightCategoryLabel.Text = "Weight Category";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label currOdometerLabel;
        private System.Windows.Forms.Label pricePerLiterLabel;
        private System.Windows.Forms.Label currFuelTankedLabel;
        private System.Windows.Forms.Label prevOdometerLabel;
        private System.Windows.Forms.Button fuelcalcBtn;
        private System.Windows.Forms.TextBox pricePerLitTextBox;
        private System.Windows.Forms.TextBox currFuelTankedTextBox;
        private System.Windows.Forms.TextBox prevOdometerTextBox;
        private System.Windows.Forms.TextBox currOdometerTextBox;
        private System.Windows.Forms.Label fuelConsumptionKmLitLabel;
        private System.Windows.Forms.Label costPerKmLabel;
        private System.Windows.Forms.Label fuelConsumptionSweLabel;
        private System.Windows.Forms.Label fuelConsumptionMetricLabel;
        private System.Windows.Forms.Label fuelConsumptionKmLabel;
        private System.Windows.Forms.RadioButton USRadioBtn;
        private System.Windows.Forms.RadioButton metricRadioBtn;
        private System.Windows.Forms.Button BMICalcBtn;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label yourBMILabel;
        private System.Windows.Forms.Label WeightCategoryLabel;
        private System.Windows.Forms.Label WeightResultLabel;
        private System.Windows.Forms.Label fuelConKmResultLabel;
        private System.Windows.Forms.Label costPerKmResultLabel;
        private System.Windows.Forms.Label fuelConSweResultLabel;
        private System.Windows.Forms.Label fuelConMetricLabel;
        private System.Windows.Forms.Label fuelConMetricResultLabel;
        private System.Windows.Forms.Label weightCategoryResultLabel;
        private System.Windows.Forms.Label yourBMIResultLabel;
        private System.Windows.Forms.Button ClearAll;
    }
}

