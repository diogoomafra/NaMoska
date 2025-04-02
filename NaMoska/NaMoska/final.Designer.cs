namespace NaMoska
{
    partial class final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(final));
            lblClics = new Label();
            lblSeg = new Label();
            btnVoltar = new Button();
            linlblsalvar = new LinkLabel();
            SuspendLayout();
            // 
            // lblClics
            // 
            lblClics.AutoSize = true;
            lblClics.BackColor = Color.Transparent;
            lblClics.FlatStyle = FlatStyle.Flat;
            lblClics.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClics.Location = new Point(455, 333);
            lblClics.Name = "lblClics";
            lblClics.Size = new Size(50, 42);
            lblClics.TabIndex = 0;
            lblClics.Text = "21";
            // 
            // lblSeg
            // 
            lblSeg.AutoSize = true;
            lblSeg.BackColor = Color.Transparent;
            lblSeg.FlatStyle = FlatStyle.Flat;
            lblSeg.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeg.Location = new Point(558, 452);
            lblSeg.Name = "lblSeg";
            lblSeg.Size = new Size(50, 42);
            lblSeg.TabIndex = 1;
            lblSeg.Text = "21";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BackgroundImage = (Image)resources.GetObject("btnVoltar.BackgroundImage");
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.ForeColor = Color.Transparent;
            btnVoltar.Location = new Point(401, 509);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(461, 95);
            btnVoltar.TabIndex = 2;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // linlblsalvar
            // 
            linlblsalvar.ActiveLinkColor = SystemColors.Highlight;
            linlblsalvar.AutoSize = true;
            linlblsalvar.BackColor = SystemColors.ControlLight;
            linlblsalvar.LinkColor = Color.Blue;
            linlblsalvar.Location = new Point(568, 629);
            linlblsalvar.Name = "linlblsalvar";
            linlblsalvar.Size = new Size(137, 20);
            linlblsalvar.TabIndex = 3;
            linlblsalvar.TabStop = true;
            linlblsalvar.Text = "Salvar meu recorde";
            // 
            // final
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(linlblsalvar);
            Controls.Add(btnVoltar);
            Controls.Add(lblSeg);
            Controls.Add(lblClics);
            DoubleBuffered = true;
            Name = "final";
            Text = "final";
            Load += final_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClics;
        private Label lblSeg;
        private Button btnVoltar;
        private LinkLabel linlblsalvar;
    }
}