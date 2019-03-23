using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, estadocivil;
            nome = txtNome.Text;
            if (rdbCasado.Checked == true)
            {
                estadocivil = "Casado (a)";

            }
            else if (rdbSolteiro.Checked == true)
            {
                estadocivil = "Solteiro (a)";
            }
            else
            {
                MessageBox.Show("Escolha um estado");
                return;

            }

            SalvarFuncionario(nome, estadocivil);
            LimparFuncionario();
        }

        private void SalvarFuncionario(string nome, string estadocivil)
        {
            StreamWriter arquivo;
            string caminho = "c:\\sistema1\\funcionarios.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Funcionáro");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Estado Civil: " + estadocivil);
            arquivo.WriteLine("____________________________");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Funcionario salvo com sucesso!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparFuncionario()
        {
            txtNome.Clear();
            rdbCasado.Checked = false;
            rdbSolteiro.Checked = false;
        }
    }
}
