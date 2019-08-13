using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public class Metodos
    {

        Form1 form;
        public Metodos(Form1 form)
        {
            this.form = form;
        }


        public Boolean TemVencedor(List<Jogador> jogadas)
        {
            if (this.checarDiagonal(jogadas) || this.checarVertical(jogadas) || this.checarHorizontal(jogadas))
            {
                return true;
            }
            return false;
        }

        public Boolean Empatou(List<Jogador> jogadas)
        {
            int count = 0;
            foreach (Jogador jogador in jogadas)
            {
                if (jogador == Jogador.S)
                {
                    count++;
                }
            }
            return (count == 0) ? true : false;

        }

        private bool checarDiagonal(List<Jogador> jogadas)
        {
            if ((jogadas[0] == jogadas[4] && jogadas[0] == jogadas[8]) && (jogadas[0] != Jogador.S))
            {

                form.button0.BackColor = System.Drawing.Color.Red;
                form.button4.BackColor = System.Drawing.Color.Red;
                form.button8.BackColor = System.Drawing.Color.Red;
                return true;
            }

            if ((jogadas[2] == jogadas[4] && jogadas[2] == jogadas[6]) && (jogadas[2] != Jogador.S))
            {
                form.button2.BackColor = System.Drawing.Color.Red;
                form.button4.BackColor = System.Drawing.Color.Red;
                form.button6.BackColor = System.Drawing.Color.Red;
                return true;
            }

            return false;
        }

        private bool checarVertical(List<Jogador> jogadas)
        {
            if (jogadas[0] == jogadas[3] && jogadas[0] == jogadas[6] && jogadas[0] != Jogador.S)
            {
                form.button0.BackColor = System.Drawing.Color.Red;
                form.button3.BackColor = System.Drawing.Color.Red;
                form.button6.BackColor = System.Drawing.Color.Red;
                return true;
            }
            if (jogadas[1] == jogadas[4] && jogadas[1] == jogadas[7] && jogadas[1] != Jogador.S)
            {
                form.button1.BackColor = System.Drawing.Color.Red;
                form.button4.BackColor = System.Drawing.Color.Red;
                form.button7.BackColor = System.Drawing.Color.Red;
                return true;
            }
            if (jogadas[2] == jogadas[5] && jogadas[2] == jogadas[8] && jogadas[2] != Jogador.S)
            {
                form.button2.BackColor = System.Drawing.Color.Red;
                form.button5.BackColor = System.Drawing.Color.Red;
                form.button8.BackColor = System.Drawing.Color.Red;
                return true;
            }
            return false;
        }

        private bool checarHorizontal(List<Jogador> jogadas)
        {
            if (jogadas[0] == jogadas[1] && jogadas[0] == jogadas[2] && jogadas[0] != Jogador.S)
            {
                form.button0.BackColor = System.Drawing.Color.Red;
                form.button1.BackColor = System.Drawing.Color.Red;
                form.button2.BackColor = System.Drawing.Color.Red;
                return true;
            }
            if (jogadas[3] == jogadas[4] && jogadas[3] == jogadas[5] && jogadas[3] != Jogador.S)
            {
                form.button3.BackColor = System.Drawing.Color.Red;
                form.button4.BackColor = System.Drawing.Color.Red;
                form.button5.BackColor = System.Drawing.Color.Red;
                return true;
            }
            if (jogadas[6] == jogadas[7] && jogadas[6] == jogadas[8] && jogadas[8] != Jogador.S)
            {
                form.button6.BackColor = System.Drawing.Color.Red;
                form.button7.BackColor = System.Drawing.Color.Red;
                form.button8.BackColor = System.Drawing.Color.Red;
                return true;
            }
            return false;
        }

        public void HabilitarBotoes(bool p)
        {
            form.button0.Enabled = p;
            form.button1.Enabled = p;
            form.button2.Enabled = p;
            form.button3.Enabled = p;
            form.button4.Enabled = p;
            form.button5.Enabled = p;
            form.button6.Enabled = p;
            form.button7.Enabled = p;
            form.button8.Enabled = p;
        }



    }
}
