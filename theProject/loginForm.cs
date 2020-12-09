using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theProject
{
    public partial class loginForm : Form
    {
        byte click = 0;
        public loginForm()
        {
            InitializeComponent();

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //int companyId = 0;
                //DatabaseClass db = new DatabaseClass();
                //db.openConnection();
                //var cmd = db.cmd("selectCompany");
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@userName", SqlDbType.NVarChar).Value = userNameTxt.Text.Trim();
                //cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = passwordTxt.Text.Trim();
                //DataTable dt = new DataTable();
                //dt.Load(cmd.ExecuteReader());
                //db.closeConnection();

                int companyId = 0;
                DatabaseClass db = new DatabaseClass();

                SqlParameter[] param =
                {
                    new SqlParameter("@userName", SqlDbType.NVarChar) { Value = userNameTxt.Text.Trim() },
                    new SqlParameter("@password", SqlDbType.NVarChar) { Value =  passwordTxt.Text.Trim() }
                };
                var command = db.cmd("selectCompany",param);
                DataTable dt = new DataTable();
                db.openConnection();
                dt.Load(command.ExecuteReader());
                db.closeConnection();

                companyId = dt.Rows[0].Field<int>(0);
                if (dt.Rows.Count > 0)
                {
                    mainForm main = new mainForm(companyId);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("برجاء أدخل اسم مستخدم و كلمة سر صحيحة ");
                }
            }
            catch(Exception es)
            {
                MessageBox.Show("برجاء أدخل اسم مستخدم و كلمة سر");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {


            if (click == 0)
            {
                panel2.Visible = true;
                click++;
            }
            else
            {
                panel2.Visible = false;
                click--;
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void passwordTxt_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void passwordTxt_Leave(object sender, EventArgs e)
        {
            submitBtn_Click(sender, e);
        }
    }
}
