using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.I_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int peca = 1;
        double tipo = 1;
        double roupa = 1;
        double preco = 1;
        double enxague = 1;
        double modopesa = 1;
        double modoexec = 1;

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void picX_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picReset_Click(object sender, EventArgs e)
        {

            txtNumpeca.ResetText();
            cmbTipo.SelectedIndex = -1;
            cmbRoupa.SelectedIndex = -1;
            rdbCama.Checked = false;
            rdbPanos.Checked = false;
            rdbNenhum.Checked = false;
            rdbSim.Checked = false;
            rdbNao.Checked = false;
            rdbRapida.Checked = false;
            rdbEconomica.Checked = false;
            rdbPadrao.Checked = false;

            tipo = 0;
            roupa = 0;
            preco = 0;
            enxague = 0;
            modopesa = 0;
            modoexec = 0;
        }

        private void picAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cálculo realizado", "Confirmação");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumpeca.Text == "")
            {
                erp1.SetError(txtNumpeca, "Número de Peças Obrigatório");

                txtNumpeca.BackColor = Color.FromArgb(252, 3, 3);
            }
            else
            {
                erp1.SetError(txtNumpeca, "");

                txtNumpeca.BackColor = Color.FromName("Window");
            }

            //if (pnlModo.Text == "")
            //{

            //  erp1.SetError(pnlModo, "Modo Obrigatório");

            // pnlModo.BackColor = Color.FromArgb(252, 3, 3);
            //}

            //else
            //{
            //  erp1.SetError(pnlModo, "");

            //  pnlModo.BackColor = Color.FromName("Window");

            //}

            if (cmbTipo.Text == "")
            {
                erp1.SetError(cmbTipo, "Tipos de Roupas Obrigatório");

                cmbTipo.BackColor = Color.FromArgb(252, 3, 3);
            }
            else
            {
                erp1.SetError(cmbTipo, "");

                cmbTipo.BackColor = Color.FromName("Window");
            }

            if (cmbRoupa.Text == "")
            {
                erp1.SetError(cmbRoupa, "Classificação de Roupas Obrigatório");

                cmbRoupa.BackColor = Color.FromArgb(252, 3, 3);
            }
            else
            {
                erp1.SetError(cmbRoupa, "");

                cmbRoupa.BackColor = Color.FromName("Window");
            }

            //if ((rdbCama.Checked = false) || (rdbPanos.Checked = false) || (rdbNenhum.Checked = false))
            //{
            //  erp1.SetError(panel2, "Opção Obrigatória");
            //  panel2.BackColor = Color.FromArgb(252, 3, 3);
            //}

            //else if ((rdbCama.Checked = true) || (rdbPanos.Checked = true) || (rdbNenhum.Checked = true))
            //{
            // erp1.SetError(panel2, "");
            // panel2.BackColor = Color.FromName("Window");
            //}

            // Tipo
            if  (cmbTipo.SelectedIndex == 0)
            {
                tipo = 2.2;
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                tipo = 1.5;
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                tipo = 1.3;
            }
            else if (cmbTipo.SelectedIndex == 3)
            {
                tipo = 2;
            }
            else if (cmbTipo.SelectedIndex == 4)
            {
                tipo = 2;
            }
            else if (cmbTipo.SelectedIndex == 5)
            {
                tipo = 1.5;
            }
            else if (cmbTipo.SelectedIndex == 6)
            {
                tipo = 1.2;
            }
            else if (cmbTipo.SelectedIndex == 7)
            {
                tipo = 1.4;
            }
            else if (cmbTipo.SelectedIndex == 8)
            {
                tipo = 2.3;
            }

            // Roupa
            if (cmbRoupa.SelectedIndex == 0)
            {
                roupa = 1.8;
            }
            else if (cmbRoupa.SelectedIndex == 1)
            {
                roupa = 1.5;
            }
            else if (cmbRoupa.SelectedIndex == 2)
            {
                roupa = 1.2;
            }

            // Modo Pesado
            if (rdbCama.Checked == true)
            {
                modopesa = 1.7;
            }
            else if (rdbPanos.Checked == true)
            {
                modopesa = 1.2;
            }
            else if (rdbNenhum.Checked == true)
            {
                modopesa = 1;
            }

            // Enxague
            if (rdbSim.Checked == true)
            {
                enxague = 1.3;
            }
            else if (rdbNao.Checked == true)
            {
                enxague = 1;
            }

            // Modo de Execução
            if (rdbRapida.Checked == true)
            {
                modoexec = 1.4;
            }
            else if (rdbEconomica.Checked == true)
            {
                modoexec = 1;
            }
            else if (rdbPadrao.Checked == true)
            {
                modoexec = 1.2;
            }

            if (txtNumpeca.Text == "")
            {
                peca = 0;
            }
            else
            {
                int peca = Convert.ToInt32(txtNumpeca.Text);
            }

            if (txtNumpeca.Text == "" || cmbTipo.Text == "" || cmbRoupa.Text == "")
            {
                MessageBox.Show("Preencha os Campos Obrigatórios!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int pecaa = Convert.ToInt32(txtNumpeca.Text);
                peca = pecaa;
                preco = peca * tipo * roupa * modopesa * enxague * modoexec;
                MessageBox.Show("Preço da Lavagem: R$" + preco);
            }
        }
    }
}