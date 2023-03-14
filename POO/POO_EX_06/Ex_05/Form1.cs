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
        Student [] students = new Student[10];
        int qt = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                students[qt] = new Student()
                {
                    Name = txtName.Text,
                    Grade1 = Convert.ToDouble(txtGrade1.Text),
                    Grade2 = Convert.ToDouble(txtGrade2.Text),
                };
                qt++;
                btnSave.Enabled = qt != 10;
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = students;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
