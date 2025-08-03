namespace ComercializadoraBDII.Formularios
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            txtContrasena = new MaskedTextBox();
            chkVer = new CheckBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(126, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 205);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 1;
            label1.Text = "Gestión de usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 238);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 237);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 272);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 307);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(175, 306);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(150, 23);
            txtContrasena.TabIndex = 7;
            // 
            // chkVer
            // 
            chkVer.AutoSize = true;
            chkVer.Location = new Point(331, 308);
            chkVer.Name = "chkVer";
            chkVer.Size = new Size(42, 19);
            chkVer.TabIndex = 8;
            chkVer.Text = "Ver";
            chkVer.UseVisualStyleBackColor = true;
            chkVer.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 341);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 9;
            label5.Text = "Departamento:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 340);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(94, 374);
            label6.Name = "label6";
            label6.Size = new Size(99, 17);
            label6.TabIndex = 11;
            label6.Text = "Administrador:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Si", "No" });
            comboBox2.Location = new Point(199, 373);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 23);
            comboBox2.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(115, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 74);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(196, 402);
            button2.Name = "button2";
            button2.Size = new Size(75, 74);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(277, 402);
            button3.Name = "button3";
            button3.Size = new Size(75, 74);
            button3.TabIndex = 15;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(330, 263);
            button4.Name = "button4";
            button4.Size = new Size(43, 38);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(126, 478);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 17;
            label7.Text = "Guardar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(209, 478);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 18;
            label8.Text = "Eliminar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(285, 478);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 19;
            label9.Text = "Actualizar";
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 511);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(chkVer);
            Controls.Add(txtContrasena);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Nuevo Usuario";
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
        private TextBox textBox2;
        private Label label4;
        private MaskedTextBox txtContrasena;
        private CheckBox chkVer;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}