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
    public partial class addProductForm : Form
    {
        DatabaseClass db = new DatabaseClass();
        int companyId;
        public addProductForm(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (String.IsNullOrEmpty(productNameTxt.Text))
            //    {
            //        MessageBox.Show("برجاء كتابة شيئ أولا");
            //    }
            //    else
            //    {
            //        db.openConnection();
            //        var cmd = db.cmd("addNewProduct");
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@productName", SqlDbType.NVarChar).Value = productNameTxt.Text.Trim();
            //        cmd.Parameters.AddWithValue("@companyId", SqlDbType.NVarChar).Value = companyId;
            //        cmd.ExecuteNonQuery();
            //        db.closeConnection();
            //        MessageBox.Show("تم إضافة المنتح بنجاح");

            //        refreshDataGridView();
            //    }
            //}
            //catch(Exception es)
            //{
            //    MessageBox.Show("لقد حدث خطأ ما و هذا هو الخطأ" + es.ToString());
            //}

            try
            {
                if (String.IsNullOrEmpty(productNameTxt.Text))
                {
                    MessageBox.Show("برجاء كتابة شيئ أولا");
                }
                else
                {
                    SqlParameter[] array = {
                        new SqlParameter("@companyId", SqlDbType.Int) { Value = companyId },
                        new SqlParameter("@productName", SqlDbType.NVarChar) { Value = productNameTxt.Text.Trim() },                        
                    };
                    var cmd = db.cmd("addNewProduct",array);
                    MessageBox.Show("تم إضافة المنتح بنجاح");
                    //to refresh datagridview with the new data
                    refreshDataGridView();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الإضافة و هذا هو الخطأ" + es.ToString());
            }

        }

        public void refreshDataGridView()
        {
            SqlParameter[] array = {
                        new SqlParameter("@companyId", SqlDbType.Int) { Value = companyId },
                    };
            var cmd = db.cmd("selectProductsForSpecificCompany", array);

            var dt = db.returnDataTable(cmd);
            dataGridView1.DataSource = dt;

            //DataTable dt = new DataTable();
            //db.openConnection();
            //dt.Load(cmd.ExecuteReader());
            //db.closeConnection();
            //dataGridView1.DataSource = dt;



        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm(companyId);
            form.Show();
            this.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productIdLbl.Text == "*")
                {
                    MessageBox.Show("برجاء تحديد منتج لتعديله");
                }
                else
                {
                    if (String.IsNullOrEmpty(productNameTxt.Text))
                    {
                        MessageBox.Show("برجاء كتابة شيئ أولا");
                    }
                    else
                    {
                        SqlParameter[] array = {
                        new SqlParameter("@productName", SqlDbType.NVarChar) { Value = productNameTxt.Text.Trim() },
                        new SqlParameter("@companyId", SqlDbType.Int) { Value = Convert.ToInt32(companyId) },
                        new SqlParameter("@productId", SqlDbType.Int) { Value = Convert.ToInt32(productIdLbl.Text) }
                    };
                        var cmd = db.cmd("editProductForSpecificCompany", array);
                        //this is to prevent user from editing unselected data
                        productIdLbl.Text = "*";
                        MessageBox.Show("تم تعديل المنتح بنجاح");
                        //to refresh datagridview with the new data
                        refreshDataGridView();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى التعديل و هذا هو الخطأ" + es.ToString());
            }
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //to put data from datagridview into cells to edit
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                productIdLbl.Text = row.Cells[0].Value.ToString();
                productNameTxt.Text = row.Cells[1].Value.ToString();

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productIdLbl.Text == "*")
                {
                    MessageBox.Show("برجاء تحديد منتج لحذفه");
                }
                else
                {
                    SqlParameter[] array = {
                        new SqlParameter("@productId", SqlDbType.Int) { Value = Convert.ToInt32(productIdLbl.Text) }
                    };
                    var cmd = db.cmd("deleteProductsForSpecifcCompany", array);
                    //this is to prevent user from editing unselected data
                    productIdLbl.Text = "*";
                    MessageBox.Show("تم حذف المنتح بنجاح");
                    //to refresh datagridview with the new data
                    refreshDataGridView();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الحذف و هذا هو الخطأ" + es.ToString());
            }
        }

        private void productNameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addProductForm_FormClosed(object sender, FormClosedEventArgs e)
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
            Application.Exit();
        }
    }
}
