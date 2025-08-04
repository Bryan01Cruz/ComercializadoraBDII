namespace ComercializadoraBDII.Formularios
{
    partial class RegistrarLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLote));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtCodigoFinca = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtFinca = new TextBox();
            label4 = new Label();
            txtCodigoProducto = new TextBox();
            label5 = new Label();
            txtProducto = new TextBox();
            label6 = new Label();
            nudArea = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            cbbTipoSuelo = new ComboBox();
            label9 = new Label();
            cbbTipoRiego = new ComboBox();
            btGuardar = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudArea).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 8);
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
            label1.Location = new Point(238, 193);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Lotes";
            // 
            // txtCodigoFinca
            // 
            txtCodigoFinca.Location = new Point(238, 226);
            txtCodigoFinca.Name = "txtCodigoFinca";
            txtCodigoFinca.Size = new Size(186, 23);
            txtCodigoFinca.TabIndex = 2;
            txtCodigoFinca.TextAlign = HorizontalAlignment.Center;
            txtCodigoFinca.Leave += txtCodigoFinca_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 227);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 3;
            label2.Text = "Código de finca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 262);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 5;
            label3.Text = "Finca:";
            // 
            // txtFinca
            // 
            txtFinca.Enabled = false;
            txtFinca.Location = new Point(177, 259);
            txtFinca.Name = "txtFinca";
            txtFinca.Size = new Size(279, 23);
            txtFinca.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 293);
            label4.Name = "label4";
            label4.Size = new Size(133, 17);
            label4.TabIndex = 7;
            label4.Text = "Código de Producto:";
            label4.Click += label4_Click;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(268, 292);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(156, 23);
            txtCodigoProducto.TabIndex = 8;
            txtCodigoProducto.TextAlign = HorizontalAlignment.Center;
            txtCodigoProducto.Leave += txtCodigoProducto_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 326);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 10;
            label5.Text = "Producto:";
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Location = new Point(207, 325);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(249, 23);
            txtProducto.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(134, 360);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 12;
            label6.Text = "Area total:";
            // 
            // nudArea
            // 
            nudArea.Location = new Point(207, 358);
            nudArea.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudArea.Name = "nudArea";
            nudArea.Size = new Size(177, 23);
            nudArea.TabIndex = 14;
            nudArea.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(390, 360);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 15;
            label7.Text = "hectáreas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 393);
            label8.Name = "label8";
            label8.Size = new Size(92, 17);
            label8.TabIndex = 16;
            label8.Text = "Tipo de suelo:";
            // 
            // cbbTipoSuelo
            // 
            cbbTipoSuelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoSuelo.FormattingEnabled = true;
            cbbTipoSuelo.Location = new Point(123, 392);
            cbbTipoSuelo.Name = "cbbTipoSuelo";
            cbbTipoSuelo.Size = new Size(175, 23);
            cbbTipoSuelo.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(304, 395);
            label9.Name = "label9";
            label9.Size = new Size(91, 17);
            label9.TabIndex = 18;
            label9.Text = "Tipo de riego:";
            // 
            // cbbTipoRiego
            // 
            cbbTipoRiego.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoRiego.FormattingEnabled = true;
            cbbTipoRiego.Location = new Point(396, 392);
            cbbTipoRiego.Name = "cbbTipoRiego";
            cbbTipoRiego.Size = new Size(175, 23);
            cbbTipoRiego.TabIndex = 19;
            // 
            // btGuardar
            // 
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btGuardar.Location = new Point(260, 434);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(82, 78);
            btGuardar.TabIndex = 23;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(278, 514);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 25;
            label12.Text = "Guardar";
            // 
            // RegistrarLote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 540);
            Controls.Add(label12);
            Controls.Add(btGuardar);
            Controls.Add(cbbTipoRiego);
            Controls.Add(label9);
            Controls.Add(cbbTipoSuelo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(nudArea);
            Controls.Add(label6);
            Controls.Add(txtProducto);
            Controls.Add(label5);
            Controls.Add(txtCodigoProducto);
            Controls.Add(label4);
            Controls.Add(txtFinca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigoFinca);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrarLote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Lotes";
            Load += RegistrarLote_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtCodigoFinca;
        private Label label2;
        private Label label3;
        private TextBox txtFinca;
        private Label label4;
        private TextBox txtCodigoProducto;
        private Label label5;
        private TextBox txtProducto;
        private Label label6;
        private NumericUpDown nudArea;
        private Label label7;
        private Label label8;
        private ComboBox cbbTipoSuelo;
        private Label label9;
        private ComboBox cbbTipoRiego;
        private Button btGuardar;
        private Label label12;
    }
}