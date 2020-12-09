namespace theProject
{
    partial class fawaterOmalaaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fawaterOmalaaForm));
            this.deleteRecieptBtn = new System.Windows.Forms.Button();
            this.editRecieptBtn = new System.Windows.Forms.Button();
            this.newRecieptBtn = new System.Windows.Forms.Button();
            this.amiilRecieptLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteRecieptBtn
            // 
            this.deleteRecieptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.deleteRecieptBtn.FlatAppearance.BorderSize = 0;
            this.deleteRecieptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecieptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.deleteRecieptBtn.Location = new System.Drawing.Point(0, 205);
            this.deleteRecieptBtn.Name = "deleteRecieptBtn";
            this.deleteRecieptBtn.Size = new System.Drawing.Size(163, 51);
            this.deleteRecieptBtn.TabIndex = 0;
            this.deleteRecieptBtn.Text = "حذف الفاتورة";
            this.deleteRecieptBtn.UseVisualStyleBackColor = false;
            this.deleteRecieptBtn.Click += new System.EventHandler(this.deleteRecieptBtn_Click);
            // 
            // editRecieptBtn
            // 
            this.editRecieptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editRecieptBtn.FlatAppearance.BorderSize = 0;
            this.editRecieptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRecieptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.editRecieptBtn.Location = new System.Drawing.Point(0, 148);
            this.editRecieptBtn.Name = "editRecieptBtn";
            this.editRecieptBtn.Size = new System.Drawing.Size(163, 51);
            this.editRecieptBtn.TabIndex = 1;
            this.editRecieptBtn.Text = "تعديل الفاتورة";
            this.editRecieptBtn.UseVisualStyleBackColor = false;
            this.editRecieptBtn.Click += new System.EventHandler(this.editRecieptBtn_Click);
            // 
            // newRecieptBtn
            // 
            this.newRecieptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.newRecieptBtn.FlatAppearance.BorderSize = 0;
            this.newRecieptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRecieptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(248)))));
            this.newRecieptBtn.Location = new System.Drawing.Point(0, 91);
            this.newRecieptBtn.Name = "newRecieptBtn";
            this.newRecieptBtn.Size = new System.Drawing.Size(163, 51);
            this.newRecieptBtn.TabIndex = 2;
            this.newRecieptBtn.Text = "فاتورة جديدة";
            this.newRecieptBtn.UseVisualStyleBackColor = false;
            this.newRecieptBtn.Click += new System.EventHandler(this.newRecieptBtn_Click);
            // 
            // amiilRecieptLbl
            // 
            this.amiilRecieptLbl.AutoSize = true;
            this.amiilRecieptLbl.Location = new System.Drawing.Point(421, 36);
            this.amiilRecieptLbl.Name = "amiilRecieptLbl";
            this.amiilRecieptLbl.Size = new System.Drawing.Size(11, 13);
            this.amiilRecieptLbl.TabIndex = 1;
            this.amiilRecieptLbl.Text = "*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(565, 316);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.newRecieptBtn);
            this.panel1.Controls.Add(this.deleteRecieptBtn);
            this.panel1.Controls.Add(this.editRecieptBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(593, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 394);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(85, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fawaterOmalaaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(756, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.amiilRecieptLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fawaterOmalaaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة فواتير العملاء";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fawaterOmalaaForm_FormClosed);
            this.Load += new System.EventHandler(this.fawaterOmalaaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteRecieptBtn;
        private System.Windows.Forms.Button editRecieptBtn;
        private System.Windows.Forms.Button newRecieptBtn;
        private System.Windows.Forms.Label amiilRecieptLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}