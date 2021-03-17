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

namespace library_mngt
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand();

        public Login()
        {
            InitializeComponent();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"Select * from library_person where username='{txtusername.Text.Trim()}' and password='{txtpassword.Text}'",con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            
            
            if(dr.Read())
            {
                main mn = new main();
                mn.Show();
                    this.Hide();
                    //MessageBox.Show("user exit");
               
               
            }
            else
            {
                MessageBox.Show("user doesnot exit");
            }
            dr.Close();
            con.Close();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void keydown_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
               
                
                btnlogin.PerformClick();
            }
        }
    }
}
