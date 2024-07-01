using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmRegionRegistrar : Form
    {
        public frmRegionRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            NRegions negocio = new NRegions();
            try
            {
                string mensaje = string.Empty;
                mensaje = negocio.Registrar(txtRegionName.Text);

                if (mensaje == "true")
                {
                    MessageBox.Show("Registro Exitoso");
                    frmRegions frm = new frmRegions();
                    this.Hide();
                    frm.listar();                
                    txtRegionName.Text = "";
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
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
    }
}
