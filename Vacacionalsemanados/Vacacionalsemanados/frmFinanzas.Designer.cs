namespace Vacacionalsemanados
{
    partial class frmFinanzas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboidAreaF = new ComboBox();
            lblidAreaF = new Label();
            txtnombreAreaF = new TextBox();
            txtresponsableF = new TextBox();
            lblResponsableF = new Label();
            lblnombreAreaF = new Label();
            lblareaFinanzas = new Label();
            txtegresosFinancieros = new TextBox();
            txtingresosFinancieros = new TextBox();
            lblegresosFinancieros = new Label();
            lblingresosFinancieros = new Label();
            lblfechaFinanzas = new Label();
            dtpfechaFinanzas = new DateTimePicker();
            btnGuardar = new Button();
            tabControl1 = new TabControl();
            tabPageFinanzas = new TabPage();
            grdFinanzas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageFinanzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdFinanzas).BeginInit();
            SuspendLayout();
            // 
            // cboidAreaF
            // 
            cboidAreaF.FormattingEnabled = true;
            cboidAreaF.Location = new Point(561, 222);
            cboidAreaF.Name = "cboidAreaF";
            cboidAreaF.Size = new Size(121, 23);
            cboidAreaF.TabIndex = 40;
            cboidAreaF.SelectedIndexChanged += cboidAreaF_SelectedIndexChanged;
            // 
            // lblidAreaF
            // 
            lblidAreaF.AutoSize = true;
            lblidAreaF.Location = new Point(491, 225);
            lblidAreaF.Name = "lblidAreaF";
            lblidAreaF.Size = new Size(44, 15);
            lblidAreaF.TabIndex = 39;
            lblidAreaF.Text = "Id Area";
            // 
            // txtnombreAreaF
            // 
            txtnombreAreaF.Location = new Point(561, 106);
            txtnombreAreaF.Name = "txtnombreAreaF";
            txtnombreAreaF.Size = new Size(181, 23);
            txtnombreAreaF.TabIndex = 38;
            // 
            // txtresponsableF
            // 
            txtresponsableF.Location = new Point(561, 165);
            txtresponsableF.Name = "txtresponsableF";
            txtresponsableF.Size = new Size(181, 23);
            txtresponsableF.TabIndex = 37;
            // 
            // lblResponsableF
            // 
            lblResponsableF.AutoSize = true;
            lblResponsableF.Location = new Point(415, 173);
            lblResponsableF.Name = "lblResponsableF";
            lblResponsableF.Size = new Size(120, 15);
            lblResponsableF.TabIndex = 36;
            lblResponsableF.Text = "Responsable Del Area";
            // 
            // lblnombreAreaF
            // 
            lblnombreAreaF.AutoSize = true;
            lblnombreAreaF.Location = new Point(415, 111);
            lblnombreAreaF.Name = "lblnombreAreaF";
            lblnombreAreaF.Size = new Size(78, 15);
            lblnombreAreaF.TabIndex = 35;
            lblnombreAreaF.Text = "Nombre Area";
            // 
            // lblareaFinanzas
            // 
            lblareaFinanzas.AutoSize = true;
            lblareaFinanzas.BorderStyle = BorderStyle.FixedSingle;
            lblareaFinanzas.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblareaFinanzas.ForeColor = SystemColors.ControlText;
            lblareaFinanzas.Location = new Point(12, 24);
            lblareaFinanzas.Name = "lblareaFinanzas";
            lblareaFinanzas.Size = new Size(187, 32);
            lblareaFinanzas.TabIndex = 34;
            lblareaFinanzas.Text = "Area Finanzas\r\n";
            // 
            // txtegresosFinancieros
            // 
            txtegresosFinancieros.Location = new Point(151, 129);
            txtegresosFinancieros.Name = "txtegresosFinancieros";
            txtegresosFinancieros.Size = new Size(181, 23);
            txtegresosFinancieros.TabIndex = 33;
            // 
            // txtingresosFinancieros
            // 
            txtingresosFinancieros.Location = new Point(147, 83);
            txtingresosFinancieros.Name = "txtingresosFinancieros";
            txtingresosFinancieros.Size = new Size(181, 23);
            txtingresosFinancieros.TabIndex = 32;
            // 
            // lblegresosFinancieros
            // 
            lblegresosFinancieros.AutoSize = true;
            lblegresosFinancieros.Location = new Point(16, 129);
            lblegresosFinancieros.Name = "lblegresosFinancieros";
            lblegresosFinancieros.Size = new Size(110, 15);
            lblegresosFinancieros.TabIndex = 31;
            lblegresosFinancieros.Text = "Egresos Financieros";
            // 
            // lblingresosFinancieros
            // 
            lblingresosFinancieros.AutoSize = true;
            lblingresosFinancieros.Location = new Point(12, 86);
            lblingresosFinancieros.Name = "lblingresosFinancieros";
            lblingresosFinancieros.Size = new Size(114, 15);
            lblingresosFinancieros.TabIndex = 30;
            lblingresosFinancieros.Text = "Ingresos Financieros";
            // 
            // lblfechaFinanzas
            // 
            lblfechaFinanzas.AutoSize = true;
            lblfechaFinanzas.Location = new Point(28, 230);
            lblfechaFinanzas.Name = "lblfechaFinanzas";
            lblfechaFinanzas.Size = new Size(86, 15);
            lblfechaFinanzas.TabIndex = 42;
            lblfechaFinanzas.Text = "Fecha Finanzas";
            // 
            // dtpfechaFinanzas
            // 
            dtpfechaFinanzas.Format = DateTimePickerFormat.Short;
            dtpfechaFinanzas.Location = new Point(159, 224);
            dtpfechaFinanzas.Name = "dtpfechaFinanzas";
            dtpfechaFinanzas.Size = new Size(100, 23);
            dtpfechaFinanzas.TabIndex = 41;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 43;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageFinanzas);
            tabControl1.Location = new Point(28, 305);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 147);
            tabControl1.TabIndex = 45;
            // 
            // tabPageFinanzas
            // 
            tabPageFinanzas.Controls.Add(grdFinanzas);
            tabPageFinanzas.Location = new Point(4, 24);
            tabPageFinanzas.Name = "tabPageFinanzas";
            tabPageFinanzas.Padding = new Padding(3);
            tabPageFinanzas.Size = new Size(721, 119);
            tabPageFinanzas.TabIndex = 0;
            tabPageFinanzas.Text = "Finanzas";
            tabPageFinanzas.UseVisualStyleBackColor = true;
            // 
            // grdFinanzas
            // 
            grdFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdFinanzas.Location = new Point(3, 3);
            grdFinanzas.Name = "grdFinanzas";
            grdFinanzas.Size = new Size(712, 116);
            grdFinanzas.TabIndex = 0;
            grdFinanzas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmFinanzas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(btnGuardar);
            Controls.Add(lblfechaFinanzas);
            Controls.Add(dtpfechaFinanzas);
            Controls.Add(cboidAreaF);
            Controls.Add(lblidAreaF);
            Controls.Add(txtnombreAreaF);
            Controls.Add(txtresponsableF);
            Controls.Add(lblResponsableF);
            Controls.Add(lblnombreAreaF);
            Controls.Add(lblareaFinanzas);
            Controls.Add(txtegresosFinancieros);
            Controls.Add(txtingresosFinancieros);
            Controls.Add(lblegresosFinancieros);
            Controls.Add(lblingresosFinancieros);
            Name = "frmFinanzas";
            Text = "frmFinanzas";
            Load += frmFinanzas_Load;
            tabControl1.ResumeLayout(false);
            tabPageFinanzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdFinanzas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboidAreaF;
        private Label lblidAreaF;
        private TextBox txtnombreAreaF;
        private TextBox txtresponsableF;
        private Label lblResponsableF;
        private Label lblnombreAreaF;
        private Label lblareaFinanzas;
        private TextBox txtegresosFinancieros;
        private TextBox txtingresosFinancieros;
        private Label lblegresosFinancieros;
        private Label lblingresosFinancieros;
        private Label lblfechaFinanzas;
        private DateTimePicker dtpfechaFinanzas;
        private Button btnGuardar;
        private TabControl tabControl1;
        private TabPage tabPageFinanzas;
        private DataGridView grdFinanzas;
    }
}