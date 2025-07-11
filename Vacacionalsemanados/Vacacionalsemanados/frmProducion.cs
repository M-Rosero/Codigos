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
    public partial class frmProducion : Form
    {
        public BindingList<AreaEmpresas> listaEmpresas2;
        public frmProducion(BindingList<AreaEmpresas> listaempresas)
        {
            InitializeComponent();
            listaEmpresas2 = listaempresas;

            cboidAreaP.DataSource = listaEmpresas2.Select(a => a.idArea).ToList();
        }

        private void frmProducion_Load(object sender, EventArgs e)
        {

        }

        private void cboidAreaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mirar que id selecciono
            int idguardado = (int)cboidAreaP.SelectedValue;

            // Mostrar un mensaje con el id seleccionado
            MessageBox.Show("El id seleccionado es: " + idguardado);

            if (idguardado != null)
            {
                //Buscar el area con el id
                AreaEmpresas areaseleccionada = listaEmpresas2.FirstOrDefault(e => e.idArea == idguardado);
                //Agrego el nombre y el responsable a los texbox
                txtnombreAreaP.Text = areaseleccionada.nombreArea;
                txtresponsableP.Text = areaseleccionada.responsableArea;

            }
        }
    }
}
