using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DRegions
    {
        public List<ERegions> Listar()
        {
            List<ERegions> Regions = new List<ERegions>();
            try
            {
                using (var connection = new SqlConnection(Conexion.cadena))
                {
                    //Usar el procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_ReadRegion", connection);
                    cmd.CommandType = CommandType.StoredProcedure;


                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Recorrer el data reader
                    while (reader.Read())
                    {

                        int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
                        string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";
                        string Enabled = reader["Enabled"] != DBNull.Value ? Convert.ToString(reader["Enabled"]) : "";

                        Regions.Add(new ERegions { RegionId = RegionId, RegionName = RegionName, Enabled = Enabled });

                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return Regions;

        }
    }
}
