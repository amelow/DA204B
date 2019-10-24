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
    public class Task
    {
        private DateTime date;
        private string description;
        private PriorityType priority;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        //Constructors
        public Task(DateTime date, PriorityType priority, string description)
        {
            this.date = date;
            this.priority = priority;
            this.description = description;
        }
        public Task(Task other)
        {
            this.date = other.date;
            this.priority = other.priority;
            this.description = other.description;
        }

        public Task()
        {
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Date);
            sb.Append("\t");
            sb.Append(GetTimeString());
            sb.Append(GetPriorityString());
            sb.Append("\t");
            if (Priority.Equals(PriorityType.Important) ||
                Priority.Equals(PriorityType.Normal) ||
                Priority.Equals(PriorityType.Urgent))
            {
                sb.Append("\t");
            }
            sb.Append(Description);
            sb.Append("\t");

            return sb.ToString();
        }

        public string GetPriorityString()//getting the prioritytype but without the _ character
        {
            return this.priority.ToString().Replace('_', ' ');
        }
        public string GetTimeString() //getting the time
        {
            string str = date.ToShortTimeString();
            return str;
        }

    }
}

