using System;
using System.Windows.Forms;
using Curierat.Model;
using Curierat.Model.Persistenta;
using Curierat.Presenter;

namespace Curierat.View
{
    public partial class AutentificareV : Form, IAutentificare
    {

        public AutentificareV()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        public string AccesParola()
        {
            return this.txtParolaAutentificare.Text;
        }

        public string AccesUser()
        {
            return this.txtUserAutentificare.Text;
        }

        public void ActualizareParola()
        {
            this.txtParolaAutentificare.Text = "";
        }

        public void ActualizareUser()
        {
            this.txtUserAutentificare.Text = "";
        }

        public void ActualizareVizualizare()
        {
            this.Hide();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            AutentificareP aP = new AutentificareP(this);
            aP.Logare();
            this.Hide();
        }

        private void AutentificareV_Load(object sender, EventArgs e)
        {

        }
    }
}
