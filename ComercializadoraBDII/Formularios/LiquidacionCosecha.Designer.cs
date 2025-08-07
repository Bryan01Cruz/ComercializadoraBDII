namespace ComercializadoraBDII.Formularios
{
    partial class LiquidacionCosecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiquidacionCosecha));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            cbbCosecha = new ComboBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            cbbMetodo = new ComboBox();
            label5 = new Label();
            nudMonto = new NumericUpDown();
            label6 = new Label();
            btAgregar = new Button();
            label7 = new Label();
            label8 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 234);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 1;
            label1.Text = "Código Productor:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(232, 233);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(167, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.Leave += txtCodigo_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 296);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 3;
            label2.Text = "Código de Cosecha:";
            // 
            // cbbCosecha
            // 
            cbbCosecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCosecha.FormattingEnabled = true;
            cbbCosecha.Location = new Point(232, 296);
            cbbCosecha.Name = "cbbCosecha";
            cbbCosecha.Size = new Size(167, 23);
            cbbCosecha.TabIndex = 2;
            cbbCosecha.SelectedIndexChanged += cbbCosecha_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(180, 333);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 5;
            label3.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(232, 329);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(167, 23);
            dtpFecha.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 363);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 7;
            label4.Text = "Método de pago:";
            // 
            // cbbMetodo
            // 
            cbbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMetodo.FormattingEnabled = true;
            cbbMetodo.Items.AddRange(new object[] { "Deposito", "Cheque" });
            cbbMetodo.Location = new Point(232, 362);
            cbbMetodo.Name = "cbbMetodo";
            cbbMetodo.Size = new Size(167, 23);
            cbbMetodo.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 396);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 9;
            label5.Text = "Monto:";
            // 
            // nudMonto
            // 
            nudMonto.Enabled = false;
            nudMonto.Location = new Point(232, 396);
            nudMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(167, 23);
            nudMonto.TabIndex = 5;
            nudMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(156, 197);
            label6.Name = "label6";
            label6.Size = new Size(201, 25);
            label6.TabIndex = 11;
            label6.Text = "Registrar Liquidación";
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Location = new Point(232, 434);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 72);
            btAgregar.TabIndex = 6;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(209, 509);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 13;
            label7.Text = "Agregar Liquidación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(106, 265);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 14;
            label8.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 265);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 15;
            // 
            // LiquidacionCosecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 540);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btAgregar);
            Controls.Add(label6);
            Controls.Add(nudMonto);
            Controls.Add(label5);
            Controls.Add(cbbMetodo);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(cbbCosecha);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LiquidacionCosecha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liquidacion de Cosecha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private ComboBox cbbCosecha;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private ComboBox cbbMetodo;
        private Label label5;
        private NumericUpDown nudMonto;
        private Label label6;
        private Button btAgregar;
        private Label label7;
        private Label label8;
        private TextBox txtNombre;
    }
}