namespace NaMoska
{
    partial class jogo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jogo));
            btnMosca = new Button();
            timerMosca = new System.Windows.Forms.Timer(components);
            lblPonto = new Label();
            lblTempo = new Label();
            Seg = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnMosca
            // 
            btnMosca.BackColor = Color.Transparent;
            btnMosca.BackgroundImage = (Image)resources.GetObject("btnMosca.BackgroundImage");
            btnMosca.BackgroundImageLayout = ImageLayout.Stretch;
            btnMosca.Cursor = Cursors.Cross;
            btnMosca.ForeColor = Color.Transparent;
            btnMosca.Location = new Point(524, 326);
            btnMosca.Name = "btnMosca";
            btnMosca.Size = new Size(156, 91);
            btnMosca.TabIndex = 0;
            btnMosca.UseVisualStyleBackColor = false;
            btnMosca.Click += btnMosca_Click;
            // 
            // timerMosca
            // 
            timerMosca.Tick += timerMosca_Tick;
            // 
            // lblPonto
            // 
            lblPonto.AutoSize = true;
            lblPonto.BackColor = Color.Transparent;
            lblPonto.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPonto.ForeColor = Color.Black;
            lblPonto.Location = new Point(984, 41);
            lblPonto.Name = "lblPonto";
            lblPonto.Size = new Size(158, 45);
            lblPonto.TabIndex = 1;
            lblPonto.Text = "Pontos: 0";
            lblPonto.Click += lblPonto_Click;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.Transparent;
            lblTempo.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempo.ForeColor = Color.Black;
            lblTempo.Location = new Point(12, 41);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(154, 45);
            lblTempo.TabIndex = 2;
            lblTempo.Text = "Tempo: 0";
            lblTempo.Click += label1_Click;
            // 
            // Seg
            // 
            Seg.Tick += Seg_Tick;
            // 
            // jogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblTempo);
            Controls.Add(lblPonto);
            Controls.Add(btnMosca);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            Name = "jogo";
            Text = "jogo";
            Load += jogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMosca;
        private System.Windows.Forms.Timer timerMosca;
        private Label lblPonto;
        private Label lblTempo;
        private System.Windows.Forms.Timer Seg;
    }
}