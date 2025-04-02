namespace NaMoska
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEntrar = new Button();
            txbUsuario = new TextBox();
            txbSenha = new TextBox();
            linklbl_conta = new LinkLabel();
            btn_checkpass = new Button();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonFace;
            btnEntrar.BackgroundImage = (Image)resources.GetObject("btnEntrar.BackgroundImage");
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(472, 559);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(317, 90);
            btnEntrar.TabIndex = 0;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txbUsuario
            // 
            txbUsuario.BackColor = Color.DarkGray;
            txbUsuario.BorderStyle = BorderStyle.None;
            txbUsuario.Location = new Point(432, 282);
            txbUsuario.Multiline = true;
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(397, 49);
            txbUsuario.TabIndex = 1;
            txbUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txbSenha
            // 
            txbSenha.BackColor = Color.DarkGray;
            txbSenha.BorderStyle = BorderStyle.None;
            txbSenha.Location = new Point(432, 449);
            txbSenha.Multiline = true;
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(397, 50);
            txbSenha.TabIndex = 2;
            // 
            // linklbl_conta
            // 
            linklbl_conta.AutoSize = true;
            linklbl_conta.Location = new Point(584, 652);
            linklbl_conta.Name = "linklbl_conta";
            linklbl_conta.Size = new Size(81, 20);
            linklbl_conta.TabIndex = 3;
            linklbl_conta.TabStop = true;
            linklbl_conta.Text = "Criar conta";
            linklbl_conta.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_checkpass
            // 
            btn_checkpass.BackColor = Color.Transparent;
            btn_checkpass.BackgroundImage = (Image)resources.GetObject("btn_checkpass.BackgroundImage");
            btn_checkpass.BackgroundImageLayout = ImageLayout.Stretch;
            btn_checkpass.Cursor = Cursors.Hand;
            btn_checkpass.FlatStyle = FlatStyle.Flat;
            btn_checkpass.ForeColor = Color.Transparent;
            btn_checkpass.Location = new Point(862, 456);
            btn_checkpass.Name = "btn_checkpass";
            btn_checkpass.Size = new Size(39, 36);
            btn_checkpass.TabIndex = 6;
            btn_checkpass.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(btn_checkpass);
            Controls.Add(linklbl_conta);
            Controls.Add(txbSenha);
            Controls.Add(txbUsuario);
            Controls.Add(btnEntrar);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "NaMoska";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txbUsuario;
        private TextBox txbSenha;
        private LinkLabel linklbl_conta;
        private Button btn_checkpass;
    }
}
