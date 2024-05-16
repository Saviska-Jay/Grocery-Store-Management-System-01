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
using System.Configuration;

namespace Grocery_Store_Management_System_01
{
    public partial class CashierLoginForm : Form
    {
        public CashierLoginForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Cashier Login Button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                try
                { 

                Con.Open();
                String CashierLoginQ = "Select Username, Password From CashierLoginInfo Where Username= @Username And Password= @Password ";
                SqlCommand cmd = new SqlCommand(CashierLoginQ, Con);

                //SQL Parameters 
                cmd.Parameters.AddWithValue("@Username", UsernameText.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordText.Text);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

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
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry. There is an Error." +ex ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
            }
        }

        //Cashier Cancel Button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
