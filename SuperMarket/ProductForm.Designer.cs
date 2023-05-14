namespace SuperMarket
{
    partial class ProductForm
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
            panel1 = new Panel();
            dataGridView_product = new DataGridView();
            button_Refresh = new Button();
            comboBox_search = new ComboBox();
            label6 = new Label();
            TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            button_delete = new Button();
            label1 = new Label();
            TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            button_update = new Button();
            label2 = new Label();
            button_add = new Button();
            TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            comboBox_category = new ComboBox();
            label4 = new Label();
            TextBox_qty = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label_seller = new Label();
            label_category = new Label();
            label_selling = new Label();
            label_logout = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_product).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(dataGridView_product);
            panel1.Controls.Add(button_Refresh);
            panel1.Controls.Add(comboBox_search);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TextBox_id);
            panel1.Controls.Add(button_delete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBox_name);
            panel1.Controls.Add(button_update);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(TextBox_price);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_category);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TextBox_qty);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(119, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 479);
            panel1.TabIndex = 0;
            // 
            // dataGridView_product
            // 
            dataGridView_product.BackgroundColor = Color.White;
            dataGridView_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_product.Location = new Point(297, 112);
            dataGridView_product.Name = "dataGridView_product";
            dataGridView_product.RowHeadersWidth = 51;
            dataGridView_product.RowTemplate.Height = 29;
            dataGridView_product.Size = new Size(493, 360);
            dataGridView_product.TabIndex = 16;
            dataGridView_product.Click += dataGridView_product_Click;
            // 
            // button_Refresh
            // 
            button_Refresh.FlatAppearance.BorderSize = 0;
            button_Refresh.FlatStyle = FlatStyle.Flat;
            button_Refresh.ForeColor = Color.White;
            button_Refresh.Location = new Point(577, 59);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(70, 29);
            button_Refresh.TabIndex = 15;
            button_Refresh.Text = "Refresh";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // comboBox_search
            // 
            comboBox_search.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox_search.FormattingEnabled = true;
            comboBox_search.Location = new Point(403, 59);
            comboBox_search.Name = "comboBox_search";
            comboBox_search.Size = new Size(151, 25);
            comboBox_search.TabIndex = 14;
            comboBox_search.Text = "select category";
            comboBox_search.SelectionChangeCommitted += comboBox_search_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(314, 0);
            label6.Name = "label6";
            label6.Size = new Size(237, 27);
            label6.TabIndex = 13;
            label6.Text = "MANAGE PRODUCTS";
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
            TextBox_id.Location = new Point(107, 53);
            TextBox_id.Name = "TextBox_id";
            TextBox_id.PasswordChar = '\0';
            TextBox_id.PlaceholderText = "";
            TextBox_id.SelectedText = "";
            TextBox_id.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBox_id.Size = new Size(136, 27);
            TextBox_id.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 59);
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
            TextBox_name.Location = new Point(107, 100);
            TextBox_name.Name = "TextBox_name";
            TextBox_name.PasswordChar = '\0';
            TextBox_name.PlaceholderText = "";
            TextBox_name.SelectedText = "";
            TextBox_name.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBox_name.Size = new Size(136, 27);
            TextBox_name.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 100);
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
            button_add.Location = new Point(18, 313);
            button_add.Name = "button_add";
            button_add.Size = new Size(62, 29);
            button_add.TabIndex = 10;
            button_add.Text = "add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // TextBox_price
            // 
            TextBox_price.BorderRadius = 18;
            TextBox_price.CustomizableEdges = customizableEdges5;
            TextBox_price.DefaultText = "";
            TextBox_price.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_price.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_price.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_price.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_price.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_price.ForeColor = Color.Black;
            TextBox_price.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_price.Location = new Point(107, 143);
            TextBox_price.Name = "TextBox_price";
            TextBox_price.PasswordChar = '\0';
            TextBox_price.PlaceholderText = "";
            TextBox_price.SelectedText = "";
            TextBox_price.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBox_price.Size = new Size(136, 27);
            TextBox_price.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 251);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Category";
            // 
            // comboBox_category
            // 
            comboBox_category.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox_category.FormattingEnabled = true;
            comboBox_category.Location = new Point(117, 247);
            comboBox_category.Name = "comboBox_category";
            comboBox_category.Size = new Size(151, 25);
            comboBox_category.TabIndex = 9;
            comboBox_category.Text = "select category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 149);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Price";
            // 
            // TextBox_qty
            // 
            TextBox_qty.BorderRadius = 18;
            TextBox_qty.CustomizableEdges = customizableEdges7;
            TextBox_qty.DefaultText = "";
            TextBox_qty.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox_qty.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox_qty.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox_qty.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox_qty.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_qty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_qty.ForeColor = Color.Black;
            TextBox_qty.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox_qty.Location = new Point(107, 187);
            TextBox_qty.Name = "TextBox_qty";
            TextBox_qty.PasswordChar = '\0';
            TextBox_qty.PlaceholderText = "";
            TextBox_qty.SelectedText = "";
            TextBox_qty.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TextBox_qty.Size = new Size(136, 27);
            TextBox_qty.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 187);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // label_seller
            // 
            label_seller.AutoSize = true;
            label_seller.BackColor = Color.White;
            label_seller.ForeColor = Color.Navy;
            label_seller.Location = new Point(37, 88);
            label_seller.Name = "label_seller";
            label_seller.Size = new Size(56, 20);
            label_seller.TabIndex = 1;
            label_seller.Text = "SELLER";
            label_seller.Click += label_seller_Click;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.BackColor = Color.White;
            label_category.ForeColor = Color.Navy;
            label_category.Location = new Point(11, 135);
            label_category.Name = "label_category";
            label_category.Size = new Size(81, 20);
            label_category.TabIndex = 2;
            label_category.Text = "CATEGORY";
            label_category.Click += label_category_Click;
            // 
            // label_selling
            // 
            label_selling.AutoSize = true;
            label_selling.BackColor = Color.White;
            label_selling.ForeColor = Color.Navy;
            label_selling.Location = new Point(29, 179);
            label_selling.Name = "label_selling";
            label_selling.Size = new Size(64, 20);
            label_selling.TabIndex = 3;
            label_selling.Text = "SELLING";
            label_selling.Click += label_selling_Click;
            // 
            // label_logout
            // 
            label_logout.AutoSize = true;
            label_logout.BackColor = Color.White;
            label_logout.ForeColor = Color.Navy;
            label_logout.Location = new Point(21, 481);
            label_logout.Name = "label_logout";
            label_logout.Size = new Size(65, 20);
            label_logout.TabIndex = 4;
            label_logout.Text = "LOGOUT";
            label_logout.Click += label_logout_Click;
            label_logout.MouseEnter += label_logout_MouseEnter;
            label_logout.MouseLeave += label_logout_MouseLeave;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(917, 509);
            Controls.Add(label_logout);
            Controls.Add(label_selling);
            Controls.Add(label_category);
            Controls.Add(label_seller);
            Controls.Add(panel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button_delete;
        private Button button_update;
        private Button button_add;
        private ComboBox comboBox_category;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_qty;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private Label label1;
        private Label label6;
        private Button button_Refresh;
        private ComboBox comboBox_search;
        private Label label_seller;
        private Label label_category;
        private Label label_selling;
        private Label label_logout;
        private DataGridView dataGridView_product;
    }
}