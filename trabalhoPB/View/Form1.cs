using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoPB
{
    public partial class Form1 : Form
    {
        List<DadosPessoa> Lista_Pessoa = new List<DadosPessoa>();
        
        public Form1()
        {
            InitializeComponent();
            maskedTBProcurarID.Visible = false;
            lblAlteraExclui.Visible = false;

        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            maskedTBProcurarID.Visible = true;
            lblAlteraExclui.Visible = true;

            DadosPessoa Dadospiloto = new DadosPessoa(
                maskedTBID.Text,
                txt_Nome.Text,
                maskedTBData.Text,
                txt_Mae.Text,
                txt_Pai.Text,
                maskedTBTell.Text,
                maskedTBCep.Text
                );

            //add dados na lista
            Lista_Pessoa.Add(Dadospiloto);

            //mostrando dados no DataGridView
            dataVGDados.DataSource = null;
            dataVGDados.DataSource = Lista_Pessoa;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            
            //Alterando dados da list<T>
            Alterar(maskedTBProcurarID.Text);

            //mostrando dados no DataGridView
            dataVGDados.DataSource = null;
            dataVGDados.DataSource = Lista_Pessoa;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //excluindo dados do list<T>
            Excluir(maskedTBProcurarID.Text);

            //mostrando dados no DataGridView
            dataVGDados.DataSource = null;
            dataVGDados.DataSource = Lista_Pessoa;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja Encerrar o progama? ", "Até a proxima :)", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bnt_Procurar_Click(object sender, EventArgs e)
        {
            //procurar dados do list<T>
            Procurar(maskedTBProcurarID.Text);

            //mostrando dados no DataGridView
            dataVGDados.DataSource = null;
            dataVGDados.DataSource = Lista_Pessoa;
        }



        //metodo excluir e 
        public void Alterar(string altera_dados)
        {
            //alterando dados da lista
            foreach (var Dados_Pessoa in Lista_Pessoa)
            {
                if (Dados_Pessoa.id == maskedTBProcurarID.Text)
                {
                    Dados_Pessoa.NOME = txt_Nome.Text;
                    Dados_Pessoa.DATA = maskedTBData.Text;
                    Dados_Pessoa.MAE = txt_Mae.Text;
                    Dados_Pessoa.PAI = txt_Pai.Text;
                    Dados_Pessoa.TELEFONE = maskedTBTell.Text;
                    Dados_Pessoa.CEP = maskedTBCep.Text;
                }
            }
        }

        public void Excluir(string exclui_dados)
        {
            //remove dados na lista
            foreach (var Dados_Pessoa in Lista_Pessoa)
            {
                if (Dados_Pessoa.id == maskedTBProcurarID.Text)
                {
                    Lista_Pessoa.Remove(Dados_Pessoa);
                    break;
                }
            }
        }

        public void Procurar(string procura_dados)
        {
            //procurando dados da lista
            foreach (var Dados_Pessoa in Lista_Pessoa)
            {
                if (Dados_Pessoa.id == maskedTBProcurarID.Text)
                {
                    Dados_Pessoa.NOME = txt_Nome.Text;
                    Dados_Pessoa.DATA = maskedTBData.Text;
                    Dados_Pessoa.MAE = txt_Mae.Text;
                    Dados_Pessoa.PAI = txt_Pai.Text;
                    Dados_Pessoa.TELEFONE = maskedTBTell.Text;
                    Dados_Pessoa.CEP = maskedTBCep.Text;
                }
            }
        }
    }
}
