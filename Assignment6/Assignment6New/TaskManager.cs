using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Amelie Löwe
 * Assignment6  
 * introduction to C# course at the university of Malmö
 */
namespace Assignment6New
{
    class TaskManager
    {
        private List<Task> taskList; //declaring a list 

        public int Count //gets the size of list
        {
            get => taskList.Count;
        }

        public TaskManager()
        {
            taskList = new List<Task>();
        }
        public bool Add(Task newTask) //adds tasks to list
        {
            Task todoObj = new Task(newTask);
            taskList.Add(todoObj);
            taskList.Sort((x, y) => x.Date.CompareTo(y.Date));
            return true;
        }
        public string[] ListToStringArray() //Converts list into a string[]
        {
            string[] taskArray = new string[Count];
            for (int i = 0; i < Count; i++) taskArray[i] = taskList[i].ToString();
            return taskArray;
        }
    }
}
