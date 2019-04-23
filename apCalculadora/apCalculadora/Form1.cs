﻿using System;
using System.Windows.Forms;

namespace apCalculadora
{
    public partial class frmCalculadora : Form
    {
        public static readonly char[] sinais = { '(', '√', '^', '*', '/', '+', '-', ')' }; // lista de todos os operadores
        public static readonly char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',' }; // lista dos números e a vírgula para números decimais
        public static readonly char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; // lista de letras

        public frmCalculadora()
        {
            InitializeComponent();
        }

        // BOTÕES NUMÉRICOS
        private void btnNumerico_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
                txtVisor.Text = Convert.ToString(((Button)sender).Text);
            else
                txtVisor.Text += ((Button)sender).Text;
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

                // ADICIONA OS VALORES NUMÉRICOS A UM VETOR
                double[] vetValores = new double[26];
                string[] a = expressao.Split(sinais);

                for (int i = 0, j = 0; i < a.Length; i++, j++)
                {
                    if(j < a.Length)
                        if (a[j] == "")
                            j++;
                    else
                        vetValores[i] = double.Parse(a[j]);
                }

                // TRANSFORMA OS VALORES PARA LETRAS
                string expLetras = "";
                for (int i = 0, j = 0; j <= expressao.Length;)
                {
                    if (j == expressao.Length)
                    {
                        expLetras += letras[i];
                        break;
                    }

                    while (IsNumero(Convert.ToChar(expressao.Substring(j,1))))
                    {
                        if (j + 1 == expressao.Length)
                        {
                            j++;
                            break;
                        }
                        j++;
                    }

                    if (j != expressao.Length)
                        while (IsOperador(Convert.ToChar(expressao.Substring(j, 1))))
                        {
                            if (Convert.ToChar(expressao.Substring(j, 1)) != '(')
                            {
                                if (Convert.ToChar(expressao.Substring(j - 1, 1)) != ')' && Convert.ToChar(expressao.Substring(j, 1)) != '√')
                                {
                                    expLetras += letras[i];
                                    i++;
                                }
                                expLetras += expressao.Substring(j, 1);        
                            }
                            else
                                expLetras += expressao.Substring(j, 1);
                                
                            j++;

                            if (j == expressao.Length)
                                break;
                        }
                }

                ////////////////// INFIXA PARA PÓS-FIXA //////////////////////////////////////////////////////////

                PilhaLista<char> pilha = new PilhaLista<char>();

                string expressaoPosfixa = "";
                for (int j = 0; j < expLetras.Length; j++)
                {
                    if(IsLetra(Convert.ToChar(expLetras.Substring(j, 1))))
                    {
                        expressaoPosfixa += Convert.ToChar(expLetras.Substring(j, 1));
                    }

                    if(IsOperador(Convert.ToChar(expLetras.Substring(j, 1))))
                    {
                        if (pilha.EstaVazia())
                        {
                            pilha.Empilhar(Convert.ToChar(expLetras.Substring(j, 1)));
                        }
                        else
                        {
                            while (Precedencia(pilha.OTopo(), Convert.ToChar(expLetras.Substring(j, 1)))) 
                            {
                                expressaoPosfixa += pilha.Desempilhar();
                            }

                            pilha.Empilhar(Convert.ToChar(expLetras.Substring(j, 1)));
                        }
                    }
                }

                while (!pilha.EstaVazia())
                    expressaoPosfixa += pilha.Desempilhar();


                lbSequencias.Text = "Posfixa: " + expressaoPosfixa + "\nInfixa : " + expLetras;

            }
        }

        //////////////////// MÉTODOS PARA RESOLVER A EXPRESSÃO ///////////////////////
        private static bool IsOperador(char s)
        {
             foreach (char sinal in sinais)
                if (s == sinal)
                    return true;

            return false;
        }

        private static bool IsNumero(char n)
        {
            foreach (char numero in numeros)
                if (n == numero)
                    return true;

            return false;
        }

        private static bool IsLetra(char l)
        {
            foreach (char letra in letras)
                if (l == letra)
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

        private static bool Precedencia(char sinalTopo, char sinal2)
        { 
            int indice1 = Array.FindIndex(sinais, x => x == sinalTopo);
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
