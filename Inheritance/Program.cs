using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Student student = new Student();
            student.LoginFacebook();
            student.CallRealMethod();

            // base class object can be created from child class constructor
            ContactDetail contactDetail = new Student();

            //// child class object cannot be created from base class constructor
            //// conversion (base class constructor does not have child class properties)
            //Student student1 = new ContactDetail();
            // some more detail are added.

            Application.Run(new Form1());


            
        }
    }
}
