using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Curierat.Model;

namespace Curierat.View
{
    public interface IAdministrator
    {
        string AccesNume();
        string AccesParola();

        string AccesLegitimatie();
        string AccesUser();
        int AccesRolSelectat();

        int AccesLegitimatieSelectata();

        void ActualizareListaUtilizatori(List<DataGridViewRow> lista);

    }
}
