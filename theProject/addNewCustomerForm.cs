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
    public partial class addNewCustomerForm : Form
    {
        DatabaseClass db = new DatabaseClass();
        int companyId;
        public addNewCustomerForm(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] array = {
                    new SqlParameter("@personName", SqlDbType.NVarChar) { Value = nameTxt.Text},
                    new SqlParameter("@role", SqlDbType.NVarChar) { Value = noaaCombo.SelectedItem},
                    new SqlParameter("@companyId", SqlDbType.Int) { Value = 1},
                    
                };
                var cmd = db.cmd("addPerson", array);
                MessageBox.Show("تم إضافة الشخص بنجاح");
                //to refresh datagridview with the new data
                refreshDataGridView();

            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الإضافة و هذا هو الخطأ" + es.ToString());
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (personIdLbl.Text != "*")
                {
                    SqlParameter[] array = {
                    new SqlParameter("@personId", SqlDbType.Int) { Value = Convert.ToInt32(personIdLbl.Text)},
                        };
                    var cmd = db.cmd("deletePerson", array);
                    MessageBox.Show("تم حذف الشخص بنجاح");
                    personIdLbl.Text = "*";
                    //to refresh datagridview with the new data
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("برجاء تحديد شخص لحذفه");
                }
        }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الحذف و هذا هو الخطأ" + es.ToString());
            }
        }

        public void refreshDataGridView()
        {
            SqlParameter[] array = {
                        new SqlParameter("@role", SqlDbType.NVarChar) { Value = noaaCombo.SelectedItem },
                    };
            var cmd = db.cmd("selectPerson", array);
            var dt = db.returnDataTable(cmd);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                personIdLbl.Text = row.Cells[0].Value.ToString();
                

            }
        }

        private void noaaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm(companyId);
            form.Show();
            this.Hide();
        }

        private void addNewCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm(companyId);
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm(companyId);
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
