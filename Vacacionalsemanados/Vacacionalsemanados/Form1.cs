using System.ComponentModel;

namespace Vacacionalsemanados
{
    public partial class frmPrincipal : Form
    {
        public BindingList<AreaEmpresas> listaEmpresas = new BindingList<AreaEmpresas>();
        public int contador = 0;
        public frmPrincipal()
        {
            InitializeComponent();
            txtidAreaempresa.Text = contador.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncreateAreasempresas_Click(object sender, EventArgs e)
        {
            contador++;
            //creamos el objeto a enlazar con el Datagridview
            AreaEmpresas areasEmpresas = new AreaEmpresas();
            // llenar los atributos del objeto con los datos de las textbox 
            areasEmpresas.idArea = contador;
            areasEmpresas.nombreArea = txtnombreAreaempresa.Text;
            areasEmpresas.responsableArea = txtnombreResponsablearea.Text;

            //Bindign enlazar el objeto o datos al gridview
            listaEmpresas.Add(areasEmpresas);
            //Actualizar el Grid (DataSource)
            grdareasEmpresas.DataSource = listaEmpresas;


        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void grdareasEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdareasEmpresas_SelectionChanged(object sender, EventArgs e)
        {
            if (grdareasEmpresas.CurrentRow != null && grdareasEmpresas.CurrentRow.DataBoundItem != null)
            {
                AreaEmpresas areaEmpresaseleccionada = (AreaEmpresas)grdareasEmpresas.CurrentRow.DataBoundItem;

                //Mostramos textbox
                txtidAreaempresa.Text = areaEmpresaseleccionada.idArea.ToString();
                txtnombreAreaempresa.Text = areaEmpresaseleccionada.nombreArea;
                txtnombreResponsablearea.Text = areaEmpresaseleccionada.responsableArea;
            }
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            frmInventario frminventario = new frmInventario(listaEmpresas);
            //frminventario.Show(); no es modal
            frminventario.ShowDialog();//es modal


        }

        private void btnreadAreasempresas_Click(object sender, EventArgs e)
        {
            AreaEmpresas areaSeleccionada = (AreaEmpresas)grdareasEmpresas.CurrentRow.DataBoundItem;

            string mensaje = $"ID: {areaSeleccionada.idArea}\n" +
                            $"Nombre Area: {areaSeleccionada.nombreArea}\n" +
                            $"Responsable: {areaSeleccionada.responsableArea}";

            MessageBox.Show(mensaje, "Detalles del Área",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndeleteAreasempresas_Click(object sender, EventArgs e)
        {
            if (grdareasEmpresas.CurrentRow != null)
            {
                listaEmpresas.Remove((AreaEmpresas)grdareasEmpresas.CurrentRow.DataBoundItem);
                MessageBox.Show("Área Eliminada correctamente", "Éxito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnupdateAreasempresas_Click(object sender, EventArgs e)
        {
            if (grdareasEmpresas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un área para actualizar");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtnombreAreaempresa.Text))
            {
                AreaEmpresas area = (AreaEmpresas)grdareasEmpresas.CurrentRow.DataBoundItem;
                area.nombreArea = txtnombreAreaempresa.Text;
                area.responsableArea = txtnombreResponsablearea.Text;
                grdareasEmpresas.Refresh();
                MessageBox.Show("Área actualizada correctamente", "Éxito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            frmProducion frmproduccion = new frmProducion(listaEmpresas);

            frmproduccion.ShowDialog();//es modal

        }



        private void btnfinanzasEmpresa_Click(object sender, EventArgs e)
        {
            frmFinanzas frmfinanzas = new frmFinanzas();

            frmfinanzas.ShowDialog();//es modal

        }

        private void btnmercadeoEmpresa_Click(object sender, EventArgs e)
        {
            frmMercadeo frmmercadeo = new frmMercadeo();

            frmmercadeo.ShowDialog();//es modal

        }
    }
}
