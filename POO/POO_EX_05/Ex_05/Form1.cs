using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_05
{
    public partial class Form1 : Form
    {
        Student a = new Student();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                a = new Student()
                {
                    Name = txtName.Text,
                    Grade1 = Convert.ToDouble(txtGrade1.Text),
                    Grade2 = Convert.ToDouble(txtGrade2.Text),
                };
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            if (a != null)
                MessageBox.Show("Average: " + a.Avg);
        }
    }
}
