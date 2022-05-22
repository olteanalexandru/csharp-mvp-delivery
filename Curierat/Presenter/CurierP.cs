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
    public class CurierP
    {
        private ICurier colV;
        private ColetPersistent colP;

        public CurierP(ICurier colV)
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