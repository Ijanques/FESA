using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace POO_EX3
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            btnShow.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (Employee employee in employees)
            {
                if (string.IsNullOrEmpty(txtEmployees.Text))
                {
                    txtEmployees.Text = "Code: " + employee.Code + Environment.NewLine + "name: " + employee.Name + Environment.NewLine + "RG: " + employee.Rg + Environment.NewLine + "wage: " +
                        employee.Wage + Environment.NewLine + "INSS: " + employee.Inss + Environment.NewLine + "Liquid wage: " + employee.LiquidWage + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    txtEmployees.Text = txtEmployees.Text + "Code: " + employee.Code + Environment.NewLine + "name: " + employee.Name + Environment.NewLine + "RG: " + employee.Rg + Environment.NewLine + "wage: " +
                        employee.Wage + Environment.NewLine + "INSS: " + employee.Inss + Environment.NewLine + "Liquid wage: " + employee.LiquidWage + Environment.NewLine + Environment.NewLine;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Code = Convert.ToInt32(txtCode.Text);
                employee.Name= txtName.Text;
                employee.Rg = txtRg.Text;
                employee.Wage = Convert.ToDouble(txtWage.Text);
                employees.Add(employee);

                MessageBox.Show("Saved!!!");
                btnShow.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Write only numbers where you should write numbers and write something where you should write something");
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
