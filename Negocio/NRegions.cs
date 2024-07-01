using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Entidad;
using Datos;

namespace Negocio
{
    public class NRegions
    {
        DRegions datos = new DRegions();

        public List<ERegions> Listar()
        {
            List<ERegions> result = new List<ERegions>();
            result = datos.Listar();
            return result;
        }

        public string Registrar(string Nombre)
        {
            return datos.Registrar(Nombre, true);
        }
    }


}
