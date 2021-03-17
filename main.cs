using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Data.SqlClient;

namespace library_mngt
{
    public partial class main : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        public main()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ln = new Login();
            ln.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // tsmheader.Text = "Add Book";
            MetroTabPage tpAddMember = new MetroTabPage();
            tpAddMember.Text = "Add Book";


            foreach (TabPage tp1 in metroTabControl1.TabPages)
            {
                if (tp1.Text == "Add Book")
                {
                    metroTabControl1.SelectTab(tp1);
                    tpAddMember.Focus();
                    return;
                }

            }
            Addbooks UC = new Addbooks();
            UC.Dock = DockStyle.Fill;
            tpAddMember.Controls.Add(UC);
            metroTabControl1.TabPages.Add(tpAddMember);
            metroTabControl1.SelectedTab = tpAddMember;
            tpAddMember.AutoScroll = true;
            tpAddMember.VerticalScrollbar = true;
            //UC.btnClose.Click += new EventHandler(BtnClose_Click);

        }

        private void main_Load(object sender, EventArgs e)
        {
            fill_chart();
            fill_chart_members();
            fill_chart_br();
        }
        private void fill_chart()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select BookName,BookQuantity from book",con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            con.Open();
            chart1.DataSource = ds;
            chart1.Series["Books"].XValueMember = "BookName";
            chart1.Series["Books"].YValueMembers = "BookQuantity";
            chart1.Titles.Add("Book Chart");
            con.Close();
        }

        private void fill_chart_members()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select BookName,BookQuantity from book", con);
            DataSet dss = new DataSet();
            cmd.Fill(dss);
            con.Open();
            chart2.DataSource = dss;
            chart2.Series["Members"].XValueMember = "BookName";
            chart2.Series["Members"].YValueMembers = "BookQuantity";
            chart2.Titles.Add("Members");
            con.Close();
        }

        private void fill_chart_br()
        {
            SqlDataAdapter cmd = new SqlDataAdapter($"Select BookName,BookQuantity,Price from book ", con);
            DataSet dss = new DataSet();
            cmd.Fill(dss);
            con.Open();
            chart3.DataSource = dss;
            chart3.Series["Borrowed"].XValueMember = "BookName";
            chart3.Series["Borrowed"].YValueMembers = "BookQuantity";
            chart3.Series["Returned"].XValueMember = "BookName";
            chart3.Series["Returned"].YValueMembers = "Price";
            chart3.Titles.Add("Borrowed/Returned");
            con.Close();
        }
    }
}
