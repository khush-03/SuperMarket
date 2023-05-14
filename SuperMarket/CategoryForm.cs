using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class CategoryForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_desc.Text + "')";

                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_desc.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName'" + TextBox_name.Text + "', CatDes='" + TextBox_desc.Text + "'WHERE CatId=" + TextBox_id.Text + " ";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_category_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_category.SelectedRows[0].Cells[0].ToString();
            TextBox_name.Text = dataGridView_category.SelectedRows[0].Cells[1].ToString();
            TextBox_desc.Text = dataGridView_category.SelectedRows[0].Cells[2].ToString();
        }

        private void dataGridView_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_desc.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM category WHERE CatId=" + TextBox_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Navy;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void label_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void label_selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }
    }
}
