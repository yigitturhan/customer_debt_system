namespace CustomerDebtSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwCustomers = new DataGridView();
            gbx = new GroupBox();
            tbxExpAdd = new TextBox();
            label5 = new Label();
            tbxBorcAdd = new TextBox();
            tbxAlacakAdd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbxNameAdd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimeAdd = new DateTimePicker();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            tbxExpUpdate = new TextBox();
            label6 = new Label();
            tbxBorcUpdate = new TextBox();
            tbxAlacakUpdate = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tbxNameUpdate = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dateTimeUpdate = new DateTimePicker();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgwTotal = new DataGridView();
            label11 = new Label();
            textBox1 = new TextBox();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).BeginInit();
            gbx.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwTotal).BeginInit();
            SuspendLayout();
            // 
            // dgwCustomers
            // 
            dgwCustomers.BackgroundColor = Color.Lavender;
            dgwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCustomers.Location = new Point(12, 13);
            dgwCustomers.Name = "dgwCustomers";
            dgwCustomers.RowTemplate.Height = 25;
            dgwCustomers.Size = new Size(1063, 540);
            dgwCustomers.TabIndex = 0;
            dgwCustomers.CellClick += dgwCustomers_CellClick;
            // 
            // gbx
            // 
            gbx.Controls.Add(tbxExpAdd);
            gbx.Controls.Add(label5);
            gbx.Controls.Add(tbxBorcAdd);
            gbx.Controls.Add(tbxAlacakAdd);
            gbx.Controls.Add(label4);
            gbx.Controls.Add(label3);
            gbx.Controls.Add(tbxNameAdd);
            gbx.Controls.Add(label2);
            gbx.Controls.Add(label1);
            gbx.Controls.Add(dateTimeAdd);
            gbx.Controls.Add(btnAdd);
            gbx.Location = new Point(12, 574);
            gbx.Name = "gbx";
            gbx.Size = new Size(684, 171);
            gbx.TabIndex = 1;
            gbx.TabStop = false;
            gbx.Text = "Ekle";
            // 
            // tbxExpAdd
            // 
            tbxExpAdd.Location = new Point(79, 101);
            tbxExpAdd.Name = "tbxExpAdd";
            tbxExpAdd.Size = new Size(288, 23);
            tbxExpAdd.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 101);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Açıklama";
            // 
            // tbxBorcAdd
            // 
            tbxBorcAdd.Location = new Point(399, 42);
            tbxBorcAdd.Name = "tbxBorcAdd";
            tbxBorcAdd.Size = new Size(115, 23);
            tbxBorcAdd.TabIndex = 8;
            // 
            // tbxAlacakAdd
            // 
            tbxAlacakAdd.Location = new Point(553, 42);
            tbxAlacakAdd.Name = "tbxAlacakAdd";
            tbxAlacakAdd.Size = new Size(115, 23);
            tbxAlacakAdd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 22);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Alacak";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 19);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Borç";
            // 
            // tbxNameAdd
            // 
            tbxNameAdd.Location = new Point(79, 60);
            tbxNameAdd.Name = "tbxNameAdd";
            tbxNameAdd.Size = new Size(288, 23);
            tbxNameAdd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 63);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "İsim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "Tarih";
            // 
            // dateTimeAdd
            // 
            dateTimeAdd.Location = new Point(79, 22);
            dateTimeAdd.Name = "dateTimeAdd";
            dateTimeAdd.Size = new Size(288, 23);
            dateTimeAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(473, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 41);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxExpUpdate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbxBorcUpdate);
            groupBox1.Controls.Add(tbxAlacakUpdate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbxNameUpdate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimeUpdate);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Location = new Point(784, 574);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 171);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Değiştir";
            // 
            // tbxExpUpdate
            // 
            tbxExpUpdate.Location = new Point(79, 101);
            tbxExpUpdate.Name = "tbxExpUpdate";
            tbxExpUpdate.Size = new Size(288, 23);
            tbxExpUpdate.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 101);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "Açıklama";
            // 
            // tbxBorcUpdate
            // 
            tbxBorcUpdate.Location = new Point(395, 42);
            tbxBorcUpdate.Name = "tbxBorcUpdate";
            tbxBorcUpdate.Size = new Size(115, 23);
            tbxBorcUpdate.TabIndex = 8;
            // 
            // tbxAlacakUpdate
            // 
            tbxAlacakUpdate.Location = new Point(549, 42);
            tbxAlacakUpdate.Name = "tbxAlacakUpdate";
            tbxAlacakUpdate.Size = new Size(115, 23);
            tbxAlacakUpdate.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(581, 22);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 6;
            label7.Text = "Alacak";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(437, 19);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 5;
            label8.Text = "Borç";
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(79, 63);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(288, 23);
            tbxNameUpdate.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 63);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 3;
            label9.Text = "İsim";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 28);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 2;
            label10.Text = "Tarih";
            // 
            // dateTimeUpdate
            // 
            dateTimeUpdate.Location = new Point(79, 22);
            dateTimeUpdate.Name = "dateTimeUpdate";
            dateTimeUpdate.Size = new Size(288, 23);
            dateTimeUpdate.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(469, 110);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 41);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Değiştir";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(501, 765);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 41);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Kayıt Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgwTotal
            // 
            dgwTotal.BackgroundColor = Color.Lavender;
            dgwTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTotal.Location = new Point(1101, 13);
            dgwTotal.Name = "dgwTotal";
            dgwTotal.RowTemplate.Height = 25;
            dgwTotal.ShowRowErrors = false;
            dgwTotal.Size = new Size(367, 540);
            dgwTotal.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(726, 765);
            label11.Name = "label11";
            label11.Size = new Size(108, 15);
            label11.TabIndex = 13;
            label11.Text = "Müşteriye Göre Ara";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(669, 783);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(960, 765);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(125, 41);
            btnPrint.TabIndex = 15;
            btnPrint.Text = "Yazdır";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1480, 818);
            Controls.Add(btnPrint);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(dgwTotal);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(gbx);
            Controls.Add(dgwCustomers);
            Name = "Form1";
            Text = "Kalamoza";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).EndInit();
            gbx.ResumeLayout(false);
            gbx.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCustomers;
        private GroupBox gbx;
        private Button btnAdd;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimeAdd;
        private TextBox tbxExpAdd;
        private Label label5;
        private TextBox tbxBorcAdd;
        private TextBox tbxAlacakAdd;
        private Label label4;
        private Label label3;
        private TextBox tbxNameAdd;
        private GroupBox groupBox1;
        private TextBox tbxExpUpdate;
        private Label label6;
        private TextBox tbxBorcUpdate;
        private TextBox tbxAlacakUpdate;
        private Label label7;
        private Label label8;
        private TextBox tbxNameUpdate;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimeUpdate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgwTotal;
        private Label label11;
        private TextBox textBox1;
        private Button btnPrint;
    }
}