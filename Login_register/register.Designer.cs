namespace Login_register
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRNombre = new System.Windows.Forms.TextBox();
            this.txtRUsuario = new System.Windows.Forms.TextBox();
            this.txtRContraseña = new System.Windows.Forms.TextBox();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.btnRregistarse = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registra tu cuenta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // txtRNombre
            // 
            this.txtRNombre.Location = new System.Drawing.Point(59, 120);
            this.txtRNombre.Name = "txtRNombre";
            this.txtRNombre.PlaceholderText = "Nombre Completo";
            this.txtRNombre.Size = new System.Drawing.Size(215, 23);
            this.txtRNombre.TabIndex = 2;
            // 
            // txtRUsuario
            // 
            this.txtRUsuario.Location = new System.Drawing.Point(59, 180);
            this.txtRUsuario.Name = "txtRUsuario";
            this.txtRUsuario.PlaceholderText = "Usuario";
            this.txtRUsuario.Size = new System.Drawing.Size(215, 23);
            this.txtRUsuario.TabIndex = 3;
            // 
            // txtRContraseña
            // 
            this.txtRContraseña.Location = new System.Drawing.Point(59, 240);
            this.txtRContraseña.Name = "txtRContraseña";
            this.txtRContraseña.PlaceholderText = "Contraseña";
            this.txtRContraseña.Size = new System.Drawing.Size(215, 23);
            this.txtRContraseña.TabIndex = 4;
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(59, 298);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.PlaceholderText = "email@gmail.com";
            this.txtREmail.Size = new System.Drawing.Size(215, 23);
            this.txtREmail.TabIndex = 5;
            // 
            // btnRregistarse
            // 
            this.btnRregistarse.BackColor = System.Drawing.Color.Teal;
            this.btnRregistarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRregistarse.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRregistarse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRregistarse.Location = new System.Drawing.Point(72, 355);
            this.btnRregistarse.Name = "btnRregistarse";
            this.btnRregistarse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRregistarse.Size = new System.Drawing.Size(174, 38);
            this.btnRregistarse.TabIndex = 6;
            this.btnRregistarse.Text = "Registrarse";
            this.btnRregistarse.UseVisualStyleBackColor = false;
            this.btnRregistarse.Click += new System.EventHandler(this.btnRregistarse_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 408);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Acuerdo con";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(128, 408);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "condiciones y politica de uso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnRregistarse);
            this.Controls.Add(this.txtREmail);
            this.Controls.Add(this.txtRContraseña);
            this.Controls.Add(this.txtRUsuario);
            this.Controls.Add(this.txtRNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.Text = "register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRNombre;
        private TextBox txtRUsuario;
        private TextBox txtRContraseña;
        private TextBox txtREmail;
        private Button btnRregistarse;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}