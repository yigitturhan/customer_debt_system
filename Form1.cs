using System.Data;
using System.Windows.Forms;

namespace CustomerDebtSystem
{
    public partial class Form1 : Form
    {
        DAL dal = new DAL();
        public Form1()
        {
            InitializeComponent();
            dgwCustomers.CellFormatting += dgwCustomers_CellFormatting;
            dgwTotal.CellFormatting += dgwTotal_CellFormatting;
        }
        private void dgwTotal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgwTotal.Columns[e.ColumnIndex].ValueType == typeof(decimal))
                {
                    e.Value = string.Format("{0:n}", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                İsim = tbxNameAdd.Text,
                Alacak = string.IsNullOrEmpty(tbxAlacakAdd.Text) ? 0 : Convert.ToDecimal(tbxAlacakAdd.Text),
                Borç = string.IsNullOrEmpty(tbxBorcAdd.Text) ? 0 : Convert.ToDecimal(tbxBorcAdd.Text),
                Açıklama = tbxExpAdd.Text,
                Tarih = dateTimeAdd.Value
            };
            dal.AddRecord(customer);
            LoadRecords();
            LoadTotals();
            MessageBox.Show("EKLENDİ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Id = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value),
                CustomerId = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[1].Value),
                İsim = tbxNameUpdate.Text,
                Alacak = string.IsNullOrEmpty(tbxAlacakUpdate.Text) ? 0 : Convert.ToDecimal(tbxAlacakUpdate.Text),
                Borç = string.IsNullOrEmpty(tbxBorcUpdate.Text) ? 0 : Convert.ToDecimal(tbxBorcUpdate.Text),
                Açıklama = tbxExpUpdate.Text,
                Tarih = dateTimeUpdate.Value
            };
            dal.UpdateRecord(customer);
            LoadRecords();
            LoadTotals();
            MessageBox.Show("GÜNCELLENDİ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin Misin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            dal.DeleteRecord(Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value));
            MessageBox.Show("SİLİNDİ");
            LoadRecords();
            LoadTotals();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecords();
            LoadTotals();

        }

        private void LoadTotals()
        {

            dgwTotal.DataSource = dal.GetTotals();
            dgwTotal.Columns[0].Visible = false;
            dgwTotal.Columns[1].Visible = false;
            dgwTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwTotal.Columns[3].HeaderText = "Total";
        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBorcAdd.Text = dgwCustomers.CurrentRow.Cells[5].Value.ToString();
            tbxExpAdd.Text = dgwCustomers.CurrentRow.Cells[4].Value.ToString();
            tbxAlacakAdd.Text = dgwCustomers.CurrentRow.Cells[6].Value.ToString();
            tbxNameAdd.Text = dgwCustomers.CurrentRow.Cells[3].Value.ToString();
            dateTimeAdd.Value = Convert.ToDateTime(dgwCustomers.CurrentRow.Cells[2].Value);

            tbxBorcUpdate.Text = dgwCustomers.CurrentRow.Cells[5].Value.ToString();
            tbxExpUpdate.Text = dgwCustomers.CurrentRow.Cells[4].Value.ToString();
            tbxAlacakUpdate.Text = dgwCustomers.CurrentRow.Cells[6].Value.ToString();
            tbxNameUpdate.Text = dgwCustomers.CurrentRow.Cells[3].Value.ToString();
            dateTimeUpdate.Value = Convert.ToDateTime(dgwCustomers.CurrentRow.Cells[2].Value);
        }
        private void LoadRecords()
        {
            dgwCustomers.DataSource = dal.GetCustomers();
            dgwCustomers.Columns[0].Visible = false;
            dgwCustomers.Columns[1].Visible = false;
            dgwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            tbxExpAdd.Clear();
            tbxExpUpdate.Clear();
            tbxNameAdd.Clear();
            tbxNameUpdate.Clear();

            tbxAlacakAdd.Text = "0";
            tbxBorcAdd.Text = "0";
            tbxAlacakUpdate.Text = "0";
            tbxBorcUpdate.Text = "0";

            string[] customHeaders = { "Tarih", "İsim", "Açıklama", "Borç", "Alacak" };
            for (int i = 0; i < customHeaders.Length; i++)
            {
                dgwCustomers.Columns[i + 2].HeaderText = customHeaders[i];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) dgwCustomers.DataSource = dal.GetByName(textBox1.Text);
            else LoadRecords();
        }

        private void dgwCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgwCustomers.Columns[e.ColumnIndex].ValueType == typeof(decimal))
                {
                    e.Value = string.Format("{0:n}", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintingManager.PrintDataGridView(dgwCustomers);
        }
    }
}