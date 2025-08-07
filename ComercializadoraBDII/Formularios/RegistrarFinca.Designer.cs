namespace ComercializadoraBDII.Formularios
{
    partial class RegistrarFinca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarFinca));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtCodigoProductor = new TextBox();
            label3 = new Label();
            txtProductor = new TextBox();
            label4 = new Label();
            txtFinca = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            nudArea = new NumericUpDown();
            label7 = new Label();
            btAgregar = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudArea).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 15);
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
            label1.Location = new Point(229, 206);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Finca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 248);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 2;
            label2.Text = "Código Productor:";
            // 
            // txtCodigoProductor
            // 
            txtCodigoProductor.Location = new Point(308, 245);
            txtCodigoProductor.Name = "txtCodigoProductor";
            txtCodigoProductor.Size = new Size(116, 23);
            txtCodigoProductor.TabIndex = 1;
            txtCodigoProductor.TextAlign = HorizontalAlignment.Center;
            txtCodigoProductor.Leave += txtCodigoProductor_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 280);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtProductor
            // 
            txtProductor.Enabled = false;
            txtProductor.Location = new Point(229, 279);
            txtProductor.Name = "txtProductor";
            txtProductor.Size = new Size(224, 23);
            txtProductor.TabIndex = 5;
            txtProductor.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(152, 316);
            label4.Name = "label4";
            label4.Size = new Size(112, 17);
            label4.TabIndex = 7;
            label4.Text = "Nombre de finca:";
            // 
            // txtFinca
            // 
            txtFinca.Location = new Point(270, 313);
            txtFinca.Name = "txtFinca";
            txtFinca.Size = new Size(183, 23);
            txtFinca.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(152, 351);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 9;
            label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(229, 348);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(224, 52);
            txtDireccion.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(152, 409);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 11;
            label6.Text = "Area total:";
            // 
            // nudArea
            // 
            nudArea.Location = new Point(229, 409);
            nudArea.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudArea.Name = "nudArea";
            nudArea.Size = new Size(152, 23);
            nudArea.TabIndex = 4;
            nudArea.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(387, 409);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 13;
            label7.Text = "hectáreas";
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgregar.Location = new Point(270, 438);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 66);
            btAgregar.TabIndex = 5;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(284, 506);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 15;
            label8.Text = "Agregar";
            // 
            // RegistrarFinca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 537);
            Controls.Add(label8);
            Controls.Add(btAgregar);
            Controls.Add(label7);
            Controls.Add(nudArea);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtFinca);
            Controls.Add(label4);
            Controls.Add(txtProductor);
            Controls.Add(label3);
            Controls.Add(txtCodigoProductor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrarFinca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Fincas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtCodigoProductor;
        private Label label3;
        private TextBox txtProductor;
        private Button button1;
        private Label label4;
        private TextBox txtFinca;
        private Label label5;
        private TextBox txtDireccion;
        private Label label6;
        private NumericUpDown nudArea;
        private Label label7;
        private Button btAgregar;
        private Label label8;
    }
}