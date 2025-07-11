namespace Vacacionalsemanados
{
    partial class frmMercadeo
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
            txttotalMercadeo = new TextBox();
            txtlineaMercadeo = new TextBox();
            lbltotalMercadeo = new Label();
            lbllineaMercadeo = new Label();
            tabpageMercadeo = new TabControl();
            tabPageFinanzas = new TabPage();
            grdMercadeo = new DataGridView();
            btnGuardar = new Button();
            tabpageMercadeo.SuspendLayout();
            tabPageFinanzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdMercadeo).BeginInit();
            SuspendLayout();
            // 
            // txttotalMercadeo
            // 
            txttotalMercadeo.Location = new Point(170, 93);
            txttotalMercadeo.Name = "txttotalMercadeo";
            txttotalMercadeo.Size = new Size(181, 23);
            txttotalMercadeo.TabIndex = 37;
            // 
            // txtlineaMercadeo
            // 
            txtlineaMercadeo.Location = new Point(166, 47);
            txtlineaMercadeo.Name = "txtlineaMercadeo";
            txtlineaMercadeo.Size = new Size(181, 23);
            txtlineaMercadeo.TabIndex = 36;
            // 
            // lbltotalMercadeo
            // 
            lbltotalMercadeo.AutoSize = true;
            lbltotalMercadeo.Location = new Point(35, 93);
            lbltotalMercadeo.Name = "lbltotalMercadeo";
            lbltotalMercadeo.Size = new Size(88, 15);
            lbltotalMercadeo.TabIndex = 35;
            lbltotalMercadeo.Text = "Total Mercadeo";
            // 
            // lbllineaMercadeo
            // 
            lbllineaMercadeo.AutoSize = true;
            lbllineaMercadeo.Location = new Point(31, 50);
            lbllineaMercadeo.Name = "lbllineaMercadeo";
            lbllineaMercadeo.Size = new Size(91, 15);
            lbllineaMercadeo.TabIndex = 34;
            lbllineaMercadeo.Text = "Linea Mercadeo";
            // 
            // tabpageMercadeo
            // 
            tabpageMercadeo.Controls.Add(tabPageFinanzas);
            tabpageMercadeo.Location = new Point(35, 181);
            tabpageMercadeo.Name = "tabpageMercadeo";
            tabpageMercadeo.SelectedIndex = 0;
            tabpageMercadeo.Size = new Size(729, 147);
            tabpageMercadeo.TabIndex = 47;
            // 
            // tabPageFinanzas
            // 
            tabPageFinanzas.Controls.Add(grdMercadeo);
            tabPageFinanzas.Location = new Point(4, 24);
            tabPageFinanzas.Name = "tabPageFinanzas";
            tabPageFinanzas.Padding = new Padding(3);
            tabPageFinanzas.Size = new Size(721, 119);
            tabPageFinanzas.TabIndex = 0;
            tabPageFinanzas.Text = "Mercadeo";
            tabPageFinanzas.UseVisualStyleBackColor = true;
            // 
            // grdMercadeo
            // 
            grdMercadeo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMercadeo.Location = new Point(3, 3);
            grdMercadeo.Name = "grdMercadeo";
            grdMercadeo.Size = new Size(712, 116);
            grdMercadeo.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(35, 148);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 46;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmMercadeo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabpageMercadeo);
            Controls.Add(btnGuardar);
            Controls.Add(txttotalMercadeo);
            Controls.Add(txtlineaMercadeo);
            Controls.Add(lbltotalMercadeo);
            Controls.Add(lbllineaMercadeo);
            Name = "frmMercadeo";
            Text = "frmMercadeo";
            tabpageMercadeo.ResumeLayout(false);
            tabPageFinanzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdMercadeo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttotalMercadeo;
        private TextBox txtlineaMercadeo;
        private Label lbltotalMercadeo;
        private Label lbllineaMercadeo;
        private TabControl tabpageMercadeo;
        private TabPage tabPageFinanzas;
        private DataGridView grdMercadeo;
        private Button btnGuardar;
    }
}