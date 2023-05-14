namespace SuperMarket
{
    partial class SellingForm
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
            label4 = new Label();
            label_amount = new Label();
            button4 = new Button();
            button2 = new Button();
            DataGridView_sellList = new DataGridView();
            button_refresh = new Button();
            comboBox_category = new ComboBox();
            DataGridView_product = new DataGridView();
            label_date = new Label();
            sellerName = new Label();
            dataGridView_order = new DataGridView();
            ProdId = new DataGridViewTextBoxColumn();
            ProdName = new DataGridViewTextBoxColumn();
            ProdPrice = new DataGridViewTextBoxColumn();
            ProdQty = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label6 = new Label();
            TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            button_print = new Button();
            TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            button_add = new Button();
            label2 = new Label();
            button_addOrder = new Button();
            TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            label_price = new Label();
            TextBox_qty = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label_logout = new Label();
            label_selling = new Label();
            label_category = new Label();
            label_seller = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_sellList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label_amount);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(DataGridView_sellList);
            panel1.Controls.Add(button_refresh);
            panel1.Controls.Add(comboBox_category);
            panel1.Controls.Add(DataGridView_product);
            panel1.Controls.Add(label_date);
            panel1.Controls.Add(sellerName);
            panel1.Controls.Add(dataGridView_order);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TextBox_id);
            panel1.Controls.Add(button_print);
            panel1.Controls.Add(TextBox_name);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_addOrder);
            panel1.Controls.Add(TextBox_price);
            panel1.Controls.Add(label_price);
            panel1.Controls.Add(TextBox_qty);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(98, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 603);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(519, 288);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 29;
            label4.Text = "BillId";
            // 
            // label_amount
            // 
            label_amount.AutoSize = true;
            label_amount.ForeColor = Color.White;
            label_amount.Location = new Point(621, 237);
            label_amount.Name = "label_amount";
            label_amount.Size = new Size(24, 20);
            label_amount.TabIndex = 28;
            label_amount.Text = "Ks";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(296, 280);
            button4.Name = "button4";
            button4.Size = new Size(107, 29);
            button4.TabIndex = 27;
            button4.Text = "Sells List";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(425, 233);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 25;
            button2.Text = "Amount";
            button2.UseVisualStyleBackColor = true;
            // 
            // DataGridView_sellList
            // 
            DataGridView_sellList.BackgroundColor = Color.White;
            DataGridView_sellList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_sellList.Location = new Point(293, 315);
            DataGridView_sellList.Name = "DataGridView_sellList";
            DataGridView_sellList.RowHeadersWidth = 51;
            DataGridView_sellList.RowTemplate.Height = 29;
            DataGridView_sellList.Size = new Size(514, 155);
            DataGridView_sellList.TabIndex = 24;
            // 
            // button_refresh
            // 
            button_refresh.FlatAppearance.BorderSize = 0;
            button_refresh.FlatStyle = FlatStyle.Flat;
            button_refresh.ForeColor = Color.White;
            button_refresh.Location = new Point(183, 280);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(107, 29);
            button_refresh.TabIndex = 23;
            button_refresh.Text = "Refresh";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // comboBox_category
            // 
            comboBox_category.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox_category.FormattingEnabled = true;
            comboBox_category.Location = new Point(32, 280);
            comboBox_category.Name = "comboBox_category";
            comboBox_category.Size = new Size(149, 26);
            comboBox_category.TabIndex = 22;
            comboBox_category.Text = "select category";
            comboBox_category.SelectionChangeCommitted += comboBox_category_SelectionChangeCommitted;
            // 
            // DataGridView_product
            // 
            DataGridView_product.BackgroundColor = Color.White;
            DataGridView_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_product.Location = new Point(23, 315);
            DataGridView_product.Name = "DataGridView_product";
            DataGridView_product.RowHeadersWidth = 51;
            DataGridView_product.RowTemplate.Height = 29;
            DataGridView_product.Size = new Size(245, 191);
            DataGridView_product.TabIndex = 21;
            DataGridView_product.Click += DataGridView_product_Click;
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.ForeColor = Color.White;
            label_date.Location = new Point(714, 24);
            label_date.Name = "label_date";
            label_date.Size = new Size(41, 20);
            label_date.TabIndex = 20;
            label_date.Text = "Date";
            // 
            // sellerName
            // 
            sellerName.AutoSize = true;
            sellerName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sellerName.ForeColor = Color.White;
            sellerName.Location = new Point(37, 25);
            sellerName.Name = "sellerName";
            sellerName.Size = new Size(91, 20);
            sellerName.TabIndex = 19;
            sellerName.Text = "SellerName";
            // 
            // dataGridView_order
            // 
            dataGridView_order.BackgroundColor = Color.White;
            dataGridView_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_order.Columns.AddRange(new DataGridViewColumn[] { ProdId, ProdName, ProdPrice, ProdQty, Total });
            dataGridView_order.Location = new Point(293, 93);
            dataGridView_order.Name = "dataGridView_order";
            dataGridView_order.RowHeadersWidth = 51;
            dataGridView_order.RowTemplate.Height = 29;
            dataGridView_order.Size = new Size(514, 134);
            dataGridView_order.TabIndex = 16;
            // 
            // ProdId
            // 
            ProdId.HeaderText = "ProdId";
            ProdId.MinimumWidth = 6;
            ProdId.Name = "ProdId";
            ProdId.Width = 125;
            // 
            // ProdName
            // 
            ProdName.HeaderText = "ProdName";
            ProdName.MinimumWidth = 6;
            ProdName.Name = "ProdName";
            ProdName.Width = 125;
            // 
            // ProdPrice
            // 
            ProdPrice.HeaderText = "ProdPrice";
            ProdPrice.MinimumWidth = 6;
            ProdPrice.Name = "ProdPrice";
            ProdPrice.Width = 125;
            // 
            // ProdQty
            // 
            ProdQty.HeaderText = "ProdQty";
            ProdQty.MinimumWidth = 6;
            ProdQty.Name = "ProdQty";
            ProdQty.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(373, 18);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 13;
            label6.Text = "SELLING";
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
            TextBox_id.Location = new Point(585, 281);
            TextBox_id.Name = "TextBox_id";
            TextBox_id.PasswordChar = '\0';
            TextBox_id.PlaceholderText = "";
            TextBox_id.SelectedText = "";
            TextBox_id.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBox_id.Size = new Size(136, 27);
            TextBox_id.TabIndex = 1;
            // 
            // button_print
            // 
            button_print.BackColor = Color.Navy;
            button_print.FlatAppearance.BorderSize = 0;
            button_print.FlatStyle = FlatStyle.Flat;
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(641, 485);
            button_print.Name = "button_print";
            button_print.Size = new Size(80, 29);
            button_print.TabIndex = 12;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
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
            TextBox_name.Location = new Point(123, 110);
            TextBox_name.Name = "TextBox_name";
            TextBox_name.PasswordChar = '\0';
            TextBox_name.PlaceholderText = "";
            TextBox_name.SelectedText = "";
            TextBox_name.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBox_name.Size = new Size(136, 27);
            TextBox_name.TabIndex = 2;
            // 
            // button_add
            // 
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(714, 284);
            button_add.Name = "button_add";
            button_add.Size = new Size(80, 29);
            button_add.TabIndex = 11;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 117);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // button_addOrder
            // 
            button_addOrder.FlatAppearance.BorderSize = 0;
            button_addOrder.FlatStyle = FlatStyle.Flat;
            button_addOrder.ForeColor = Color.White;
            button_addOrder.Location = new Point(135, 228);
            button_addOrder.Name = "button_addOrder";
            button_addOrder.Size = new Size(107, 29);
            button_addOrder.TabIndex = 10;
            button_addOrder.Text = "Add Order";
            button_addOrder.UseVisualStyleBackColor = true;
            button_addOrder.Click += button_addOrder_Click;
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
            TextBox_price.Location = new Point(123, 147);
            TextBox_price.Name = "TextBox_price";
            TextBox_price.PasswordChar = '\0';
            TextBox_price.PlaceholderText = "";
            TextBox_price.SelectedText = "";
            TextBox_price.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBox_price.Size = new Size(136, 27);
            TextBox_price.TabIndex = 5;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.ForeColor = Color.White;
            label_price.Location = new Point(48, 154);
            label_price.Name = "label_price";
            label_price.Size = new Size(41, 20);
            label_price.TabIndex = 6;
            label_price.Text = "Price";
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
            TextBox_qty.Location = new Point(123, 180);
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
            label3.Location = new Point(32, 187);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            // 
            // label_logout
            // 
            label_logout.AutoSize = true;
            label_logout.BackColor = SystemColors.Control;
            label_logout.ForeColor = Color.Navy;
            label_logout.Location = new Point(9, 485);
            label_logout.Name = "label_logout";
            label_logout.Size = new Size(65, 20);
            label_logout.TabIndex = 14;
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
            label_selling.Location = new Point(9, 198);
            label_selling.Name = "label_selling";
            label_selling.Size = new Size(64, 20);
            label_selling.TabIndex = 13;
            label_selling.Text = "SELLING";
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.BackColor = SystemColors.Control;
            label_category.ForeColor = Color.Navy;
            label_category.Location = new Point(7, 145);
            label_category.Name = "label_category";
            label_category.Size = new Size(81, 20);
            label_category.TabIndex = 12;
            label_category.Text = "CATEGORY";
            // 
            // label_seller
            // 
            label_seller.AutoSize = true;
            label_seller.BackColor = SystemColors.Control;
            label_seller.ForeColor = Color.Navy;
            label_seller.Location = new Point(9, 101);
            label_seller.Name = "label_seller";
            label_seller.Size = new Size(56, 20);
            label_seller.TabIndex = 11;
            label_seller.Text = "SELLER";
            // 
            // SellingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 509);
            Controls.Add(panel1);
            Controls.Add(label_logout);
            Controls.Add(label_selling);
            Controls.Add(label_category);
            Controls.Add(label_seller);
            Name = "SellingForm";
            Text = "SellingForm";
            Load += SellingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_sellList).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_order;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private Button button_print;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Button button_add;
        private Label label2;
        private Button button_addOrder;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private Label label_price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_qty;
        private Label label3;
        private Label label_logout;
        private Label label_selling;
        private Label label_category;
        private Label label_seller;
        private Label label_date;
        private Label sellerName;
        private Button button4;
        private Button button2;
        private DataGridView DataGridView_sellList;
        private Button button_refresh;
        private ComboBox comboBox_category;
        private DataGridView DataGridView_product;
        private DataGridViewTextBoxColumn ProdId;
        private DataGridViewTextBoxColumn ProdName;
        private DataGridViewTextBoxColumn ProdPrice;
        private DataGridViewTextBoxColumn ProdQty;
        private DataGridViewTextBoxColumn Total;
        private Label label_amount;
        private Label label4;
    }
}