using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class productForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win 10\Documents\InventoryControl.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public productForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProducts.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%" + textBoxSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                productModuleForm productModule = new productModuleForm();
                productModule.p_id_Lable.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.textBoxNameProduct.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.textBoxQty.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.textBoxPrice.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.richTextBoxDesc.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.comboBoxCategory.Text = dgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btnAddProduct.Enabled = false;
                productModule.btnUpdateProduct.Enabled = true;
                productModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pid LIKE '" + dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productModuleForm formModule = new productModuleForm();
            formModule.btnAddProduct.Enabled = true;
            formModule.btnUpdateProduct.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            LoadProduct();
        }
    }
}
