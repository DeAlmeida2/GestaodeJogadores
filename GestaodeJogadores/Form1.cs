using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaodeJogadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_gravar_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_nomeJogador.Text.Equals(" "))
            {
                MessageBox.Show("É preciso inserir algum nome na lista", "Alerta!");
                return;
            }
            
            
            //transformar nome em maiúsculo
            textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();

            String email;

            //gravar numa lista desde que não seja lista
            if (Jogador.jaCadastrado(textBox_nomeJogador.Text, listaJogadores))
            {
                MessageBox.Show("Jogador já Cadastrado!", "Alerta");
            } else
            {

                string[] vetorNomes = textBox_nomeJogador.Text.ToLower().Split(' '); // verificar no cod fonte

                if (vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";
                } else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }


                listaJogadores.Add(new Jogador(textBox_nomeJogador.Text, email));
                textBox_listaJogadores.AppendText(textBox_nomeJogador.Text + " - " + email + Environment.NewLine);

                StreamWriter escritor = new StreamWriter("jogadores.dat", true); //criar arquivo!!!

                escritor.WriteLine(textBox_nomeJogador.Text + ";" + email);

                escritor.Close();
            }
            textBox_nomeJogador.Text = "";

        }

        private void button_gravar_Click(object sender, EventArgs e)
        {

        }

        private void button_limpar_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_nomeJogador.Text = "";
            textBox_listaJogadores.Text = "";
            listaJogadores.Clear();
        }
        List<Jogador> listaJogadores = new List<Jogador>();
    }
}
