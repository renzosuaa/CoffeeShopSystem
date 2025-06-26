using CoffeeShopSystem_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopCommon;
using System.Windows.Forms.VisualStyles;

namespace CoffeeShopForm
{
    public partial class OrderingInterface : Form
    {

        int userID;
        OrderProcess orderProcess;

        public OrderingInterface(int userID)
        {
            this.userID = userID;
            orderProcess = new OrderProcess(userID);
            InitializeComponent();
            InitializeOrderType();
        }

        private void InitializeOrderType()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (string orderType in CoffeeShop.coffeeShopprocess.GetItemTypes())
            {
                Button orderTypeButton = new Button
                {
                    Size = new Size(140, 69),
                    Text = orderType,
                    Tag = orderType,
                    TabIndex = 0,
                    Font = new Font("Constantia", 12.75F),
                    BackColor = Color.FromArgb(57, 53, 76),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
                orderTypeButton.Click += (sender, e) => AddItemsToPanel(sender ?? orderTypeButton, e, orderType);
                flowLayoutPanel1.Controls.Add(orderTypeButton);
            }
        }

        private void InitializeItems(string orderType)
        {
            flowLayoutPanel2.Controls.Clear();

            foreach (Item item in CoffeeShop.coffeeShopprocess.GetItemsPerType(orderType))
            {
                Button orderTypeButton = new Button
                {
                    Size = new Size(140, 69),
                    Text = item.name + "\n " + item.cost,
                    Tag = item.name,
                    TabIndex = 0,
                    Font = new Font("Constantia", 12.75F),
                    BackColor = Color.FromArgb(86, 82, 105),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
                orderTypeButton.Click += (sender, e) => QuantityGetterUI(sender ?? orderTypeButton, e, item);
                flowLayoutPanel2.Controls.Add(orderTypeButton);
            }
        }

        protected void PlaceOrder(object sender, EventArgs e)
        {
            if (orderProcess.GetAllOrderItems().Count != 0 && ConfirmMessage("Place Order"))
            {
                CoffeeShop.coffeeShopprocess.AddSoldCount(orderProcess.GetAllOrderItems());
                MessageBox.Show("Order Placed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the current form instead of creating a new instance
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                InitializeOrderType();
                orderProcess.ClearOrder();
            }
        }

        protected void ClearOrder(object sender, EventArgs e)
        {
            if (ConfirmMessage("Clear Order"))
            {
                orderProcess.ClearOrder();
            }
        }


        protected void AddItemsToPanel(object sender, EventArgs e, string orderrType)
        {
            flowLayoutPanel2.Controls.Clear();
            InitializeItems(orderrType);

        }

        protected void QuantityGetterUI(object sender, EventArgs e, Item item)
        {
            int count = GetQuantity(item.name, item.cost);

            if (count > 0)
            {
                Item orderItem = new Item
                {
                    name = item.name,
                    cost = item.cost,
                    type = item.type,
                    soldCount = count
                };

                orderProcess.AddOrder(orderItem);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
