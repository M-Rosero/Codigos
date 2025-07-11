namespace Vacacionalsemanados
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstidAreaempresa = new Label();
            txtidAreaempresa = new TextBox();
            lstnombreAreaempresa = new Label();
            txtnombreAreaempresa = new TextBox();
            lstnombreResponsablearea = new Label();
            txtnombreResponsablearea = new TextBox();
            btncreateAreasempresas = new Button();
            btndeleteAreasempresas = new Button();
            btnupdateAreasempresas = new Button();
            btnreadAreasempresas = new Button();
            btngestionarPersona = new Button();
            tabpageAreas = new TabControl();
            tabpageareaEmpresa = new TabPage();
            grdareasEmpresas = new DataGridView();
            tabpageInventario = new TabPage();
            lblinventarioempresa = new Label();
            btnGestionar = new Button();
            tabPageProduccion = new TabPage();
            btnProduccion = new Button();
            lblproduccionEmpresa = new Label();
            tabPageMercadeo = new TabPage();
            btnmercadeoEmpresa = new Button();
            lblMercadeo = new Label();
            tabPageFinanzas = new TabPage();
            lblfinanzasEmpresa = new Label();
            btnfinanzasEmpresa = new Button();
            tabpageAreas.SuspendLayout();
            tabpageareaEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdareasEmpresas).BeginInit();
            tabpageInventario.SuspendLayout();
            tabPageProduccion.SuspendLayout();
            tabPageMercadeo.SuspendLayout();
            tabPageFinanzas.SuspendLayout();
            SuspendLayout();
            // 
            // lstidAreaempresa
            // 
            lstidAreaempresa.AutoSize = true;
            lstidAreaempresa.Location = new Point(71, 36);
            lstidAreaempresa.Name = "lstidAreaempresa";
            lstidAreaempresa.Size = new Size(86, 15);
            lstidAreaempresa.TabIndex = 1;
            lstidAreaempresa.Text = "idAreaempresa";
            lstidAreaempresa.Click += label1_Click;
            // 
            // txtidAreaempresa
            // 
            txtidAreaempresa.Enabled = false;
            txtidAreaempresa.Location = new Point(174, 28);
            txtidAreaempresa.Name = "txtidAreaempresa";
            txtidAreaempresa.Size = new Size(100, 23);
            txtidAreaempresa.TabIndex = 2;
            // 
            // lstnombreAreaempresa
            // 
            lstnombreAreaempresa.AutoSize = true;
            lstnombreAreaempresa.Location = new Point(39, 83);
            lstnombreAreaempresa.Name = "lstnombreAreaempresa";
            lstnombreAreaempresa.Size = new Size(118, 15);
            lstnombreAreaempresa.TabIndex = 3;
            lstnombreAreaempresa.Text = "nombreAreaempresa";
            // 
            // txtnombreAreaempresa
            // 
            txtnombreAreaempresa.Location = new Point(174, 75);
            txtnombreAreaempresa.Name = "txtnombreAreaempresa";
            txtnombreAreaempresa.Size = new Size(174, 23);
            txtnombreAreaempresa.TabIndex = 4;
            // 
            // lstnombreResponsablearea
            // 
            lstnombreResponsablearea.AutoSize = true;
            lstnombreResponsablearea.Location = new Point(20, 130);
            lstnombreResponsablearea.Name = "lstnombreResponsablearea";
            lstnombreResponsablearea.Size = new Size(137, 15);
            lstnombreResponsablearea.TabIndex = 5;
            lstnombreResponsablearea.Text = "nombreResponsablearea";
            // 
            // txtnombreResponsablearea
            // 
            txtnombreResponsablearea.Location = new Point(174, 127);
            txtnombreResponsablearea.Name = "txtnombreResponsablearea";
            txtnombreResponsablearea.Size = new Size(174, 23);
            txtnombreResponsablearea.TabIndex = 6;
            // 
            // btncreateAreasempresas
            // 
            btncreateAreasempresas.BackColor = Color.LightGreen;
            btncreateAreasempresas.Image = Properties.Resources.imgBotonGuardar;
            btncreateAreasempresas.ImageAlign = ContentAlignment.TopCenter;
            btncreateAreasempresas.Location = new Point(39, 159);
            btncreateAreasempresas.Name = "btncreateAreasempresas";
            btncreateAreasempresas.Size = new Size(51, 60);
            btncreateAreasempresas.TabIndex = 7;
            btncreateAreasempresas.Text = "Create";
            btncreateAreasempresas.TextAlign = ContentAlignment.BottomCenter;
            btncreateAreasempresas.UseVisualStyleBackColor = false;
            btncreateAreasempresas.Click += btncreateAreasempresas_Click;
            // 
            // btndeleteAreasempresas
            // 
            btndeleteAreasempresas.BackColor = Color.Tomato;
            btndeleteAreasempresas.Image = Properties.Resources.imgBotonEliminar;
            btndeleteAreasempresas.ImageAlign = ContentAlignment.TopCenter;
            btndeleteAreasempresas.Location = new Point(297, 159);
            btndeleteAreasempresas.Name = "btndeleteAreasempresas";
            btndeleteAreasempresas.Size = new Size(51, 60);
            btndeleteAreasempresas.TabIndex = 8;
            btndeleteAreasempresas.Text = "delete";
            btndeleteAreasempresas.TextAlign = ContentAlignment.BottomCenter;
            btndeleteAreasempresas.UseVisualStyleBackColor = false;
            btndeleteAreasempresas.Click += btndeleteAreasempresas_Click;
            // 
            // btnupdateAreasempresas
            // 
            btnupdateAreasempresas.BackColor = Color.FromArgb(255, 255, 128);
            btnupdateAreasempresas.Image = Properties.Resources.imgBotonActualizar;
            btnupdateAreasempresas.ImageAlign = ContentAlignment.TopCenter;
            btnupdateAreasempresas.Location = new Point(204, 159);
            btnupdateAreasempresas.Name = "btnupdateAreasempresas";
            btnupdateAreasempresas.Size = new Size(59, 60);
            btnupdateAreasempresas.TabIndex = 9;
            btnupdateAreasempresas.Text = "Update";
            btnupdateAreasempresas.TextAlign = ContentAlignment.BottomCenter;
            btnupdateAreasempresas.UseVisualStyleBackColor = false;
            btnupdateAreasempresas.Click += btnupdateAreasempresas_Click;
            // 
            // btnreadAreasempresas
            // 
            btnreadAreasempresas.BackColor = Color.Turquoise;
            btnreadAreasempresas.Image = Properties.Resources.imgBotonLeer;
            btnreadAreasempresas.ImageAlign = ContentAlignment.TopCenter;
            btnreadAreasempresas.Location = new Point(120, 159);
            btnreadAreasempresas.Name = "btnreadAreasempresas";
            btnreadAreasempresas.Size = new Size(56, 60);
            btnreadAreasempresas.TabIndex = 10;
            btnreadAreasempresas.Text = "Leer";
            btnreadAreasempresas.TextAlign = ContentAlignment.BottomCenter;
            btnreadAreasempresas.UseVisualStyleBackColor = false;
            btnreadAreasempresas.Click += btnreadAreasempresas_Click;
            // 
            // btngestionarPersona
            // 
            btngestionarPersona.BackColor = Color.FromArgb(255, 192, 192);
            btngestionarPersona.Image = Properties.Resources.imgBotonPersonas;
            btngestionarPersona.ImageAlign = ContentAlignment.TopCenter;
            btngestionarPersona.Location = new Point(428, 45);
            btngestionarPersona.Name = "btngestionarPersona";
            btngestionarPersona.Size = new Size(69, 69);
            btngestionarPersona.TabIndex = 11;
            btngestionarPersona.Text = "gestionarPersona";
            btngestionarPersona.TextAlign = ContentAlignment.BottomCenter;
            btngestionarPersona.UseVisualStyleBackColor = false;
            // 
            // tabpageAreas
            // 
            tabpageAreas.Controls.Add(tabpageareaEmpresa);
            tabpageAreas.Controls.Add(tabpageInventario);
            tabpageAreas.Controls.Add(tabPageProduccion);
            tabpageAreas.Controls.Add(tabPageMercadeo);
            tabpageAreas.Controls.Add(tabPageFinanzas);
            tabpageAreas.Location = new Point(39, 238);
            tabpageAreas.Name = "tabpageAreas";
            tabpageAreas.SelectedIndex = 0;
            tabpageAreas.Size = new Size(541, 171);
            tabpageAreas.TabIndex = 12;
            // 
            // tabpageareaEmpresa
            // 
            tabpageareaEmpresa.Controls.Add(grdareasEmpresas);
            tabpageareaEmpresa.Location = new Point(4, 24);
            tabpageareaEmpresa.Name = "tabpageareaEmpresa";
            tabpageareaEmpresa.Padding = new Padding(3);
            tabpageareaEmpresa.Size = new Size(533, 143);
            tabpageareaEmpresa.TabIndex = 0;
            tabpageareaEmpresa.Text = "areasEmpresas";
            tabpageareaEmpresa.UseVisualStyleBackColor = true;
            // 
            // grdareasEmpresas
            // 
            grdareasEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdareasEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdareasEmpresas.Location = new Point(6, 6);
            grdareasEmpresas.Name = "grdareasEmpresas";
            grdareasEmpresas.Size = new Size(521, 131);
            grdareasEmpresas.TabIndex = 0;
            grdareasEmpresas.CellContentClick += grdareasEmpresas_CellContentClick;
            grdareasEmpresas.SelectionChanged += grdareasEmpresas_SelectionChanged;
            // 
            // tabpageInventario
            // 
            tabpageInventario.Controls.Add(lblinventarioempresa);
            tabpageInventario.Controls.Add(btnGestionar);
            tabpageInventario.Location = new Point(4, 24);
            tabpageInventario.Name = "tabpageInventario";
            tabpageInventario.Padding = new Padding(3);
            tabpageInventario.Size = new Size(533, 143);
            tabpageInventario.TabIndex = 1;
            tabpageInventario.Text = "inventario";
            tabpageInventario.UseVisualStyleBackColor = true;
            // 
            // lblinventarioempresa
            // 
            lblinventarioempresa.AutoSize = true;
            lblinventarioempresa.Location = new Point(131, 47);
            lblinventarioempresa.Name = "lblinventarioempresa";
            lblinventarioempresa.Size = new Size(108, 15);
            lblinventarioempresa.TabIndex = 1;
            lblinventarioempresa.Text = "Inventario Empresa";
            // 
            // btnGestionar
            // 
            btnGestionar.Location = new Point(145, 89);
            btnGestionar.Name = "btnGestionar";
            btnGestionar.Size = new Size(75, 23);
            btnGestionar.TabIndex = 0;
            btnGestionar.Text = "Gestionar";
            btnGestionar.UseVisualStyleBackColor = true;
            btnGestionar.Click += btnGestionar_Click;
            // 
            // tabPageProduccion
            // 
            tabPageProduccion.Controls.Add(btnProduccion);
            tabPageProduccion.Controls.Add(lblproduccionEmpresa);
            tabPageProduccion.Location = new Point(4, 24);
            tabPageProduccion.Name = "tabPageProduccion";
            tabPageProduccion.Size = new Size(533, 143);
            tabPageProduccion.TabIndex = 2;
            tabPageProduccion.Text = "produccion";
            tabPageProduccion.UseVisualStyleBackColor = true;
            // 
            // btnProduccion
            // 
            btnProduccion.Location = new Point(195, 54);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(86, 23);
            btnProduccion.TabIndex = 1;
            btnProduccion.Text = "Producciòn";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // lblproduccionEmpresa
            // 
            lblproduccionEmpresa.AutoSize = true;
            lblproduccionEmpresa.Location = new Point(186, 22);
            lblproduccionEmpresa.Name = "lblproduccionEmpresa";
            lblproduccionEmpresa.Size = new Size(119, 15);
            lblproduccionEmpresa.TabIndex = 0;
            lblproduccionEmpresa.Text = " Produccion Empresa";
            // 
            // tabPageMercadeo
            // 
            tabPageMercadeo.Controls.Add(btnmercadeoEmpresa);
            tabPageMercadeo.Controls.Add(lblMercadeo);
            tabPageMercadeo.Location = new Point(4, 24);
            tabPageMercadeo.Name = "tabPageMercadeo";
            tabPageMercadeo.Size = new Size(533, 143);
            tabPageMercadeo.TabIndex = 4;
            tabPageMercadeo.Text = "Mercadeo";
            tabPageMercadeo.UseVisualStyleBackColor = true;
            // 
            // btnmercadeoEmpresa
            // 
            btnmercadeoEmpresa.Location = new Point(198, 53);
            btnmercadeoEmpresa.Name = "btnmercadeoEmpresa";
            btnmercadeoEmpresa.Size = new Size(75, 23);
            btnmercadeoEmpresa.TabIndex = 1;
            btnmercadeoEmpresa.Text = "Mercadeo";
            btnmercadeoEmpresa.UseVisualStyleBackColor = true;
            btnmercadeoEmpresa.Click += btnmercadeoEmpresa_Click;
            // 
            // lblMercadeo
            // 
            lblMercadeo.AutoSize = true;
            lblMercadeo.Location = new Point(187, 20);
            lblMercadeo.Name = "lblMercadeo";
            lblMercadeo.Size = new Size(108, 15);
            lblMercadeo.TabIndex = 0;
            lblMercadeo.Text = "Mercadeo Empresa";
            // 
            // tabPageFinanzas
            // 
            tabPageFinanzas.Controls.Add(lblfinanzasEmpresa);
            tabPageFinanzas.Controls.Add(btnfinanzasEmpresa);
            tabPageFinanzas.Location = new Point(4, 24);
            tabPageFinanzas.Name = "tabPageFinanzas";
            tabPageFinanzas.Size = new Size(533, 143);
            tabPageFinanzas.TabIndex = 3;
            tabPageFinanzas.Text = "finanzas";
            tabPageFinanzas.UseVisualStyleBackColor = true;
            // 
            // lblfinanzasEmpresa
            // 
            lblfinanzasEmpresa.AutoSize = true;
            lblfinanzasEmpresa.Location = new Point(176, 30);
            lblfinanzasEmpresa.Name = "lblfinanzasEmpresa";
            lblfinanzasEmpresa.Size = new Size(129, 15);
            lblfinanzasEmpresa.TabIndex = 1;
            lblfinanzasEmpresa.Text = "Finanzas De la Empresa";
            // 
            // btnfinanzasEmpresa
            // 
            btnfinanzasEmpresa.Location = new Point(196, 64);
            btnfinanzasEmpresa.Name = "btnfinanzasEmpresa";
            btnfinanzasEmpresa.Size = new Size(75, 23);
            btnfinanzasEmpresa.TabIndex = 0;
            btnfinanzasEmpresa.Text = "Finanzas";
            btnfinanzasEmpresa.UseVisualStyleBackColor = true;
            btnfinanzasEmpresa.Click += btnfinanzasEmpresa_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabpageAreas);
            Controls.Add(btngestionarPersona);
            Controls.Add(btnreadAreasempresas);
            Controls.Add(btnupdateAreasempresas);
            Controls.Add(btndeleteAreasempresas);
            Controls.Add(btncreateAreasempresas);
            Controls.Add(txtnombreResponsablearea);
            Controls.Add(lstnombreResponsablearea);
            Controls.Add(txtnombreAreaempresa);
            Controls.Add(lstnombreAreaempresa);
            Controls.Add(txtidAreaempresa);
            Controls.Add(lstidAreaempresa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            tabpageAreas.ResumeLayout(false);
            tabpageareaEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdareasEmpresas).EndInit();
            tabpageInventario.ResumeLayout(false);
            tabpageInventario.PerformLayout();
            tabPageProduccion.ResumeLayout(false);
            tabPageProduccion.PerformLayout();
            tabPageMercadeo.ResumeLayout(false);
            tabPageMercadeo.PerformLayout();
            tabPageFinanzas.ResumeLayout(false);
            tabPageFinanzas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lstidAreaempresa;
        private TextBox txtidAreaempresa;
        private Label lstnombreAreaempresa;
        private TextBox txtnombreAreaempresa;
        private Label lstnombreResponsablearea;
        private TextBox txtnombreResponsablearea;
        private Button btncreateAreasempresas;
        private Button btndeleteAreasempresas;
        private Button btnupdateAreasempresas;
        private Button btnreadAreasempresas;
        private Button btngestionarPersona;
        private TabControl tabpageAreas;
        private TabPage tabpageareaEmpresa;
        private TabPage tabpageInventario;
        private TabPage tabPageProduccion;
        private TabPage tabPageFinanzas;
        private DataGridView grdareasEmpresas;
        private Label lblinventarioempresa;
        private Button btnGestionar;
        private TabPage tabPageMercadeo;
        private Button btnProduccion;
        private Label lblproduccionEmpresa;
        private Label lblfinanzasEmpresa;
        private Button btnfinanzasEmpresa;
        private Button btnmercadeoEmpresa;
        private Label lblMercadeo;
    }
}
