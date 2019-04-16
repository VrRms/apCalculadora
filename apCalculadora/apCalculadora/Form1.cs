using System;
using System.Windows.Forms;

namespace apCalculadora
{
    public partial class frmCalculadora : Form
    {
        public static readonly char[] sinais = { '(', '√', '^', '*', '/', '+', '-', ')' };

        public frmCalculadora()
        {
            InitializeComponent();
        }

        // BOTÃO "1"
        private void btnUm_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(1);
            else
                txtVisor.Text += 1;
        }

        // BOTÃO "2"
        private void btnDois_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(2);
            else
                txtVisor.Text += 2;
        }

        // BOTÃO "3"
        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(3);
            else
                txtVisor.Text += 3;
        }

        // BOTÃO "4"
        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(4);
            else
                txtVisor.Text += 4;
        }

        // BOTÃO "5"
        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(5);
            else
                txtVisor.Text += 5;
        }

        // BOTÃO "6"
        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(6);
            else
                txtVisor.Text += 6;
        }

        // BOTÃO "7"
        private void btnSete_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(7);
            else
                txtVisor.Text += 7;
        }

        // BOTÃO "8"
        private void btnOito_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(8);
            else
                txtVisor.Text += 8;
        }

        // BOTÃO "9"
        private void btnNove_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(9);
            else
                txtVisor.Text += 9;
        }

        // BOTÃO "0"
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text += 0;
        }

        // BOTÃO "C"
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
                txtVisor.Text = Convert.ToString(0);
        }

        // BOTÃO "^"
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

        // BOTÃO "/"
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

        // BOTÃO "*"
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

        // BOTÃO "-"
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

        // BOTÃO "+"
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

        // BOTÃO "√"
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = "√";
            else
            {
                try
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));
                }
                catch (Exception erro)
                {
                    if (!txtVisor.Text.EndsWith(")"))
                        txtVisor.Text += "√";
                }
            }

        }

        // BOTÃO "."
        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text.EndsWith(")") && !txtVisor.Text.EndsWith(","))
            {
                try
                {
                    Convert.ToInt32(txtVisor.Text.Substring(txtVisor.Text.Length - 1));

                    txtVisor.Text += ",";
                }
                catch (Exception erro)
                {
                    txtVisor.Text = txtVisor.Text + "0,";
                }
            }
        }

        // BOTÃO ")"
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

        // BOTÃO "("
        private void btnAbreParent_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
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

        // BOTÃO "←"
        private void btnApagarUm_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length != 0)
            {
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);

                if (txtVisor.Text.Length == 0)
                    txtVisor.Text = Convert.ToString(0);
            }
        }

        // BOTÃO "="
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")
            {
                string expressao = txtVisor.Text;
                double[] vetValores = new double[20];
                string[] a = expressao.Split(sinais);
                for(int i = 0; i < vetValores.Length && i < a.Length; i++)
                {
                    vetValores[i] = double.Parse(a[i]);
                }
                txtResultado.Text = vetValores[1] + "";
                string expressaoPposfixa = ConverterParaPosfixa(expressao);
            }
        }

        //////////////////// MÉTODOS PARA RESOLVER A EXPRESSÃO ///////////////////////
        private static bool IsOperador(char c)
        {
            foreach (char sinal in sinais)
                if (c == sinal)
                    return true;

            return false;
        }

        private static string ConverterParaPosfixa(string infixa)
        {
            string posfixa = "";

            return posfixa;
        }

        private static double ResolverOperacao(double operando1, double operando2, char sinal)
        {
            switch (sinal)
            {
                case '+': return operando1 + operando2;

                case '-': return operando1 - operando2;

                case '*': return operando1 * operando2;

                case '/': return operando1 / operando2;

                case '^': return Math.Pow(operando1, operando2);

                case '√': return Math.Sqrt(operando1);

                default: return 0; // retorno padrão, apenas para satisfazer o compilador 
            }
        }

        private static bool Precedencia(char sinal1, char sinal2)
        { 
            int indice1 = Array.FindIndex(sinais, x => x == sinal1);
            int indice2 = Array.FindIndex(sinais, y => y == sinal2);

            if (indice1 < 0 || indice2 < 0)
                throw new Exception("Sinal inexistente");

            if (indice1 == indice2)
                return true;

            if (indice1 < indice2)
                return true;

            return false;
        }
    }
}
