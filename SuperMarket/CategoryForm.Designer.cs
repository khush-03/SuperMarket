namespace SuperMarket
{
    partial class CategoryForm
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
            dataGridView_category = new DataGridView();
            label6 = new Label();
            TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            TextBox_desc = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            panel1 = new Panel();
            button_delete = new Button();
            button_update = new Button();
            button_add = new Button();
            label_logout = new Label();
            label_selling = new Label();
            label_product = new Label();
            label_seller = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_category).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_category
            // 
            dataGridView_category.BackgroundColor = Color.White;
            dataGridView_category.ColumnHeadersHeight = 24;
            dataGridView_category.Location = new Point(291, 76);
            dataGridView_category.Name = "dataGridView_category";
            dataGridView_category.RowHeadersWidth = 51;
            dataGridView_category.RowTemplate.Height = 29;
            dataGridView_category.Size = new Size(499, 396);
            dataGridView_category.TabIndex = 16;
            dataGridView_category.CellContentClick += dataGridView_category_CellContentClick;
            dataGridView_category.Click += dataGridView_category_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(255, 10);
            label6.Name = "label6";
            label6.Size = new Size(259, 27);
            label6.TabIndex = 13;
            label6.Text = "MANAGE CATEGORIES";
            // 
            // TextBox_id
            // 
            TextBox_id.BorderRadius = 18;
            TextBox_id.CustomizableEdges = customizableEdges1;
            TextBox_id.DefaultText = "";
            TextBox_id.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_id.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_id.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_id.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_id.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_id.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_id.ForeColor = Color.Black;
            TextBox_id.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_id.Location = new Point(116, 110);
            TextBox_id.Name = "TextBox_id";
            TextBox_id.PasswordChar = '\0';
            TextBox_id.PlaceholderText = "";
            TextBox_id.SelectedText = "";
            TextBox_id.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBox_id.Size = new Size(136, 26);
            TextBox_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 110);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // TextBox_name
            // 
            TextBox_name.BorderRadius = 18;
            TextBox_name.CustomizableEdges = customizableEdges3;
            TextBox_name.DefaultText = "";
            TextBox_name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_name.ForeColor = Color.Black;
            TextBox_name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_name.Location = new Point(116, 164);
            TextBox_name.Name = "TextBox_name";
            TextBox_name.PasswordChar = '\0';
            TextBox_name.PlaceholderText = "";
            TextBox_name.SelectedText = "";
            TextBox_name.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBox_name.Size = new Size(136, 26);
            TextBox_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 164);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // TextBox_desc
            // 
            TextBox_desc.BorderRadius = 18;
            TextBox_desc.CustomizableEdges = customizableEdges5;
            TextBox_desc.DefaultText = "";
            TextBox_desc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_desc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_desc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_desc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_desc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_desc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_desc.ForeColor = Color.Black;
            TextBox_desc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_desc.Location = new Point(116, 216);
            TextBox_desc.Name = "TextBox_desc";
            TextBox_desc.PasswordChar = '\0';
            TextBox_desc.PlaceholderText = "";
            TextBox_desc.SelectedText = "";
            TextBox_desc.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBox_desc.Size = new Size(136, 26);
            TextBox_desc.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 222);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(dataGridView_category);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TextBox_id);
            panel1.Controls.Add(button_delete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBox_name);
            panel1.Controls.Add(button_update);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(TextBox_desc);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(113, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 479);
            panel1.TabIndex = 5;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.Navy;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(187, 313);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(80, 29);
            button_delete.TabIndex = 12;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.FlatAppearance.BorderSize = 0;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(101, 313);
            button_update.Name = "button_update";
            button_update.Size = new Size(80, 29);
            button_update.TabIndex = 11;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_add
            // 
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(18, 313);
            button_add.Name = "button_add";
            button_add.Size = new Size(62, 29);
            button_add.TabIndex = 10;
            button_add.Text = "add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label_logout
            // 
            label_logout.AutoSize = true;
            label_logout.BackColor = Color.WhiteSmoke;
            label_logout.ForeColor = Color.Navy;
            label_logout.Location = new Point(4, 481);
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
            label_selling.BackColor = Color.WhiteSmoke;
            label_selling.ForeColor = Color.Navy;
            label_selling.Location = new Point(5, 179);
            label_selling.Name = "label_selling";
            label_selling.Size = new Size(64, 20);
            label_selling.TabIndex = 8;
            label_selling.Text = "SELLING";
            label_selling.Click += label_selling_Click;
            // 
            // label_product
            // 
            label_product.AutoSize = true;
            label_product.BackColor = Color.WhiteSmoke;
            label_product.ForeColor = Color.Navy;
            label_product.Location = new Point(1, 130);
            label_product.Name = "label_product";
            label_product.Size = new Size(75, 20);
            label_product.TabIndex = 7;
            label_product.Text = "PRODUCT";
            label_product.Click += label_product_Click;
            // 
            // label_seller
            // 
            label_seller.AutoSize = true;
            label_seller.BackColor = Color.WhiteSmoke;
            label_seller.ForeColor = Color.Navy;
            label_seller.Location = new Point(13, 83);
            label_seller.Name = "label_seller";
            label_seller.Size = new Size(56, 20);
            label_seller.TabIndex = 6;
            label_seller.Text = "SELLER";
            label_seller.Click += label_seller_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 510);
            Controls.Add(panel1);
            Controls.Add(label_logout);
            Controls.Add(label_selling);
            Controls.Add(label_product);
            Controls.Add(label_seller);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_category).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_category;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_desc;
        private Label label4;
        private Panel panel1;
        private Button button_delete;
        private Button button_update;
        private Button button_add;
        private Label label_logout;
        private Label label_selling;
        private Label label_product;
        private Label label_seller;
    }
}