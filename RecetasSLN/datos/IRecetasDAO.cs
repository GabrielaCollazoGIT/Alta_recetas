using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    interface IRecetasDAO
    { 
        DataTable ListarIngredientes();
        int ProximaReceta();
        bool EjecutarInsert(Receta oReceta);

    }
}
