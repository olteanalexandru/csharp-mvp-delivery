using System;
using System.Windows.Forms;

namespace Curierat.Model
{
    public class Colet
    {
        private int cod_colet;
        private string locatie;
        private string livrator;
        private string traseuoptim;
        public Colet()
        {
            this.cod_colet = 0;
            this.locatie = "";
            this.livrator = "";
            this.traseuoptim = "";

        }
        public Colet(int cod_colet, string locatie, string livrator ,string traseuoptim)
        {
            this.cod_colet = cod_colet;
            this.locatie = locatie;
            this.livrator = livrator;
            this.traseuoptim = traseuoptim;
        }

        public Colet(Colet m)
        {
            this.cod_colet = m.cod_colet;
            this.locatie = m.locatie;
            this.livrator = m.livrator;
            this.traseuoptim=m.traseuoptim;
        }

        public int AccesCodColet()
        {
            return this.cod_colet;
        }
        public string AccesLocatie()
        {
            return this.locatie;
        }
        public string AccesLivrator()
        {
            return this.livrator;
        }
        public string AccesTraseuoptim()
        {
            return this.traseuoptim;
        }

        public void ActualizareCodColet(int cod_colet)
        {
            this.cod_colet = cod_colet;
        }
        public void ActualizareLocatie(string locatie)
        {
            this.locatie = locatie;
        }
        public void ActualizareLivrator(string livrator)
        {
            this.livrator = livrator;
        }
        public override string ToString()
        {

            return this.cod_colet.ToString() + ";" + this.locatie + ";" + this.livrator + ";" +this.traseuoptim;
        }
    }
}
