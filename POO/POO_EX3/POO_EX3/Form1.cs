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
                    txtEmployees.Text = "Code: " + employee.GetCode() + Environment.NewLine + "name: " + employee.GetName() + Environment.NewLine + "RG: " + employee.GetRg() + Environment.NewLine + "wage: " +
                        employee.GetWage() + Environment.NewLine + "INSS: " + employee.GetINSS() + Environment.NewLine + "Liquid wage: " + employee.GetLiquidWage() + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    txtEmployees.Text = txtEmployees.Text + "Code: " + employee.GetCode() + Environment.NewLine + "name: " + employee.GetName() + Environment.NewLine + "RG: " + employee.GetRg() + Environment.NewLine + "wage: " +
                        employee.GetWage() + Environment.NewLine + "INSS: " + employee.GetINSS() + Environment.NewLine + "Liquid wage: " + employee.GetLiquidWage() + Environment.NewLine + Environment.NewLine;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.SetCodigo(Convert.ToInt32(txtCode.Text));
                employee.SetName(txtName.Text);
                employee.SetRg(txtRg.Text);
                employee.SetWage(Convert.ToDouble(txtWage.Text));
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
