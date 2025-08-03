namespace ComercializadoraBDII.Formularios
{
    partial class AgregarInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarInsumo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            cbbTipoInsumo = new ComboBox();
            label5 = new Label();
            cbbUnidad = new ComboBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            btGuardar = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 13);
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
            label1.Location = new Point(174, 198);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Insumo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 236);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 236);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(114, 269);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 6;
            label4.Text = "Tipo de Insumo:";
            // 
            // cbbTipoInsumo
            // 
            cbbTipoInsumo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTipoInsumo.FormattingEnabled = true;
            cbbTipoInsumo.Location = new Point(221, 268);
            cbbTipoInsumo.Name = "cbbTipoInsumo";
            cbbTipoInsumo.Size = new Size(175, 23);
            cbbTipoInsumo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(114, 300);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 9;
            label5.Text = "Unidad de medida:";
            // 
            // cbbUnidad
            // 
            cbbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUnidad.FormattingEnabled = true;
            cbbUnidad.Location = new Point(235, 299);
            cbbUnidad.Name = "cbbUnidad";
            cbbUnidad.Size = new Size(161, 23);
            cbbUnidad.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(114, 327);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 11;
            label6.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(190, 347);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(206, 77);
            txtDescripcion.TabIndex = 12;
            // 
            // btGuardar
            // 
            btGuardar.BackgroundImage = (Image)resources.GetObject("btGuardar.BackgroundImage");
            btGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btGuardar.Location = new Point(221, 430);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 69);
            btGuardar.TabIndex = 13;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(236, 499);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 14;
            label7.Text = "Agregar";
            // 
            // AgregarInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 521);
            Controls.Add(label7);
            Controls.Add(btGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(cbbUnidad);
            Controls.Add(label5);
            Controls.Add(cbbTipoInsumo);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AgregarInsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Nuevo Insumo";
            Load += AgregarInsumo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cbbTipoInsumo;
        private Label label5;
        private ComboBox cbbUnidad;
        private Label label6;
        private TextBox txtDescripcion;
        private Button btGuardar;
        private Label label7;
    }
}