using DomainLayer.DomainModel;
using DomainLayer.DTO;
using DomainLayer.TableModule;
using DomainLayer.TransactionScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void button1_Click(object sender, EventArgs e)
        {
            // SOME DATA FROM UI
            var userId = 1;
            var orderItems = new List<OrderItemDTO>();
            orderItems.Add(new OrderItemDTO
            {
                Name = "SomeBook",
                Amount = 2,
                Price = 1750
            });

            // DomainModel
            var order = new Order(userId, orderItems);
            order.SubmitOrder();

            // TableModule
            var tableModule = new OrderModule();
            tableModule.SubmitOrder(userId,orderItems);

            // TransactionScript
            var transactionScript = new SubmitOrder();
            transactionScript.Execute(userId, orderItems);
        }
    }
}
