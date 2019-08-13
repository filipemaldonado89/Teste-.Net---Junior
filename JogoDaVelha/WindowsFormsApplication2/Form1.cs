using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int count, jogadorX, jogadorO, empate;

        public Form1()
        {
            InitializeComponent();
            InicializarJogadas();
        }

        List<Jogador> Casas = new List<Jogador>();
        private Jogador turno = Jogador.X;

        private void button1_Click(object sender, EventArgs e)
        {           
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;
            Metodos jogoDaVelha = new Metodos(this);

            btn.Enabled = false;
         
            Casas[buttonIndex] = turno;

            turno = (turno == Jogador.X) ? Jogador.O : Jogador.X;

            btn.Text = (turno == Jogador.X) ? "X" : "O";            

            if (jogoDaVelha.TemVencedor(Casas))
            {
                if (MessageBox.Show(this, "VENCEDOR: JOGADOR " + turno, "Jogo Da Velha", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {                    
                    if (turno.Equals(Jogador.X))
                        jogadorX++;
                    if (turno.Equals(Jogador.O))
                        jogadorO++;

                    jogoDaVelha.HabilitarBotoes(false);

                    pontosX.Text = Convert.ToString(jogadorX);
                    pontosO.Text = Convert.ToString(jogadorO);                    
                }
            }

            if (jogoDaVelha.Empatou(Casas) && !jogoDaVelha.TemVencedor(Casas))
            {
                empate++;
                MessageBox.Show("O jogo empatou!");
                empates.Text = Convert.ToString(empate);
            }

            jogadorVez.Text = (turno == Jogador.X) ? "O" : "X";
        }

        public void InicializarJogadas()
        {
            Metodos jogoDaVelha = new Metodos(this);

            Casas.Clear();

            jogadorVez.Text = (turno == Jogador.X) ? "O" : "X";

            button0.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            jogoDaVelha.HabilitarBotoes(true);

            button0.BackColor = System.Drawing.Color.White;
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;

            for (int i = 0; i < 9; i++)
                Casas.Add(Jogador.S);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pontosX.Text = "0";
            pontosO.Text = "0";
            empates.Text = "0";
            empate = 0;
            jogadorO = 0;
            jogadorX = 0;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            InicializarJogadas();
        } 
    }

}
