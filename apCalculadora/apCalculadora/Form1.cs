﻿using System;
using System.Windows.Forms;

/// <summary>
/// NOMES: MATEUS DE PADUA VICENTE E VITOR RAMOS
/// RAs  : 18186 E 18171
/// </summary>

namespace apCalculadora
{
    public partial class frmCalculadora : Form
    {
        private static readonly char[] sinais = { '(', '√', '^', '/', '*', '-', '+', ')' }; // lista de todos os operadores
        private static readonly char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',' }; // lista dos números e a vírgula para números decimais
        private static readonly char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; // lista de letras

        static double[] vetValores; // vetor de valores

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            // mensagem para facilitar o uso do usuário
            MessageBox.Show("Bem-vindo usuário! \nPara melhor utilizar a calculadora, veja algumas regras: \n" +
                            "\n1 - Números negativos devem ser escritos entre parênteses. Ex.: (-2);" +
                            "\n2 - Expressões dentro de qualquer operador devem estar entre parênteses, assim como as prioritárias. Ex.: √(√(10+6)) ou 10/(5*(1+1));" +
                            "\n3 - Evite expressões muito longas. Caso não esteja vendo completamente sua expressão, clique no visor e acompanhe até o fim;" +
                            "\n4 - Divisão por 0 (zero) é indeterminado;" +
                            "\n\nQualquer erro será avisado. \nAgora, vamos calcular!" +
                            "\n\n\n\n© Esse projeto foi desenvolvido por Vitor Ramos e Mateus Vicente",
                            "Antes de começar...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // BOTÕES NUMÉRICOS
        private void btnNumerico_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0") // textbox vazio
                txtVisor.Text = Convert.ToString(((Button)sender).Text);
            else
                txtVisor.Text += ((Button)sender).Text; // adiciona o valor do botão

            btnIgual.Select();
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
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0") // verifica se o sinal pode ser aplicado
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
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0") // verifica se o sinal pode ser aplicado
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
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0") // verifica se o sinal pode ser aplicado
                    txtVisor.Text += "*";
            }
        }

        // BOTÃO "-"
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.EndsWith(")") || txtVisor.Text.EndsWith("("))
                txtVisor.Text += "-";
            else
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1])) // verifica se o sinal pode ser aplicado
                {
                    if (txtVisor.Text != "0") // textbox não vazio
                        txtVisor.Text += "-";
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
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0") // verifica se o sinal pode ser aplicado
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
                if (IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && !txtVisor.Text.EndsWith(")")) // verifica se o sinal pode ser aplicado
                    txtVisor.Text += "√";
            }
            btnIgual.Select();
        }

        // BOTÃO "."
        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtVisor.Text.EndsWith(")") && !txtVisor.Text.EndsWith(","))
            {
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1])) // verifica se o ponto pode ser aplicado
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
                if (!IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]) && txtVisor.Text != "0") // verifica se o sinal pode ser aplicado
                    txtVisor.Text += ")";
            }
            btnIgual.Select();
        }

        // BOTÃO "("
        private void btnAbreParent_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0") // textbox vazio
                txtVisor.Text = "(";
            else
            {
                if (txtVisor.Text.Substring(txtVisor.Text.Length - 1) != ")")
                    if (IsOperador(txtVisor.Text[txtVisor.Text.Length - 1])) // verifica se o sinal pode ser aplicado
                        txtVisor.Text += "(";
            }
            btnIgual.Select();
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
            btnIgual.Select();
        }

        // BOTÃO "="
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "0")  // textbox não vazio
            {
                try
                {
                    if (!txtVisor.Text.EndsWith(")") && IsOperador(txtVisor.Text[txtVisor.Text.Length - 1]))
                        throw new Exception("Expressão incorreta!"); // a expressão não pode terminar com um operador

                    vetValores = new double[26]; // vetor de valores de máximo 26, por causa das letras do alfabeto
                    string expressao = txtVisor.Text; // expressão digitada
                    string[] soValores = expressao.Split(sinais); // separa a expressão pelos operadores para obter somente os valores

                    for (int posVet = 0, posSoValores = 0; posSoValores < soValores.Length; posSoValores++) // posVet e posSoValores são locais
                    {
                        if (soValores[posSoValores] != "")
                        {
                            vetValores[posVet] = double.Parse(soValores[posSoValores]); // adiciona o valor no vetor
                            posVet++;
                        }
                    }

                    string expLetras = ""; // expressão com letras no lugar dos números
                    ValoresParaLetras(expressao, ref expLetras);

                    string expPosfixa = ""; // expressão pósfixa com letras
                    InfixaParaPosfixa(expLetras, ref expPosfixa);

                    double resultado = 0; // resultado da expressão
                    CalcularPosfixa(expPosfixa, ref resultado);

                    txtResultado.Text = resultado + "";// mostra o resultado do cálculo
                    lbSequencias.Text = "Posfixa: " + expPosfixa + "\nInfixa : " + expLetras; // apresenta a pósfixa e infixa
                }
                catch (Exception erro)
                {
                    if (erro.Message == "Divisão por zero!")
                        MessageBox.Show("Divisão por 0 (zero) é indeterminado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Expressão incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtResultado.Text = ""; // apaga
                    lbSequencias.Text = "Posfixa: \nInfixa : "; // reinicializa
                }
            }
        }

        //////////////////////////////////////////// MÉTODOS AUXILIARES ////////////////////////////////////////////

        // MÉTODO PARA CONVERTER A EXPRESSÃO NUMÉRICA PARA LETRAS
        private static void ValoresParaLetras(string expOriginal, ref string expLetras)
        {
            expLetras = "";

            for (int posLetra = 0, posExpressao = 0; posExpressao <= expOriginal.Length;) // posLetra e posExpressao são locais
            {
                if (posExpressao == expOriginal.Length)
                {
                    if (expOriginal[posExpressao - 1] != ')')
                        expLetras += letras[posLetra];

                    break;
                }
                while (!IsOperador(expOriginal[posExpressao])) // IsOperador é mais rápido que IsNumero
                {
                    if (posExpressao == expOriginal.Length - 1)
                    {
                        posExpressao++;
                        break;
                    }
                    posExpressao++;
                }
                if (posExpressao != expOriginal.Length)
                {
                    while (IsOperador(expOriginal[posExpressao])) // enquanto é operador
                    {
                        if (expOriginal[posExpressao] != '(' && expOriginal[posExpressao] != '√' && expOriginal[posExpressao - 1] != ')')
                        {
                            if (expOriginal[posExpressao] == '-') // o operador "-" é unário quando entre parênteses
                            {
                                if (expOriginal[posExpressao - 1] != '(')
                                {                                  // o operador "-" não é unário
                                    expLetras += letras[posLetra]; // adiciona a letra equivalente
                                    posLetra++;
                                }
                                else // o operador "-" é unário
                                {
                                    vetValores[posLetra] *= -1; // a valor foi separado pelos operadores, então é preciso negativar os números que eram negativos
                                    posExpressao++;
                                    break;
                                }
                            }
                            else // todo operador necessita de 2 operandos, menos os identificados no "if" após o "while"
                            {
                                expLetras += letras[posLetra]; // adiciona a letra equivalente
                                posLetra++;
                            }
                        }
                        expLetras += expOriginal.Substring(posExpressao, 1); // adiciona o operador
                        posExpressao++;

                        if (posExpressao == expOriginal.Length) // fim da expressão
                            break;
                    }
                }
            }
        }

        // MÉTODO PARA TRANSFORMAR A EXPRESSÃO INFIXA PARA PÓSFIXA
        private static void InfixaParaPosfixa(string expLetras, ref string expPosfixa)
        {
            PilhaLista<char> pilha = new PilhaLista<char>(); // para empilhar os operadores
            expPosfixa = ""; // expressão pósfixa com letras

            for (int posExp = 0; posExp < expLetras.Length; posExp++)
            {
                char c = Convert.ToChar(expLetras.Substring(posExp, 1)); // caracter lido

                if (!IsOperador(c))        // se não é operador, ou seja, é letra (valor)
                    expPosfixa += c; // adiciona na expressão
                else
                {
                    if (pilha.EstaVazia() && c != ')')
                        pilha.Empilhar(c); // empilha o operador
                    else
                    {
                        if (c == ')') // se achamos um ")", existem operações prioritárias
                        {
                            while (pilha.OTopo() != '(')                 // enquanto não acharmos o correspondente
                                expPosfixa += pilha.Desempilhar(); // desempilha os operadores priorizados

                            pilha.Desempilhar(); // desempilha o próprio "("
                        }
                        else
                        {
                            while (Precedencia(pilha.OTopo(), c) && pilha.OTopo() != '(')
                            {
                                expPosfixa += pilha.Desempilhar();  // o topo tem precedência, então devem vir primeiro (desempilhando)
                                if (pilha.EstaVazia())
                                    break;
                            }
                            pilha.Empilhar(c); // empilha o novo caracter lido
                        }
                    }
                }
            }
            while (!pilha.EstaVazia()) // acabou a expressão, então se sobrou operadores
                expPosfixa += pilha.Desempilhar(); // desempilhamos, já que está na ordem certa
        }

        // MÉTODO PARA CALCULAR A EXPRESSÃO PÓSFIXA
        private static void CalcularPosfixa(string expPosfixa, ref double result)
        {
            result = 0;  // resultado do cálculo pófixo
            int posExpPosFixa = 0; // posição na expressão pósfixa
            PilhaLista<double> pilhaValores = new PilhaLista<double>(); // para empilhar os valores

            while (posExpPosFixa < expPosfixa.Length)
            {
                char c = Convert.ToChar(expPosfixa.Substring(posExpPosFixa, 1)); // caracter lido

                if (!IsOperador(c)) // não é operador
                {
                    pilhaValores.Empilhar(vetValores[c - 'A']); // empilha o valor double

                    if (expPosfixa.Length == 1)
                        result = vetValores[c - 'A'];
                }
                else
                {
                    if (c == '√')
                        result = ResolverOperacao(0, pilhaValores.Desempilhar(), c); // "√" é operador unário
                    else
                        result = ResolverOperacao(pilhaValores.Desempilhar(), pilhaValores.Desempilhar(), c); // resolve a operação

                    pilhaValores.Empilhar(result); // // empilha o resultado
                }
                posExpPosFixa++;
            }
        }

        // MÉTODO QUE RESOLVE A OPERAÇÃO, DEFINIDA PELO SINAL, ENTRE OS OPERANDOS
        private static double ResolverOperacao(double operando2, double operando1, char sinal)
        {
            switch (sinal)
            {
                case '+': return operando1 + operando2; // calcula adição

                case '-': return operando1 - operando2; // calcula subtração

                case '*': return operando1 * operando2; // calcula multiplicação

                case '/':
                    if (operando2 == 0)
                        throw new Exception("Divisão por zero!");
                    else
                        return operando1 / operando2; // calcula divisão

                case '^': return Math.Pow(operando1, operando2); // calcula potenciação

                case '√': return Math.Sqrt(operando1); // calcula raiz quadrada de apenas um operando

                default: throw new Exception("Sinal inexistente!"); // retorno padrão
            }
        }

        // ANALISA A PRECEDÊNCIA ENTRE OPERADORES
        private static bool Precedencia(char sinalTopo, char sinal2)
        {
            int indice1 = Array.FindIndex(sinais, x => x == sinalTopo); // encontra o indice do sinal do topo no vetor sinais
            int indice2 = Array.FindIndex(sinais, y => y == sinal2);   // encontra o indice do operador atual no vetor sinais

            if (indice1 < 0 || indice2 < 0)
                throw new Exception("Sinal inexistente");

            if (indice1 == indice2)
                return true; // se indices iguais, o topo tem preferência

            if (indice1 < indice2)
                return true; // se o indice do topo é menor que o outro, ele que tem preferência

            return false;
        }

        private static bool IsOperador(char s)
        {
            foreach (char sinal in sinais)
                if (s == sinal) // verifica se o caracter é um operador
                    return true;

            return false;
        }
        /*
        private static bool IsNumero(char n)
        {
            foreach (char numero in numeros)
                if (n == numero) // verifica se o caracter é um número
                    return true;

            return false;
        }

        private static bool IsLetra(char l)
        {
            foreach (char letra in letras)
                if (l == letra) // verifica se o caracter é uma letra
                    return true;

            return false;
        }
        */

        //-------------------- MÉTODO QUE RECONHECE AS TECLAS DO TECLADO --------------------//
        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Shift)
                switch (e.KeyValue)
                {
                    case 48: // ")"
                        btnFechaParent.PerformClick();
                        break;
                    case 56: // "*"
                        btnMult.PerformClick();
                        break;
                    case 57: // "("
                        btnAbreParent.PerformClick();
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
                }
        }
    }
}
