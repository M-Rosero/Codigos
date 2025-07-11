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
    public partial class frmFinanzas : Form
    {
        public BindingList<Finanzas> listaFinanzas = new BindingList<Finanzas>();
        
        public frmFinanzas()
        {
            InitializeComponent();
            
        }

        private void frmFinanzas_Load(object sender, EventArgs e)
        {

        }

        private void cboidAreaF_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            //creamos el objeto a enlazar con el Datagridview
            Finanzas finanzas = new Finanzas();
            // llenar los atributos del objeto con los datos de las textbox 
            finanzas.fechaFinanza = DateTime.Today;
            finanzas.ingresosFinancieros = double.Parse(txtingresosFinancieros.Text);
            finanzas.egresosFinancieros = double.Parse(txtegresosFinancieros.Text);
            finanzas.utilidadNeta= finanzas.ingresosFinancieros-finanzas.egresosFinancieros;


            //Bindign enlazar el objeto o datos al gridview
            listaFinanzas.Add(finanzas);
            //Actualizar el Grid (DataSource)
            grdFinanzas.DataSource = listaFinanzas;
        }
    }
}
