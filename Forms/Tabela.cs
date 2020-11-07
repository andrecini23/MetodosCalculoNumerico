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
    public partial class Tabela : Form
    {


        public Tabela()
        {

            InitializeComponent();

        }
        
        /// <summary>
        /// Botão responsável para abrir o formulário refente à
        /// ajuda sobre o que é a Bissecção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();

        }

        /// <summary>
        /// Quando o formulário inicia, são puxados os 
        /// dados compartilhados entre os formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            string[] Raizes = new string[DadosCompartilhados.raizes.Length];
            Raizes = DadosCompartilhados.raizes;

            // As Raízes são adicionadas na comboBox
            for (int i = 0; i < Raizes.Length; i++)
            {
                cmb1.Items.Add(Raizes[i]);
            }
        }

        // Cria uma tabela de dados na memória
        DataTable Tbl;

        /// <summary>
        /// Método para gerar o grid referente a tabela da Bissecção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Indica que está carregando
            button1.UseWaitCursor = true;
            
            // Instância a Tabela
            Tbl = new DataTable();

            // Define o tipo e o texto das colunas a serem utilizadas
            Tbl.Columns.Add("Rodada", typeof(double));
            Tbl.Columns.Add("a", typeof(double));
            Tbl.Columns.Add("f(a)", typeof(double));
            Tbl.Columns.Add("b", typeof(double));
            Tbl.Columns.Add("f(b)", typeof(double));
            Tbl.Columns.Add("Xk", typeof(double));
            Tbl.Columns.Add("f(Xk)", typeof(double));
            Tbl.Columns.Add("Precisao", typeof(double));

            // Cria uma Linha do Grid
            DataRow Linha;

            // Contador
            int x = 1;

            // Criação das variáveis
            double[] valorA = new double[x], valorB = new double[x], valorXk = new double[x];
            double[] rodadas = new double[x], precisao = new double[x], funcaoDeA = new double[x],
            funcaoDeB = new double[x], funcaoDeXk = new double[x];

            // Variável referente ao "Erro"
            double E = Double.Parse(textBox1.Text);

            // Separa os valores de "a" e "b" informados
            //na raíz selecionada na comboBox
            string a = cmb1.Text.Substring(0, cmb1.Text.IndexOf(";"));
            string b = cmb1.Text.Substring(cmb1.Text.IndexOf(";") + 1, cmb1.Text.Length - (cmb1.Text.IndexOf(";") + 1));

            // Transforma as variáveis "a" e "b" em "double"
            double aa = Double.Parse(a);
            double bb = Double.Parse(b);

            // Adiciona o valor no vetor
            valorA[0] = aa;
            valorB[0] = bb;

            // Recebe a fórmula digitada no Form1.cs através dos 
            //dados compartilhados
            string formula = DadosCompartilhados.formula;

            // Substitui a "," por "." parra realizar o cálculo
            string formulaA = formula.Replace("X", a.Replace(",", "."));
            string formulaB = formula.Replace("X", b.Replace(",", "."));

            // Define qual valor real das funções é maior 
            if ((Convert.ToDouble(EvalCSCode.Eval(formulaA))) > (Convert.ToDouble(EvalCSCode.Eval(formulaB))))
            {
                funcaoDeA[0] = Convert.ToDouble(EvalCSCode.Eval(formulaA));
                funcaoDeB[0] = Convert.ToDouble(EvalCSCode.Eval(formulaB));
            }
            else
            {
                funcaoDeA[0] = Convert.ToDouble(EvalCSCode.Eval(formulaB));
                funcaoDeB[0] = Convert.ToDouble(EvalCSCode.Eval(formulaA));
                double aux = valorB[0];
                valorB[0] = valorA[0];
                valorA[0] = aux;
            }

            // Define o valor de Xk no vetor
            valorXk[0] = (Convert.ToDouble(valorA[0]) + Convert.ToDouble(valorB[0])) / 2;

            // Lógica para substituir a "," por "."
            string Xk = valorXk[0].ToString();
            Xk = Xk.Replace(",", ".");

            // Substitui os o "X", por "Xk" para utilização do Eval
            string formulaXk = formula.Replace("X", Xk);

            // Calcula a função de F(Xk) 
            funcaoDeXk[0] = Convert.ToDouble(EvalCSCode.Eval(formulaXk));
            rodadas[0] = 0;

            // Laço para as rodadas
            for (x = 1; x > -1; x++)
            {
                // Define a precisão do cálculo
                precisao[x - 1] = valorXk[x - 1] - valorA[x - 1];

                // Define o módulo da precisão
                if (precisao[x - 1] < 0)
                {
                    precisao[x - 1] = -precisao[x - 1];
                }

                // Verifica se o "Erro" é maior do que a precisão 
                //definida para poder continuar o laço
                if (precisao[x - 1] < E)
                {
                    // Cria uma nova linha
                    Linha = Tbl.NewRow();

                    //Define o que vai em cada celula da linha
                    Linha[0] = Math.Round(rodadas[x - 1], 7);
                    Linha["a"] = Math.Round(valorA[x - 1], 7);
                    Linha["f(a)"] = Math.Round(funcaoDeA[x - 1], 7);
                    Linha["b"] = Math.Round(valorB[x - 1], 7);
                    Linha["f(b)"] = Math.Round(funcaoDeB[x - 1], 7);
                    Linha["Xk"] = Math.Round(valorXk[x - 1], 7);
                    Linha["f(Xk)"] = Math.Round(funcaoDeXk[x - 1], 7);
                    Linha["Precisao"] = Math.Round(precisao[x - 1], 7);

                    // Adiciona a linha na Tabela de dados
                    Tbl.Rows.Add(Linha);

                    // Termina o laço
                    break;
                }
                
                // redefine o tamanho do array para realizar mais uma rodada
                Array.Resize(ref valorA, x + 1);
                Array.Resize(ref valorB, x + 1);
                Array.Resize(ref funcaoDeA, x + 1);
                Array.Resize(ref funcaoDeB, x + 1);
                Array.Resize(ref valorXk, x + 1);
                Array.Resize(ref funcaoDeXk, x + 1);
                Array.Resize(ref rodadas, x + 1);
                Array.Resize(ref precisao, x + 1);

                // Verificações par ver se o sinal da função de Xk mudou
                if (funcaoDeXk[x - 1] > 0)
                {
                    valorA[x] = valorXk[x - 1];
                    valorB[x] = valorB[x - 1];
                }
                else if (funcaoDeXk[x - 1] < 0)
                {
                    valorB[x] = valorXk[x - 1];
                    valorA[x] = valorA[x - 1];
                }
                else
                {
                    break;
                }

                // Substituição da "," por "."
                a = valorA[x].ToString();
                a = a.Replace(",", ".");
                b = valorB[x].ToString();
                b = b.Replace(",", ".");

                // Conversão de "string" patra "double"
                aa = Double.Parse(a);
                bb = Double.Parse(b);

                // Substituição de "X" por "a" e "b" para
                //para calculos futuros
                formulaA = formula.Replace("X", a);
                formulaB = formula.Replace("X", b);

                // Cálculos das funções de "F(a)" e "F(b)"
                funcaoDeA[x] = Convert.ToDouble(EvalCSCode.Eval(formulaA));
                funcaoDeB[x] = Convert.ToDouble(EvalCSCode.Eval(formulaB));

                // Definição do valor de "F(X)"
                valorXk[x] = (valorA[x] + valorB[x]) / 2;
                Xk = valorXk[x].ToString();
                Xk = Xk.Replace(",", ".");

                // Substitui na fórmula "X" pelo valor de "Xk"
                formulaXk = formula.Replace("X", Xk);

                // Utilização do eval para calcular o "Xk"
                funcaoDeXk[x] = Convert.ToDouble(EvalCSCode.Eval(formulaXk));

                // Contador do número de rodadas
                rodadas[x] = x;

                // Criação de uma nova linha
                Linha = Tbl.NewRow();

                // Definição das células da linha criada
                Linha[0] = Math.Round(rodadas[x - 1], 7);
                Linha["a"] = Math.Round(valorA[x - 1], 7);
                Linha["f(a)"] = Math.Round(funcaoDeA[x - 1], 7);
                Linha["b"] = Math.Round(valorB[x - 1], 7);
                Linha["f(b)"] = Math.Round(funcaoDeB[x - 1], 7);
                Linha["Xk"] = Math.Round(valorXk[x - 1], 7);
                Linha["f(Xk)"] = Math.Round(funcaoDeXk[x - 1], 7);
                Linha["Precisao"] = Math.Round(precisao[x - 1], 7);

                // Adiciona a linha na Tabela de dados
                Tbl.Rows.Add(Linha);
            }

            // Adiciona a tabela no Grid
            TabelaBisseccao.DataSource = Tbl;

            // Indica que a geração da tabela foi finalizada
            button1.UseWaitCursor = false;
        }

        /// <summary>
        /// Serve para mpedir que a tabela seja 
        /// criada sem a definição do intervalo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        /// <summary>
        /// Botão referente ao formulário de "Ajuda"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Ajuda2 tela = new Ajuda2();
            tela.ShowDialog();
        }
    }
}
