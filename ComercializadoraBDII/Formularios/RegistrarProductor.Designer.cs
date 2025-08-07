namespace ComercializadoraBDII.Formularios
{
    partial class RegistrarProductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProductor));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtIdentidad = new MaskedTextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCuentaBancaria = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cbbTipoCuenta = new ComboBox();
            btAgregar = new Button();
            cbbBanco = new ComboBox();
            txtTelefono = new MaskedTextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Location = new Point(208, 199);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Productor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(144, 241);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 238);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(216, 305);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(241, 67);
            txtDireccion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(144, 272);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 5;
            label3.Text = "Identidad:";
            // 
            // txtIdentidad
            // 
            txtIdentidad.Location = new Point(216, 271);
            txtIdentidad.Mask = "####-####-#####";
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(106, 23);
            txtIdentidad.TabIndex = 2;
            txtIdentidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(144, 308);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 7;
            label4.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(272, 378);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(185, 23);
            txtCorreo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(324, 272);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 10;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(144, 381);
            label6.Name = "label6";
            label6.Size = new Size(122, 17);
            label6.TabIndex = 11;
            label6.Text = "Correo Electrónico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(144, 415);
            label7.Name = "label7";
            label7.Size = new Size(109, 17);
            label7.TabIndex = 12;
            label7.Text = "Cuenta Bancaria:";
            // 
            // txtCuentaBancaria
            // 
            txtCuentaBancaria.Location = new Point(254, 412);
            txtCuentaBancaria.MaxLength = 15;
            txtCuentaBancaria.Name = "txtCuentaBancaria";
            txtCuentaBancaria.Size = new Size(203, 23);
            txtCuentaBancaria.TabIndex = 6;
            txtCuentaBancaria.TextChanged += txtCuentaBancaria_TextChanged;
            txtCuentaBancaria.KeyPress += txtCuentaBancaria_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(144, 449);
            label8.Name = "label8";
            label8.Size = new Size(105, 17);
            label8.TabIndex = 15;
            label8.Text = "Banco asociado:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(144, 482);
            label9.Name = "label9";
            label9.Size = new Size(101, 17);
            label9.TabIndex = 17;
            label9.Text = "Tipo de cuenta:";
            // 
            // cbbTipoCuenta
            // 
            cbbTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoCuenta.FormattingEnabled = true;
            cbbTipoCuenta.Items.AddRange(new object[] { "Cheques", "Ahorro" });
            cbbTipoCuenta.Location = new Point(254, 479);
            cbbTipoCuenta.Name = "cbbTipoCuenta";
            cbbTipoCuenta.Size = new Size(203, 23);
            cbbTipoCuenta.TabIndex = 8;
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAgregar.Location = new Point(274, 508);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(78, 73);
            btAgregar.TabIndex = 9;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // cbbBanco
            // 
            cbbBanco.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbBanco.FormattingEnabled = true;
            cbbBanco.Location = new Point(255, 446);
            cbbBanco.Name = "cbbBanco";
            cbbBanco.Size = new Size(202, 23);
            cbbBanco.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(390, 271);
            txtTelefono.Mask = "####-####";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(67, 23);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(290, 582);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 22;
            label10.Text = "Guardar";
            // 
            // RegistrarProductor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 608);
            Controls.Add(label10);
            Controls.Add(txtTelefono);
            Controls.Add(cbbBanco);
            Controls.Add(btAgregar);
            Controls.Add(cbbTipoCuenta);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtCuentaBancaria);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtIdentidad);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrarProductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Productor";
            Load += RegistrarProductor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label label3;
        private MaskedTextBox txtIdentidad;
        private Label label4;
        private TextBox txtCorreo;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCuentaBancaria;
        private Label label8;
        private Label label9;
        private ComboBox cbbTipoCuenta;
        private Button btAgregar;
        private ComboBox cbbBanco;
        private MaskedTextBox txtTelefono;
        private Label label10;
    }
}