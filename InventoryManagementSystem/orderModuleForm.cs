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

    public partial class orderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win 10\Documents\InventoryControl.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        int qty = 0;
        public orderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomerOrder.Rows.Clear();
            cm = new SqlCommand("SELECT cid, cname FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%" + textBoxSeacrhCus.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomerOrder.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvOrderProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%" + txtSearchProd.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvOrderProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvCustomerOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            this.textBoxCustomerID.Text = dgvCustomerOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.textBoxCusName.Text = dgvCustomerOrder.Rows[e.RowIndex].Cells[2].Value.ToString();

     
        }

        private void dgvOrderProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxProductID.Text = dgvOrderProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.textBoxProductName.Text = dgvOrderProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.textBoxPrice.Text = dgvOrderProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        public void Clear()
        {
            textBoxCustomerID.Clear();
            textBoxCusName.Clear();

            textBoxProductID.Clear();
            textBoxProductName.Clear();

            textBoxPrice.Clear();
            numericUpDownQty.Value = 0;
            textBoxTotal.Clear();
            dateTimePickerOrder.Value = DateTime.Now;
        }

        private void btnAddorder_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tbOrder(odate,opid,ocid,oQty,oprice,otot)VALUES(@odate, @opid, @ocid, @oQty, @oprice,@otot)", con);
                    cm.Parameters.AddWithValue("@odate", dateTimePickerOrder.Value);
                    cm.Parameters.AddWithValue("@opid", Convert.ToInt16(textBoxProductID.Text));
                    cm.Parameters.AddWithValue("@ocid", Convert.ToInt16(textBoxCustomerID.Text));
                    cm.Parameters.AddWithValue("@oQty", Convert.ToInt16(numericUpDownQty.Text));
                    cm.Parameters.AddWithValue("@oprice", Convert.ToInt16(textBoxPrice.Text));
                    cm.Parameters.AddWithValue("@otot", Convert.ToInt16(textBoxTotal.Text));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been successfully inserted.");


                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty-@pqty) WHERE pid LIKE '" + textBoxProductID.Text + "' ", con);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(numericUpDownQty.Value));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void applicationCloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void GetQty()
        {
            cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid='" + textBoxProductID.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void numericUpDownQty_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (Convert.ToInt16(numericUpDownQty.Value) > qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownQty.Value = numericUpDownQty.Value - 1;
                return;
            }
            if (Convert.ToInt16(numericUpDownQty.Value) > 0)
            {
                int total = Convert.ToInt16(textBoxPrice.Text) * Convert.ToInt16(numericUpDownQty.Value);
                textBoxTotal.Text = total.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
