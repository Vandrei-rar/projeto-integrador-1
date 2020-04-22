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

        private void picBoxExit_Click(object sender, EventArgs e)
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

        }

        private void picAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cálculo realizado", "Confirmação");
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
