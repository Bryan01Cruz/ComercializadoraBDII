namespace ComercializadoraBDII.Formularios
{
    partial class RegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCliente));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            cbbTipoIdentidad = new ComboBox();
            label4 = new Label();
            txtIdentidad = new MaskedTextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            txtTelefono = new MaskedTextBox();
            btGuardar = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 166);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 205);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 204);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(112, 240);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 4;
            label3.Text = "Tipo Identidad:";
            // 
            // cbbTipoIdentidad
            // 
            cbbTipoIdentidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoIdentidad.FormattingEnabled = true;
            cbbTipoIdentidad.Items.AddRange(new object[] { "DNI", "RTN" });
            cbbTipoIdentidad.Location = new Point(217, 239);
            cbbTipoIdentidad.Name = "cbbTipoIdentidad";
            cbbTipoIdentidad.Size = new Size(186, 23);
            cbbTipoIdentidad.TabIndex = 2;
            cbbTipoIdentidad.SelectedIndexChanged += cbbTipoIdentidad_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 277);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 6;
            label4.Text = "Identidad:";
            // 
            // txtIdentidad
            // 
            txtIdentidad.Location = new Point(183, 275);
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(220, 23);
            txtIdentidad.TabIndex = 3;
            txtIdentidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 311);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 8;
            label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(183, 310);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(220, 58);
            txtDireccion.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(116, 380);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 10;
            label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(184, 378);
            txtTelefono.Mask = "####-####";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(219, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // btGuardar
            // 
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Location = new Point(225, 407);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(81, 77);
            btGuardar.TabIndex = 6;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(244, 487);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 13;
            label7.Text = "Guardar";
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 507);
            Controls.Add(label7);
            Controls.Add(btGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtIdentidad);
            Controls.Add(label4);
            Controls.Add(cbbTipoIdentidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Cliente";
            Load += RegistrarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private ComboBox cbbTipoIdentidad;
        private Label label4;
        private MaskedTextBox txtIdentidad;
        private Label label5;
        private TextBox txtDireccion;
        private Label label6;
        private MaskedTextBox txtTelefono;
        private Button btGuardar;
        private Label label7;
    }
}