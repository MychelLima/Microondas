using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    public class TimerMicroondas : Form1
    {
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public static readonly TimerMicroondas Instance = new TimerMicroondas();

        public TimerMicroondas() { }

        public void ParseSeconds()
        {
            if (Segundos > 60)
            {
                Minutos = Segundos / 60;
                Segundos %= 60;
            }

        }

        public void AddSegundos (int segundos)
        {
            if (Minutos != 0)
            {
                Segundos += (Minutos * 60);
            }

            Segundos += (segundos + 1);

            ParseSeconds();
        }

        public void CountDown()
        {
            if (Minutos > 0 || Segundos > 0)
            {
                Segundos--;

                if (Segundos < 0)
                {
                    if (Minutos > 0)
                    {
                        Minutos--;
                        Segundos = 59;
                    }
                }
            }

        }

        public void CounterReset()
        {
            Minutos  = 0;
            Segundos = 0;
        }
    }
}
