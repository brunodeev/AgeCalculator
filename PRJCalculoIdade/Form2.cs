using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJCalculoIdade
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome, ano;
            nome = txtNome.Text;
            ano = txtAno.Text;

            if (nome != "" && ano != "")
            {
                double sub = double.Parse(ano);
                double result = 2022 - sub;

                MessageBox.Show($"{nome}, sua idade é {result}, levando em conta que você já tenha feito aniversário esse ano!");
            }
            else if (ano == "" && nome != "")
            {
                MessageBox.Show($"Ah, {nome}, faltam informações para serem completadas!");
            }
            else
            {
                MessageBox.Show($"Poxa, eu não sei seu nome :´(");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAno.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
