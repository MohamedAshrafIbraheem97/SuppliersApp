using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace theProject
{
    public partial class firstUserControl : UserControl
    {
        DatabaseClass db = new DatabaseClass();
        int companyId;

        public firstUserControl()
        {
            InitializeComponent();
        }

        public firstUserControl(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
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

        private void addBtn_Click(object sender, EventArgs e)
        {
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
                    var cmd = db.cmd("addNewProduct", array);
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

        private void firstUserControl_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                productIdLbl.Text = row.Cells[0].Value.ToString();
                productNameTxt.Text = row.Cells[1].Value.ToString();

            }
        }
    }
}
