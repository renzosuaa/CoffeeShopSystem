using CoffeeShopCommon;

namespace CoffeeShopForm
{
    partial class OrderingInterface
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnViewCart = new Button();
            btnPlaceOrder = new Button();
            btnClearCart = new Button();
            btnLogOut = new Button();
            btnViewOrders = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AccessibleRole = AccessibleRole.None;
            flowLayoutPanel1.BackColor = Color.FromArgb(78, 73, 94);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(7, 80);
            flowLayoutPanel1.MaximumSize = new Size(144, 374);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(143, 278);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.TabStop = true;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(78, 73, 94);
            flowLayoutPanel2.Location = new Point(159, 80);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(520, 278);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btnViewCart
            // 
            btnViewCart.BackColor = Color.FromArgb(57, 53, 76);
            btnViewCart.FlatStyle = FlatStyle.Flat;
            btnViewCart.Font = new Font("Constantia", 12.75F);
            btnViewCart.ForeColor = Color.FromArgb(218, 216, 227);
            btnViewCart.Location = new Point(403, 379);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(130, 55);
            btnViewCart.TabIndex = 2;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = false;
            btnViewCart.Click += ShowReceipt;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(117, 82, 186);
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Constantia", 12.75F);
            btnPlaceOrder.ForeColor = Color.FromArgb(218, 216, 227);
            btnPlaceOrder.Location = new Point(549, 379);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(130, 55);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += PlaceOrder;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(57, 53, 76);
            btnClearCart.BackgroundImageLayout = ImageLayout.None;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Constantia", 12.75F);
            btnClearCart.ForeColor = Color.FromArgb(218, 216, 227);
            btnClearCart.Location = new Point(257, 379);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(130, 55);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += ClearOrder;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(57, 53, 76);
            btnLogOut.BackgroundImageLayout = ImageLayout.None;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Constantia", 12.75F);
            btnLogOut.ForeColor = Color.FromArgb(218, 216, 227);
            btnLogOut.Location = new Point(12, 379);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(138, 55);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOutEvent;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Location = new Point(0, 0);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(75, 23);
            btnViewOrders.TabIndex = 0;
            // 
            // OrderingInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 42, 56);
            ClientSize = new Size(691, 456);
            Controls.Add(btnLogOut);
            Controls.Add(btnClearCart);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnViewCart);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderingInterface";
            Text = "OrderingInterface";
            ResumeLayout(false);
        }

        private int quantityResult = 0; // Variable to store the result

        public int GetQuantity(string itemName, double cost)
        {
            quantityResult = 0; // Reset the result each time the method is called

            // Create a new form to act as a pop-up
            using (Form popupForm = new Form())
            {
                popupForm.Text = "Select Quantity";
                popupForm.Size = new Size(250, 250);
                popupForm.StartPosition = FormStartPosition.CenterParent;
                popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                popupForm.MaximizeBox = false;
                popupForm.MinimizeBox = false;
                popupForm.ShowInTaskbar = false;
                popupForm.BackColor = Color.FromArgb(44, 42, 56);


                // Create controls
                Label lbl_item_name = new Label
                {
                    AutoSize = true,
                    Font = new Font("Constantia", 15F),
                    Location = new Point(66, 23),
                    Text = itemName,
                    ForeColor = Color.FromArgb(218, 216, 227)
                };

                Label lbl_cost = new Label
                {
                    AutoSize = true,
                    Font = new Font("Constantia", 12F),
                    Location = new Point(89, 51),
                    Text = cost.ToString("C"),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };

                Label lbl_quantity_count = new Label
                {
                    AutoSize = true,
                    Location = new Point(107, 135),
                    Text = "0",
                    ForeColor = Color.FromArgb(218, 216, 227)
                };

                Button btn_increase = new Button
                {
                    Font = new Font("Constantia", 20F),
                    Location = new Point(140, 125),
                    Size = new Size(42, 38),
                    Text = "+",
                    BackColor = Color.FromArgb(57, 53, 76),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
                btn_increase.Click += (sender, e) =>
                {
                    int count = Convert.ToInt32(lbl_quantity_count.Text);
                    count++;
                    lbl_quantity_count.Text = count.ToString();
                };

                Button btn_decrease = new Button
                {
                    Font = new Font("Constantia", 20F),
                    Location = new Point(48, 125),
                    Size = new Size(42, 38),
                    Text = "-",
                    BackColor = Color.FromArgb(57, 53, 76),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
                btn_decrease.Click += (sender, e) =>
                {
                    int count = Convert.ToInt32(lbl_quantity_count.Text);
                    if (count > 0)
                    {
                        count--;
                        lbl_quantity_count.Text = count.ToString();
                    }
                };

                Button btnAddOrder = new Button
                {
                    Location = new Point(46, 168),
                    Size = new Size(138, 21),
                    Text = "Add Order",
                    BackColor = Color.FromArgb(57, 53, 76),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
                btnAddOrder.Click += (sender, e) =>
                {
                    quantityResult = Convert.ToInt32(lbl_quantity_count.Text); // Set result to the current quantity
                    popupForm.Close(); // Close the form
                };

                // Add controls to the form
                popupForm.Controls.Add(lbl_item_name);
                popupForm.Controls.Add(lbl_cost);
                popupForm.Controls.Add(lbl_quantity_count);
                popupForm.Controls.Add(btn_increase);
                popupForm.Controls.Add(btn_decrease);
                popupForm.Controls.Add(btn_exit);
                popupForm.Controls.Add(btnAddOrder);

                // Show the form as a modal dialog
                popupForm.ShowDialog();
            }

            return quantityResult; // Return the result
        }

        private void InitializeUserPrivilage()
        {
            if (userID != 0)
            {
                btnViewOrders.BackColor = Color.FromArgb(57, 53, 76);
                btnViewOrders.FlatStyle = FlatStyle.Flat;
                btnViewOrders.Font = new Font("Constantia", 12.75F);
                btnViewOrders.ForeColor = Color.FromArgb(218, 216, 227);
                btnViewOrders.Location = new Point(549, 19);
                btnViewOrders.Name = "btnViewOrders";
                btnViewOrders.Size = new Size(130, 55);
                btnViewOrders.TabIndex = 6;
                btnViewOrders.Text = "View Orders";
                btnViewOrders.Click += btnViewOrderEvent;
                btnViewOrders.UseVisualStyleBackColor = false;
            }

            if (userID != 0)
            {
                Controls.Add(btnViewOrders);
            }
        }

        private bool ConfirmMessage(string action)
        {
            using (Form confirmForm = new Form())
            {
                confirmForm.Text = action;
                confirmForm.Size = new Size(300, 150);
                confirmForm.StartPosition = FormStartPosition.CenterParent;
                confirmForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                confirmForm.MaximizeBox = false;
                confirmForm.MinimizeBox = false;
                confirmForm.ShowInTaskbar = false;
                confirmForm.BackColor = Color.FromArgb(44, 42, 56);

                string text = "";

                if (action == "Clear Order")
                {
                    text = "Are you sure you want to clear your order list?";
                }
                else if (action == "Place Order")
                {
                    text = "Are you sure you want to place your order?";
                }


                Label lblMessage = new Label
                {
                    AutoSize = true,
                    Text = text,
                    Location = new Point(20, 20),
                    Size = new Size(260, 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(218, 216, 227)
                };

                Button btnYes = new Button
                {
                    Text = "Yes",
                    Location = new Point(50, 70),
                    Size = new Size(75, 30),
                    BackColor = Color.FromArgb(57, 53, 76),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
                btnYes.Click += (sender, e) =>
                {
                    confirmForm.DialogResult = DialogResult.Yes;
                    confirmForm.Close();
                };

                Button btnNo = new Button
                {
                    Text = "No",
                    Location = new Point(150, 70),
                    Size = new Size(75, 30),
                    BackColor = Color.FromArgb(57, 53, 76),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
                btnNo.Click += (sender, e) =>
                {
                    confirmForm.DialogResult = DialogResult.No;
                    confirmForm.Close();
                };

                confirmForm.Controls.Add(lblMessage);
                confirmForm.Controls.Add(btnYes);
                confirmForm.Controls.Add(btnNo);

                return confirmForm.ShowDialog() == DialogResult.Yes;
            }
        }

        private void btnViewOrderEvent(object sender, EventArgs e)
        {
            using (Form confirmForm = new Form())
            {
                confirmForm.Text = "View Order";
                confirmForm.Size = new Size(300, 150);
                confirmForm.StartPosition = FormStartPosition.CenterParent;
                confirmForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                confirmForm.MaximizeBox = false;
                confirmForm.MinimizeBox = false;
                confirmForm.ShowInTaskbar = false;
                confirmForm.BackColor = Color.FromArgb(44, 42, 56);

                // Create a label for the message
                Label lblMessage = new Label
                {
                    AutoSize = true,
                    Text = orderProcess.GetUserOrders(),
                    Location = new Point(20, 20),
                    Size = new Size(260, 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(218, 216, 227)
                };
            }
        }


        protected void DecreaseCountValue(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(lbl_quantity_count.Text);
            if (count > 0)
            {
                count--;
                lbl_quantity_count.Text = count.ToString();
            }
        }

        protected void IncreaseCountValue(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(lbl_quantity_count.Text);
            count++;
            lbl_quantity_count.Text = count.ToString();
        }

        private void ShowReceipt(object sender, EventArgs e)
        {
            using (Form receiptForm = new Form())
            {
                receiptForm.Text = "Receipt";
                receiptForm.Size = new Size(350, 390);
                receiptForm.StartPosition = FormStartPosition.CenterParent;
                receiptForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                receiptForm.MaximizeBox = false;
                receiptForm.MinimizeBox = false;
                receiptForm.ShowInTaskbar = false;
                receiptForm.BackColor = Color.FromArgb(44, 42, 56);
                FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel
                {
                    Location = new Point(0, 20),
                    Size = new Size(350, 350),
                    AutoScroll = true
                };

                Label lblReceipt = new Label
                {
                    AutoSize = true,
                    Text = orderProcess.PrintReceipt(),
                    Font = new Font("Constantia", 13F, FontStyle.Bold),
                    Location = new Point(3, 0),
                    ForeColor = Color.FromArgb(218, 216, 227)
                };

                flowLayoutPanel1.Controls.Add(lblReceipt);
                receiptForm.Controls.Add(flowLayoutPanel1);
                receiptForm.ShowDialog();
            }
        }
        private void btnLogOutEvent(object sender, EventArgs e)
        {
            this.Hide();
            new SignInForm().ShowDialog();
            this.Dispose();
        }

        #endregion
        private Panel panel1;
        private Label lbl_item_name;
        private Label lbl_quantity_count;
        private Button btn_decrease;
        private Button btn_increase;
        private Label lbl_cost;
        private Button btn_exit, btnAddOrder;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnViewCart;
        private Button btnPlaceOrder;
        private Button btnClearCart;
        private Button btnLogOut;
        private Button btnViewOrders;
    }
}