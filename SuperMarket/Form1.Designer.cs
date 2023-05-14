namespace SuperMarket
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label_clear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            comboBox_role = new ComboBox();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            Button_login = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label_clear
            // 
            label_clear.BackColor = Color.Transparent;
            label_clear.Font = new Font("Century Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label_clear.Location = new Point(628, 370);
            label_clear.Name = "label_clear";
            label_clear.Size = new Size(46, 23);
            label_clear.TabIndex = 0;
            label_clear.Text = "clear";
            label_clear.Click += label_clear_Click;
            label_clear.MouseEnter += label_clear_MouseEnter;
            label_clear.MouseLeave += label_clear_MouseLeave;
            // 
            // comboBox_role
            // 
            comboBox_role.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_role.ForeColor = Color.Navy;
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            comboBox_role.Location = new Point(573, 126);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(160, 29);
            comboBox_role.TabIndex = 1;
            comboBox_role.Text = "select role";
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Navy;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(-143, -28);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(513, 503);
            guna2CircleButton1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(425, 209);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 3;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(425, 255);
            label2.Name = "label2";
            label2.Size = new Size(135, 27);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(586, 42);
            label3.Name = "label3";
            label3.Size = new Size(110, 37);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // TextBox_username
            // 
            TextBox_username.BorderRadius = 18;
            TextBox_username.CustomizableEdges = customizableEdges2;
            TextBox_username.DefaultText = "";
            TextBox_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_username.Location = new Point(562, 201);
            TextBox_username.Name = "TextBox_username";
            TextBox_username.PasswordChar = '\0';
            TextBox_username.PlaceholderText = "";
            TextBox_username.SelectedText = "";
            TextBox_username.ShadowDecoration.CustomizableEdges = customizableEdges3;
            TextBox_username.Size = new Size(197, 35);
            TextBox_username.TabIndex = 6;
            // 
            // TextBox_password
            // 
            TextBox_password.BorderRadius = 18;
            TextBox_password.CustomizableEdges = customizableEdges4;
            TextBox_password.DefaultText = "";
            TextBox_password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_password.Location = new Point(562, 247);
            TextBox_password.Name = "TextBox_password";
            TextBox_password.PasswordChar = '●';
            TextBox_password.PlaceholderText = "";
            TextBox_password.SelectedText = "";
            TextBox_password.ShadowDecoration.CustomizableEdges = customizableEdges5;
            TextBox_password.Size = new Size(197, 35);
            TextBox_password.TabIndex = 7;
            TextBox_password.UseSystemPasswordChar = true;
            // 
            // Button_login
            // 
            Button_login.BorderRadius = 18;
            Button_login.CustomizableEdges = customizableEdges6;
            Button_login.DisabledState.BorderColor = Color.DarkGray;
            Button_login.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_login.FillColor = Color.Navy;
            Button_login.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button_login.ForeColor = Color.White;
            Button_login.Location = new Point(562, 301);
            Button_login.Name = "Button_login";
            Button_login.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Button_login.Size = new Size(174, 54);
            Button_login.TabIndex = 8;
            Button_login.Text = "LOGIN";
            Button_login.Click += Button_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 171);
            label4.Name = "label4";
            label4.Size = new Size(201, 34);
            label4.TabIndex = 9;
            label4.Text = "SUPERMARKET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 205);
            label5.Name = "label5";
            label5.Size = new Size(196, 34);
            label5.TabIndex = 10;
            label5.Text = "APPLICATION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Navy;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 56);
            label6.Name = "label6";
            label6.Size = new Size(153, 34);
            label6.TabIndex = 11;
            label6.Text = "WELCOME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Button_login);
            Controls.Add(TextBox_password);
            Controls.Add(TextBox_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2CircleButton1);
            Controls.Add(comboBox_role);
            Controls.Add(label_clear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel label_clear;
        private ComboBox comboBox_role;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}