using System.Diagnostics;

namespace CoffeeShopForm
{
    partial class AdminDashBoard
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
            pnlContainer = new Panel();
            pnlContainerSummary = new FlowLayoutPanel();
            lblSummary = new Label();
            btnViewSoldSummary = new Button();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            btnBack = new Button();
            lblItemName = new Label();
            lblItemType = new Label();
            label1 = new Label();
            btnAdd = new Button();
            txtItemName = new TextBox();
            txtItemType = new TextBox();
            txtCost = new TextBox();
            lblAddItem = new Label();
            txtItemNameR = new TextBox();
            lblItemNameR = new Label();
            lblRemoveItem = new Label();
            btnRemove = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pnlContainer.SuspendLayout();
            pnlContainerSummary.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(78, 73, 94);
            pnlContainer.Location = new Point(163, 67);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(558, 359);
            pnlContainer.TabIndex = 0;
            // 
            // pnlContainerSummary
            // 
            pnlContainerSummary.AutoScroll = true;
            pnlContainerSummary.BackColor = Color.RosyBrown;
            pnlContainerSummary.Controls.Add(lblSummary);
            pnlContainerSummary.Location = new Point(21, 17);
            pnlContainerSummary.Name = "pnlContainerSummary";
            pnlContainerSummary.Size = new Size(522, 327);
            pnlContainerSummary.TabIndex = 0;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(3, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(38, 15);
            lblSummary.TabIndex = 0;
            lblSummary.Text = GenerateSummaryText();
            // 
            // btnViewSoldSummary
            // 
            btnViewSoldSummary.BackColor = Color.FromArgb(57, 53, 76);
            btnViewSoldSummary.FlatStyle = FlatStyle.Flat;
            btnViewSoldSummary.Font = new Font("Constantia", 12.75F);
            btnViewSoldSummary.ForeColor = Color.FromArgb(218, 216, 227);
            btnViewSoldSummary.Location = new Point(6, 9);
            btnViewSoldSummary.Name = "btnViewSoldSummary";
            btnViewSoldSummary.Size = new Size(133, 56);
            btnViewSoldSummary.TabIndex = 1;
            btnViewSoldSummary.Text = "View Sold Summary";
            btnViewSoldSummary.UseVisualStyleBackColor = false;
            btnViewSoldSummary.Click += btnViewSoldSummaryEvent;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(57, 53, 76);
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Constantia", 12.75F);
            btnAddItem.ForeColor = Color.FromArgb(218, 216, 227);
            btnAddItem.Location = new Point(6, 72);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(133, 56);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += InitializeAddButtonBoard;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(57, 53, 76);
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Constantia", 12.75F);
            btnRemoveItem.ForeColor = Color.FromArgb(218, 216, 227);
            btnRemoveItem.Location = new Point(6, 134);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(133, 56);
            btnRemoveItem.TabIndex = 3;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += InitializeRemoveButtonBoard;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(57, 53, 76);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Constantia", 10F);
            btnBack.ForeColor = Color.FromArgb(218, 216, 227);
            btnBack.Location = new Point(14, 385);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 36);
            btnBack.TabIndex = 4;
            btnBack.Text = "BACK TO LOG IN";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBackEvent;
            // 
            // lblItemName
            // 
            lblItemName.Location = new Point(0, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(100, 23);
            lblItemName.TabIndex = 0;
            // 
            // lblItemType
            // 
            lblItemType.Location = new Point(0, 0);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(100, 23);
            lblItemType.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(0, 0);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 23);
            txtItemName.TabIndex = 0;
            // 
            // txtItemType
            // 
            txtItemType.Location = new Point(0, 0);
            txtItemType.Name = "txtItemType";
            txtItemType.Size = new Size(100, 23);
            txtItemType.TabIndex = 0;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(0, 0);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(100, 23);
            txtCost.TabIndex = 0;
            // 
            // lblAddItem
            // 
            lblAddItem.Location = new Point(0, 0);
            lblAddItem.Name = "lblAddItem";
            lblAddItem.Size = new Size(100, 23);
            lblAddItem.TabIndex = 0;
            // 
            // txtItemNameR
            // 
            txtItemNameR.Location = new Point(0, 0);
            txtItemNameR.Name = "txtItemNameR";
            txtItemNameR.Size = new Size(100, 23);
            txtItemNameR.TabIndex = 0;
            // 
            // lblItemNameR
            // 
            lblItemNameR.Location = new Point(0, 0);
            lblItemNameR.Name = "lblItemNameR";
            lblItemNameR.Size = new Size(100, 23);
            lblItemNameR.TabIndex = 0;
            // 
            // lblRemoveItem
            // 
            lblRemoveItem.Location = new Point(0, 0);
            lblRemoveItem.Name = "lblRemoveItem";
            lblRemoveItem.Size = new Size(100, 23);
            lblRemoveItem.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(0, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 73, 94);
            panel1.Controls.Add(btnRemoveItem);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(btnViewSoldSummary);
            panel1.Location = new Point(12, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 200);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 42, 56);
            ClientSize = new Size(733, 450);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashBoard";
            Text = "AdminDashBoard";
            Load += AdminDashBoard_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainerSummary.ResumeLayout(false);
            pnlContainerSummary.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        protected void InitializeAddButtonBoard(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(lblAddItem);
            pnlContainer.Controls.Add(txtCost);
            pnlContainer.Controls.Add(txtItemType);
            pnlContainer.Controls.Add(txtItemName);
            pnlContainer.Controls.Add(btnAdd);
            pnlContainer.Controls.Add(label1);
            pnlContainer.Controls.Add(lblItemType);
            pnlContainer.Controls.Add(lblItemName);

            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Constantia", 17F);
            lblItemName.ForeColor = Color.FromArgb(218, 216, 227);
            lblItemName.Location = new Point(57, 106);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(132, 31);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name:";
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Font = new Font("Constantia", 17F);
            lblItemType.Location = new Point(122, 162);
            lblItemType.ForeColor = Color.FromArgb(218, 216, 227);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(67, 31);
            lblItemType.TabIndex = 1;
            lblItemType.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 17F);
            label1.Location = new Point(122, 217);
            label1.Name = "label1";
            label1.Size = new Size(64, 31);
            label1.TabIndex = 2;
            label1.Text = "Cost:";
            label1.ForeColor = Color.FromArgb(218, 216, 227);
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Constantia", 12F);
            btnAdd.Location = new Point(371, 274);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 43);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddItemEvent;
            btnAdd.BackColor = Color.FromArgb(57, 53, 76); 
            btnAdd.ForeColor = Color.FromArgb(218, 216, 227);
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Constantia", 15F);
            txtItemName.Location = new Point(195, 106);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(309, 34);
            txtItemName.TabIndex = 4;
            txtItemName.BackColor = Color.FromArgb(57, 53, 76);
            txtItemName.ForeColor = Color.FromArgb(86, 82, 105);

            // 
            // txtItemType
            // 
            txtItemType.Font = new Font("Constantia", 15F);
            txtItemType.Location = new Point(195, 162);
            txtItemType.Name = "txtItemType";
            txtItemType.Size = new Size(309, 34);
            txtItemType.TabIndex = 5;
            txtItemType.BackColor = Color.FromArgb(57, 53, 76);
            txtItemType.ForeColor = Color.FromArgb(86, 82, 105);
            // 
            // txtCost
            // 
            txtCost.Font = new Font("Constantia", 15F);
            txtCost.Location = new Point(195, 217);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(309, 34);
            txtCost.TabIndex = 6;
            txtCost.BackColor = Color.FromArgb(57, 53, 76);
            txtCost.ForeColor = Color.FromArgb(86, 82, 105);
            // 
            // lblAddItem
            // 
            lblAddItem.AutoSize = true;
            lblAddItem.Font = new Font("Constantia", 25F, FontStyle.Bold);
            lblAddItem.Location = new Point(195, 28);
            lblAddItem.Name = "lblAddItem";
            lblAddItem.Size = new Size(185, 46);
            lblAddItem.TabIndex = 7;
            lblAddItem.Text = "ADD ITEM";
            lblAddItem.ForeColor = Color.FromArgb(218, 216, 227);
        }

        protected void InitializeRemoveButtonBoard(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(lblRemoveItem);
            pnlContainer.Controls.Add(lblItemNameR);
            pnlContainer.Controls.Add(txtItemNameR);
            pnlContainer.Controls.Add(btnRemove);

            // 
            // lvlRemoveItem
            // 
            lblRemoveItem.AutoSize = true;
            lblRemoveItem.Font = new Font("Constantia", 23F);
            lblRemoveItem.Location = new Point(173, 45);
            lblRemoveItem.Name = "lvlRemoveItem";
            lblRemoveItem.Size = new Size(198, 42);
            lblRemoveItem.TabIndex = 0;
            lblRemoveItem.Text = "Remove Item";
            lblRemoveItem.ForeColor = Color.FromArgb(218, 216, 227);
            // 
            // lblItemNameR
            // 
            lblItemNameR.AutoSize = true;
            lblItemNameR.Font = new Font("Constantia", 17F);
            lblItemNameR.Location = new Point(61, 136);
            lblItemNameR.Name = "lblItemNameR";
            lblItemNameR.Size = new Size(132, 31);
            lblItemNameR.TabIndex = 1;
            lblItemNameR.Text = "Item Name:";
            lblItemNameR.ForeColor = Color.FromArgb(218, 216, 227);
            // 
            // txtItemNameR
            // 
            txtItemNameR.Font = new Font("Constantia", 15F);
            txtItemNameR.Location = new Point(199, 136);
            txtItemNameR.Name = "txtItemNameR";
            txtItemNameR.Size = new Size(265, 34);
            txtItemNameR.TabIndex = 2;
            txtItemNameR.BackColor = Color.FromArgb(57, 53, 76);
            txtItemNameR.ForeColor = Color.FromArgb(86, 82, 105);
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(355, 195);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(111, 47);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemoveItemEvent;
            btnRemove.BackColor = Color.FromArgb(57, 53, 76);
            btnRemove.ForeColor = Color.FromArgb(218, 216, 227);

        }


        protected void btnAddItemEvent(object sender, EventArgs e)
        {
            string type = txtItemType.Text;
            string name = txtItemName.Text;
            double cost = 0;
            
            if (name.Trim() == null || txtItemName.Name.Trim().Equals(""))
            {
                MessageBox.Show("ERROR: Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCost.Text.Trim() == null || txtCost.Text.Trim().Equals(""))
            {
                MessageBox.Show("ERROR: Enter Item Cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    cost = Convert.ToDouble(txtCost.Text.Trim());

                }
                catch
                {
                    MessageBox.Show("ERROR: Invalid Item Cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (type.Trim() == null || txtItemType.Text.Trim().Equals(""))
            {
                MessageBox.Show("ERROR: Enter Item Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CoffeeShop.coffeeShopprocess.AddItem(name, cost, type);
            MessageBox.Show("SUCCESSFUL: ITEM ADDED", "ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtItemName.Text = "";
            txtItemType.Text = "";
            txtCost.Text = "";
            return;
        }

        protected void btnRemoveItemEvent(object sender, EventArgs e)
        {
            string itemName = txtItemNameR.Text.Trim();
            if (itemName.Equals(""))
            {
                MessageBox.Show("ERROR: Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CoffeeShop.coffeeShopprocess.DeleteItem(itemName))
            {
                MessageBox.Show("SUCCESSFUL: ITEM '"+itemName +"' REMOVED", "REMOVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemNameR.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR: ITEM '"+ itemName +"' NOT FOUND", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemNameR.Text = "";
            }
        }

        protected void btnBackEvent(object sender, EventArgs e)
        {
            this.Hide();
            new SignInForm().ShowDialog();
            this.Close();
          
        }


        protected void btnViewSoldSummaryEvent(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(pnlContainerSummary);
        }

        protected String GenerateSummaryText()
        {
            string summary = "";
            var itemTypes = CoffeeShop.coffeeShopprocess.GetItemTypes();
            if (itemTypes == null || itemTypes.Count() == 0)
            {
                return summary;
            }

            double grandTotal = 0;
            foreach (string itemType in itemTypes)
            {
                summary += " ------------------------------------------\n";
                summary += itemType + "     " + "COST" + "     " + "Sold  Count" + "     " + "Total\n";
                summary += " ------------------------------------------\n";

                var items = CoffeeShop.coffeeShopprocess.GetItemsPerType(itemType);
                if (items != null && items.Count > 0)
                {
                    double totalSoldPerType = 0;
                    foreach (var item in items)
                    {
                        double totalSoldPerItem = item.soldCount * item.cost;
                        totalSoldPerType += totalSoldPerItem;
                        summary += (item.name + "      " + item.cost + "     " + item.soldCount + "     " + totalSoldPerItem + "\n");
                    }
                    summary += (" ------------------------------------------\n");
                    summary += ("Total for " + itemType + ": " + totalSoldPerType + "\n");
                    grandTotal += totalSoldPerType;
                }
                else
                {
                    summary += ("No items sold in this category.\n");
                }
                summary += (" ------------------------------------------\n");
            }
            summary += ("Grand Total: " + grandTotal);
            return summary;
        }

        #endregion

        private Panel pnlContainer;
        private Button btnViewSoldSummary;
        private Button btnAddItem;
        private Button btnRemoveItem, btnRemove;
        private Button btnBack;
        private Label lblItemType;
        private Label lblItemName, lblItemNameR;
        private Label label1;
        private Label lblAddItem, lblRemoveItem;
        private TextBox txtCost, txtItemNameR;
        private TextBox txtItemType;
        private TextBox txtItemName;
        private Button btnAdd;
        private Panel panel1;
        private Label label2;
        private FlowLayoutPanel pnlContainerSummary;
        private Label lblSummary;
    }
}