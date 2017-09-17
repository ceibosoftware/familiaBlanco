using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFamiliaBlanco
{
    public partial class frmAgregarProveedor : Form
    {
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            frmAgregarContacto form = new frmAgregarContacto();
            form.ShowDialog();
        }
    }
}
