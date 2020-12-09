namespace CompanyWF
{
    partial class OrdersDetails
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
            System.Windows.Forms.TabControl OrdersTabs;
            this.FindOrdersTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_byItem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.By = new System.Windows.Forms.Label();
            this.textBox_byUsers = new System.Windows.Forms.TextBox();
            this.FindOrdersView = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOrdered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeliveryStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastUpdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastUpdateStaff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SortOrder = new System.Windows.Forms.TabPage();
            this.GetAll = new System.Windows.Forms.Button();
            this.SortByStatus = new System.Windows.Forms.Button();
            this.SortByDate = new System.Windows.Forms.Button();
            this.SortOrderView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateOrder = new System.Windows.Forms.TabPage();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button_logOut = new System.Windows.Forms.Button();
            this.label_OrderMenu = new System.Windows.Forms.Label();
            this.button_goBack = new System.Windows.Forms.Button();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.OrderCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderCol3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderCol4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxStatuses = new System.Windows.Forms.ComboBox();
            this.buttonFindOrder = new System.Windows.Forms.Button();
            OrdersTabs = new System.Windows.Forms.TabControl();
            OrdersTabs.SuspendLayout();
            this.FindOrdersTab.SuspendLayout();
            this.SortOrder.SuspendLayout();
            this.UpdateOrder.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersTabs
            // 
            OrdersTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            OrdersTabs.Controls.Add(this.FindOrdersTab);
            OrdersTabs.Controls.Add(this.SortOrder);
            OrdersTabs.Controls.Add(this.UpdateOrder);
            OrdersTabs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OrdersTabs.Location = new System.Drawing.Point(179, 12);
            OrdersTabs.Multiline = true;
            OrdersTabs.Name = "OrdersTabs";
            OrdersTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            OrdersTabs.SelectedIndex = 0;
            OrdersTabs.Size = new System.Drawing.Size(903, 529);
            OrdersTabs.TabIndex = 2;
            // 
            // FindOrdersTab
            // 
            this.FindOrdersTab.BackColor = System.Drawing.Color.Olive;
            this.FindOrdersTab.Controls.Add(this.label1);
            this.FindOrdersTab.Controls.Add(this.textBox_byItem);
            this.FindOrdersTab.Controls.Add(this.button2);
            this.FindOrdersTab.Controls.Add(this.button1);
            this.FindOrdersTab.Controls.Add(this.By);
            this.FindOrdersTab.Controls.Add(this.textBox_byUsers);
            this.FindOrdersTab.Controls.Add(this.FindOrdersView);
            this.FindOrdersTab.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FindOrdersTab.Location = new System.Drawing.Point(4, 32);
            this.FindOrdersTab.Name = "FindOrdersTab";
            this.FindOrdersTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FindOrdersTab.Size = new System.Drawing.Size(895, 493);
            this.FindOrdersTab.TabIndex = 0;
            this.FindOrdersTab.Text = "Find Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(527, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "by item:";
            // 
            // textBox_byItem
            // 
            this.textBox_byItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_byItem.Location = new System.Drawing.Point(635, 15);
            this.textBox_byItem.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_byItem.Name = "textBox_byItem";
            this.textBox_byItem.Size = new System.Drawing.Size(113, 32);
            this.textBox_byItem.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(778, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.FindOrdersByItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(297, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.FindOrdersByUser_Click);
            // 
            // By
            // 
            this.By.AutoSize = true;
            this.By.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.By.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.By.Location = new System.Drawing.Point(13, 20);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(144, 23);
            this.By.TabIndex = 2;
            this.By.Text = "by username:";
            // 
            // textBox_byUsers
            // 
            this.textBox_byUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_byUsers.Location = new System.Drawing.Point(165, 17);
            this.textBox_byUsers.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_byUsers.Name = "textBox_byUsers";
            this.textBox_byUsers.Size = new System.Drawing.Size(113, 32);
            this.textBox_byUsers.TabIndex = 1;
            // 
            // FindOrdersView
            // 
            this.FindOrdersView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindOrdersView.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.FindOrdersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Customer,
            this.DateOrdered,
            this.DeliveryStatus,
            this.LastUpdate,
            this.LastUpdateStaff,
            this.Comments});
            this.FindOrdersView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindOrdersView.HideSelection = false;
            this.FindOrdersView.Location = new System.Drawing.Point(-3, 68);
            this.FindOrdersView.Margin = new System.Windows.Forms.Padding(0);
            this.FindOrdersView.Name = "FindOrdersView";
            this.FindOrdersView.Size = new System.Drawing.Size(898, 425);
            this.FindOrdersView.TabIndex = 0;
            this.FindOrdersView.UseCompatibleStateImageBehavior = false;
            this.FindOrdersView.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "OrderID";
            this.OrderID.Width = 80;
            // 
            // Customer
            // 
            this.Customer.Text = "Customer";
            this.Customer.Width = 140;
            // 
            // DateOrdered
            // 
            this.DateOrdered.Text = "Date";
            this.DateOrdered.Width = 100;
            // 
            // DeliveryStatus
            // 
            this.DeliveryStatus.Text = "Status";
            this.DeliveryStatus.Width = 120;
            // 
            // LastUpdate
            // 
            this.LastUpdate.Text = "Last update";
            this.LastUpdate.Width = 120;
            // 
            // LastUpdateStaff
            // 
            this.LastUpdateStaff.Text = "by Staff";
            this.LastUpdateStaff.Width = 120;
            // 
            // Comments
            // 
            this.Comments.Text = "Comments";
            this.Comments.Width = 200;
            // 
            // SortOrder
            // 
            this.SortOrder.BackColor = System.Drawing.Color.Olive;
            this.SortOrder.Controls.Add(this.GetAll);
            this.SortOrder.Controls.Add(this.SortByStatus);
            this.SortOrder.Controls.Add(this.SortByDate);
            this.SortOrder.Controls.Add(this.SortOrderView);
            this.SortOrder.Location = new System.Drawing.Point(4, 32);
            this.SortOrder.Name = "SortOrder";
            this.SortOrder.Padding = new System.Windows.Forms.Padding(3);
            this.SortOrder.Size = new System.Drawing.Size(895, 493);
            this.SortOrder.TabIndex = 2;
            this.SortOrder.Text = "Sort Orders";
            // 
            // GetAll
            // 
            this.GetAll.BackColor = System.Drawing.Color.Khaki;
            this.GetAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetAll.ForeColor = System.Drawing.Color.SaddleBrown;
            this.GetAll.Location = new System.Drawing.Point(522, 6);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(252, 60);
            this.GetAll.TabIndex = 4;
            this.GetAll.Text = "Without Filters";
            this.GetAll.UseVisualStyleBackColor = false;
            this.GetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // SortByStatus
            // 
            this.SortByStatus.BackColor = System.Drawing.Color.Khaki;
            this.SortByStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SortByStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortByStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByStatus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SortByStatus.Location = new System.Drawing.Point(264, 6);
            this.SortByStatus.Name = "SortByStatus";
            this.SortByStatus.Size = new System.Drawing.Size(252, 60);
            this.SortByStatus.TabIndex = 3;
            this.SortByStatus.Text = "Sort By Status";
            this.SortByStatus.UseVisualStyleBackColor = false;
            this.SortByStatus.Click += new System.EventHandler(this.buttonSortByStatus_Click);
            // 
            // SortByDate
            // 
            this.SortByDate.BackColor = System.Drawing.Color.Khaki;
            this.SortByDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SortByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByDate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SortByDate.Location = new System.Drawing.Point(6, 6);
            this.SortByDate.Name = "SortByDate";
            this.SortByDate.Size = new System.Drawing.Size(252, 60);
            this.SortByDate.TabIndex = 2;
            this.SortByDate.Text = "Sort By Last Update";
            this.SortByDate.UseVisualStyleBackColor = false;
            this.SortByDate.Click += new System.EventHandler(this.buttonSortByDate_Click);
            // 
            // SortOrderView
            // 
            this.SortOrderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortOrderView.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SortOrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.SortOrderView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortOrderView.HideSelection = false;
            this.SortOrderView.Location = new System.Drawing.Point(0, 72);
            this.SortOrderView.Name = "SortOrderView";
            this.SortOrderView.Size = new System.Drawing.Size(895, 421);
            this.SortOrderView.TabIndex = 1;
            this.SortOrderView.UseCompatibleStateImageBehavior = false;
            this.SortOrderView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OrderID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last update";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "by Staff";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Comments";
            this.columnHeader7.Width = 200;
            // 
            // UpdateOrder
            // 
            this.UpdateOrder.BackColor = System.Drawing.Color.Olive;
            this.UpdateOrder.Controls.Add(this.buttonFindOrder);
            this.UpdateOrder.Controls.Add(this.comboBoxStatuses);
            this.UpdateOrder.Controls.Add(this.listViewOrder);
            this.UpdateOrder.Controls.Add(this.buttonChangeStatus);
            this.UpdateOrder.Controls.Add(this.listViewItems);
            this.UpdateOrder.Controls.Add(this.textBox1);
            this.UpdateOrder.Controls.Add(this.orderIdLabel);
            this.UpdateOrder.Location = new System.Drawing.Point(4, 32);
            this.UpdateOrder.Name = "UpdateOrder";
            this.UpdateOrder.Size = new System.Drawing.Size(895, 493);
            this.UpdateOrder.TabIndex = 3;
            this.UpdateOrder.Text = "Update Order";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.BackColor = System.Drawing.Color.Green;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.button_logOut);
            this.MenuPanel.Controls.Add(this.label_OrderMenu);
            this.MenuPanel.Controls.Add(this.button_goBack);
            this.MenuPanel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPanel.ForeColor = System.Drawing.Color.Cornsilk;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.MenuPanel.MinimumSize = new System.Drawing.Size(177, 465);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(177, 541);
            this.MenuPanel.TabIndex = 2;
            // 
            // button_logOut
            // 
            this.button_logOut.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logOut.Location = new System.Drawing.Point(-2, 127);
            this.button_logOut.Margin = new System.Windows.Forms.Padding(0);
            this.button_logOut.MaximumSize = new System.Drawing.Size(177, 46);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_logOut.Size = new System.Drawing.Size(177, 46);
            this.button_logOut.TabIndex = 2;
            this.button_logOut.Text = "Log Out";
            this.button_logOut.UseVisualStyleBackColor = false;
            this.button_logOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // label_OrderMenu
            // 
            this.label_OrderMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.label_OrderMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OrderMenu.Location = new System.Drawing.Point(0, 0);
            this.label_OrderMenu.Name = "label_OrderMenu";
            this.label_OrderMenu.Size = new System.Drawing.Size(177, 50);
            this.label_OrderMenu.TabIndex = 1;
            this.label_OrderMenu.Text = "Order Menu";
            this.label_OrderMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_goBack
            // 
            this.button_goBack.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_goBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_goBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_goBack.Location = new System.Drawing.Point(-2, 67);
            this.button_goBack.Margin = new System.Windows.Forms.Padding(0);
            this.button_goBack.MaximumSize = new System.Drawing.Size(177, 46);
            this.button_goBack.Name = "button_goBack";
            this.button_goBack.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_goBack.Size = new System.Drawing.Size(177, 46);
            this.button_goBack.TabIndex = 0;
            this.button_goBack.Text = "Go back";
            this.button_goBack.UseVisualStyleBackColor = false;
            this.button_goBack.Click += new System.EventHandler(this.button_goBack_Click);
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIdLabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.orderIdLabel.Location = new System.Drawing.Point(22, 21);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(152, 23);
            this.orderIdLabel.TabIndex = 3;
            this.orderIdLabel.Text = "Input Order ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.orderText_Changed);
            // 
            // listViewItems
            // 
            this.listViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewItems.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ID,
            this.Price,
            this.Amount});
            this.listViewItems.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(400, 201);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(480, 274);
            this.listViewItems.TabIndex = 5;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item";
            this.ItemName.Width = 145;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 55;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 75;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 75;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.BackColor = System.Drawing.Color.Khaki;
            this.buttonChangeStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeStatus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonChangeStatus.Location = new System.Drawing.Point(400, 73);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(190, 46);
            this.buttonChangeStatus.TabIndex = 7;
            this.buttonChangeStatus.Text = "Change Status";
            this.buttonChangeStatus.UseVisualStyleBackColor = false;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewOrder.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderCol1,
            this.OrderCol2,
            this.OrderCol3,
            this.OrderCol4});
            this.listViewOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(20, 73);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(361, 402);
            this.listViewOrder.TabIndex = 8;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Tile;
            // 
            // OrderCol1
            // 
            this.OrderCol1.Width = 120;
            // 
            // OrderCol2
            // 
            this.OrderCol2.Width = 120;
            // 
            // OrderCol3
            // 
            this.OrderCol3.Width = 120;
            // 
            // OrderCol4
            // 
            this.OrderCol4.Width = 120;
            // 
            // comboBoxStatuses
            // 
            this.comboBoxStatuses.FormattingEnabled = true;
            this.comboBoxStatuses.Items.AddRange(new object[] {
            "canceled",
            "ordered",
            "paid-up",
            "inProgress",
            "awCustConf",
            "delivered"});
            this.comboBoxStatuses.Location = new System.Drawing.Point(400, 143);
            this.comboBoxStatuses.Name = "comboBoxStatuses";
            this.comboBoxStatuses.Size = new System.Drawing.Size(190, 31);
            this.comboBoxStatuses.TabIndex = 9;
            // 
            // buttonFindOrder
            // 
            this.buttonFindOrder.BackColor = System.Drawing.Color.Khaki;
            this.buttonFindOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFindOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindOrder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonFindOrder.Location = new System.Drawing.Point(400, 12);
            this.buttonFindOrder.Name = "buttonFindOrder";
            this.buttonFindOrder.Size = new System.Drawing.Size(190, 46);
            this.buttonFindOrder.TabIndex = 10;
            this.buttonFindOrder.Text = "Find Order";
            this.buttonFindOrder.UseVisualStyleBackColor = false;
            this.buttonFindOrder.Click += new System.EventHandler(this.buttonFindOrder_Click);
            // 
            // OrdersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1082, 541);
            this.Controls.Add(OrdersTabs);
            this.Controls.Add(this.MenuPanel);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "OrdersDetails";
            this.Text = "OrdersDetails";
            OrdersTabs.ResumeLayout(false);
            this.FindOrdersTab.ResumeLayout(false);
            this.FindOrdersTab.PerformLayout();
            this.SortOrder.ResumeLayout(false);
            this.UpdateOrder.ResumeLayout(false);
            this.UpdateOrder.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label_OrderMenu;
        private System.Windows.Forms.Button button_goBack;
        private System.Windows.Forms.TabPage FindOrdersTab;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Label By;
        private System.Windows.Forms.TextBox textBox_byUsers;
        private System.Windows.Forms.ListView FindOrdersView;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader DateOrdered;
        private System.Windows.Forms.ColumnHeader DeliveryStatus;
        private System.Windows.Forms.ColumnHeader LastUpdate;
        private System.Windows.Forms.ColumnHeader LastUpdateStaff;
        private System.Windows.Forms.ColumnHeader Comments;
        private System.Windows.Forms.TabPage SortOrder;
        private System.Windows.Forms.ListView SortOrderView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage UpdateOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_byItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GetAll;
        private System.Windows.Forms.Button SortByStatus;
        private System.Windows.Forms.Button SortByDate;
        private System.Windows.Forms.ComboBox comboBoxStatuses;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader OrderCol1;
        private System.Windows.Forms.ColumnHeader OrderCol2;
        private System.Windows.Forms.ColumnHeader OrderCol3;
        private System.Windows.Forms.ColumnHeader OrderCol4;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Button buttonFindOrder;
    }
}