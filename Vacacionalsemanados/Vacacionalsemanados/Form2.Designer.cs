namespace Vacacionalsemanados
{
    partial class frmInventario
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
            lblInventario = new Label();
            dtpfechaInventario = new DateTimePicker();
            cboubicacionStock = new ComboBox();
            lbltotalStock = new Label();
            lblfechaInventario = new Label();
            lblubicacionStock = new Label();
            txttotalStock = new TextBox();
            lblidArea = new Label();
            cboidArea = new ComboBox();
            lblnombreArea = new Label();
            lblResponsable = new Label();
            txtresponsableI = new TextBox();
            txtnombreAreai = new TextBox();
            SuspendLayout();
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.BorderStyle = BorderStyle.FixedSingle;
            lblInventario.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventario.Location = new Point(243, 21);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(273, 29);
            lblInventario.TabIndex = 0;
            lblInventario.Text = "formulario Inventario";
            lblInventario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpfechaInventario
            // 
            dtpfechaInventario.Format = DateTimePickerFormat.Short;
            dtpfechaInventario.Location = new Point(164, 122);
            dtpfechaInventario.Name = "dtpfechaInventario";
            dtpfechaInventario.Size = new Size(100, 23);
            dtpfechaInventario.TabIndex = 1;
            // 
            // cboubicacionStock
            // 
            cboubicacionStock.FormattingEnabled = true;
            cboubicacionStock.Location = new Point(164, 196);
            cboubicacionStock.Name = "cboubicacionStock";
            cboubicacionStock.Size = new Size(121, 23);
            cboubicacionStock.TabIndex = 2;
            // 
            // lbltotalStock
            // 
            lbltotalStock.AutoSize = true;
            lbltotalStock.Location = new Point(67, 76);
            lbltotalStock.Name = "lbltotalStock";
            lbltotalStock.Size = new Size(60, 15);
            lbltotalStock.TabIndex = 3;
            lbltotalStock.Text = "totalStock";
            // 
            // lblfechaInventario
            // 
            lblfechaInventario.AutoSize = true;
            lblfechaInventario.Location = new Point(33, 128);
            lblfechaInventario.Name = "lblfechaInventario";
            lblfechaInventario.Size = new Size(94, 15);
            lblfechaInventario.TabIndex = 5;
            lblfechaInventario.Text = "Fecha Inventario";
            // 
            // lblubicacionStock
            // 
            lblubicacionStock.AutoSize = true;
            lblubicacionStock.Location = new Point(33, 204);
            lblubicacionStock.Name = "lblubicacionStock";
            lblubicacionStock.Size = new Size(92, 15);
            lblubicacionStock.TabIndex = 6;
            lblubicacionStock.Text = "Ubicacion Stock";
            // 
            // txttotalStock
            // 
            txttotalStock.Location = new Point(164, 73);
            txttotalStock.Name = "txttotalStock";
            txttotalStock.Size = new Size(100, 23);
            txttotalStock.TabIndex = 4;
            // 
            // lblidArea
            // 
            lblidArea.AutoSize = true;
            lblidArea.Location = new Point(33, 264);
            lblidArea.Name = "lblidArea";
            lblidArea.Size = new Size(44, 15);
            lblidArea.TabIndex = 7;
            lblidArea.Text = "Id Area";
            // 
            // cboidArea
            // 
            cboidArea.FormattingEnabled = true;
            cboidArea.Location = new Point(164, 256);
            cboidArea.Name = "cboidArea";
            cboidArea.Size = new Size(121, 23);
            cboidArea.TabIndex = 8;
            cboidArea.SelectedIndexChanged += cboidArea_SelectedIndexChanged;
            // 
            // lblnombreArea
            // 
            lblnombreArea.AutoSize = true;
            lblnombreArea.Location = new Point(448, 81);
            lblnombreArea.Name = "lblnombreArea";
            lblnombreArea.Size = new Size(78, 15);
            lblnombreArea.TabIndex = 9;
            lblnombreArea.Text = "Nombre Area";
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Location = new Point(448, 128);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(120, 15);
            lblResponsable.TabIndex = 10;
            lblResponsable.Text = "Responsable Del Area";
            // 
            // txtresponsableI
            // 
            txtresponsableI.Location = new Point(594, 120);
            txtresponsableI.Name = "txtresponsableI";
            txtresponsableI.Size = new Size(181, 23);
            txtresponsableI.TabIndex = 11;
            // 
            // txtnombreAreai
            // 
            txtnombreAreai.Location = new Point(594, 76);
            txtnombreAreai.Name = "txtnombreAreai";
            txtnombreAreai.Size = new Size(181, 23);
            txtnombreAreai.TabIndex = 12;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnombreAreai);
            Controls.Add(txtresponsableI);
            Controls.Add(lblResponsable);
            Controls.Add(lblnombreArea);
            Controls.Add(cboidArea);
            Controls.Add(lblidArea);
            Controls.Add(lblubicacionStock);
            Controls.Add(lblfechaInventario);
            Controls.Add(txttotalStock);
            Controls.Add(lbltotalStock);
            Controls.Add(cboubicacionStock);
            Controls.Add(dtpfechaInventario);
            Controls.Add(lblInventario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInventario";
            Text = "formularioInventario";
            Load += frmInventario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventario;
        private DateTimePicker dtpfechaInventario;
        private ComboBox cboubicacionStock;
        private Label lbltotalStock;
        private Label lblfechaInventario;
        private Label lblubicacionStock;
        private TextBox txttotalStock;
        private Label lblidArea;
        private ComboBox cboidArea;
        private Label lblnombreArea;
        private Label lblResponsable;
        private TextBox txtresponsableI;
        private TextBox txtnombreAreai;
    }
}