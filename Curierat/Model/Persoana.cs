namespace Curierat.Model
{
    public class Persoana
    {
        protected string nume;
        protected uint legitimatie;

        public Persoana()
        {
            this.nume = "";
            this.legitimatie = 0;
        }

        public Persoana(string nume, uint legitimatie)
        {
            this.nume = nume;
            this.legitimatie = legitimatie;
        }

        public Persoana(Persoana p)
        {
            this.nume = p.nume;
            this.legitimatie = p.legitimatie;
        }

        public string AccesNume()
        {
            return this.nume;
        }

        public uint AccesLegitimatie()
        {
            return this.legitimatie;
        }

        public void ActualizareNume(string nume)
        {
            this.nume = nume;
        }

        public void ActualizareLegitimatie(uint legitimatie)
        {
            this.legitimatie = legitimatie;
        }

        public override string ToString()
        {
            return this.legitimatie.ToString() + ";" + this.nume;
        }


    }
}
