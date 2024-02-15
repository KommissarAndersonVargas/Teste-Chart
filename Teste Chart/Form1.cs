using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Teste_Chart
{
    public partial class Form1 : Form
    {
        int inc = 0;
        int inc2 = 1;

        public Form1()
        {
         

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.ForeColor = Color.Yellow;
            progressBar1.Step = 1;
            int valor = 10;

            progressBar1.Value = valor + progressBar1.Value;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GerarColunas();
                Title title = new Title();
                title.Font = new Font("Arial", 14, FontStyle.Bold);
                title.ForeColor = Color.Blue;
                title.Text = "Memoria x Tempo";
                chart1.Titles.Add(title);
            }
            catch(Exception EX)
            {
                MessageBox.Show("Erro: " + EX);
            }

        }
        private void GerarColunas()
        {
            /*
            Title title  = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.BlueViolet;
            title.Text = "Vendas";
            chart1.Titles.Add(title);
            

            chart1.Series.Add("vendas");
            chart1.Series["vendas"].LegendText = "Vendas";
            chart1.Series["vendas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart1.Series["vendas"].Points.AddXY("Janeiro", 140);
            chart1.Series["vendas"].Points.AddXY("Fevereiro",60);

            */

            try
            {
                chart1.Series[0].Points.AddXY(3, 7);
                chart1.Series[0].Points.AddXY(4, 9);
            }

            catch (Exception EX)
            {
                MessageBox.Show("Erro: " + EX);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 string dado = textBox1.Text.ToString();
                 chart1.Series["vendas"].Points.AddXY(dado, inc = inc + 20);
                 */
                chart1.Series[0].Points.AddXY(inc2 = 1 + inc2, inc = inc + 3);

            }
            catch (Exception EX)
            {
                MessageBox.Show("Erro: " + EX);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.AddXY(inc2 = 1 + inc2, inc = inc - 1);
            }
            catch (Exception EX)
            {
                MessageBox.Show("Erro: " + EX);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

