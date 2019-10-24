using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Fourth assignment for the Introduction to C#(Da204B) course at the University of Malmö.
 * Author: Amelie Löwe
 */
namespace Assignment4
{
    static class Program{
     
        [STAThread]
        static void Main() { // main entry-point for the assignment4
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
