using System;
using System.Data;
using System.Windows.Forms;

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
            btnGerar.UseWaitCursor = true;

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


            // Contador
            int x = 1;

            try
            {
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
                double aa = Double.Parse(a.Trim());
                double bb = Double.Parse(b.Trim());

                // Adiciona o valor no vetor
                valorA[0] = aa;
                valorB[0] = bb;

                // Recebe a fórmula digitada no Form1.cs através dos 
                //dados compartilhados
                string formula = DadosCompartilhados.formula;

                // Substitui a "X" por "a" e "b" parra realizar o cálculo
                string formulaA = formula.Replace("X", TrocaVirgula(a));
                string formulaB = formula.Replace("X", TrocaVirgula(b));

                // Define qual valor real das funções é maior 
                if (UsoEval(formulaA) > UsoEval(formulaB))
                {
                    funcaoDeA[0] = UsoEval(formulaA);
                    funcaoDeB[0] = UsoEval(formulaB);
                }
                else
                {
                    funcaoDeA[0] = UsoEval(formulaB);
                    funcaoDeB[0] = UsoEval(formulaA);
                    double aux = valorB[0];
                    valorB[0] = valorA[0];
                    valorA[0] = aux;
                }

                // Define o valor de Xk no vetor
                valorXk[0] = (Convert.ToDouble(valorA[0]) + Convert.ToDouble(valorB[0])) / 2;

                // Lógica para substituir a "," por "."
                string Xk = valorXk[0].ToString();
                Xk = TrocaVirgula(Xk);

                // Substitui os o "X", por "Xk" para utilização do Eval
                string formulaXk = formula.Replace("X", Xk);

                // Calcula a função de F(Xk) 
                funcaoDeXk[0] = UsoEval(formulaXk);
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
                        // Método que retorna as linhas que serão
                        //adicionadas a tabela e depois no Grid
                        Linhas(rodadas, valorA, funcaoDeA, valorB, funcaoDeB, valorXk, funcaoDeXk, precisao, x);

                        // Termina o laço
                        break;
                    }

                    // redefine o tamanho do array para realizar mais uma rodada                    
                    RedefineTamanhoVetor(ref rodadas, ref valorA, ref funcaoDeA, ref valorB, ref funcaoDeB, ref valorXk, ref funcaoDeXk, ref precisao, x);
                    /*Array.Resize(ref rodadas, x + 1);
                    Array.Resize(ref valorA, x + 1);
                    Array.Resize(ref funcaoDeA, x + 1);
                    Array.Resize(ref valorB, x + 1);
                    Array.Resize(ref funcaoDeB, x + 1);
                    Array.Resize(ref valorXk, x + 1);
                    Array.Resize(ref funcaoDeXk, x + 1);
                    Array.Resize(ref precisao, x + 1);*/

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
                    a = TrocaVirgula(a);
                    b = valorB[x].ToString();
                    b = TrocaVirgula(b);

                    // Conversão de "string" patra "double"
                    aa = Double.Parse(a);
                    bb = Double.Parse(b);

                    // Substituição de "X" por "a" e "b" para
                    //para calculos futuros
                    formulaA = formula.Replace("X", a);
                    formulaB = formula.Replace("X", b);

                    // Cálculos das funções de "F(a)" e "F(b)"
                    funcaoDeA[x] = UsoEval(formulaA);
                    funcaoDeB[x] = UsoEval(formulaB);

                    // Definição do valor de "F(X)"
                    valorXk[x] = (valorA[x] + valorB[x]) / 2;
                    Xk = valorXk[x].ToString();
                    Xk = TrocaVirgula(Xk);

                    // Substitui na fórmula "X" pelo valor de "Xk"
                    formulaXk = formula.Replace("X", Xk);

                    // Utilização do eval para calcular o "Xk"
                    funcaoDeXk[x] = UsoEval(formulaXk);

                    // Contador do número de rodadas
                    rodadas[x] = x;

                    Linhas(rodadas, valorA, funcaoDeA, valorB, funcaoDeB, valorXk, funcaoDeXk, precisao, x);
                }

                // Adiciona a tabela no Grid
                TabelaBisseccao.DataSource = Tbl;
            }
            catch
            {
                MessageBox.Show("Digite números válidos pp", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Indica que a geração da tabela foi finalizada
            btnGerar.UseWaitCursor = false;
        }

        /// <summary>
        /// Serve para mpedir que a tabela seja 
        /// criada sem a definição do intervalo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGerar.Enabled = true;
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

       /// <summary>
       /// Método para trocar a "," de um número em string
       /// por "." para que o cálculo seja possível
       /// </summary>
       /// <param name="entrada"></param>
       /// <returns String com "."></returns>
        public string TrocaVirgula(string entrada)
        {
            string saida = entrada.Replace(",", ".");
            return saida;
        }

        // Ainda não está funcionando
        public void RedefineTamanhoVetor(ref double[] a, ref double[] b, ref double[] c, ref double[] d, ref double[] e, ref double[] f, ref double[] g, ref double[] h, int x)
        {
            Array.Resize(ref a, x + 1);
            Array.Resize(ref b, x + 1);
            Array.Resize(ref c, x + 1);
            Array.Resize(ref d, x + 1);
            Array.Resize(ref e, x + 1);
            Array.Resize(ref f, x + 1);
            Array.Resize(ref g, x + 1);
            Array.Resize(ref h, x + 1);
        }

        /// <summary>
        /// Método para chamar a classe eval e transformar
        /// a função (em string) em um valor em double
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns valor em double></returns>
        public double UsoEval(string entrada)
        {
            double saida = Convert.ToDouble(EvalCSCode.Eval(entrada));
            return saida;
        }

        /// <summary>
        /// Cria e coloca as Linhas no Grig
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        /// <param name="h"></param>
        /// <param name="x"></param>
        public void Linhas(double[] a, double[] b, double[] c, double[] d, double[] e, double[] f, double[] g, double[] h, int x)
        {
            DataRow Linha;

            // Cria uma nova linha
            Linha = Tbl.NewRow();

            //Define o que vai em cada celula da linha
            Linha[0] = Math.Round(a[x - 1], 7);
            Linha["a"] = Math.Round(b[x - 1], 7);
            Linha["f(a)"] = Math.Round(c[x - 1], 7);
            Linha["b"] = Math.Round(d[x - 1], 7);
            Linha["f(b)"] = Math.Round(e[x - 1], 7);
            Linha["Xk"] = Math.Round(f[x - 1], 7);
            Linha["f(Xk)"] = Math.Round(g[x - 1], 7);
            Linha["Precisao"] = Math.Round(h[x - 1], 7);

            // Adiciona a linha na Tabela de dados
            Tbl.Rows.Add(Linha);
        }

    }
}
