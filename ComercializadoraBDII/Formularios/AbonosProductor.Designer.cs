namespace ComercializadoraBDII.Formularios
{
    partial class AbonosProductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbonosProductor));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btAgregar = new Button();
            txtCodigoProductor = new TextBox();
            txtProductor = new TextBox();
            dtpFecha = new DateTimePicker();
            cbbMetodo = new ComboBox();
            nudMonto = new NumericUpDown();
            label8 = new Label();
            cbbCosecha = new ComboBox();
            label9 = new Label();
            nudSaldo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaldo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 200);
            label1.Name = "label1";
            label1.Size = new Size(267, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar abono a Productor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 239);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 2;
            label2.Text = "Código Productor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 272);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(110, 307);
            label4.Name = "label4";
            label4.Size = new Size(108, 17);
            label4.TabIndex = 4;
            label4.Text = "Código Cosecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(172, 346);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 5;
            label5.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(105, 378);
            label6.Name = "label6";
            label6.Size = new Size(113, 17);
            label6.TabIndex = 6;
            label6.Text = "Método de pago:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(164, 445);
            label7.Name = "label7";
            label7.Size = new Size(111, 17);
            label7.TabIndex = 7;
            label7.Text = "Monto a abonar:";
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Location = new Point(224, 477);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 69);
            btAgregar.TabIndex = 6;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // txtCodigoProductor
            // 
            txtCodigoProductor.Location = new Point(236, 238);
            txtCodigoProductor.Name = "txtCodigoProductor";
            txtCodigoProductor.Size = new Size(168, 23);
            txtCodigoProductor.TabIndex = 1;
            txtCodigoProductor.TextAlign = HorizontalAlignment.Center;
            txtCodigoProductor.Leave += txtCodigoProductor_Leave;
            // 
            // txtProductor
            // 
            txtProductor.Enabled = false;
            txtProductor.Location = new Point(177, 271);
            txtProductor.Name = "txtProductor";
            txtProductor.Size = new Size(227, 23);
            txtProductor.TabIndex = 10;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd-MM-yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(224, 342);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(180, 23);
            dtpFecha.TabIndex = 3;
            // 
            // cbbMetodo
            // 
            cbbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMetodo.FormattingEnabled = true;
            cbbMetodo.Items.AddRange(new object[] { "Cheque", "Deposito" });
            cbbMetodo.Location = new Point(224, 377);
            cbbMetodo.Name = "cbbMetodo";
            cbbMetodo.Size = new Size(180, 23);
            cbbMetodo.TabIndex = 4;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(281, 445);
            nudMonto.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(123, 23);
            nudMonto.TabIndex = 5;
            nudMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(218, 549);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 15;
            label8.Text = "Agregar Abono";
            // 
            // cbbCosecha
            // 
            cbbCosecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCosecha.FormattingEnabled = true;
            cbbCosecha.Location = new Point(224, 306);
            cbbCosecha.Name = "cbbCosecha";
            cbbCosecha.Size = new Size(180, 23);
            cbbCosecha.TabIndex = 2;
            cbbCosecha.SelectedIndexChanged += cbbCosecha_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(93, 414);
            label9.Name = "label9";
            label9.Size = new Size(182, 17);
            label9.TabIndex = 17;
            label9.Text = "Saldo Disponible de cosecha:";
            // 
            // nudSaldo
            // 
            nudSaldo.Enabled = false;
            nudSaldo.Location = new Point(281, 411);
            nudSaldo.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudSaldo.Name = "nudSaldo";
            nudSaldo.Size = new Size(123, 23);
            nudSaldo.TabIndex = 18;
            nudSaldo.TextAlign = HorizontalAlignment.Right;
            // 
            // AbonosProductor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 571);
            Controls.Add(nudSaldo);
            Controls.Add(label9);
            Controls.Add(cbbCosecha);
            Controls.Add(label8);
            Controls.Add(nudMonto);
            Controls.Add(cbbMetodo);
            Controls.Add(dtpFecha);
            Controls.Add(txtProductor);
            Controls.Add(txtCodigoProductor);
            Controls.Add(btAgregar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AbonosProductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AbonosProductor";
            Load += AbonosProductor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btAgregar;
        private TextBox txtCodigoProductor;
        private TextBox txtProductor;
        private DateTimePicker dtpFecha;
        private ComboBox cbbMetodo;
        private NumericUpDown nudMonto;
        private Label label8;
        private ComboBox cbbCosecha;
        private Label label9;
        private NumericUpDown nudSaldo;
    }
}