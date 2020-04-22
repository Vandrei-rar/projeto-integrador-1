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

        }

        private void picAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cálculo realizado", "Confirmação");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
