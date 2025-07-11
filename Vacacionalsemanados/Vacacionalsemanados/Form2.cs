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
    public partial class frmInventario : Form

    {
        public BindingList<AreaEmpresas> listaEmpresas1;




        public frmInventario(BindingList<AreaEmpresas> listaempresas)
        {
            InitializeComponent();
            listaEmpresas1 = listaempresas;
            cboubicacionStock.Items.AddRange(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboubicacionStock.SelectedIndex = 0;
            //Traer id del binding lista empresas
            var listaId = listaempresas.Select(e => e.idArea).ToList();
            //Mostrar lista en combobox
            cboidArea.DataSource = listaId;

        }

        private void frmInventario_Load(object sender, EventArgs e)
        {

        }

        private void cboidArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mirar que id selecciono
            int idguardado = (int)cboidArea.SelectedValue;

            // Mostrar un mensaje con el id seleccionado
            MessageBox.Show("El id seleccionado es: " + idguardado);

            if (idguardado != null) {
                //Buscar el area con el id
                AreaEmpresas areaseleccionada = listaEmpresas1.FirstOrDefault(e => e.idArea == idguardado);
                //Agrego el nombre y el responsable a los texbox
                txtnombreAreai.Text = areaseleccionada.nombreArea;
                txtresponsableI.Text= areaseleccionada.responsableArea;
            
            }


        }
    }
}
