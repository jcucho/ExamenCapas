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
            listar();
        }

        public void listar()
        {
            NRegions negocio = new NRegions();
            try
            {
                dgvRegions.DataSource = null;
                //dgvRegions.DataSource = negocio.Listar();
                dgvRegions.Rows.Clear();
                foreach (ERegions Regions in negocio.Listar())
                {
                    dgvRegions.Rows.Add(Regions.RegionId, Regions.RegionName);
                }
                dgvRegions.Update();
                dgvRegions.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
            finally
            {
                negocio = null;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegionRegistrar frm = new frmRegionRegistrar();
            frm.Show();
        }

        private void dgvRegions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvRegions.CurrentRow.Cells[0].Value != null) {
                    frmRegionEditar frm = new frmRegionEditar();
                    frm.txtIdEdit.Text = this.dgvRegions.CurrentRow.Cells[0].Value.ToString();
                    frm.txtRegionNameEdit.Text = this.dgvRegions.CurrentRow.Cells[1].Value.ToString();
                    frm.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
