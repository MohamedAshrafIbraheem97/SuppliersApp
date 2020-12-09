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
    public partial class fawaterOmalaaForm : Form
    {
        DatabaseClass db = new DatabaseClass();
        int companyId;
        public fawaterOmalaaForm(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        private void newRecieptBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //SqlParameter[] array = {
                //    new SqlParameter("@type", SqlDbType.NVarChar) { Value = "بيع" },
                //    new SqlParameter("@date", SqlDbType.Date) { Value = DateTime.Now },
                //    new SqlParameter("@total", SqlDbType.Float) { Value = 0},
                //    new SqlParameter("@percentage", SqlDbType.Float) { Value = 0},
                //    new SqlParameter("@totalOfTotal", SqlDbType.Float) { Value = 0},
                //    new SqlParameter("@personName", SqlDbType.NVarChar) { Value = "لم يتم تخصيص عميل"},
                //    new SqlParameter("@companyIdAR", SqlDbType.Int) { Value = companyId},
                //};
                //var cmd = db.cmd("AddToAmiilReceiptTable", array);

                //var dt = db.returnDataTable(cmd);

                //var lastRow = db.returnDataTable(db.cmd("[selectLastEneteredReciept]"));

                //var amiilRTID = lastRow.Rows[0].Field<int>(0);

                //newRecieptForm reciept = new newRecieptForm(companyId, amiilRTID);
                //reciept.Show();
                //this.Hide();

                newRecieptForm reciept = new newRecieptForm(companyId);
                reciept.Show();
                this.Hide();

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
            var cmd = db.cmd("selectAllCompanyReciepts", array);
            
            var dt = db.returnDataTable(cmd);
            dataGridView1.DataSource = dt;

        }

        private void fawaterOmalaaForm_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                amiilRecieptLbl.Text = row.Cells[0].Value.ToString();
                
            }
        }

        private void editRecieptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                newRecieptForm reciept = new newRecieptForm(companyId, Convert.ToInt32(amiilRecieptLbl.Text));
                reciept.Show();
                this.Hide();

            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى التعديل و هذا هو الخطأ" + es.ToString());
            }
        }

        private void deleteRecieptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (amiilRecieptLbl.Text != "*")
                {
                    //delete all dependencies first
                    SqlParameter[] array1 = {
                    new SqlParameter("@amiilRId", SqlDbType.Int) { Value = Convert.ToInt32(amiilRecieptLbl.Text)},
                };
                    var cmd1 = db.cmd("deleteAllRecieptcomponents", array1);
                    
                    //delete the reciept second
                    SqlParameter[] array = {
                    new SqlParameter("@amiilRecieptID", SqlDbType.Int) { Value = Convert.ToInt32(amiilRecieptLbl.Text)},
                };
                    var cmd = db.cmd("deleteFromAmiilReceiptTable", array);
                    MessageBox.Show("تم حذف الفاتورة بنجاح");
                    amiilRecieptLbl.Text = "*";
                    //to refresh datagridview with the new data
                    refreshDataGridView();
                }
                else
                {
                    MessageBox.Show("برجاء تحديد فاتورة لحذفها");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الحذف و هذا هو الخطأ" + es.ToString());
            }
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm(companyId);
            form.Show();
            this.Hide();
        }

        private void fawaterOmalaaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                newRecieptForm reciept = new newRecieptForm(companyId, Convert.ToInt32(amiilRecieptLbl.Text));
                reciept.Show();
                this.Hide();

            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى التعديل و هذا هو الخطأ" + es.ToString());
            }
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
