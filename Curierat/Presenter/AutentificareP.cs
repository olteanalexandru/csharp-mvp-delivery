using Curierat.Model;
using Curierat.Model.Persistenta;
using Curierat.View;
using System.Windows.Forms;

namespace Curierat.Presenter
{
        public class AutentificareP
        {
            private IAutentificare aV;
            private UtilizatorPersistent utP;
            public AutentificareP(IAutentificare aV)
            {
                this.aV = aV;
                this.utP = new UtilizatorPersistent();
            }

       
            public void Logare()
            {
                string user = this.aV.AccesUser();
                string parola = this.aV.AccesParola();
                Utilizator ut = this.utP.CautareUtilizator(user, parola);
                if (ut == null)
                {
                    MessageBox.Show("Nu exista niciun cont cu datele specificate!");
                    this.aV.ActualizareUser();
                    this.aV.ActualizareParola();
                    AutentificareV autentificareV = new AutentificareV();
                    autentificareV.Show();
                }
                else
                {
                    string rol = ut.AccesRol();
                    if (rol.ToUpper() == "ADMINISTRATOR")
                    {
                        AutentificareV autentificareV = new AutentificareV();
                        autentificareV.Hide();
                        AdministratorV admV = new AdministratorV();
                        admV.Show();
                    }
                else if (rol.ToUpper() == "COORDONATOR")  
                    {
                        AutentificareV autentificareV = new AutentificareV();
                        autentificareV.Hide();
                        CoordonatorV coordonatorV = new CoordonatorV();
                        coordonatorV.Show();
                    }
                    else
                {
                    AutentificareV autentificareV = new AutentificareV();
                    autentificareV.Hide();
                    CurierV curierV = new CurierV();
                    curierV.Show();
                }
                }
            }
        }
    }
