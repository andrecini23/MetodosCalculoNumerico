using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabalho_Marcio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();

            #region Definição de toolTips:
            toolTip1.SetToolTip(BtnRaiz, " Substitua o α (alpha) para calcular a Raíz Quadrada da expressão. Ex.: " +
                                         "Math.Sqrt(4) = √4 = 2.");

            toolTip1.SetToolTip(BtnPot2, " Substitua o α (alpha) para calcular o quadrado da expressão. Ex.: " +
                                         "Math.Pow(4) = 4² = 16.");

            toolTip1.SetToolTip(BtnPot, " Substitua o α (alpha) e o β (beta) para calcular potência desejada da expressão. Ex.: " +
                                         "Math.Pow(2, 3) = 2³ = 8.");

            toolTip1.SetToolTip(BtnEuller, " Substitua o α (alpha) para calcular a potência desejada de Euller. Ex.: " +
                                         "Math.EXP(2) = e² ~ 7,389.");

            toolTip1.SetToolTip(BtnLn, " Substitua o α (alpha) e o β (beta) para calcular o LN da expressão. Ex.: " +
                                         "Math.Log(2) = Ln(2) ~ 0,693.");

            toolTip1.SetToolTip(BtnLog, " Substitua o α (alpha) para calcular o LOG na base 10 da expressão. Ex.: " +
                                         "Math.Log10(2) = Log(2) ~ 0,301.");

            toolTip1.SetToolTip(BtnCos, " Substitua o α (alpha) para calcular o COSSENO da expressão. Ex.: " +
                                         "Math.Cos(0) = Cos(0) = 1.");

            toolTip1.SetToolTip(BtnSen, " Substitua o α (alpha) para calcular o SENO da expressão. Ex.: " +
                                        "Math.Sen(0) = Sen(0) = 0.");

            toolTip1.SetToolTip(BtnTan, " Substitua o α (alpha) para calcular o TANGENTE da expressão. Ex.: " +
                                        "Math.Tan(0) = Tan(0) = 0.");

            toolTip1.SetToolTip(BtnPI, " Valor de π (3,14159265...).");
            #endregion

        }

        #region Váriáveis Públicas:

        public List<string> Lista = new List<string>();
        public List<string> Raizes = new List<string>();
        public bool messagebox = true;
        public string formulaFinal;

        #endregion

        #region Botões de Numéricos:  

        /// <summary>
        /// Definição Botão 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "1";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "1";
            }
            else
            {
                Lista.Add("1");
                Display.Text += "1";
            }
        }

        /// <summary>
        /// Definição Botão 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "2";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "2";
            }
            else
            {
                Lista.Add("2");
                Display.Text += "2";
            }
        }

        /// <summary>
        /// Definição Botão 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "3";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "3";
            }
            else
            {
                Lista.Add("3");
                Display.Text += "3";
            }
        }

        /// <summary>
        /// Definição Botão 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "4";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "4";
            }
            else
            {
                Lista.Add("4");
                Display.Text += "4";
            }
        }

        /// <summary>
        /// Definição Botão 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "5";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "5";
            }
            else
            {
                Lista.Add("5");
                Display.Text += "5";
            }
        }

        /// <summary>
        /// Definição Botão 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "6";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "6";
            }
            else
            {
                Lista.Add("6");
                Display.Text += "6";
            }
        }

        /// <summary>
        /// Definição Botão 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "7";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "7";
            }
            else
            {
                Lista.Add("7");
                Display.Text += "7";
            }
        }

        /// <summary>
        /// Definição Botão 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "8";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "8";
            }
            else
            {
                Lista.Add("8");
                Display.Text += "8";
            }
        }

        /// <summary>
        /// Definição Botão 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "9";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "9";
            }
            else
            {
                Lista.Add("9");
                Display.Text += "9";
            }
        }

        /// <summary>
        /// Definição Botão 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn0_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "0";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "0";
            }
            else
            {
                Lista.Add("0");
                Display.Text += "0";
            }
        }

        /// <summary>
        /// Definição Botão "π"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPI_Click(object sender, EventArgs e)
        {
            double aux = Math.Round(Math.PI, 5);

            if (textBox1.Enabled == true)
            {
                textBox1.Text += "π";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "π";
            }
            else
            {

                Lista.Add("π");
                Display.Text += $"{aux}";
            }
        }

        /// Definição Botão "X"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnX_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "(X)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "(X)";
            }
            else
            {
                Lista.Add("(X)");
                Display.Text += "(X)";
            }
        }
        #endregion

        #region Botões de Cálculo básico:

        /// <summary>
        /// Definição Botao "÷"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDivide_Click(object sender, EventArgs e)

        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "/";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "/";
            }
            else
            {
                Lista.Add("/");
                Display.Text += "/";
            }
        }

        /// <summary>
        /// Definição Botao "*"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "*";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "*";
            }
            else
            {
                Lista.Add("*");
                Display.Text += "*";
            }
        }

        /// <summary>
        /// Definição Botao "-"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMen_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "-";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "-";
            }
            else
            {
                Lista.Add("-");
                Display.Text += "-";
            }
        }

        /// <summary>
        /// Definição Botao "+"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btnmais_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "+";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "+";
            }
            else
            {
                Lista.Add("+");
                Display.Text += "+";
            }
        }
        #endregion

        #region Botões de formatação:

        /// <summary>
        /// Definição Botao "."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += ".";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += ".";
            }
            else
            {
                Lista.Add(".");
                Display.Text += ".";
            }
        }

        /// <summary>
        /// Definição Botao "("
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnP1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "(";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "(";
            }
            else
            {
                Lista.Add("(");
                Display.Text += "(";
            }
        }

        /// <summary>
        /// Definição Botao ")"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnP2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += ")";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += ")";
            }
            else
            {
                Lista.Add(")");
                Display.Text += ")";
            }
        }

        /// <summary>
        /// Definição Botao "Clear"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        /// <summary>
        /// Definição Botao "Delete"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (Display.Text != "")
            Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            else
            {
                BtnDel.Enabled = false;
            }
        }

        #endregion

        #region Botões de Cálculo avançado:

        /// <summary>
        /// Botão "√"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Sqrt(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Sqrt(α)";
            }
            else
            {
                Display.Text += "Math.Sqrt(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                     "     " + "(Math.Sqrt( X*Math.Sqrt(2) ), por exemplo), é necessário escrever a" +
                                    " função no formato C#, caso contrário, não será possível finalizar " +
                                    "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                    "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    messagebox = false;
                }

                Display.Enabled = false;
            }
        }

        /// <summary>
       /// Botão "LN"
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BtnLn_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Log(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Log(α)";
            }
            else
            {
                Display.Text += "Math.Log(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Log( X*Math.Log(2) ), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }

        /// <summary>
        /// Botão "SEN"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSen_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Sin(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Sin(α)";
            }
            else
            {
                Display.Text += "Math.Sin(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Sen( X*Math.Sen(0) ), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }

                Display.Enabled = false;
            }
        }

        /// <summary>
        /// Botão "COS"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCos_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Cos(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Cos(α)";
            }
            else
            {
                Display.Text += "Math.Cos(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Cos( X*Math.Cos(0) ), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }

        /// <summary>
        /// Botão "TAN"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTan_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Tan(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Tan(α)";
            }
            else
            {
                Display.Text += "Math.Tan(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Tan( X*Math.Tan(0)), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }

        /// <summary>
        /// Botão "X²"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPot2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Pow(α, 2)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Pow(α, 2)";
            }
            else
            {
                Display.Text += "Math.Pow(α, 2)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Pow( X*Math.Pow(α, 2), 2), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display.Enabled = false;
                    messagebox = false;
                }
            }
        }

        /// <summary>
        /// Botão "e^(X)"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEuller_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Exp(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Exp(α)";
            }
            else
            {
                Display.Text += "Math.Exp(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Pow( X*Math.Exp(Math.Exp(α)), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }

                Display.Enabled = false;

            }
        }

        /// <summary>
        /// Botão "LOG10"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLog_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Log10(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Log10(α)";
            }
            else
            {
                Display.Text += "Math.Log10(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Log10( X*Math.Exp(Math.Log10(α)), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }

                Display.Enabled = false;
            }
        }

        /// <summary>
        /// Botão "^"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPot_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Pow(α, β)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Pow(α, β)";
            }
            else
            {
                Display.Text += "Math.Pow(α, β)";
                groupBox2.Enabled = true;
                textBox2.Enabled = true;

                if (messagebox == true)
                {
                    MessageBox.Show("  Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + " (Math.Pow(Math.Pow(α, β), X), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar" +
                                " o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a" +
                                " estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }

        #endregion Botões de Cálculo avançado

        #region Botões de Tomada de decisão

        /// <summary>
        /// Botão de Substituição de "α" e "β"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubstituicao_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Replace("α", textBox1.Text);

            if (Display.Text.IndexOf("β") != 1)
            {
                Display.Text = Display.Text.Replace("β", textBox2.Text);
            }

            textBox1.Text = "";
            textBox2.Text = "";

            groupBox2.Enabled = false;
            Display.Enabled = true;

        }

        /// <summary>
        /// Botão para calcular Bolzano
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBolzano_Click(object sender, EventArgs e)
        {
            BtnBolzano.UseWaitCursor = true;
            comboBox1.Items.Clear();
            Raizes.Clear();


            // Controle de Exceção para a entrada em "double"
            try
            {                
                double E = Double.Parse(comboBox2.Text);
                label7.Visible = true;

                // double divisorA = 0, divisorB = 0;
                double a = 0, b = 0;

                //Identifica se o número tem vírgula no número "a"
                if (textBox3.Text.IndexOf(',') != -1) 
                {
                     //Lógica ainda não utilizada!
                     //divisorA = Math.Pow(10.00, (textBox3.Text.Length - (textBox3.Text.IndexOf(',') + 1.00)));
                     a = Convert.ToDouble(textBox3.Text);
                }
                else
                {
                    a = double.Parse(textBox3.Text);
                }

                //Identifica se o número tem vírgula no número "b"
                if (textBox4.Text.IndexOf(',') != -1) 
                {
                    //Lógica ainda não utilizada!
                    // divisorB = Math.Pow(10.00, (textBox4.Text.Length - (textBox3.Text.IndexOf(',') + 1.00)));
                    b = Convert.ToDouble(textBox4.Text);
                }
                else
                {
                    b = double.Parse(textBox4.Text);
                }

                // Verifica se o "a" é maior do que o "b",
                //se for, apaga as textBox's e abre uma mes-
                //sageBox avisando para digitar corretamente.
                if (a > b)
                {
                    MessageBox.Show("Digite um valor de 'a' menor do que o valor de 'b'!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                // Se não for, realiza o cálculo!
                else
                {
                    double i = a + E;


                    do
                    {
                        // Substituição da "," por  "." para não dar erro
                        string x = i.ToString().Replace(",", ".");
                        string y = (i - E).ToString().Replace(",", ".");

                        // Definições das funções utilizando os valores do 
                        //intervalo pré-estabelecidos
                        string alfa = Display.Text.Replace("X", x);
                        string beta = Display.Text.Replace("X", y);

                        double aux1a, aux1b;

                        // Utilização da Classe "Eval" para trasnformar a
                        //função do formato "string" para o seu valor real
                        aux1a = Convert.ToDouble(EvalCSCode.Eval(alfa));
                        aux1b = Convert.ToDouble(EvalCSCode.Eval(beta));

                        // Lógicas para definir o maior e o menor
                        if (aux1a >= 0 && aux1b < 0)
                        {
                            Raizes.Add($"{i - E}; {i}");
                        }
                        else if (aux1a < 0 && aux1b >= 0)
                        {
                            Raizes.Add($"{i}; {i - E}");
                        }

                        i += E;

                    } while (i <= b); // O laço termina quando atingir o maior
                                      //valor estabelecido pelo usuário

                    // Laço para adicionar as raízes na comboBox
                    for (int j = 0; j < Raizes.Count; j++)
                        comboBox1.Items.Add(Raizes.ElementAt(j));

                    label7.Visible = false;
                    BtnBolzano.UseWaitCursor = false;
                    BtnTabela.Enabled = true;

                    // Adiciona os valores da primeira Raíz encontrada nas
                    //textBox para facilitar o novo calculo do Bolzano.
                    // Se não houver raíz no intervalo selecionado, entrará
                    //no controle de exceção
                    try
                    {
                        string[] valores = Raizes[0].Split(';');
                        textBox3.Text = valores[1].Trim();
                        textBox4.Text = valores[0].Trim();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível encontrar raízes no intervalo selecionado. Tente outro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Digite um valor válido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        /// <summary>
        /// Botão para calcular função ou Defini-la
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            // Se a função digitada não possuir "x" ou "x",
            //será cálculado o valor real da equação
            if (Display.Text.IndexOf("X") == -1 && Display.Text.IndexOf("x") == -1)
            {
                double aux = Convert.ToDouble(EvalCSCode.Eval(Display.Text));
                aux = Math.Round(aux, 6);
                Display.Text = aux.ToString();
            }
            // Se possuir, será "levado" para o álculo do
            //Bolzano e da Bissecção
            else
            {
                groupBox3.Enabled = true;
            }

            // Compartilhamento de dados entre formulários
            DadosCompartilhados.formula = Display.Text;

        }

        /// <summary>
        /// Botão responsável por abrir o formulário
        /// referente à tabela da bissecção.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTabela_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma Raíz", "DADOS INCOMPLETOS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
                Tabela tabela = new Tabela();
                string[] Raizes1 = Raizes.ToArray();
                DadosCompartilhados.raizes = Raizes1;
                Hide();
                tabela.ShowDialog();
            
        }

        /// <summary>
        /// Botão responsável por abrir o formuário 
        /// referente à ajuda de referências das funções
        /// da calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Ajuda1 ajuda = new Ajuda1();
            ajuda.ShowDialog();
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnTabela.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
