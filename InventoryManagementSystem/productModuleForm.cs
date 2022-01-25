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
    public partial class productModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win 10\Documents\InventoryControl.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public productModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            comboBoxCategory.Items.Clear();
            cm = new SqlCommand("SELECT ctname FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboBoxCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }


        

        public void Clear()
        {
            textBoxNameProduct.Clear();
            textBoxQty.Clear();
            textBoxPrice.Clear();
            richTextBoxDesc.Clear();
            comboBoxCategory.Text = "";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
               
                    cm = new SqlCommand("INSERT INTO tbProduct(pname,pqty,pprice,pdescription,pcategory)VALUES(@pname, @pqty, @pprice, @pdescription, @pcategory)", con);
                    cm.Parameters.AddWithValue("@pname", textBoxNameProduct.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(textBoxQty.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(textBoxPrice.Text));
                    cm.Parameters.AddWithValue("@pdescription", richTextBoxDesc.Text);
                    cm.Parameters.AddWithValue("@pcategory", comboBoxCategory.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully saved.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to update this product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("UPDATE tbProduct SET pname = @pname, pqty=@pqty, pprice=@pprice, pdescription=@pdescription, pcategory=@pcategory WHERE pid LIKE '" + p_id_Lable.Text + "' ", con);
                    cm.Parameters.AddWithValue("@pname", textBoxNameProduct.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(textBoxQty.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(textBoxPrice.Text));
                    cm.Parameters.AddWithValue("@pdescription", richTextBoxDesc.Text);
                    cm.Parameters.AddWithValue("@pcategory", comboBoxCategory.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully updated!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnAddProduct.Enabled = true;
            btnUpdateProduct.Enabled = false;
        }

        private void applicationCloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
