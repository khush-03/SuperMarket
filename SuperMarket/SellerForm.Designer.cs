namespace SuperMarket
{
    partial class SellerForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label5 = new Label();
            TextBox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView_Seller = new DataGridView();
            label6 = new Label();
            TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            button_delete = new Button();
            label1 = new Label();
            TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            button_update = new Button();
            label2 = new Label();
            button_add = new Button();
            TextBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label_logout = new Label();
            label_selling = new Label();
            label_product = new Label();
            label_category = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Seller).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TextBox_pass);
            panel1.Controls.Add(dataGridView_Seller);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TextBox_id);
            panel1.Controls.Add(button_delete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBox_name);
            panel1.Controls.Add(button_update);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(TextBox_age);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TextBox_phone);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(105, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 561);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 279);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // TextBox_pass
            // 
            TextBox_pass.BorderRadius = 18;
            TextBox_pass.CustomizableEdges = customizableEdges1;
            TextBox_pass.DefaultText = "";
            TextBox_pass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_pass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_pass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_pass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_pass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_pass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_pass.ForeColor = Color.Black;
            TextBox_pass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_pass.Location = new Point(123, 272);
            TextBox_pass.Name = "TextBox_pass";
            TextBox_pass.PasswordChar = '\0';
            TextBox_pass.PlaceholderText = "";
            TextBox_pass.SelectedText = "";
            TextBox_pass.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBox_pass.Size = new Size(136, 27);
            TextBox_pass.TabIndex = 17;
            // 
            // dataGridView_Seller
            // 
            dataGridView_Seller.BackgroundColor = Color.White;
            dataGridView_Seller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Seller.Location = new Point(275, 59);
            dataGridView_Seller.Name = "dataGridView_Seller";
            dataGridView_Seller.RowHeadersWidth = 51;
            dataGridView_Seller.RowTemplate.Height = 29;
            dataGridView_Seller.Size = new Size(514, 413);
            dataGridView_Seller.TabIndex = 16;
            dataGridView_Seller.Click += dataGridView_Seller_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(314, 0);
            label6.Name = "label6";
            label6.Size = new Size(190, 27);
            label6.TabIndex = 13;
            label6.Text = "MANAGE SELLER";
            // 
            // TextBox_id
            // 
            TextBox_id.BorderRadius = 18;
            TextBox_id.CustomizableEdges = customizableEdges3;
            TextBox_id.DefaultText = "";
            TextBox_id.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_id.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_id.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_id.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_id.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_id.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_id.ForeColor = Color.Black;
            TextBox_id.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_id.Location = new Point(123, 93);
            TextBox_id.Name = "TextBox_id";
            TextBox_id.PasswordChar = '\0';
            TextBox_id.PlaceholderText = "";
            TextBox_id.SelectedText = "";
            TextBox_id.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBox_id.Size = new Size(136, 27);
            TextBox_id.TabIndex = 1;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.Navy;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(189, 349);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(80, 29);
            button_delete.TabIndex = 12;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 93);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // TextBox_name
            // 
            TextBox_name.BorderRadius = 18;
            TextBox_name.CustomizableEdges = customizableEdges5;
            TextBox_name.DefaultText = "";
            TextBox_name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_name.ForeColor = Color.Black;
            TextBox_name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_name.Location = new Point(123, 143);
            TextBox_name.Name = "TextBox_name";
            TextBox_name.PasswordChar = '\0';
            TextBox_name.PlaceholderText = "";
            TextBox_name.SelectedText = "";
            TextBox_name.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBox_name.Size = new Size(136, 27);
            TextBox_name.TabIndex = 2;
            // 
            // button_update
            // 
            button_update.FlatAppearance.BorderSize = 0;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(102, 349);
            button_update.Name = "button_update";
            button_update.Size = new Size(80, 29);
            button_update.TabIndex = 11;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 143);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // button_add
            // 
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(18, 349);
            button_add.Name = "button_add";
            button_add.Size = new Size(62, 29);
            button_add.TabIndex = 10;
            button_add.Text = "add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // TextBox_age
            // 
            TextBox_age.BorderRadius = 18;
            TextBox_age.CustomizableEdges = customizableEdges7;
            TextBox_age.DefaultText = "";
            TextBox_age.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_age.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_age.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_age.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_age.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_age.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_age.ForeColor = Color.Black;
            TextBox_age.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_age.Location = new Point(123, 188);
            TextBox_age.Name = "TextBox_age";
            TextBox_age.PasswordChar = '\0';
            TextBox_age.PlaceholderText = "";
            TextBox_age.SelectedText = "";
            TextBox_age.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TextBox_age.Size = new Size(136, 27);
            TextBox_age.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 188);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // TextBox_phone
            // 
            TextBox_phone.BorderRadius = 18;
            TextBox_phone.CustomizableEdges = customizableEdges9;
            TextBox_phone.DefaultText = "";
            TextBox_phone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_phone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_phone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_phone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_phone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_phone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_phone.ForeColor = Color.Black;
            TextBox_phone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_phone.Location = new Point(123, 232);
            TextBox_phone.Name = "TextBox_phone";
            TextBox_phone.PasswordChar = '\0';
            TextBox_phone.PlaceholderText = "";
            TextBox_phone.SelectedText = "";
            TextBox_phone.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TextBox_phone.Size = new Size(136, 27);
            TextBox_phone.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 239);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Phone number";
            // 
            // label_logout
            // 
            label_logout.AutoSize = true;
            label_logout.BackColor = SystemColors.Control;
            label_logout.ForeColor = Color.Navy;
            label_logout.Location = new Point(16, 488);
            label_logout.Name = "label_logout";
            label_logout.Size = new Size(65, 20);
            label_logout.TabIndex = 9;
            label_logout.Text = "LOGOUT";
            label_logout.Click += label_logout_Click;
            label_logout.MouseEnter += label_logout_MouseEnter;
            label_logout.MouseLeave += label_logout_MouseLeave;
            // 
            // label_selling
            // 
            label_selling.AutoSize = true;
            label_selling.BackColor = SystemColors.Control;
            label_selling.ForeColor = Color.Navy;
            label_selling.Location = new Point(16, 201);
            label_selling.Name = "label_selling";
            label_selling.Size = new Size(64, 20);
            label_selling.TabIndex = 8;
            label_selling.Text = "SELLING";
            label_selling.Click += label_selling_Click;
            // 
            // label_product
            // 
            label_product.AutoSize = true;
            label_product.BackColor = SystemColors.Control;
            label_product.ForeColor = Color.Navy;
            label_product.Location = new Point(16, 104);
            label_product.Name = "label_product";
            label_product.Size = new Size(75, 20);
            label_product.TabIndex = 6;
            label_product.Text = "PRODUCT";
            label_product.Click += label_product_Click;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.BackColor = SystemColors.Control;
            label_category.ForeColor = Color.Navy;
            label_category.Location = new Point(14, 148);
            label_category.Name = "label_category";
            label_category.Size = new Size(81, 20);
            label_category.TabIndex = 7;
            label_category.Text = "CATEGORY";
            label_category.Click += label_category_Click;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 509);
            Controls.Add(panel1);
            Controls.Add(label_logout);
            Controls.Add(label_selling);
            Controls.Add(label_product);
            Controls.Add(label_category);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SellerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellerForm";
            Load += SellerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Seller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_Seller;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private Button button_delete;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Button button_update;
        private Label label2;
        private Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_age;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private Label label3;
        private Label label_logout;
        private Label label_selling;
        private Label label_product;
        private Label label_category;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_pass;
    }
}