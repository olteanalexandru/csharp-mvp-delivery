namespace Curierat.Model
{
    public class Utilizator : Persoana
    {
        private string cont;
        private string parola;
        private string rol;

        public Utilizator() : base()
        {
            this.cont = "";
            this.parola = "";
            this.rol = "";
        }

        public Utilizator(string nume, uint legitimatie, string cont, string parola, string rol)
              : base(nume, legitimatie)
        {
            this.cont = cont;
            this.parola = parola;
            this.rol = rol;
        }

        public Utilizator(Utilizator u)
        {
            this.nume = u.nume;
            this.legitimatie = u.legitimatie;
            this.cont = u.cont;
            this.parola = u.parola;
            this.rol = u.rol;
        }

        public string AccesCont()
        {
            return this.cont;
        }

        public string AccesParola()
        {
            return this.parola;
        }

        public string AccesRol()
        {
            return this.rol;
        }

        public void ActualizareCont(string cont)
        {
            this.cont = cont;
        }

        public void ActualizareParola(string parola)
        {
            this.parola = parola;
        }

        public void ActualizareRol(string rol)
        {
            this.rol = rol;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += ";" + this.cont + ";" + this.parola + ";" + this.rol;
            return s;
        }
    }
}
