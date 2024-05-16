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

namespace Grocery_Store_Management_System_01
{
    public partial class CashierLoginForm : Form
    {
        public CashierLoginForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=SAVISKAMJ\SQLEXPRESS;Initial Catalog=GroceryStoreManagementSystem01DB;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Cashier Login Button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            String CashierLoginQ = "Select Username, Password From CashierLoginInfo Where Username= @Username And Password= @Password ";
            SqlCommand cmd = new SqlCommand(CashierLoginQ, Con);

            //SQL Parameters 
            cmd.Parameters.AddWithValue("@Username", UsernameText.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordText.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Cashier Login Successful!", "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                CashierMainMenuForm CashierMainMenuForm = new CashierMainMenuForm();
                CashierMainMenuForm.ShowDialog();

            }
            else
            {

                MessageBox.Show("Invalied Cashier Username or Password. Please Try Again.", "Invalied Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameText.Clear();
                PasswordText.Clear();
            
            }
            Con.Close();
        }

        //Cashier Cancel Button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
