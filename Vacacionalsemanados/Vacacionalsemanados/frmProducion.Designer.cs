namespace Vacacionalsemanados
{
    partial class frmProducion
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
            lbllineaProduccion = new Label();
            lbltotalProduccion = new Label();
            txtlineaProduccion = new TextBox();
            txttotalProduccion = new TextBox();
            lblareaProduccion = new Label();
            txtnombreAreaP = new TextBox();
            txtresponsableP = new TextBox();
            lblResponsableP = new Label();
            lblnombreAreap = new Label();
            cboidAreaP = new ComboBox();
            lblidAreaP = new Label();
            SuspendLayout();
            // 
            // lbllineaProduccion
            // 
            lbllineaProduccion.AutoSize = true;
            lbllineaProduccion.Location = new Point(58, 116);
            lbllineaProduccion.Name = "lbllineaProduccion";
            lbllineaProduccion.Size = new Size(99, 15);
            lbllineaProduccion.TabIndex = 0;
            lbllineaProduccion.Text = "Linea Producciòn";
            // 
            // lbltotalProduccion
            // 
            lbltotalProduccion.AutoSize = true;
            lbltotalProduccion.Location = new Point(58, 175);
            lbltotalProduccion.Name = "lbltotalProduccion";
            lbltotalProduccion.Size = new Size(96, 15);
            lbltotalProduccion.TabIndex = 1;
            lbltotalProduccion.Text = "Total Producciòn";
            // 
            // txtlineaProduccion
            // 
            txtlineaProduccion.Location = new Point(193, 113);
            txtlineaProduccion.Name = "txtlineaProduccion";
            txtlineaProduccion.Size = new Size(181, 23);
            txtlineaProduccion.TabIndex = 2;
            // 
            // txttotalProduccion
            // 
            txttotalProduccion.Location = new Point(193, 175);
            txttotalProduccion.Name = "txttotalProduccion";
            txttotalProduccion.Size = new Size(181, 23);
            txttotalProduccion.TabIndex = 3;
            // 
            // lblareaProduccion
            // 
            lblareaProduccion.AutoSize = true;
            lblareaProduccion.BorderStyle = BorderStyle.FixedSingle;
            lblareaProduccion.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblareaProduccion.ForeColor = SystemColors.ControlText;
            lblareaProduccion.Location = new Point(58, 26);
            lblareaProduccion.Name = "lblareaProduccion";
            lblareaProduccion.Size = new Size(230, 32);
            lblareaProduccion.TabIndex = 4;
            lblareaProduccion.Text = "Area Producciòn";
            // 
            // txtnombreAreaP
            // 
            txtnombreAreaP.Location = new Point(607, 108);
            txtnombreAreaP.Name = "txtnombreAreaP";
            txtnombreAreaP.Size = new Size(181, 23);
            txtnombreAreaP.TabIndex = 16;
            // 
            // txtresponsableP
            // 
            txtresponsableP.Location = new Point(607, 167);
            txtresponsableP.Name = "txtresponsableP";
            txtresponsableP.Size = new Size(181, 23);
            txtresponsableP.TabIndex = 15;
            // 
            // lblResponsableP
            // 
            lblResponsableP.AutoSize = true;
            lblResponsableP.Location = new Point(461, 175);
            lblResponsableP.Name = "lblResponsableP";
            lblResponsableP.Size = new Size(120, 15);
            lblResponsableP.TabIndex = 14;
            lblResponsableP.Text = "Responsable Del Area";
            // 
            // lblnombreAreap
            // 
            lblnombreAreap.AutoSize = true;
            lblnombreAreap.Location = new Point(461, 113);
            lblnombreAreap.Name = "lblnombreAreap";
            lblnombreAreap.Size = new Size(78, 15);
            lblnombreAreap.TabIndex = 13;
            lblnombreAreap.Text = "Nombre Area";
            // 
            // cboidAreaP
            // 
            cboidAreaP.FormattingEnabled = true;
            cboidAreaP.Location = new Point(607, 224);
            cboidAreaP.Name = "cboidAreaP";
            cboidAreaP.Size = new Size(121, 23);
            cboidAreaP.TabIndex = 18;
            cboidAreaP.SelectedIndexChanged += cboidAreaP_SelectedIndexChanged;
            // 
            // lblidAreaP
            // 
            lblidAreaP.AutoSize = true;
            lblidAreaP.Location = new Point(537, 227);
            lblidAreaP.Name = "lblidAreaP";
            lblidAreaP.Size = new Size(44, 15);
            lblidAreaP.TabIndex = 17;
            lblidAreaP.Text = "Id Area";
            // 
            // frmProducion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboidAreaP);
            Controls.Add(lblidAreaP);
            Controls.Add(txtnombreAreaP);
            Controls.Add(txtresponsableP);
            Controls.Add(lblResponsableP);
            Controls.Add(lblnombreAreap);
            Controls.Add(lblareaProduccion);
            Controls.Add(txttotalProduccion);
            Controls.Add(txtlineaProduccion);
            Controls.Add(lbltotalProduccion);
            Controls.Add(lbllineaProduccion);
            Name = "frmProducion";
            Text = "frmProducion";
            Load += frmProducion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllineaProduccion;
        private Label lbltotalProduccion;
        private TextBox txtlineaProduccion;
        private TextBox txttotalProduccion;
        private Label lblareaProduccion;
        private TextBox txtnombreAreaP;
        private TextBox txtresponsableP;
        private Label lblResponsableP;
        private Label lblnombreAreap;
        private ComboBox cboidAreaP;
        private Label lblidAreaP;
    }
}