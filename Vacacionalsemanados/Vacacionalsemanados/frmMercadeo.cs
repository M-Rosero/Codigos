using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacacionalsemanados
{
    public partial class frmMercadeo : Form
    {
        public BindingList<Mercadeo> listamercadeo = new BindingList<Mercadeo>();
        public frmMercadeo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //creamos el objeto a enlazar con el Datagridview
            Mercadeo mercadeo = new Mercadeo();
            // llenar los atributos del objeto con los datos de las textbox 
            
            mercadeo.lineaMercadeo = txtlineaMercadeo.Text;
            mercadeo.totalMercadeo = int.Parse(txttotalMercadeo.Text);
            


            //Bindign enlazar el objeto o datos al gridview
            listamercadeo.Add(mercadeo);
            //Actualizar el Grid (DataSource)
            grdMercadeo.DataSource = listamercadeo;
        }
    }
}
