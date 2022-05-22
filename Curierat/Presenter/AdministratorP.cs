using Curierat.Model;
using Curierat.Model.Persistenta;
using Curierat.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Curierat.Presenter
{
    public class AdministratorP
    {
        private IAdministrator admV;
        private UtilizatorPersistent utP;
        public AdministratorP(IAdministrator admV)
        {
            this.admV = admV;
            this.utP = new UtilizatorPersistent();
        }



        public void curierColet()
        {
            {
                List<Utilizator> lista = this.utP.ListaUtilizatori();
                if (lista != null)
                {
                    List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                    foreach (Utilizator ut in lista)
                    {
                        DataGridViewRow rand = new DataGridViewRow();                      
                        rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesNume() });
                        randuri.Add(rand);
                    }
                    this.admV.ActualizareListaUtilizatori(randuri);
                }
            }

        }



        public void AdaugareUtilizator()
        {
            bool dateCorecte = true;
            int rolSelectat = this.admV.AccesRolSelectat();
            if (rolSelectat < 0 || admV.AccesNume().Equals("") || admV.AccesLegitimatie().Equals("") || admV.AccesUser().Equals("")
                || admV.AccesParola().Equals(""))
            {
                dateCorecte = false;
                MessageBox.Show("Nu ati introdus toate datele necesare!");
            }
            else
            {
                string rol = "undefined";

                if (rolSelectat == 0)
                    rol = "Administrator";
                else if (rolSelectat == 1)
                {
                    rol = "Coordonator";
                } else if (rolSelectat == 2)
                {
                    rol = "Curier";
                }





                    string leg = this.admV.AccesLegitimatie();
                uint nrLeg = Convert.ToUInt32(leg);
                if (this.utP.CautareUtilizator(nrLeg) != null)
                {
                    MessageBox.Show("Exista alt utilizator cu acest ID!");
                    dateCorecte = false;
                }
                else
                {
                    string nume = this.admV.AccesNume();
                    string parola = this.admV.AccesParola();
                    string user = this.admV.AccesUser();
                    if (dateCorecte)
                    {
                        Utilizator ut = new Utilizator(nume, nrLeg, user, parola, rol);
                        bool succes = this.utP.AdaugareUtilizator(ut);
                        if (!succes)
                            MessageBox.Show("Eroare la adaugare!");
                        else
                            this.VizualizareLista();
                    }
                }
            }
        }

      
        public void VizualizareLista()
        {
            List<Utilizator> lista = this.utP.ListaUtilizatori();

            if (lista != null)
            {
                List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                foreach (Utilizator ut in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesLegitimatie().ToString() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesNume() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesCont() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesParola() });
                    rand.Cells.Add(new DataGridViewTextBoxCell { Value = ut.AccesRol() });
                    randuri.Add(rand);
                }
                this.admV.ActualizareListaUtilizatori(randuri);
            }
            else
                MessageBox.Show("Lista utilizatorilor este vida!");
        }
        public void ActualizareaUtilizator()
        {
            int nrLeg = this.admV.AccesLegitimatieSelectata();
            if (nrLeg == -1)
                MessageBox.Show("Nu s-a selectat niciun utilizator!");
            else
            {
                bool dateCorecte = true;
                int rolSelectat = this.admV.AccesRolSelectat();
                string rol = "undefined"; ;
                string leg;
                uint nrLegNou;

                

                if (rolSelectat == 0)
                    rol = "Administrator";
                else if (rolSelectat == 1)
                {
                    rol = "Coordonator";
                }
                else if (rolSelectat == 2) { 

                    rol = "Curier";
            }

                leg = this.admV.AccesLegitimatie();

                if (leg == "")
                    nrLegNou = 0;
                else

                {
                    nrLegNou = Convert.ToUInt32(leg);
                    if (nrLegNou == 0) MessageBox.Show("ID-urile introduse trebuie sa fie mai mari ca 0!");
                }


                if (this.utP.CautareUtilizator(nrLegNou) != null)
                {
                    MessageBox.Show("Exista alt utilizator cu acest ID!");
                    dateCorecte = false;
                }
                else
                {
                    if (nrLegNou == 0)
                        nrLegNou = (uint)nrLeg;

                    string nume = this.admV.AccesNume();
                    string parola = this.admV.AccesParola();
                    string user = this.admV.AccesUser();
                    if (dateCorecte)
                    {
                        Utilizator ut = new Utilizator(nume, nrLegNou, user, parola, rol);
                        bool succes = this.utP.ActualizareUtilizator((uint)nrLeg, ut);
                        if (!succes)
                            MessageBox.Show("Eroare la actualizare!");
                        else
                            this.VizualizareLista();
                    }
                }

            }
        }
        public void StergereUtilizator()
        {
            int nrLeg = this.admV.AccesLegitimatieSelectata();
            if (nrLeg == -1)
                MessageBox.Show("Nu s-a selectat niciun utilizator!");
            else
            {
                bool succes = this.utP.StergereUtilizator((uint)nrLeg);
                if (!succes)
                    MessageBox.Show("Nu s-a efectuat stergerea!");
                else
                    this.VizualizareLista();
            }
        }
    }
    
}
