﻿namespace RMS.User_Controls
{
    partial class NewFoodItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFoodItem));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.foodGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.isSpecialCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnAddFoodItems = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.panelTopContainer = new System.Windows.Forms.Panel();
            this.btnRadioActive = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRadioInactive = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelForImage = new System.Windows.Forms.Label();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.paneltopBorder = new System.Windows.Forms.Panel();
            this.panelBorderRight = new System.Windows.Forms.Panel();
            this.panelBorderLeft = new System.Windows.Forms.Panel();
            this.panelBorderBottom = new System.Windows.Forms.Panel();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelTopContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(10, 373);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1305, 352);
            this.bunifuCustomDataGrid1.TabIndex = 6;
            // 
            // foodGridView
            // 
            this.foodGridView.AllowUserToAddRows = false;
            this.foodGridView.AllowUserToDeleteRows = false;
            this.foodGridView.AllowUserToResizeColumns = false;
            this.foodGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.foodGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.foodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.foodGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.foodGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.foodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sn,
            this.InvoiceNumber,
            this.Date,
            this.Amount,
            this.Status,
            this.isSpecial,
            this.Discount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.foodGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodGridView.DoubleBuffered = true;
            this.foodGridView.EnableHeadersVisualStyles = false;
            this.foodGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.foodGridView.HeaderForeColor = System.Drawing.Color.White;
            this.foodGridView.Location = new System.Drawing.Point(10, 373);
            this.foodGridView.MultiSelect = false;
            this.foodGridView.Name = "foodGridView";
            this.foodGridView.ReadOnly = true;
            this.foodGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.foodGridView.RowHeadersVisible = false;
            this.foodGridView.RowHeadersWidth = 51;
            this.foodGridView.RowTemplate.DividerHeight = 1;
            this.foodGridView.RowTemplate.Height = 30;
            this.foodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodGridView.Size = new System.Drawing.Size(1305, 352);
            this.foodGridView.TabIndex = 10;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // isSpecial
            // 
            this.isSpecial.DataPropertyName = "isSpecial";
            this.isSpecial.HeaderText = "Is Special?";
            this.isSpecial.MinimumWidth = 6;
            this.isSpecial.Name = "isSpecial";
            this.isSpecial.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Price";
            this.Amount.HeaderText = "Price";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "FoodName";
            this.Date.HeaderText = "Food Name";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "CategoryName";
            this.InvoiceNumber.HeaderText = "Category Name";
            this.InvoiceNumber.MinimumWidth = 6;
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Id";
            this.Sn.HeaderText = "      S.N";
            this.Sn.MinimumWidth = 6;
            this.Sn.Name = "Sn";
            this.Sn.ReadOnly = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.foodGridView);
            this.panelMain.Controls.Add(this.bunifuCustomDataGrid1);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelTopContainer);
            this.panelMain.Controls.Add(this.panelBorderBottom);
            this.panelMain.Controls.Add(this.panelBorderLeft);
            this.panelMain.Controls.Add(this.panelBorderRight);
            this.panelMain.Controls.Add(this.paneltopBorder);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1325, 735);
            this.panelMain.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(52, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(149, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Category Name* :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(52, 89);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(118, 20);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Food Name* :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(52, 144);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(66, 20);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Price* :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(52, 196);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(62, 20);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Status";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(52, 246);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(108, 20);
            this.bunifuCustomLabel5.TabIndex = 0;
            this.bunifuCustomLabel5.Text = "Is Special? :";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(351, 249);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(110, 20);
            this.bunifuCustomLabel6.TabIndex = 0;
            this.bunifuCustomLabel6.Text = "Discount % :";
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(308, 29);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(255, 28);
            this.cmbCategoryName.TabIndex = 0;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(308, 86);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(255, 26);
            this.txtFoodName.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(496, 243);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(67, 26);
            this.txtDiscount.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(308, 144);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(255, 26);
            this.txtPrice.TabIndex = 2;
            // 
            // isSpecialCheckBox
            // 
            this.isSpecialCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.isSpecialCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.isSpecialCheckBox.Checked = true;
            this.isSpecialCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.isSpecialCheckBox.ForeColor = System.Drawing.Color.White;
            this.isSpecialCheckBox.Location = new System.Drawing.Point(308, 249);
            this.isSpecialCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.isSpecialCheckBox.Name = "isSpecialCheckBox";
            this.isSpecialCheckBox.Size = new System.Drawing.Size(20, 20);
            this.isSpecialCheckBox.TabIndex = 5;
            // 
            // btnAddFoodItems
            // 
            this.btnAddFoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(141)))), ((int)(((byte)(1)))));
            this.btnAddFoodItems.ForeColor = System.Drawing.Color.White;
            this.btnAddFoodItems.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFoodItems.Image")));
            this.btnAddFoodItems.Location = new System.Drawing.Point(879, 249);
            this.btnAddFoodItems.Name = "btnAddFoodItems";
            this.btnAddFoodItems.Size = new System.Drawing.Size(266, 49);
            this.btnAddFoodItems.TabIndex = 7;
            this.btnAddFoodItems.Text = "     Add Food Item";
            this.btnAddFoodItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFoodItems.UseVisualStyleBackColor = false;
            this.btnAddFoodItems.Click += new System.EventHandler(this.btnAddFoodItems_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.Image")));
            this.btnUploadImage.Location = new System.Drawing.Point(879, 183);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(266, 49);
            this.btnUploadImage.TabIndex = 7;
            this.btnUploadImage.Text = "     Upload Image";
            this.btnUploadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // panelTopContainer
            // 
            this.panelTopContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panelTopContainer.Controls.Add(this.btnRemoveImage);
            this.panelTopContainer.Controls.Add(this.labelForImage);
            this.panelTopContainer.Controls.Add(this.pictureBox1);
            this.panelTopContainer.Controls.Add(this.btnRadioInactive);
            this.panelTopContainer.Controls.Add(this.btnRadioActive);
            this.panelTopContainer.Controls.Add(this.btnUploadImage);
            this.panelTopContainer.Controls.Add(this.btnAddFoodItems);
            this.panelTopContainer.Controls.Add(this.isSpecialCheckBox);
            this.panelTopContainer.Controls.Add(this.txtPrice);
            this.panelTopContainer.Controls.Add(this.txtDiscount);
            this.panelTopContainer.Controls.Add(this.txtFoodName);
            this.panelTopContainer.Controls.Add(this.cmbCategoryName);
            this.panelTopContainer.Controls.Add(this.bunifuCustomLabel6);
            this.panelTopContainer.Controls.Add(this.bunifuCustomLabel5);
            this.panelTopContainer.Controls.Add(this.bunifuCustomLabel4);
            this.panelTopContainer.Controls.Add(this.bunifuCustomLabel3);
            this.panelTopContainer.Controls.Add(this.bunifuCustomLabel2);
            this.panelTopContainer.Controls.Add(this.bunifuCustomLabel1);
            this.panelTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopContainer.Location = new System.Drawing.Point(10, 10);
            this.panelTopContainer.Name = "panelTopContainer";
            this.panelTopContainer.Size = new System.Drawing.Size(1305, 317);
            this.panelTopContainer.TabIndex = 4;
            // 
            // btnRadioActive
            // 
            this.btnRadioActive.AutoSize = true;
            this.btnRadioActive.Checked = true;
            this.btnRadioActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadioActive.Location = new System.Drawing.Point(308, 196);
            this.btnRadioActive.Name = "btnRadioActive";
            this.btnRadioActive.Size = new System.Drawing.Size(79, 28);
            this.btnRadioActive.TabIndex = 3;
            this.btnRadioActive.TabStop = true;
            this.btnRadioActive.Text = "Active";
            this.btnRadioActive.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(32, 12);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(237, 20);
            this.bunifuCustomLabel7.TabIndex = 0;
            this.bunifuCustomLabel7.Text = "Recently Added Food Items:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 46);
            this.panel1.TabIndex = 5;
            // 
            // btnRadioInactive
            // 
            this.btnRadioInactive.AutoSize = true;
            this.btnRadioInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRadioInactive.Location = new System.Drawing.Point(431, 196);
            this.btnRadioInactive.Name = "btnRadioInactive";
            this.btnRadioInactive.Size = new System.Drawing.Size(91, 28);
            this.btnRadioInactive.TabIndex = 4;
            this.btnRadioInactive.Text = "Inactive";
            this.btnRadioInactive.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(879, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelForImage
            // 
            this.labelForImage.AutoSize = true;
            this.labelForImage.Location = new System.Drawing.Point(872, 196);
            this.labelForImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForImage.Name = "labelForImage";
            this.labelForImage.Size = new System.Drawing.Size(0, 20);
            this.labelForImage.TabIndex = 11;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveImage.Image")));
            this.btnRemoveImage.Location = new System.Drawing.Point(879, 183);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(266, 49);
            this.btnRemoveImage.TabIndex = 12;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Visible = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // paneltopBorder
            // 
            this.paneltopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.paneltopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltopBorder.Location = new System.Drawing.Point(0, 0);
            this.paneltopBorder.Name = "paneltopBorder";
            this.paneltopBorder.Size = new System.Drawing.Size(1325, 10);
            this.paneltopBorder.TabIndex = 0;
            // 
            // panelBorderRight
            // 
            this.panelBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBorderRight.Location = new System.Drawing.Point(1315, 10);
            this.panelBorderRight.Name = "panelBorderRight";
            this.panelBorderRight.Size = new System.Drawing.Size(10, 725);
            this.panelBorderRight.TabIndex = 1;
            // 
            // panelBorderLeft
            // 
            this.panelBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorderLeft.Location = new System.Drawing.Point(0, 10);
            this.panelBorderLeft.Name = "panelBorderLeft";
            this.panelBorderLeft.Size = new System.Drawing.Size(10, 725);
            this.panelBorderLeft.TabIndex = 2;
            // 
            // panelBorderBottom
            // 
            this.panelBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panelBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBorderBottom.Location = new System.Drawing.Point(10, 725);
            this.panelBorderBottom.Name = "panelBorderBottom";
            this.panelBorderBottom.Size = new System.Drawing.Size(1305, 10);
            this.panelBorderBottom.TabIndex = 3;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // NewFoodItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewFoodItem";
            this.Size = new System.Drawing.Size(1325, 735);
            this.Load += new System.EventHandler(this.NewFoodItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelTopContainer.ResumeLayout(false);
            this.panelTopContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid foodGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn isSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Panel panelTopContainer;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Label labelForImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton btnRadioInactive;
        private System.Windows.Forms.RadioButton btnRadioActive;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnAddFoodItems;
        private Bunifu.Framework.UI.BunifuCheckbox isSpecialCheckBox;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panelBorderBottom;
        private System.Windows.Forms.Panel panelBorderLeft;
        private System.Windows.Forms.Panel panelBorderRight;
        private System.Windows.Forms.Panel paneltopBorder;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}
