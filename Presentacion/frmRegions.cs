using Entidad;
using Negocio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentacion
{
    public partial class frmRegions : Form
    {
        public frmRegions()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            NRegions negocio = new NRegions();
            try
            {
                dgvRegions.DataSource = null;
                dgvRegions.Rows.Clear();
                foreach (ERegions Regions in negocio.Listar())
                {
                    dgvRegions.Rows.Add(Regions.RegionId, Regions.RegionName);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                negocio = null;
            }

            
        }
    }
}
