using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curierat.View
{
    public interface ICoordonator
    {
        string AccesLocatie();

        string AccesCodColet();

        void ActualizareListaColete(List<DataGridViewRow> lista);

        int AccesLivrator();

        int AccesCodColetSelectat();

        string AccesCautareDupaNume();
    }
}
