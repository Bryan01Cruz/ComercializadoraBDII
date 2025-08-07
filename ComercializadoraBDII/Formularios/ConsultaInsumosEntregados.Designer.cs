namespace ComercializadoraBDII.Formularios
{
    partial class ConsultaInsumosEntregados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaInsumosEntregados));
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btBuscar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvInsumos = new DataGridView();
            Agricultor = new DataGridViewTextBoxColumn();
            CodigoInsumo = new DataGridViewTextBoxColumn();
            Insumo = new DataGridViewTextBoxColumn();
            Recibidos = new DataGridViewTextBoxColumn();
            UnidadMedida = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(btBuscar);
            splitContainer1.Panel1.Controls.Add(txtBuscar);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvInsumos);
            splitContainer1.Size = new Size(800, 475);
            splitContainer1.SplitterDistance = 183;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(352, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 69);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 31);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 2;
            label4.Text = "Insumo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 31);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 1;
            label3.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "Agricultor";
            // 
            // btBuscar
            // 
            btBuscar.BackgroundImage = (Image)resources.GetObject("btBuscar.BackgroundImage");
            btBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btBuscar.Location = new Point(606, 78);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 61);
            btBuscar.TabIndex = 3;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(352, 145);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(329, 23);
            txtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 35);
            label1.Name = "label1";
            label1.Size = new Size(297, 32);
            label1.TabIndex = 1;
            label1.Text = "INSUMOS ENTREGADOS ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvInsumos
            // 
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Columns.AddRange(new DataGridViewColumn[] { Agricultor, CodigoInsumo, Insumo, Recibidos, UnidadMedida });
            dgvInsumos.Dock = DockStyle.Fill;
            dgvInsumos.Location = new Point(0, 0);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.Size = new Size(800, 288);
            dgvInsumos.TabIndex = 0;
            // 
            // Agricultor
            // 
            Agricultor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Agricultor.DataPropertyName = "Agricultor";
            Agricultor.HeaderText = "Agricultor";
            Agricultor.Name = "Agricultor";
            // 
            // CodigoInsumo
            // 
            CodigoInsumo.DataPropertyName = "CodigoInsumo";
            CodigoInsumo.HeaderText = "Codigo Insumo";
            CodigoInsumo.Name = "CodigoInsumo";
            CodigoInsumo.Width = 120;
            // 
            // Insumo
            // 
            Insumo.DataPropertyName = "Insumo";
            Insumo.HeaderText = "Insumo";
            Insumo.Name = "Insumo";
            Insumo.Width = 150;
            // 
            // Recibidos
            // 
            Recibidos.DataPropertyName = "Recibidos";
            Recibidos.HeaderText = "Recibidos";
            Recibidos.Name = "Recibidos";
            // 
            // UnidadMedida
            // 
            UnidadMedida.DataPropertyName = "UnidadMedida";
            UnidadMedida.HeaderText = "Unidad Medida";
            UnidadMedida.Name = "UnidadMedida";
            UnidadMedida.Width = 120;
            // 
            // ConsultaInsumosEntregados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConsultaInsumosEntregados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insumos Entregados";
            Load += ConsultaInsumosEntregados_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvInsumos;
        private Label label3;
        private Label label2;
        private Label label4;
        private DataGridViewTextBoxColumn Agricultor;
        private DataGridViewTextBoxColumn CodigoInsumo;
        private DataGridViewTextBoxColumn Insumo;
        private DataGridViewTextBoxColumn Recibidos;
        private DataGridViewTextBoxColumn UnidadMedida;
    }
}