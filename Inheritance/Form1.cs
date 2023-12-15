using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateEmployeeObject_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.LoginFacebook();
        }

        private void CreateStudentObject_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.LoginFacebook();
        }
    }
}
