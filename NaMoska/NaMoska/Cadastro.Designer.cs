namespace NaMoska
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            linkLabel1 = new LinkLabel();
            btn_criar = new Button();
            txbUsuarioReg = new TextBox();
            txbSenhaReg = new TextBox();
            txbConfSenha = new TextBox();
            btn_checkpass = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(576, 649);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Voltar ao login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_criar
            // 
            btn_criar.BackgroundImage = (Image)resources.GetObject("btn_criar.BackgroundImage");
            btn_criar.FlatAppearance.BorderSize = 0;
            btn_criar.FlatStyle = FlatStyle.Flat;
            btn_criar.Location = new Point(465, 563);
            btn_criar.Name = "btn_criar";
            btn_criar.Size = new Size(332, 83);
            btn_criar.TabIndex = 1;
            btn_criar.UseVisualStyleBackColor = true;
            btn_criar.Click += button1_Click;
            // 
            // txbUsuarioReg
            // 
            txbUsuarioReg.BackColor = Color.DarkGray;
            txbUsuarioReg.BorderStyle = BorderStyle.None;
            txbUsuarioReg.ForeColor = Color.Transparent;
            txbUsuarioReg.Location = new Point(431, 228);
            txbUsuarioReg.Multiline = true;
            txbUsuarioReg.Name = "txbUsuarioReg";
            txbUsuarioReg.Size = new Size(397, 49);
            txbUsuarioReg.TabIndex = 2;
            txbUsuarioReg.TextChanged += txbUsuarioReg_TextChanged;
            // 
            // txbSenhaReg
            // 
            txbSenhaReg.BackColor = Color.DarkGray;
            txbSenhaReg.BorderStyle = BorderStyle.None;
            txbSenhaReg.ForeColor = Color.Transparent;
            txbSenhaReg.Location = new Point(431, 357);
            txbSenhaReg.Multiline = true;
            txbSenhaReg.Name = "txbSenhaReg";
            txbSenhaReg.Size = new Size(397, 49);
            txbSenhaReg.TabIndex = 3;
            // 
            // txbConfSenha
            // 
            txbConfSenha.BackColor = Color.DarkGray;
            txbConfSenha.BorderStyle = BorderStyle.None;
            txbConfSenha.Location = new Point(431, 489);
            txbConfSenha.Multiline = true;
            txbConfSenha.Name = "txbConfSenha";
            txbConfSenha.Size = new Size(397, 49);
            txbConfSenha.TabIndex = 4;
            // 
            // btn_checkpass
            // 
            btn_checkpass.BackColor = Color.Transparent;
            btn_checkpass.BackgroundImage = (Image)resources.GetObject("btn_checkpass.BackgroundImage");
            btn_checkpass.BackgroundImageLayout = ImageLayout.Stretch;
            btn_checkpass.Cursor = Cursors.Hand;
            btn_checkpass.FlatStyle = FlatStyle.Flat;
            btn_checkpass.ForeColor = Color.Transparent;
            btn_checkpass.Location = new Point(862, 364);
            btn_checkpass.Name = "btn_checkpass";
            btn_checkpass.Size = new Size(39, 36);
            btn_checkpass.TabIndex = 5;
            btn_checkpass.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(btn_checkpass);
            Controls.Add(txbConfSenha);
            Controls.Add(txbSenhaReg);
            Controls.Add(txbUsuarioReg);
            Controls.Add(btn_criar);
            Controls.Add(linkLabel1);
            DoubleBuffered = true;
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btn_criar;
        private TextBox txbUsuarioReg;
        private TextBox txbSenhaReg;
        private TextBox txbConfSenha;
        private Button button2;
        private Button btn_checkpass;
    }
}