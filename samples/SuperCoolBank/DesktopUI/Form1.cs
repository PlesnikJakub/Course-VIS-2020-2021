using Bussiness.Services;

namespace DesktopUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getAll_btn_Click(object sender, EventArgs e)
        {
            var service = new AccountService();
            var accounts = service.GetAll();

            foreach (var account in accounts)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = account.Id.ToString();
                row.Cells[1].Value = account.Name;
                dataGridView1.Rows.Add(row);
            }
        }

        private void addInterest_btn_Click(object sender, EventArgs e)
        {

        }
    }
}