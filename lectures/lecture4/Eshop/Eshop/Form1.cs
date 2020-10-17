using DomainLayer.LazyLoading;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Eshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is just a sample of usage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LazyLoadingBtn_Click(object sender, EventArgs e)
        {
            // place breakpoint into lazy load function and see when its hit
            // Sometime it is the debugger - preview that triggers the loading
            // This behavior can be controlled with Tools - Options - Debugging - General - "Enable property evaluation and other implicit function calls"
            var customer = new DomainLayer.LazyLoading.Customer();
            customer.Age = 5;
            customer.Name = "test";
            var addresses = customer.Addresses;
        }

        private void UnitOfWorkBtn_Click(object sender, EventArgs e)
        {

        }

        private void IdentityMapBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
