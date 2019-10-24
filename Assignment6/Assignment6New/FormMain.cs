using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Amelie Löwe
 * Assignment6  
 * introduction to C# course at the university of Malmö
 */
namespace Assignment6New
{
    public partial class FormMain : Form
    {
        TaskManager taskManager = new TaskManager();
        public FormMain()
        {
            this.Text = "To do reminder";
            InitializeComponent();
            InitializeGui();
        }
        private void InitializeGui() //initializing the gui
        {

            priorityCombo.Items.Clear(); // clearing the prioritylist
            string[] priority = Enum.GetNames(typeof(PriorityType));
            foreach (var item in priority) priorityCombo.Items.Add(item.Replace("_", " "));
            priorityCombo.SelectedIndex = (int)PriorityType.Normal;
            toolTip1.SetToolTip(dateTimePicker1, "Click to open calendar for date, write in time here."); //tooltip at the top
            toDoListBox.Items.Clear();
            txToDo.Text = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            menuFileOpen.Enabled = false;
            menuFileSave.Enabled = false;//Disabling the Save and Open functions
        }
        private void AddBtn_Click(object sender, EventArgs e) //when add button is pressed
        {
            if (dateTimePicker1.Value < new DateTime(2000, 01, 01) || dateTimePicker1.Value >= new DateTime(2222, 01, 01))
            {
                MessageBox.Show("Wrong date, must be between 2000 - 2222");

            }
            Task newTask = GetTaskFromUserInputs(); //Reads input
            if (newTask != null)
            {
                taskManager.Add(newTask);
                UpdateGUI(newTask);
                ClearInputs();
            }

        }

        private void ClearInputs()//clear the input fields everytime after the data is added
        {
            txToDo.Text = " ";
            priorityCombo.SelectedIndex = (int)PriorityType.Normal;

        }

        private void UpdateGUI(Task taskObj) //adding the taskobj to the listbox
        {
            toDoListBox.Items.Add(taskObj.ToString());
        }

        private Task GetTaskFromUserInputs() //Reading the user input
        {
            Task taskObj = new Task();
            taskObj.Date = dateTimePicker1.Value;
            taskObj.Priority = (PriorityType)priorityCombo.SelectedIndex;
            taskObj.Description = txToDo.Text;
            return taskObj;
        }

        private void MenuFileNew_Click(object sender, EventArgs e) //starting over by calling the initializeGUI
        {
            InitializeGui();
        }
        private void MenuFileExit_Click(object sender, EventArgs e) //method for when the user wants to close the application
        {

            const string message = //control message
            "Close the application?";
            const string caption = "Are you sure?";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit(); //exiting the todo application
            }
        }
        private void MenuHelpAbout_Click(object sender, EventArgs e) // about the application window
        {
            AboutBox box = new AboutBox(); //calling the AboutBox.cs file
            box.ShowDialog();
        }
        private void Timer_Seconds_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();//timer at the bottom of the form
        }
    }
}
