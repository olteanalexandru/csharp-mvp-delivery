using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curierat.View
{
    public interface ICurier
    {
       
        void ActualizareListaColete(List<DataGridViewRow> lista);


        int AccesCodColetSelectat();

        string AccesCautareDupaNume();
    }
}

