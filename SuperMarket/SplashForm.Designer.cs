namespace SuperMarket
{
    partial class SplashForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            myProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.White;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(1, 235);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(648, 360);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Text = "guna2CircleButton1";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(85, 31);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(504, 39);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "SuperMarket Management System";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(289, 126);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(81, 22);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "version 1.0";
            // 
            // myProgressBar
            // 
            myProgressBar.BackColor = Color.Transparent;
            myProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
            myProgressBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myProgressBar.ForeColor = Color.White;
            myProgressBar.Location = new Point(255, 76);
            myProgressBar.Minimum = 0;
            myProgressBar.Name = "myProgressBar";
            myProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            myProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            myProgressBar.Size = new Size(153, 153);
            myProgressBar.TabIndex = 3;
            myProgressBar.Text = "guna2CircleProgressBar1";
            myProgressBar.UseTransparentBackground = true;
            myProgressBar.ValueChanged += guna2CircleProgressBar1_ValueChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(650, 400);
            Controls.Add(myProgressBar);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2CircleButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar myProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}