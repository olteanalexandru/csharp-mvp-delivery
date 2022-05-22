using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Curierat.Model;
using Curierat.Model.Persistenta;
using Curierat.View;

namespace Curierat.Presenter
{
    public class CoordonatorP
    {
        private ICoordonator colV;
        private ColetPersistent colP;

        public CoordonatorP(ICoordonator colV)
        {
            this.colV = colV;
            this.colP = new ColetPersistent();
        }



        public void VizualizareListaColete()
        {
            List<Colet> lista = this.colP.ListaColete();

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Colet ut in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesCodColet().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesLocatie() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesLivrator() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesTraseuoptim() });
                    randuri.Add(rand);
                }
                this.colV.ActualizareListaColete(randuri);
            }
            else
                MessageBox.Show("Lista coletelor este vida!");
        }
        public void AdaugareColet()
        {
            bool dateCorecte = true;
            int rolSelectat = this.colV.AccesLivrator();

            if (rolSelectat < 0 || colV.AccesCodColet().Equals("") || colV.AccesLocatie().Equals(""))
            {
                dateCorecte = false;
                MessageBox.Show("Nu au fost introduse toate datele necesare!!");
            } else {
                uint cod_colet;
                string livrator = "DA";
                if (rolSelectat == 1)
                    livrator = "NU";



                string codm = this.colV.AccesCodColet();
                string Locatie  = this.colV.AccesLocatie();

                string traseuoptim="";

                switch (Locatie)
                {
                    case "Cluj":
                        traseuoptim = "prioriatar";
                        break;
                    case "Turda":
                        traseuoptim = "Daca s-au terminat coletele in Cluj";
                        break;
                    case "Floresti":
                        traseuoptim = "Dupa Cluj si Turda";
                        break;

                }





                if (livrator == "")
                {
                    MessageBox.Show("Nu au fost introduse toate datele necesare");
                    dateCorecte = false;
                }

                bool conversie = uint.TryParse(codm, out cod_colet);
                if (conversie)
                {
                    cod_colet = Convert.ToUInt32(codm);
                    if (cod_colet == 0)
                    {
                        dateCorecte = false;
                        MessageBox.Show("ID-ul nu poate fi 0!");
                    }
                }

                if ((!Regex.IsMatch(codm, @"^\d+$")) && codm != "")
                {
                    MessageBox.Show("ID-ul trebuie sa fie compus din cifre!!!");
                    dateCorecte = false;
                }
               
                if (this.colP.CautareColet((int)cod_colet) != null)
                {
                    MessageBox.Show("Exista alt colet cu acest cod!");
                    dateCorecte = false;
                }
                else
                {
                    string locatie = this.colV.AccesLocatie();

                    if (dateCorecte)
                    {
                        Colet ut = new Colet((int)cod_colet, locatie, livrator , traseuoptim);
                        bool succes = this.colP.AdaugareColet(ut);
                        if (!succes)
                            MessageBox.Show("Eroare la adaugare!");
                        else
                            this.VizualizareListaColete();
                    }
                }
            }
        }
        public void ActualizareaColet()
        {
            int codcol = this.colV.AccesCodColetSelectat();
            int rolSelectat = this.colV.AccesLivrator();
            if (codcol == -1)
                MessageBox.Show("Nu s-a selectat niciun colet!");
            else
            {

                bool dateCorecte = true;
                int dispSelectat = this.colV.AccesLivrator();
                string livrator;
                string txtCodCol;
                uint codColNou;

                livrator = "DA";
                if (rolSelectat == 1)
                    livrator = "NU";

                string Locatie = this.colV.AccesLocatie();

                string traseuoptim = "";

                switch (Locatie)
                {
                    case "Cluj":
                        traseuoptim = "prioriatar";
                        break;
                    case "Turda":
                        traseuoptim = "Daca s-au terminat coletele in Cluj";
                        break;
                    case "Floresti":
                        traseuoptim = "Dupa Cluj si Turda";
                        break;

                }


                txtCodCol = this.colV.AccesCodColet();

                bool conversie = uint.TryParse(txtCodCol, out codColNou);
                if (conversie)
                {
                    codColNou = Convert.ToUInt32(txtCodCol);
                    if (codColNou == 0)
                    {
                        dateCorecte = false;
                        MessageBox.Show("ID-ul nu poate fi 0!");
                    }
                }
                if ((!Regex.IsMatch(txtCodCol, @"^\d+$")) && txtCodCol != "")
                {
                    MessageBox.Show("ID-ul trebuie sa fie compus din cifre!!!");
                    dateCorecte = false;
                }


                if (this.colP.CautareColet((int)codColNou) != null)
                {
                    MessageBox.Show("Exista alt colet cu acest cod!");
                    dateCorecte = false;
                }
                else
                {
                    if (codColNou == 0)
                        codColNou = (uint)codcol;
                    string locatie = this.colV.AccesLocatie();
                                                                     
                    if (dateCorecte)
                    {
                        Colet ut = new Colet((int)codColNou, locatie, livrator,traseuoptim);
                        bool succes = this.colP.ActualizareColet(codcol, ut);
                        if (!succes)
                            MessageBox.Show("Eroare la actualizare!");
                        else
                            this.VizualizareListaColete();
                    }
                }

            }
        }
        public void StergereColet()
        {
            int codcol = this.colV.AccesCodColetSelectat();
            if (codcol == -1)
                MessageBox.Show("Nu s-a selectat niciun colet!");
            else
            {
                bool succes = this.colP.StergereColet(codcol);
                if (!succes)
                    MessageBox.Show("Nu s-a efectuat stergerea!");
                else
                    this.VizualizareListaColete();
            }
        }

        public void VizualizareListaColeteFiltrate()
        {

            List<Colet> lista = new List<Colet>();
           
     
                lista = this.colP.ListaColete();

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Colet colet in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = colet.AccesCodColet().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = colet.AccesLocatie() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = colet.AccesLivrator() });
                    randuri.Add(rand);
                }
                this.colV.ActualizareListaColete(randuri);
            }
            else
                MessageBox.Show("Lista coletelor este vida!");
        }

        public void VizualizareListaColeteCautateLocatie()
        {

            List<Colet> lista = new List<Colet>();
            string txtCautare = this.colV.AccesCautareDupaNume();

            if (txtCautare.Equals(""))
            {
                MessageBox.Show("Nu ati introdus locatiea coletului!");

            }
            else
                lista = this.colP.CautareColeteLocatie(txtCautare);

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Colet colet in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = colet.AccesCodColet().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = colet.AccesLocatie() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = colet.AccesLivrator() });
                    randuri.Add(rand);
                }
                this.colV.ActualizareListaColete(randuri);
            }
            else
                MessageBox.Show("Lista coletelor este vida!");
        }
    }
}