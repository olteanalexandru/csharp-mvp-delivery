using Curierat.Presenter;
using Curierat.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Curierat
{
    public partial class AdministratorV : Form, IAdministrator
    {
        private AdministratorP admP;
   
        public AdministratorV()
        {
            InitializeComponent();
            this.admP = new AdministratorP(this);

        }
        public string AccesNume()
        {
            return this.txtNume.Text;
        }

        public string AccesParola()
        {
            return this.txtParola.Text;
        }

        public string AccesLegitimatie()
        {
            return this.txtLegitimatie.Text;
        }

        public string AccesUser()
        {
            return this.txtUser.Text;
        }

        public int AccesRolSelectat()
        {
            return this.cmbRolU.SelectedIndex;
        }

        public void ActualizareListaUtilizatori(List<DataGridViewRow> lista)
        {
            this.dataGridView1.Rows.Clear();
            foreach (DataGridViewRow rand in lista)
                this.dataGridView1.Rows.Add(rand);
        }

        public int AccesLegitimatieSelectata()
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
                return Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
            else
                return -1;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            this.admP.ActualizareaUtilizator();
        }
        private void btnAdaugareU_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAdaugareU_Click_1(object sender, EventArgs e)
        {
            this.admP.AdaugareUtilizator();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            this.admP.VizualizareLista();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            this.admP.StergereUtilizator();
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutentificareV autentificareV = new AutentificareV();
            autentificareV.Show();
        }

        private void AdministratorV_Load(object sender, EventArgs e)
        {

        }

        private void cmbRolU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
