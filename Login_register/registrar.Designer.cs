namespace Login_register
{
    partial class registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrar));
            this.txtRNombre = new System.Windows.Forms.TextBox();
            this.txtRUser = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.btnRregistrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRNombre
            // 
            this.txtRNombre.Location = new System.Drawing.Point(64, 83);
            this.txtRNombre.Name = "txtRNombre";
            this.txtRNombre.PlaceholderText = "Nombre completo";
            this.txtRNombre.Size = new System.Drawing.Size(234, 23);
            this.txtRNombre.TabIndex = 0;
            // 
            // txtRUser
            // 
            this.txtRUser.Location = new System.Drawing.Point(64, 134);
            this.txtRUser.Name = "txtRUser";
            this.txtRUser.PlaceholderText = "UserName";
            this.txtRUser.Size = new System.Drawing.Size(234, 23);
            this.txtRUser.TabIndex = 1;
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(64, 197);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.PlaceholderText = "Contraseña";
            this.txtRPass.Size = new System.Drawing.Size(234, 23);
            this.txtRPass.TabIndex = 2;
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(64, 258);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.PlaceholderText = "Email@gmail.com";
            this.txtREmail.Size = new System.Drawing.Size(234, 23);
            this.txtREmail.TabIndex = 3;
            // 
            // btnRregistrarse
            // 
            this.btnRregistrarse.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRregistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRregistrarse.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRregistrarse.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRregistrarse.Location = new System.Drawing.Point(74, 327);
            this.btnRregistrarse.Name = "btnRregistrarse";
            this.btnRregistrarse.Size = new System.Drawing.Size(201, 37);
            this.btnRregistrarse.TabIndex = 4;
            this.btnRregistrarse.Text = "Registrarse";
            this.btnRregistrarse.UseVisualStyleBackColor = false;
            this.btnRregistrarse.Click += new System.EventHandler(this.btnRregistrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registra tu cuenta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 377);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Acuerdo con";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(115, 377);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "condiciones y politicas de uso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(333, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 446);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRregistrarse);
            this.Controls.Add(this.txtREmail);
            this.Controls.Add(this.txtRPass);
            this.Controls.Add(this.txtRUser);
            this.Controls.Add(this.txtRNombre);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRNombre;
        private TextBox txtRUser;
        private TextBox txtRPass;
        private TextBox txtREmail;
        private Button btnRregistrarse;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
    }
}