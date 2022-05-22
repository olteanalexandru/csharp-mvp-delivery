using Curierat.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Curierat.View
{
    public partial class CoordonatorV : Form, ICoordonator
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

        public string AccesLocatie()
        {
            return this.txtLocatie.Text;
        }



     

        public int AccesLivrator()
        {
            return this.txtLivrator.SelectedIndex;

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
        

        private void btnDeconectare2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutentificareV autentificareV = new AutentificareV();
            autentificareV.Show();
        }

        public string AccesCautareDupaNume()
        {
            return this.txtCautareLocatie.Text;
        }
        private void btnCautareDupaLocatie_Click(object sender, EventArgs e)
        {
            CoordonatorP colnP = new CoordonatorP(this);
            colnP.VizualizareListaColeteCautateLocatie();
        }

        private void CoordonatorV_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void COD_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLivrator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltrare_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
