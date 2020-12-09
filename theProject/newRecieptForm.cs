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
    public partial class newRecieptForm : Form
    {
        DatabaseClass db = new DatabaseClass();
        int companyId;
        int receiptId;
        double totals;

        public newRecieptForm(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        public newRecieptForm(int companyId, int receiptId)
        {
            InitializeComponent();
            this.companyId = companyId;
            this.receiptId = receiptId;
        }

        

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            fawaterOmalaaForm form = new fawaterOmalaaForm(companyId);
            form.Show();
            this.Hide();
        }

        private void newRecieptForm_Load(object sender, EventArgs e)
        {
            //load Products to comboBox
            loadToComboBox("@companyId", companyId.ToString(), SqlDbType.Int, "selectProductsForSpecificCompany", "productName", "productName", productCombo);
            productCombo.SelectedIndex = -1;
            //load persons to comboBox
            loadToComboBox("@role", "عميل", SqlDbType.NVarChar, "selectPerson", "personName", "personName", personNameCombo);
            //to refresh datagridview
            refreshDataGridView();
            //to calculate the reciept total
            calculateRecipetTotal();
            //to load data to type combobox
            noaaFatoraCombo.SelectedIndex = 0;
            //to select the data of the reciept from the database
            putDataInTheirCells();

        }
        void loadToComboBox(string par1, string par2, SqlDbType type, string procedureName, string displayMember,string valueMember, ComboBox comoBoxName)
        {
            SqlParameter[] array = {
                        new SqlParameter(par1, type) { Value = par2},
                    };
            var cmd = db.cmd(procedureName, array);


            var dt = db.returnDataTable(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, procedureName);

            comoBoxName.DataSource = ds.Tables[procedureName];
            comoBoxName.DisplayMember = displayMember;
            comoBoxName.ValueMember = valueMember;



            //SqlParameter[] array = {
            //            new SqlParameter("@companyId", SqlDbType.Int) { Value = companyId },
            //        };
            //var cmd = db.cmd("selectProductsForSpecificCompany", array);


            //var dt = db.returnDataTable(cmd);

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "selectProductsForSpecificCompany");

            //productCombo.DataSource = ds.Tables["selectProductsForSpecificCompany"];
            //productCombo.DisplayMember = "productName";
            //productCombo.ValueMember = "productName";

            //refreshDataGridView();
        }



        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                productTotalTxt.Text = (Convert.ToDouble(priceTxt.Text) * Convert.ToDouble(quantityTxt.Text)).ToString();
            }
            catch (Exception es)
            {
                MessageBox.Show("برجاء عدم ترك خانتى العدد و السعر فارغتين");
            }
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                productTotalTxt.Text = (Convert.ToDouble(priceTxt.Text) * Convert.ToDouble(quantityTxt.Text)).ToString();
                
            }
            catch (Exception es)
            {
                MessageBox.Show("برجاء عدم ترك خانتى العدد و السعر فارغتين");
            }
        }

        private void quantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void addToRecieptBtn_Click(object sender, EventArgs e)
        {
            try
                {
                    SqlParameter[] arrayy = {
                    new SqlParameter("@type", SqlDbType.NVarChar) { Value = "بيع" },
                    new SqlParameter("@date", SqlDbType.Date) { Value = DateTime.Now },
                    new SqlParameter("@total", SqlDbType.Float) { Value = 0},
                    new SqlParameter("@percentage", SqlDbType.Float) { Value = 0},
                    new SqlParameter("@totalOfTotal", SqlDbType.Float) { Value = 0},
                    new SqlParameter("@personName", SqlDbType.NVarChar) { Value = "لم يتم تخصيص عميل"},
                    new SqlParameter("@companyIdAR", SqlDbType.Int) { Value = companyId},
                };
                    /*var cmdd =*/ db.cmd("AddToAmiilReceiptTable", arrayy);

                    //var dt = db.returnDataTable(cmdd);

                    var lastRow = db.returnDataTable(db.cmd("selectLastEneteredReciept"));

                    var amiilRTID = lastRow.Rows[0].Field<int>(0);
                    receiptId = amiilRTID;

                }
                catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الإضافة و هذا هو الخطأ" + es.ToString());
            }
            try
            {
                SqlParameter[] array = {
                    new SqlParameter("@productName", SqlDbType.NVarChar) { Value = productCombo.SelectedValue },
                    new SqlParameter("@price", SqlDbType.Float) { Value = Convert.ToDouble(priceTxt.Text)},
                    new SqlParameter("@quantity", SqlDbType.Int) { Value = Convert.ToInt32(quantityTxt.Text)},
                    new SqlParameter("@total", SqlDbType.Float) { Value = Convert.ToDouble(productTotalTxt.Text)},
                    new SqlParameter("@AmiilRTID", SqlDbType.Int) { Value = receiptId }
                };
                var cmd = db.cmd("addToInsideTheReciept", array);
                MessageBox.Show("تم إضافة المنتج إلى الفاتورة بنجاح");
                //to refresh datagridview with the new data
                refreshDataGridView();
                refreshCells();

                //this is to update the total of the reciept
                calculateRecipetTotal();

            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الإضافة و هذا هو الخطأ" + es.ToString());
            }
        }

        public void refreshDataGridView()
        {
            SqlParameter[] array = {
                        new SqlParameter("@AmiilRTID", SqlDbType.Int) { Value = receiptId },
                    };
            var cmd = db.cmd("selectRecieptsFromTheReciept", array);
            specificProductIdLbl.Text = "*";
            var dt = db.returnDataTable(cmd);
            dataGridView1.DataSource = dt;

        }

        public void putDataInTheirCells()
        {
            if (receiptId == 0)
            {

            }
            else
            {
                SqlParameter[] array = {
                        new SqlParameter("@receiptId", SqlDbType.Int) { Value = receiptId },
                    };
                var cmd = db.cmd("selectAmiilReciept", array);
                var dt = db.returnDataTable(cmd);

                noaaFatoraCombo.SelectedItem = dt.Rows[0].Field<string>(1);
                treekhFatoraDTP.Value = Convert.ToDateTime(dt.Rows[0][2]);
                totalTxt.Text = Convert.ToString(dt.Rows[0][3]);
                percentageTxt.Text = Convert.ToString(dt.Rows[0][4]);
                totalOfTotalTxt.Text = Convert.ToString(dt.Rows[0][5]);
                personNameCombo.SelectedItem = dt.Rows[0].Field<string>(6);
            }
        }

        private void deleteFromRecieptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (specificProductIdLbl.Text != "*")
                {
                    SqlParameter[] array = {
                    new SqlParameter("@insideRecieptID", SqlDbType.Int) { Value = Convert.ToInt32(specificProductIdLbl.Text)},
                };
                    var cmd = db.cmd("deleteRecieptsFromTheReciept", array);
                    MessageBox.Show("تم حذف المنتج من الفاتورة بنجاح");
                    specificProductIdLbl.Text = "*";
                    //to refresh datagridview with the new data
                    refreshDataGridView();
                    refreshCells();
                }
                else
                {
                    MessageBox.Show("برجاء تحديد منتج لحذفه");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ فى الحذف و هذا هو الخطأ" + es.ToString());
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //    {
            //        specificProductIdLbl.Text = row.Cells[0].Value.ToString();
            //        productCombo.SelectedText = row.Cells[1].Value.ToString();
            //        priceTxt.Text = row.Cells[2].Value.ToString();
            //        quantityTxt.Text = row.Cells[3].Value.ToString();
            //        productTotalTxt.Text = row.Cells[4].Value.ToString();
            //        personNameCombo.SelectedText = row.Cells[5].Value.ToString();
            //        AmiilIRIDLbl.Text = row.Cells[6].Value.ToString();

            //    }
            //}catch(Exception es)
            //{
            //    MessageBox.Show("لقد حدث خطأ في التحديد");
            //}
        }

        void calculateRecipetTotal()
        {
            totals = 0;
            try
            {
                //this is to update the total of the reciept
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    totals += Convert.ToDouble(row.Cells[4].Value);
                }
                totalTxt.Text = totals.ToString();
            }
            catch(Exception es)
            { ; }
        }
        private void saveReceiptBtn_Click(object sender, EventArgs e)
        {
            calculateRecipetTotal();
            if (percentageTxt.Text == "" || percentageTxt.Text == " " || percentageTxt.Text == null)
            {
                MessageBox.Show("برجاء عدم ترك خانة النسبة فارغة");
            }
            else
            {
                try
                {

                    SqlParameter[] array = {
                    new SqlParameter("@type", SqlDbType.NVarChar) { Value = noaaFatoraCombo.SelectedItem},
                    new SqlParameter("@date", SqlDbType.Date) { Value = treekhFatoraDTP.Value.Date },
                    new SqlParameter("@total", SqlDbType.Float) { Value = Convert.ToDouble(totalTxt.Text)},
                    new SqlParameter("@percentage", SqlDbType.Float) { Value = Convert.ToDouble(percentageTxt.Text)},
                    new SqlParameter("@totalOfTotal", SqlDbType.Float) { Value = Convert.ToDouble(totalOfTotalTxt.Text)},
                    new SqlParameter("@personName", SqlDbType.NVarChar) { Value = personNameCombo.SelectedValue},
                    new SqlParameter("@companyId", SqlDbType.Int) { Value = 1},
                    new SqlParameter("@amiilRecieptID", SqlDbType.Int) { Value = Convert.ToInt32(receiptId)},
                };
                    var cmd = db.cmd("EditToAmiilReceiptTable", array);

                    MessageBox.Show("تم حفظ الفاتورة بنجاح");

                }
                catch (Exception es)
                {
                    MessageBox.Show("لقد حدث خطأ فى الحفظ و هذا هو الخطأ" + es.ToString());
                }


                //try
                //{
                //    SqlParameter[] array = {
                //    new SqlParameter("@type", SqlDbType.NVarChar) { Value = "بيع" },
                //    new SqlParameter("@date", SqlDbType.Date) { Value = DateTime.Now },
                //    new SqlParameter("@total", SqlDbType.Float) { Value = 0},
                //    new SqlParameter("@percentage", SqlDbType.Float) { Value = 0},
                //    new SqlParameter("@totalOfTotal", SqlDbType.Float) { Value = 0},
                //    new SqlParameter("@personName", SqlDbType.NVarChar) { Value = "لم يتم تخصيص عميل"},
                //    new SqlParameter("@companyIdAR", SqlDbType.Int) { Value = companyId},
                //};
                //    var cmd = db.cmd("AddToAmiilReceiptTable", array);

                //    var dt = db.returnDataTable(cmd);

                //    var lastRow = db.returnDataTable(db.cmd("[selectLastEneteredReciept]"));

                //    var amiilRTID = lastRow.Rows[0].Field<int>(0);

                //    newRecieptForm reciept = new newRecieptForm(companyId, amiilRTID);
                //    reciept.Show();
                //    this.Hide();

                //}
                //catch (Exception es)
                //{
                //    MessageBox.Show("لقد حدث خطأ فى الإضافة و هذا هو الخطأ" + es.ToString());
                //}
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                refreshCells();
                specificProductIdLbl.Text = dataGridView1.SelectedCells[0].Value.ToString();
                productCombo.SelectedValue = dataGridView1.SelectedCells[1].Value.ToString();
                priceTxt.Text = dataGridView1.SelectedCells[2].Value.ToString();
                quantityTxt.Text = dataGridView1.SelectedCells[3].Value.ToString();
                productTotalTxt.Text = dataGridView1.SelectedCells[4].Value.ToString();
                AmiilIRIDLbl.Text = dataGridView1.SelectedCells[5].Value.ToString();
            }
            catch (Exception es)
            {
                MessageBox.Show("لقد حدث خطأ في التحديد");
            }
        }

        
        //to make cells empty after addition or deletion
        void refreshCells()
        {
            treekhFatoraDTP.Value = DateTime.Now;
            productCombo.SelectedIndex = -1;
            priceTxt.Text = "0";
            quantityTxt.Text = "0";
            productTotalTxt.Text = "0";
            totalTxt.Text = "0";
        }

        private void percentageTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void percentageTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
               totalOfTotalTxt.Text = (Convert.ToDouble(totalTxt.Text) * Convert.ToDouble(percentageTxt.Text)).ToString();

                
            }
            catch (Exception es)
            {
                MessageBox.Show("برجاء عدم ترك خانة النسبة فارغة");
            }
        }

        private void newRecieptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fawaterOmalaaForm form = new fawaterOmalaaForm(companyId);
            form.Show();
            this.Hide();
        }
    }
}
