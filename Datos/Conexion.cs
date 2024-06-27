using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class Conexion
    {
        public static string cadena = "Server=.; " +
                                      "Initial Catalog=WICMonitoriaDBDev; " +
                                      //"User Id=userMonitoria; Pwd=123456;" +
                                      "Integrated Security=True;" +
                                      "trustservercertificate=True";
    }
}
