using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_ex17
{
    public partial class Form1 : Form
    {
        List<Funcionario> list = new List<Funcionario>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPeão_Click(object sender, EventArgs e)
        {
            FuncionarioPeao f = new FuncionarioPeao();
            f.Salario = Convert.ToDouble(txtSalario.Text);
            f.Nome = txtNome.Text;
            f.Codigo = Convert.ToInt32(txtCodigo.Text);
            f.HoraExtra = Convert.ToDouble(txtValorHExtra.Text);
            list.Add(f);
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            FuncionarioGerente f = new FuncionarioGerente();
            f.Salario = Convert.ToDouble(txtSalario.Text);
            f.Nome = txtNome.Text;
            f.Codigo = Convert.ToInt32(txtCodigo.Text);
            f.Bonus = Convert.ToDouble(txtBonus.Text);
            f.DeptoGerenciado = Convert.ToInt16(txtDepto.Text);
            list.Add(f);
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FuncionarioVendedor f = new FuncionarioVendedor();
            f.Salario = Convert.ToDouble(txtSalario.Text);
            f.Nome = txtNome.Text;
            f.Codigo = Convert.ToInt32(txtCodigo.Text);
            f.PorcentagemSobreVendas = Convert.ToDouble(txtPorcentXVendas.Text);
            f.MetaDeVendaMesEmReais = Convert.ToDouble(txtMeta.Text);
            f.VendasMesEmReais = Convert.ToDouble(txtVendasMes.Text);
            list.Add(f);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = null;
            foreach (var f in list) 
            {
                txtResultado.Text += f.ToString() + Environment.NewLine;
            }
        }
    }
}
