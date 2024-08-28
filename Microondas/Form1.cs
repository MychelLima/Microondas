using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public partial class Form1 : Form
    {
        protected bool StatusMicroondas;
        protected bool displayPotencia = false;
        private string tempoDigitado = "";
        private string potenciaDigitada = "";
        private string avisoTempo;
        private string avisoPotencia;

        public Form1()
        {
            InitializeComponent();
        }

        public void AddTemporizador(int segundos) 
        {
            TimerMicroondas.Instance.AddSegundos(segundos);
            StatusMicroondas = true;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "1";
                txtPotencia.Text += potenciaDigitada;
            } else {
                if (avisoTempo != "") 
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "1";
                txtTimer.Text += tempoDigitado;
            }
                
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "2";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "2";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "3";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "3";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "4";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "4";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "5";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "5";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "6";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "6";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "7";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "7";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "8";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "8";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "9";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "9";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (displayPotencia)
            {
                potenciaDigitada = "0";
                txtPotencia.Text += potenciaDigitada;
            }
            else
            {
                if (avisoTempo != "")
                {
                    txtTimer.Text = "";
                    avisoTempo = "";
                }
                tempoDigitado = "0";
                txtTimer.Text += tempoDigitado;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (StatusMicroondas || TimerMicroondas.Instance.Minutos == 0 && TimerMicroondas.Instance.Segundos == 0)
            {
                if (txtTimer.Text != "")
                {
                    var tempo = int.Parse(txtTimer.Text);
                    if (tempo < 1 || tempo > 120) 
                    {   
                        avisoTempo = "TEMPO NÃO PERMITIDO! INFORME ENTRE 1 Á 120 SEGUNDOS!";
                        txtTimer.Text = avisoTempo;

                    } else {

                        if (txtPotencia.Text == "")
                        {
                            txtPotencia.Text = "10";
                        }
                        var potencia = int.Parse(txtPotencia.Text);
                        if (potencia < 1 || potencia > 10) 
                        {
                            avisoPotencia = "POTÊNCIA INVÁLIDA!";
                            txtPotencia.Text = avisoPotencia;
                        } else {
                            TimerMicroondas.Instance.AddSegundos(tempo);
                            StatusMicroondas = true;
                        }                       
                    }    
                } else {
                    txtPotencia.Text = "10";
                    TimerMicroondas.Instance.AddSegundos(30);
                    StatusMicroondas = true;
                }
            }
        }

        private void btnPausarCancelar_Click(object sender, EventArgs e)
        {
            if (!StatusMicroondas)
            {
                TimerMicroondas.Instance.CounterReset();
                txtTimer.Text = "";
                txtPotencia.Text = "";
            }

            StatusMicroondas = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StatusMicroondas) 
            {
                TimerMicroondas.Instance.CountDown();
                txtTimer.Text = string.Format("{0}:{1}", TimerMicroondas.Instance.Minutos.ToString().PadLeft(2, '0'), TimerMicroondas.Instance.Segundos.ToString().PadLeft(2, '0'));
            }       
        }

        private void AdicionaTempo(int segundos)
        {
            TimerMicroondas.Instance.AddSegundos(segundos);
            StatusMicroondas = true;
        }

        private void btnPipoca_Click(object sender, EventArgs e)
        {
            TimerMicroondas.Instance.CounterReset();
            txtTimer.Text = "";
            txtPotencia.Text = "";
            AdicionaTempo(180);
            txtPotencia.Text = "7";
        }

        private void btnLeite_Click(object sender, EventArgs e)
        {
            TimerMicroondas.Instance.CounterReset();
            txtTimer.Text = "";
            txtPotencia.Text = "";
            AdicionaTempo(300);
            txtPotencia.Text = "5";
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            TimerMicroondas.Instance.CounterReset();
            txtTimer.Text = "";
            txtPotencia.Text = "";
            AdicionaTempo(840);
            txtPotencia.Text = "4";
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            TimerMicroondas.Instance.CounterReset();
            txtTimer.Text = "";
            txtPotencia.Text = "";
            AdicionaTempo(480);
            txtPotencia.Text = "7";
        }

        private void btnFeijao_Click(object sender, EventArgs e)
        {
            TimerMicroondas.Instance.CounterReset();
            txtTimer.Text = "";
            txtPotencia.Text = "";
            AdicionaTempo(480);
            txtPotencia.Text = "9";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            txtPotencia.Text = "";
            displayPotencia = true;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            displayPotencia = false;
        }
    }
}
