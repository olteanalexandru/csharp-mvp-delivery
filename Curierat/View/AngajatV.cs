using Curierat.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Curierat.View
{
    public partial class AngajatV : Form, ICoordonator
    {
        private CoordonatorP coletP;
        public CoordonatorV()
        {
            InitializeComponent();
            this.coletP = new CoordonatorP(this);
        }

        public string AccesCodColet()
        {
            return this.txtCod.Text;
        }

        public string AccesDenumire()
        {
            return this.txtDenumire.Text;
        }



        public string AccesPret()
        {
            return this.txtPret.Text;
        }

        public string AccesProducator()
        {
            return this.txtProducator.Text;
        }

        public string AccesValabilitate()
        {
            return this.txtValabilitate.Text;
        }
        public int AccesDisponibilitate()
        {
            return this.txtDisponibilitate.SelectedIndex;

        }

        public void ActualizareListaColete(List<DataGridViewRow> lista)
        {
            this.dataGridView1.Rows.Clear();
            foreach (DataGridViewRow rand in lista)
                this.dataGridView1.Rows.Add(rand);
        }

        private void btnListaCol_Click(object sender, EventArgs e)
        {
            this.coletP.VizualizareListaColete();
        }

        private void btnAdaugareCol_Click(object sender, EventArgs e)
        {
            this.coletP.AdaugareColet();
        }

        private void btnActualizareCol_Click(object sender, EventArgs e)
        {
            this.coletP.ActualizareaColet();
        }
        public int AccesCodColetSelectat()
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
                return Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
            else
                return -1;
        }


        private void btnStergereCol_Click(object sender, EventArgs e)
        {
            this.coletP.StergereColet();
        }

        private void btnFiltrare_Click(object sender, EventArgs e)
        {
            CoordonatorP aP = new CoordonatorP(this);
            aP.VizualizareListaColeteFiltrate();
        }
        public int AccesareFiltruSelectat()
        {
            return this.cmbCriteriu.SelectedIndex;
        }

        public string AccesFiltrare()
        {
            return this.txtFiltrare.Text;
        }

        private void btnDeconectare2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutentificareV autentificareV = new AutentificareV();
            autentificareV.Show();
        }

        public string AccesCautareDupaNume()
        {
            return this.txtCautareDenumire.Text;
        }
        private void btnCautareDupaDenumire_Click(object sender, EventArgs e)
        {
            AngajatP colnP = new CoordonatorP(this);
            colnP.VizualizareListaColeteCautateDenumire();
        }

        private void CoordonatorV_Load(object sender, EventArgs e)
        {

        }
    }
    
}
