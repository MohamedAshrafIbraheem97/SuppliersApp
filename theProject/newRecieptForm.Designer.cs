namespace theProject
{
    partial class newRecieptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newRecieptForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treekhFatoraDTP = new System.Windows.Forms.DateTimePicker();
            this.noaaFatoraCombo = new System.Windows.Forms.ComboBox();
            this.AmiilIRIDLbl = new System.Windows.Forms.Label();
            this.specificProductIdLbl = new System.Windows.Forms.Label();
            this.personNameCombo = new System.Windows.Forms.ComboBox();
            this.deleteFromRecieptBtn = new System.Windows.Forms.Button();
            this.addToRecieptBtn = new System.Windows.Forms.Button();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.productTotalTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productCombo = new System.Windows.Forms.ComboBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.percentageTxt = new System.Windows.Forms.TextBox();
            this.totalOfTotalTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveReceiptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label3.Location = new System.Drawing.Point(342, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "نوع الفاتورة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label2.Location = new System.Drawing.Point(342, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label1.Location = new System.Drawing.Point(342, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل";
            // 
            // treekhFatoraDTP
            // 
            this.treekhFatoraDTP.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.treekhFatoraDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.treekhFatoraDTP.Location = new System.Drawing.Point(23, 52);
            this.treekhFatoraDTP.Name = "treekhFatoraDTP";
            this.treekhFatoraDTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treekhFatoraDTP.Size = new System.Drawing.Size(313, 32);
            this.treekhFatoraDTP.TabIndex = 4;
            // 
            // noaaFatoraCombo
            // 
            this.noaaFatoraCombo.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.noaaFatoraCombo.FormattingEnabled = true;
            this.noaaFatoraCombo.Items.AddRange(new object[] {
            "بيع",
            "استرجاع"});
            this.noaaFatoraCombo.Location = new System.Drawing.Point(23, 13);
            this.noaaFatoraCombo.Name = "noaaFatoraCombo";
            this.noaaFatoraCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noaaFatoraCombo.Size = new System.Drawing.Size(313, 33);
            this.noaaFatoraCombo.TabIndex = 3;
            // 
            // AmiilIRIDLbl
            // 
            this.AmiilIRIDLbl.AutoSize = true;
            this.AmiilIRIDLbl.Location = new System.Drawing.Point(78, 122);
            this.AmiilIRIDLbl.Name = "AmiilIRIDLbl";
            this.AmiilIRIDLbl.Size = new System.Drawing.Size(11, 13);
            this.AmiilIRIDLbl.TabIndex = 7;
            this.AmiilIRIDLbl.Text = "*";
            this.AmiilIRIDLbl.Visible = false;
            // 
            // specificProductIdLbl
            // 
            this.specificProductIdLbl.AutoSize = true;
            this.specificProductIdLbl.Location = new System.Drawing.Point(48, 122);
            this.specificProductIdLbl.Name = "specificProductIdLbl";
            this.specificProductIdLbl.Size = new System.Drawing.Size(11, 13);
            this.specificProductIdLbl.TabIndex = 8;
            this.specificProductIdLbl.Text = "*";
            this.specificProductIdLbl.Visible = false;
            // 
            // personNameCombo
            // 
            this.personNameCombo.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.personNameCombo.FormattingEnabled = true;
            this.personNameCombo.Items.AddRange(new object[] {
            "بيع",
            "استرجاع"});
            this.personNameCombo.Location = new System.Drawing.Point(23, 90);
            this.personNameCombo.Name = "personNameCombo";
            this.personNameCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.personNameCombo.Size = new System.Drawing.Size(313, 33);
            this.personNameCombo.TabIndex = 9;
            // 
            // deleteFromRecieptBtn
            // 
            this.deleteFromRecieptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.deleteFromRecieptBtn.FlatAppearance.BorderSize = 0;
            this.deleteFromRecieptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFromRecieptBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.deleteFromRecieptBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteFromRecieptBtn.Location = new System.Drawing.Point(19, 307);
            this.deleteFromRecieptBtn.Name = "deleteFromRecieptBtn";
            this.deleteFromRecieptBtn.Size = new System.Drawing.Size(117, 36);
            this.deleteFromRecieptBtn.TabIndex = 1;
            this.deleteFromRecieptBtn.Text = "حذف المنتج";
            this.deleteFromRecieptBtn.UseVisualStyleBackColor = false;
            this.deleteFromRecieptBtn.Click += new System.EventHandler(this.deleteFromRecieptBtn_Click);
            // 
            // addToRecieptBtn
            // 
            this.addToRecieptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.addToRecieptBtn.FlatAppearance.BorderSize = 0;
            this.addToRecieptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToRecieptBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.addToRecieptBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToRecieptBtn.Location = new System.Drawing.Point(322, 307);
            this.addToRecieptBtn.Name = "addToRecieptBtn";
            this.addToRecieptBtn.Size = new System.Drawing.Size(115, 36);
            this.addToRecieptBtn.TabIndex = 0;
            this.addToRecieptBtn.Text = "إضافة منتج";
            this.addToRecieptBtn.UseVisualStyleBackColor = false;
            this.addToRecieptBtn.Click += new System.EventHandler(this.addToRecieptBtn_Click);
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.priceTxt.Location = new System.Drawing.Point(19, 12);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priceTxt.Size = new System.Drawing.Size(117, 32);
            this.priceTxt.TabIndex = 12;
            this.priceTxt.Text = "0";
            this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.quantityTxt.Location = new System.Drawing.Point(216, 53);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityTxt.Size = new System.Drawing.Size(120, 32);
            this.quantityTxt.TabIndex = 11;
            this.quantityTxt.Text = "0";
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
            this.quantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTxt_KeyPress);
            // 
            // productTotalTxt
            // 
            this.productTotalTxt.Enabled = false;
            this.productTotalTxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.productTotalTxt.Location = new System.Drawing.Point(21, 53);
            this.productTotalTxt.Name = "productTotalTxt";
            this.productTotalTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productTotalTxt.Size = new System.Drawing.Size(117, 32);
            this.productTotalTxt.TabIndex = 10;
            this.productTotalTxt.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label7.Location = new System.Drawing.Point(142, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "السعر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label6.Location = new System.Drawing.Point(342, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "العدد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label5.Location = new System.Drawing.Point(142, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "الإجمالى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label4.Location = new System.Drawing.Point(342, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "المنتج";
            // 
            // productCombo
            // 
            this.productCombo.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.productCombo.FormattingEnabled = true;
            this.productCombo.Location = new System.Drawing.Point(216, 9);
            this.productCombo.Name = "productCombo";
            this.productCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productCombo.Size = new System.Drawing.Size(120, 33);
            this.productCombo.TabIndex = 13;
            // 
            // totalTxt
            // 
            this.totalTxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.totalTxt.Location = new System.Drawing.Point(12, 349);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalTxt.Size = new System.Drawing.Size(169, 32);
            this.totalTxt.TabIndex = 15;
            // 
            // percentageTxt
            // 
            this.percentageTxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.percentageTxt.Location = new System.Drawing.Point(12, 412);
            this.percentageTxt.Name = "percentageTxt";
            this.percentageTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.percentageTxt.Size = new System.Drawing.Size(168, 32);
            this.percentageTxt.TabIndex = 14;
            this.percentageTxt.TextChanged += new System.EventHandler(this.percentageTxt_TextChanged);
            this.percentageTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percentageTxt_KeyPress);
            // 
            // totalOfTotalTxt
            // 
            this.totalOfTotalTxt.Enabled = false;
            this.totalOfTotalTxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.totalOfTotalTxt.Location = new System.Drawing.Point(12, 475);
            this.totalOfTotalTxt.Name = "totalOfTotalTxt";
            this.totalOfTotalTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalOfTotalTxt.Size = new System.Drawing.Size(168, 32);
            this.totalOfTotalTxt.TabIndex = 13;
            this.totalOfTotalTxt.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label10.Location = new System.Drawing.Point(64, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "إجمالى الفاتورة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label9.Location = new System.Drawing.Point(127, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "النسبة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label8.Location = new System.Drawing.Point(60, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "الإجمالى النهائى";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(416, 199);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // saveReceiptBtn
            // 
            this.saveReceiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(122)))), ((int)(((byte)(147)))));
            this.saveReceiptBtn.FlatAppearance.BorderSize = 0;
            this.saveReceiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReceiptBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.saveReceiptBtn.Location = new System.Drawing.Point(12, 547);
            this.saveReceiptBtn.Name = "saveReceiptBtn";
            this.saveReceiptBtn.Size = new System.Drawing.Size(113, 50);
            this.saveReceiptBtn.TabIndex = 4;
            this.saveReceiptBtn.Text = "حفظ الفاتورة";
            this.saveReceiptBtn.UseVisualStyleBackColor = false;
            this.saveReceiptBtn.Click += new System.EventHandler(this.saveReceiptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 73);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.noaaFatoraCombo);
            this.panel2.Controls.Add(this.treekhFatoraDTP);
            this.panel2.Controls.Add(this.personNameCombo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(206, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 139);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addToRecieptBtn);
            this.panel3.Controls.Add(this.deleteFromRecieptBtn);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.productCombo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.productTotalTxt);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.quantityTxt);
            this.panel3.Controls.Add(this.priceTxt);
            this.panel3.Location = new System.Drawing.Point(206, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 373);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(612, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label11.Location = new System.Drawing.Point(497, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "شاشة الفاتورة";
            // 
            // newRecieptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(672, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.percentageTxt);
            this.Controls.Add(this.totalOfTotalTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveReceiptBtn);
            this.Controls.Add(this.AmiilIRIDLbl);
            this.Controls.Add(this.specificProductIdLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newRecieptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الفاتورة الجديدة";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.newRecieptForm_FormClosed);
            this.Load += new System.EventHandler(this.newRecieptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker treekhFatoraDTP;
        private System.Windows.Forms.ComboBox noaaFatoraCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteFromRecieptBtn;
        private System.Windows.Forms.Button addToRecieptBtn;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox productTotalTxt;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.TextBox percentageTxt;
        private System.Windows.Forms.TextBox totalOfTotalTxt;
        private System.Windows.Forms.ComboBox productCombo;
        private System.Windows.Forms.Label AmiilIRIDLbl;
        private System.Windows.Forms.Label specificProductIdLbl;
        private System.Windows.Forms.Button saveReceiptBtn;
        private System.Windows.Forms.ComboBox personNameCombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
    }
}