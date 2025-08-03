namespace ComercializadoraBDII.Formularios
{
    partial class AgregarBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarBodega));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            nudCapacidad = new NumericUpDown();
            label5 = new Label();
            btAgregar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 12);
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
            label1.Location = new Point(194, 197);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar bodega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 242);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 239);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 277);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 4;
            label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(220, 277);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(216, 79);
            txtDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 365);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 6;
            label4.Text = "Capacidad:";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(220, 366);
            nudCapacidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(144, 23);
            nudCapacidad.TabIndex = 7;
            nudCapacidad.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(370, 366);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 8;
            label5.Text = "quintales.";
            // 
            // btAgregar
            // 
            btAgregar.BackgroundImage = (Image)resources.GetObject("btAgregar.BackgroundImage");
            btAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btAgregar.Location = new Point(248, 398);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(84, 71);
            btAgregar.TabIndex = 9;
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(265, 470);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 10;
            label6.Text = "Agregar";
            // 
            // AgregarBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 494);
            Controls.Add(label6);
            Controls.Add(btAgregar);
            Controls.Add(label5);
            Controls.Add(nudCapacidad);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AgregarBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Bodega";
            Load += AgregarBodega_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label4;
        private NumericUpDown nudCapacidad;
        private Label label5;
        private Button btAgregar;
        private Label label6;
    }
}