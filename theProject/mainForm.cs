using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theProject
{
    public partial class mainForm : Form
    {
        int companyId;
        public mainForm(int companyId)
        {
            InitializeComponent();
            this.companyId = companyId;
        }

        private void fwater3omala2Btn_Click(object sender, EventArgs e)
        {
            fawaterOmalaaForm theForm = new fawaterOmalaaForm(companyId);
            theForm.Show();
            this.Hide();
        }

        private void addNewProductBtn_Click(object sender, EventArgs e)
        {
            addProductForm form = new addProductForm(companyId);
            form.Show();
            this.Hide();
        }

        private void AddNewAmiilBtn_Click(object sender, EventArgs e)
        {
            addNewCustomerForm form = new addNewCustomerForm(companyId);
            form.Show();
            this.Hide();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fwaterMwrdinBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
