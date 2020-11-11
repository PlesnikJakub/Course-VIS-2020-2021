using DomainLayer.DomanModelActiveRecord;
using DomainLayer.TableModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIScv3
{
    public partial class Form1 : Form
    {

        List<CustomerActireRecord> CustomersList = new List<CustomerActireRecord>();
        public Form1()
        {
            /* Use Customer Data Gateway to return all records*/
            InitializeComponent();
            CustomersList = CustomerActireRecord.Find();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = CustomersList;
            dataGridView1.DataSource = bSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save using active records
            CustomerActireRecord NewCustomer = new CustomerActireRecord(textBoxName.Text, Double.Parse(textBox1.Text), Int32.Parse(textBox2.Text), textBox3.Text);
            NewCustomer.Insert();
            CustomersList.Add(NewCustomer);
            dataGridView1.DataSource = CustomersList;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // This inicialization should be solved by IOC container
            // In this case cannot move CustomerTableGateway to TableModule because of circular dependencies
            CustomerTableModule CustomerModule = new CustomerTableModule();           
            lblAvgSalary.Text = CustomerModule.AverageSalary().ToString();
        }
    }
}
