using Curierat.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Curierat.View
{
    public partial class CurierV : Form, ICurier
    {
        private CurierP coletP;
        public CurierV()
        {
            InitializeComponent();
            this.coletP = new CurierP(this);
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

        private void CurierV_Load(object sender, EventArgs e)
        {

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
            CurierP colnP = new CurierP(this);
            colnP.VizualizareListaColeteCautateLocatie();
        }
      
       
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int AccesCodColetSelectat()
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
                return Convert.ToInt32(this.dataGridView1.SelectedCells[0].Value);
            else
                return -1;
        }

       
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    
}


