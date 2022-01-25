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
    public partial class customerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Win 10\Documents\InventoryControl.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public customerModuleForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Are you sure you want to update this Customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("UPDATE tbCustomer SET cname = @cname,cphone=@cphone WHERE cid LIKE '" + lblCId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@cname", textBoxNameCustomer.Text);
                    cm.Parameters.AddWithValue("@cphone", textBoxPhoneCustomer.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully updated!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            textBoxNameCustomer.Clear();
            textBoxPhoneCustomer.Clear();
        }

        private void btnAddcustomer_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone)VALUES(@cname,@cphone)", con);
                    cm.Parameters.AddWithValue("@cname", textBoxNameCustomer.Text);
                    cm.Parameters.AddWithValue("@cphone", textBoxPhoneCustomer.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
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
            btnAddcustomer.Enabled = true;
            btnUpdatecustomer.Enabled = false;
        }

        private void applicationCloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
