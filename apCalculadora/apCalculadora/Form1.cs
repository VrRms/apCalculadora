using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(1);
            else
                txtVisor.Text += 1;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(2);
            else
                txtVisor.Text += 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(3);
            else
                txtVisor.Text += 3;
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(4);
            else
                txtVisor.Text += 4;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(5);
            else
                txtVisor.Text += 5;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(6);
            else
                txtVisor.Text += 6;
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(7);
            else
                txtVisor.Text += 7;
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(8);
            else
                txtVisor.Text += 8;
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(9);
            else
                txtVisor.Text += 9;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text != "0")
                txtVisor.Text += 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = Convert.ToString(0);
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = txtVisor.Text + "^";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = txtVisor.Text + "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = txtVisor.Text + "*";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = txtVisor.Text + "-";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = txtVisor.Text + "+";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + ".";
        }

        private void btnFechaParent_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = txtVisor.Text + ")";
        }

        private void btnAbreParent_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = txtVisor.Text + "(";
        }

        private void btnApagarUm_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text.Length != 0)
            {
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);

                if(txtVisor.Text.Length == 0)
                    txtVisor.Text = Convert.ToString(0);
            }
                
        }
    }
}
