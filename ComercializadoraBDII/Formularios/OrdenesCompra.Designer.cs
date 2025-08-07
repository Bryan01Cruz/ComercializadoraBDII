namespace ComercializadoraBDII.Formularios
{
    partial class OrdenesCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesCompra));
            splitContainer1 = new SplitContainer();
            btRecibir = new Button();
            txtProveedor = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dvgOrdenes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgOrdenes).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(btRecibir);
            splitContainer1.Panel1.Controls.Add(txtProveedor);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtCodigo);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dvgOrdenes);
            splitContainer1.Size = new Size(800, 475);
            splitContainer1.SplitterDistance = 186;
            splitContainer1.TabIndex = 0;
            // 
            // btRecibir
            // 
            btRecibir.BackColor = SystemColors.Control;
            btRecibir.Enabled = false;
            btRecibir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRecibir.Location = new Point(458, 142);
            btRecibir.Name = "btRecibir";
            btRecibir.Size = new Size(130, 30);
            btRecibir.TabIndex = 2;
            btRecibir.Text = "Recibir";
            btRecibir.UseVisualStyleBackColor = false;
            btRecibir.Click += btRecibir_Click;
            // 
            // txtProveedor
            // 
            txtProveedor.Enabled = false;
            txtProveedor.Location = new Point(428, 105);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(226, 23);
            txtProveedor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(351, 106);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 4;
            label3.Text = "Proveedor:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(493, 68);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(134, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(374, 69);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 2;
            label2.Text = "Código de orden:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 23);
            label1.Name = "label1";
            label1.Size = new Size(303, 32);
            label1.TabIndex = 1;
            label1.Text = "Recibir Orden de Compra";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dvgOrdenes
            // 
            dvgOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrdenes.Dock = DockStyle.Fill;
            dvgOrdenes.Location = new Point(0, 0);
            dvgOrdenes.Name = "dvgOrdenes";
            dvgOrdenes.ReadOnly = true;
            dvgOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgOrdenes.Size = new Size(800, 285);
            dvgOrdenes.TabIndex = 0;
            // 
            // OrdenesCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OrdenesCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordenes Compra";
            Load += OrdenesCompra_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgOrdenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dvgOrdenes;
        private TextBox txtCodigo;
        private Label label2;
        private Button btRecibir;
        private TextBox txtProveedor;
        private Label label3;
    }
}