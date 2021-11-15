using Bussiness.Services;

namespace DesktopUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var service = new AccountService();
            var accounts = service.GetAll();

            dataGridView1.Rows.Clear();
            foreach (var account in accounts)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = account.Id.ToString();
                row.Cells[1].Value = account.Name;
                row.Cells[2].Value = account.Balance.ToString();
                dataGridView1.Rows.Add(row);
            }
        }

        private void getAll_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addInterest_btn_Click(object sender, EventArgs e)
        {
            var service = new AccountService();
            service.AddInterestRate();
            LoadData();
        }
    }
}