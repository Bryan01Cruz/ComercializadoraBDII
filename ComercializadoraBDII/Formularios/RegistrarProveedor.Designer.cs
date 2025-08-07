namespace ComercializadoraBDII.Formularios
{
    partial class RegistrarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProveedor));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtContacto = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtRtn = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCorreo = new TextBox();
            btGuardar = new Button();
            label7 = new Label();
            label8 = new Label();
            cbbTipoProveedor = new ComboBox();
            txtTelefono = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            txtCuentaBancaria = new TextBox();
            label11 = new Label();
            label12 = new Label();
            cbbBanco = new ComboBox();
            cbbTipoCuenta = new ComboBox();
            label13 = new Label();
            txtCondiciones = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(182, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(158, 230);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(223, 229);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(158, 261);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 3;
            label2.Text = "Contacto:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(223, 258);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(227, 23);
            txtContacto.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(223, 288);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(227, 70);
            txtDireccion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(158, 289);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 6;
            label3.Text = "Dirección:";
            // 
            // txtRtn
            // 
            txtRtn.Location = new Point(194, 364);
            txtRtn.Name = "txtRtn";
            txtRtn.Size = new Size(122, 23);
            txtRtn.TabIndex = 4;
            txtRtn.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(158, 365);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 8;
            label4.Text = "RTN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(318, 365);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 10;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(158, 395);
            label6.Name = "label6";
            label6.Size = new Size(122, 17);
            label6.TabIndex = 11;
            label6.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(286, 394);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(164, 23);
            txtCorreo.TabIndex = 6;
            // 
            // btGuardar
            // 
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btGuardar.Location = new Point(271, 605);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 72);
            btGuardar.TabIndex = 12;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(208, 194);
            label7.Name = "label7";
            label7.Size = new Size(191, 25);
            label7.TabIndex = 14;
            label7.Text = "Registrar Proveedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(158, 425);
            label8.Name = "label8";
            label8.Size = new Size(124, 17);
            label8.TabIndex = 15;
            label8.Text = "Tipo de proveedor:";
            // 
            // cbbTipoProveedor
            // 
            cbbTipoProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoProveedor.FormattingEnabled = true;
            cbbTipoProveedor.Location = new Point(286, 424);
            cbbTipoProveedor.Name = "cbbTipoProveedor";
            cbbTipoProveedor.Size = new Size(164, 23);
            cbbTipoProveedor.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(383, 364);
            txtTelefono.Mask = "####-####";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(67, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(286, 680);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 18;
            label9.Text = "Guardar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(158, 454);
            label10.Name = "label10";
            label10.Size = new Size(125, 17);
            label10.TabIndex = 19;
            label10.Text = "Número de cuenta:";
            // 
            // txtCuentaBancaria
            // 
            txtCuentaBancaria.Location = new Point(286, 453);
            txtCuentaBancaria.Name = "txtCuentaBancaria";
            txtCuentaBancaria.Size = new Size(164, 23);
            txtCuentaBancaria.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(158, 483);
            label11.Name = "label11";
            label11.Size = new Size(105, 17);
            label11.TabIndex = 21;
            label11.Text = "Banco asociado:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(158, 513);
            label12.Name = "label12";
            label12.Size = new Size(101, 17);
            label12.TabIndex = 22;
            label12.Text = "Tipo de cuenta:";
            // 
            // cbbBanco
            // 
            cbbBanco.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbBanco.FormattingEnabled = true;
            cbbBanco.Location = new Point(263, 483);
            cbbBanco.Name = "cbbBanco";
            cbbBanco.Size = new Size(187, 23);
            cbbBanco.TabIndex = 9;
            // 
            // cbbTipoCuenta
            // 
            cbbTipoCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoCuenta.FormattingEnabled = true;
            cbbTipoCuenta.Items.AddRange(new object[] { "Ahorro", "Cheques" });
            cbbTipoCuenta.Location = new Point(263, 512);
            cbbTipoCuenta.Name = "cbbTipoCuenta";
            cbbTipoCuenta.Size = new Size(187, 23);
            cbbTipoCuenta.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(158, 543);
            label13.Name = "label13";
            label13.Size = new Size(138, 17);
            label13.TabIndex = 23;
            label13.Text = "Condiciones de pago:";
            // 
            // txtCondiciones
            // 
            txtCondiciones.Location = new Point(294, 542);
            txtCondiciones.Multiline = true;
            txtCondiciones.Name = "txtCondiciones";
            txtCondiciones.Size = new Size(156, 57);
            txtCondiciones.TabIndex = 11;
            // 
            // RegistrarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 705);
            Controls.Add(txtCondiciones);
            Controls.Add(label13);
            Controls.Add(cbbTipoCuenta);
            Controls.Add(cbbBanco);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtCuentaBancaria);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtTelefono);
            Controls.Add(cbbTipoProveedor);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRtn);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(txtContacto);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegistrarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Proveedor";
            Load += RegistrarProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtContacto;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtRtn;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCorreo;
        private Button btGuardar;
        private Label label7;
        private Label label8;
        private ComboBox cbbTipoProveedor;
        private MaskedTextBox txtTelefono;
        private Label label9;
        private Label label10;
        private TextBox txtCuentaBancaria;
        private Label label11;
        private Label label12;
        private ComboBox cbbBanco;
        private ComboBox cbbTipoCuenta;
        private Label label13;
        private TextBox txtCondiciones;
    }
}