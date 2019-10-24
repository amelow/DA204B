namespace Assignment6New
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txToDo = new System.Windows.Forms.TextBox();
            this.toDoLbl = new System.Windows.Forms.Label();
            this.dateAndTimeLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.toDoGroup = new System.Windows.Forms.GroupBox();
            this.descriptionResultLbl = new System.Windows.Forms.Label();
            this.priorityResultLbl = new System.Windows.Forms.Label();
            this.hourResultLbl = new System.Windows.Forms.Label();
            this.dateResultLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.toDoListBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toDoGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txToDo
            // 
            this.txToDo.Location = new System.Drawing.Point(156, 85);
            this.txToDo.Name = "txToDo";
            this.txToDo.Size = new System.Drawing.Size(508, 20);
            this.txToDo.TabIndex = 1;
            // 
            // toDoLbl
            // 
            this.toDoLbl.AutoSize = true;
            this.toDoLbl.Location = new System.Drawing.Point(12, 92);
            this.toDoLbl.Name = "toDoLbl";
            this.toDoLbl.Size = new System.Drawing.Size(38, 13);
            this.toDoLbl.TabIndex = 2;
            this.toDoLbl.Text = "To do ";
            // 
            // dateAndTimeLbl
            // 
            this.dateAndTimeLbl.AutoSize = true;
            this.dateAndTimeLbl.Location = new System.Drawing.Point(12, 51);
            this.dateAndTimeLbl.Name = "dateAndTimeLbl";
            this.dateAndTimeLbl.Size = new System.Drawing.Size(73, 13);
            this.dateAndTimeLbl.TabIndex = 3;
            this.dateAndTimeLbl.Text = "Date and time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Location = new System.Drawing.Point(429, 48);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(38, 13);
            this.priorityLbl.TabIndex = 5;
            this.priorityLbl.Text = "Priority";
            // 
            // priorityCombo
            // 
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Location = new System.Drawing.Point(483, 42);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(181, 21);
            this.priorityCombo.TabIndex = 6;
            // 
            // toDoGroup
            // 
            this.toDoGroup.Controls.Add(this.descriptionResultLbl);
            this.toDoGroup.Controls.Add(this.priorityResultLbl);
            this.toDoGroup.Controls.Add(this.hourResultLbl);
            this.toDoGroup.Controls.Add(this.dateResultLbl);
            this.toDoGroup.Controls.Add(this.timeLbl);
            this.toDoGroup.Controls.Add(this.toDoListBox);
            this.toDoGroup.Location = new System.Drawing.Point(3, 173);
            this.toDoGroup.Name = "toDoGroup";
            this.toDoGroup.Size = new System.Drawing.Size(806, 310);
            this.toDoGroup.TabIndex = 7;
            this.toDoGroup.TabStop = false;
            this.toDoGroup.Text = "To Do";
            // 
            // descriptionResultLbl
            // 
            this.descriptionResultLbl.AutoSize = true;
            this.descriptionResultLbl.Location = new System.Drawing.Point(293, 21);
            this.descriptionResultLbl.Name = "descriptionResultLbl";
            this.descriptionResultLbl.Size = new System.Drawing.Size(60, 13);
            this.descriptionResultLbl.TabIndex = 5;
            this.descriptionResultLbl.Text = "Description";
            // 
            // priorityResultLbl
            // 
            this.priorityResultLbl.AutoSize = true;
            this.priorityResultLbl.Location = new System.Drawing.Point(190, 21);
            this.priorityResultLbl.Name = "priorityResultLbl";
            this.priorityResultLbl.Size = new System.Drawing.Size(38, 13);
            this.priorityResultLbl.TabIndex = 4;
            this.priorityResultLbl.Text = "Priority";
            // 
            // hourResultLbl
            // 
            this.hourResultLbl.AutoSize = true;
            this.hourResultLbl.Location = new System.Drawing.Point(99, 21);
            this.hourResultLbl.Name = "hourResultLbl";
            this.hourResultLbl.Size = new System.Drawing.Size(30, 13);
            this.hourResultLbl.TabIndex = 3;
            this.hourResultLbl.Text = "Hour";
            // 
            // dateResultLbl
            // 
            this.dateResultLbl.AutoSize = true;
            this.dateResultLbl.Location = new System.Drawing.Point(33, 21);
            this.dateResultLbl.Name = "dateResultLbl";
            this.dateResultLbl.Size = new System.Drawing.Size(30, 13);
            this.dateResultLbl.TabIndex = 2;
            this.dateResultLbl.Text = "Date";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(653, 264);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(10, 13);
            this.timeLbl.TabIndex = 1;
            this.timeLbl.Text = " ";
            // 
            // toDoListBox
            // 
            this.toDoListBox.FormattingEnabled = true;
            this.toDoListBox.Location = new System.Drawing.Point(36, 37);
            this.toDoListBox.Name = "toDoListBox";
            this.toDoListBox.Size = new System.Drawing.Size(749, 212);
            this.toDoListBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(318, 125);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(165, 28);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer_Seconds_Tick);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(180, 22);
            this.menuFileNew.Text = "New Ctrl+N";
            this.menuFileNew.Click += new System.EventHandler(this.MenuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.menuFileOpen.Text = "Open Datafile";
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(180, 22);
            this.menuFileSave.Text = "Save Datafile";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFileExit.Size = new System.Drawing.Size(180, 22);
            this.menuFileExit.Text = "Exit Alt + F4";
            this.menuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(113, 22);
            this.menuHelpAbout.Text = "About..";
            this.menuHelpAbout.Click += new System.EventHandler(this.MenuHelpAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 515);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.toDoGroup);
            this.Controls.Add(this.priorityCombo);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateAndTimeLbl);
            this.Controls.Add(this.toDoLbl);
            this.Controls.Add(this.txToDo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.toDoGroup.ResumeLayout(false);
            this.toDoGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txToDo;
        private System.Windows.Forms.Label toDoLbl;
        private System.Windows.Forms.Label dateAndTimeLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label priorityLbl;
        private System.Windows.Forms.ComboBox priorityCombo;
        private System.Windows.Forms.GroupBox toDoGroup;
        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label dateResultLbl;
        private System.Windows.Forms.Label hourResultLbl;
        private System.Windows.Forms.Label priorityResultLbl;
        private System.Windows.Forms.Label descriptionResultLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}