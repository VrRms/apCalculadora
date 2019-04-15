﻿using System;
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
        public static readonly char[] sinais = { '(', '^', '*', '/', '+', '-', ')' };

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
            try
            {
                if (txtVisor.Text.EndsWith(")"))
                    txtVisor.Text += "^";
                else
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    if (txtVisor.Text != "0")
                        txtVisor.Text += "^";
                }
            }
            catch (Exception erro)
            { }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVisor.Text.EndsWith(")"))
                    txtVisor.Text += "/";
                else
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    if (txtVisor.Text != "0")
                        txtVisor.Text += "/";
                }
            }
            catch (Exception erro)
            { }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVisor.Text.EndsWith(")"))
                    txtVisor.Text += "*";
                else
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    if (txtVisor.Text != "0")
                        txtVisor.Text += "*";
                }
            }
            catch (Exception erro)
            { }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVisor.Text.EndsWith(")"))
                    txtVisor.Text += "-";
                else
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    if (txtVisor.Text != "0")
                        txtVisor.Text += "-";
                }
            }
            catch (Exception erro)
            { }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVisor.Text.EndsWith(")"))
                    txtVisor.Text += "+";
                else
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    if (txtVisor.Text != "0")
                        txtVisor.Text += "+";
                }
            }
            catch (Exception erro)
            { }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")"))
                txtVisor.Text += "√";
            else
            {
                if (!IsOperador(Convert.ToChar(txtVisor.Text.Substring(txtVisor.Text.Length - 1))) && txtVisor.Text != "0")
                    txtVisor.Text += "√";
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")") == false && txtVisor.Text.EndsWith(".") == false)
            {
                try
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    txtVisor.Text += ".";
                }
                catch (Exception erro)
                {
                    txtVisor.Text = txtVisor.Text + "0.";
                }
            }
        }

        private void btnFechaParent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVisor.Text.EndsWith(")"))
                    txtVisor.Text += ")";
                else
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    if (txtVisor.Text != "0")
                        txtVisor.Text += ")";
                }
            }
            catch (Exception erro)
            { }
        }

        private void btnAbreParent_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString("(");
            else
            {
                try
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));
                }
                catch (Exception erro)
                {
                    txtVisor.Text += "(";
                }
            }
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

        //////////////////////////////////////////////////////////////
        private static bool IsOperador(char c)
        {
            foreach (char sinal in sinais)
                if (c == sinal)
                    return true;

            return false;
        }
    }
}
