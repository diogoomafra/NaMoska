namespace NaMoska
{
    partial class Tempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tempo));
            btnplay15 = new Button();
            btnplay30 = new Button();
            btnplay60 = new Button();
            SuspendLayout();
            // 
            // btnplay15
            // 
            btnplay15.BackColor = Color.Transparent;
            btnplay15.BackgroundImage = (Image)resources.GetObject("btnplay15.BackgroundImage");
            btnplay15.BackgroundImageLayout = ImageLayout.Stretch;
            btnplay15.FlatStyle = FlatStyle.Flat;
            btnplay15.ForeColor = Color.Transparent;
            btnplay15.Location = new Point(168, 490);
            btnplay15.Name = "btnplay15";
            btnplay15.Size = new Size(52, 41);
            btnplay15.TabIndex = 0;
            btnplay15.UseVisualStyleBackColor = false;
            btnplay15.Click += btnplay15_Click;
            // 
            // btnplay30
            // 
            btnplay30.BackColor = Color.Transparent;
            btnplay30.BackgroundImage = (Image)resources.GetObject("btnplay30.BackgroundImage");
            btnplay30.BackgroundImageLayout = ImageLayout.Stretch;
            btnplay30.FlatStyle = FlatStyle.Flat;
            btnplay30.ForeColor = Color.Transparent;
            btnplay30.Location = new Point(605, 490);
            btnplay30.Name = "btnplay30";
            btnplay30.Size = new Size(51, 42);
            btnplay30.TabIndex = 1;
            btnplay30.UseVisualStyleBackColor = false;
            btnplay30.Click += btnplay30_Click_1;
            // 
            // btnplay60
            // 
            btnplay60.BackColor = Color.Transparent;
            btnplay60.BackgroundImage = (Image)resources.GetObject("btnplay60.BackgroundImage");
            btnplay60.BackgroundImageLayout = ImageLayout.Stretch;
            btnplay60.FlatStyle = FlatStyle.Flat;
            btnplay60.ForeColor = Color.Transparent;
            btnplay60.Location = new Point(1042, 490);
            btnplay60.Name = "btnplay60";
            btnplay60.Size = new Size(52, 41);
            btnplay60.TabIndex = 2;
            btnplay60.UseVisualStyleBackColor = false;
            btnplay60.Click += btnplay60_Click_2;
            // 
            // Tempo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnplay60);
            Controls.Add(btnplay30);
            Controls.Add(btnplay15);
            DoubleBuffered = true;
            Name = "Tempo";
            Text = "timer";
            Load += timer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnplay15;
        private Button button1;
        private Button button2;
        private Button btnplay30;
        private Button btnplay60;
    }
}