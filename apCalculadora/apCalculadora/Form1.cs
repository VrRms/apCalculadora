using System;
using System.Windows.Forms;

namespace apCalculadora
{
    public partial class frmCalculadora : Form
    {
        public static readonly char[] sinais = { '(', '√', '^', '/', '*', '-', '+', ')' }; // lista de todos os operadores
        public static readonly char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',' }; // lista dos números e a vírgula para números decimais
        public static readonly char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; // lista de letras

        public frmCalculadora()
        {
            InitializeComponent();
        }

        // BOTÕES NUMÉRICOS
        private void btnNumerico_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0") // textbox vazio
                txtVisor.Text = Convert.ToString(((Button)sender).Text);
            else
                txtVisor.Text += ((Button)sender).Text; // adiciona o valor do botão
        }

        // BOTÃO "C"
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0") // textbox não vazio
                txtVisor.Text = Convert.ToString(0);

            txtResultado.Text = ""; // apaga o resultado
            lbSequencias.Text = "Posfixa: \nInfixa : "; // reinicializa
        }

        // BOTÃO "^"
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")"))
                txtVisor.Text += "^";
            else
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length-1]) && txtVisor.Text != "0")
                    txtVisor.Text += "^";
            }

        }

        // BOTÃO "/"
        private void btnDivisao_Click(object sender, EventArgs e)
        {

            if (txtVisor.Text.EndsWith(")"))
                txtVisor.Text += "/";
            else
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0")
                    txtVisor.Text += "/";
            }
        }

        // BOTÃO "*"
        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")"))
                txtVisor.Text += "*";
            else
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0")
                    txtVisor.Text += "*";
            }
        }

        // BOTÃO "-"
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")"))
                txtVisor.Text += "-";
            else
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]))
                {
                    if (txtVisor.Text != "0") // textbox não vazio
                        txtVisor.Text += "-";
                    else
                        txtVisor.Text = "-";
                }
            }
        }

        // BOTÃO "+"
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")"))
                txtVisor.Text += "+";
            else
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0")
                    txtVisor.Text += "+";
            }
        }

        // BOTÃO "√"
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0") // textbox  vazio
                txtVisor.Text = "√";
            else
            {
                if (IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && !txtVisor.Text.EndsWith(")"))
                    txtVisor.Text += "√";
            }

        }

        // BOTÃO "."
        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text.EndsWith(")") && !txtVisor.Text.EndsWith(","))
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]))
                    txtVisor.Text += ",";
                else
                    txtVisor.Text = txtVisor.Text + "0,";
            }
        }

        // BOTÃO ")"
        private void btnFechaParent_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")"))
                txtVisor.Text += ")";
            else
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0")
                    txtVisor.Text += ")";
            }
        }

        // BOTÃO "("
        private void btnAbreParent_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0") // textbox vazio
                txtVisor.Text = "(";
            else
            {
                if (txtVisor.Text.Substring(txtVisor.Text.Length - 1) != ")")
                    if (IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]))
                        txtVisor.Text += "(";
            }
        }

        // BOTÃO "←"
        private void btnApagarUm_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length != 0)
            {
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1); // apaga um caracter

                if (txtVisor.Text.Length == 0)
                    txtVisor.Text = Convert.ToString(0);
            }
        }

        // BOTÃO "="
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")  // textbox não vazio
            {
                string expressao = txtVisor.Text;

                //////////////// ADICIONA OS VALORES NUMÉRICOS A UM VETOR //////////////////////////////
                double[] vetValores = new double[26];
                string[] soValores = expressao.Split(sinais);

                for (int posVet = 0, posSoValores = 0; posSoValores < soValores.Length; posSoValores++)
                {
                    if (posSoValores < soValores.Length)
                    {
                        if (soValores[posSoValores] != "")
                        {
                            vetValores[posVet] = double.Parse(soValores[posSoValores]);

                            if (expressao.StartsWith("-"))
                            {
                                vetValores[posVet] *= -1;
                                expressao = expressao.Remove(0, 1);
                            }
                            posVet++;
                        }
                    }
                }

                ///////////////// TRANSFORMA OS VALORES PARA LETRAS /////////////////////////////////////////////
                string expLetras = "";
                for (int posLetra = 0, posExpressao = 0; posExpressao <= expressao.Length;) // posLetra e posExpressao são locais
                {
                    if (posExpressao == expressao.Length)
                    {
                        if (Convert.ToChar(expressao.Substring(posExpressao - 1, 1)) != ')')
                            expLetras += letras[posLetra];

                        break;
                    }
                    while (IsNumero(Convert.ToChar(expressao.Substring(posExpressao, 1))))
                    {
                        if (posExpressao == expressao.Length - 1)
                        {
                            posExpressao++;
                            break;
                        }

                        posExpressao++;
                    }
                    if (posExpressao != expressao.Length)
                    {
                        while (IsOperador(Convert.ToChar(expressao.Substring(posExpressao, 1))))
                        {
                            if (Convert.ToChar(expressao.Substring(posExpressao, 1)) != '(' && Convert.ToChar(expressao.Substring(posExpressao, 1)) != '√' && Convert.ToChar(expressao.Substring(posExpressao - 1, 1)) != ')')
                            {
                                expLetras += letras[posLetra];
                                posLetra++;
                            }
                            expLetras += expressao.Substring(posExpressao, 1);
                            posExpressao++;

                            if (posExpressao == expressao.Length)
                                break;
                        }
                    }
                }

                ////////////////// INFIXA PARA PÓS-FIXA //////////////////////////////////////////////////////////

                PilhaLista<char> pilha = new PilhaLista<char>();

                string expressaoPosfixa = "";
                for (int posExp = 0; posExp < expLetras.Length; posExp++)
                {
                    char c = Convert.ToChar(expLetras.Substring(posExp, 1));
                    if (!IsOperador(c))
                        expressaoPosfixa += c;
                    else
                    {
                        if (pilha.EstaVazia() && c != ')')
                            pilha.Empilhar(c);
                        else
                        {
                            if (c == ')')
                            {
                                while (pilha.OTopo() != '(')
                                    expressaoPosfixa += pilha.Desempilhar();

                                pilha.Desempilhar();
                            }
                            else
                            {
                                while (Precedencia(pilha.OTopo(), c) && pilha.OTopo() != '(')
                                {
                                    expressaoPosfixa += pilha.Desempilhar();
                                    if (pilha.EstaVazia())
                                        break;
                                }
                                pilha.Empilhar(c);
                            }
                        }
                    }
                }
                while (!pilha.EstaVazia())
                    expressaoPosfixa += pilha.Desempilhar();

                /////////////// CALCULAR EXPRESSÃO POSFIXA //////////////////////////////////////////
                double resultado = 0;
                int posExpPosFixa = 0;
                PilhaLista<double> pilhaValores = new PilhaLista<double>();
                try
                {
                    while (posExpPosFixa < expressaoPosfixa.Length)
                    {
                        char c = Convert.ToChar(expressaoPosfixa.Substring(posExpPosFixa, 1));
                        if (!IsOperador(c))
                        {
                            pilhaValores.Empilhar(vetValores[c - 'A']);

                            if (expressaoPosfixa.Length == 1)
                                resultado = vetValores[c - 'A'];
                        }
                        else
                        {
                            if (c == '√')
                                resultado = ResolverOperacao(0, pilhaValores.Desempilhar(), c);
                            else
                                resultado = ResolverOperacao(pilhaValores.Desempilhar(), pilhaValores.Desempilhar(), c);

                            pilhaValores.Empilhar(resultado);
                        }
                        posExpPosFixa++;
                    }
                    txtResultado.Text = resultado + "";
                    lbSequencias.Text = "Posfixa: " + expressaoPosfixa + "\nInfixa : " + expLetras;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Expressão incorreta!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResultado.Text = "";
                    lbSequencias.Text = "Posfixa: \nInfixa : ";
                }
            }
        }

        // MÉTODO QUE RECONHECE AQS TECLAS DO TECLADO
        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Shift)
                switch (e.KeyValue)
                {
                    case 48: // ")"
                        btnFechaParent.PerformClick();
                        break;
                    case 57: // "("
                        btnAbreParent.PerformClick();
                        break;
                    case 56: // "*"
                        btnMult.PerformClick();
                        break;
                }
            else
                switch (e.KeyValue)
                {
                    case 96: // "0" do teclado numérico
                    case 48: // "0" do teclado 
                        btnZero.PerformClick();
                        break;
                    case 97: // "1" do teclado numérico
                    case 49: // "1" do teclado 
                        btnUm.PerformClick();
                        break;
                    case 98: // "2" do teclado numérico
                    case 50: // "2" do teclado 
                        btnDois.PerformClick();
                        break;
                    case 99: // "3" do teclado numérico
                    case 51: // "3" do teclado 
                        btnTres.PerformClick();
                        break;
                    case 100: // "4" do teclado numérico
                    case 52:  // "4" do teclado 
                        btnQuatro.PerformClick();
                        break;
                    case 101: // "5" do teclado numérico
                    case 53:  // "5" do teclado 
                        btnCinco.PerformClick();
                        break;
                    case 102: // "6" do teclado numérico
                    case 54:  // "6" do teclado 
                        btnSeis.PerformClick();
                        break;
                    case 103: // "7" do teclado numérico
                    case 55:  // "7" do teclado 
                        btnSete.PerformClick();
                        break;
                    case 104: // "8" do teclado numérico
                    case 56:  // "8" do teclado 
                        btnOito.PerformClick();
                        break;
                    case 105: // "9" do teclado numérico
                    case 57:  // "9" do teclado 
                        btnNove.PerformClick();
                        break;
                    case 8: // "BACKSPACE"
                        btnApagarUm.PerformClick();
                        break;
                    case 46: // "DELETE"
                        btnClear.PerformClick();
                        break;
                    case 109: // "-" do teclado numérico
                    case 189: // "-" do teclado
                        btnSubtracao.PerformClick();
                        break;
                    case 107: // "+" do teclado numérico
                    case 187: // "+" do teclado
                        btnSoma.PerformClick();
                        break;
                    case 106: // "*" do teclado numérico
                        btnMult.PerformClick();
                        break;
                    case 111: // "/" do teclado numérico
                    case 193: // "/" do teclado 
                        btnDivisao.PerformClick();
                        break;
                    case 194: // "." do teclado numérico
                    case 190: // "." do teclado 
                        btnPonto.PerformClick();
                        break;
                    case 13: // "ENTER" de ambos teclados
                        btnIgual.PerformClick();
                        break;
                }
        }

        ////////////////////////////////// MÉTODOS AUXILIARES ///////////////////////////////////////////
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

        // MÉTODO QUE RESOLVE A OPERAÇÃO, DEFINIDA PELO SINAL, ENTRE OS OPERANDOS
        private static double ResolverOperacao(double operando2, double operando1, char sinal)
        {
            switch (sinal)
            {
                case '+': return operando1 + operando2; // calcula adição

                case '-': return operando1 - operando2; // calcula subtração

                case '*': return operando1 * operando2; // calcula multiplicação

                case '/': return operando1 / operando2; // calcula divisão

                case '^': return Math.Pow(operando1, operando2); // calcula potenciação

                case '√': return Math.Sqrt(operando1); // calcula raiz quadrada de apenas um operando

                default: return 0; // retorno padrão
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
