namespace ComercializadoraBDII.Formularios
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            txtContrasena = new MaskedTextBox();
            chkVer = new CheckBox();
            btIniciarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 226);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "Inicio de sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 264);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(166, 263);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 23);
            txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 298);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(166, 297);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(169, 23);
            txtContrasena.TabIndex = 5;
            // 
            // chkVer
            // 
            chkVer.AutoSize = true;
            chkVer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkVer.Location = new Point(341, 297);
            chkVer.Name = "chkVer";
            chkVer.Size = new Size(46, 21);
            chkVer.TabIndex = 6;
            chkVer.Text = "Ver";
            chkVer.UseVisualStyleBackColor = true;
            chkVer.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btIniciarSesion
            // 
            btIniciarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btIniciarSesion.Location = new Point(188, 332);
            btIniciarSesion.Name = "btIniciarSesion";
            btIniciarSesion.Size = new Size(104, 27);
            btIniciarSesion.TabIndex = 7;
            btIniciarSesion.Text = "Iniciar sesión";
            btIniciarSesion.UseVisualStyleBackColor = true;
            btIniciarSesion.Click += button1_Click;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 374);
            Controls.Add(btIniciarSesion);
            Controls.Add(chkVer);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "IniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comercializadora Agrícola DBII";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private MaskedTextBox txtContrasena;
        private CheckBox chkVer;
        private Button btIniciarSesion;
    }
}