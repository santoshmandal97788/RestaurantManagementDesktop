namespace RMS.User_Controls
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtonsContainer = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnUserInputSales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMonthlySales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDailySales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalesWeekly = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fromDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panelSalesMiddleButton = new System.Windows.Forms.Panel();
            this.salesDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSalesContainer = new System.Windows.Forms.Panel();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtonsContainer.SuspendLayout();
            this.panelSalesMiddleButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSalesContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 725);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 10);
            this.panel1.TabIndex = 0;
            // 
            // panelButtonsContainer
            // 
            this.panelButtonsContainer.Controls.Add(this.txtTotal);
            this.panelButtonsContainer.Controls.Add(this.lblTotal);
            this.panelButtonsContainer.Controls.Add(this.btnUserInputSales);
            this.panelButtonsContainer.Controls.Add(this.btnMonthlySales);
            this.panelButtonsContainer.Controls.Add(this.btnDailySales);
            this.panelButtonsContainer.Controls.Add(this.btnSalesWeekly);
            this.panelButtonsContainer.Controls.Add(this.bunifuCustomLabel2);
            this.panelButtonsContainer.Controls.Add(this.toDatepicker);
            this.panelButtonsContainer.Controls.Add(this.bunifuCustomLabel1);
            this.panelButtonsContainer.Controls.Add(this.fromDatepicker);
            this.panelButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelButtonsContainer.Name = "panelButtonsContainer";
            this.panelButtonsContainer.Size = new System.Drawing.Size(1316, 90);
            this.panelButtonsContainer.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(73, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(26, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 18);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // btnUserInputSales
            // 
            this.btnUserInputSales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUserInputSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUserInputSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserInputSales.BorderRadius = 0;
            this.btnUserInputSales.ButtonText = "Get Sales";
            this.btnUserInputSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserInputSales.DisabledColor = System.Drawing.Color.Gray;
            this.btnUserInputSales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserInputSales.Iconimage = null;
            this.btnUserInputSales.Iconimage_right = null;
            this.btnUserInputSales.Iconimage_right_Selected = null;
            this.btnUserInputSales.Iconimage_Selected = null;
            this.btnUserInputSales.IconMarginLeft = 0;
            this.btnUserInputSales.IconMarginRight = 0;
            this.btnUserInputSales.IconRightVisible = true;
            this.btnUserInputSales.IconRightZoom = 0D;
            this.btnUserInputSales.IconVisible = true;
            this.btnUserInputSales.IconZoom = 90D;
            this.btnUserInputSales.IsTab = false;
            this.btnUserInputSales.Location = new System.Drawing.Point(1081, 26);
            this.btnUserInputSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserInputSales.Name = "btnUserInputSales";
            this.btnUserInputSales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUserInputSales.OnHovercolor = System.Drawing.Color.Green;
            this.btnUserInputSales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUserInputSales.selected = false;
            this.btnUserInputSales.Size = new System.Drawing.Size(101, 42);
            this.btnUserInputSales.TabIndex = 6;
            this.btnUserInputSales.Text = "Get Sales";
            this.btnUserInputSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUserInputSales.Textcolor = System.Drawing.Color.White;
            this.btnUserInputSales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInputSales.Click += new System.EventHandler(this.btnUserInputSales_Click);
            // 
            // btnMonthlySales
            // 
            this.btnMonthlySales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMonthlySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMonthlySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonthlySales.BorderRadius = 0;
            this.btnMonthlySales.ButtonText = "Monthly";
            this.btnMonthlySales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlySales.DisabledColor = System.Drawing.Color.Gray;
            this.btnMonthlySales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMonthlySales.Iconimage = null;
            this.btnMonthlySales.Iconimage_right = null;
            this.btnMonthlySales.Iconimage_right_Selected = null;
            this.btnMonthlySales.Iconimage_Selected = null;
            this.btnMonthlySales.IconMarginLeft = 0;
            this.btnMonthlySales.IconMarginRight = 0;
            this.btnMonthlySales.IconRightVisible = true;
            this.btnMonthlySales.IconRightZoom = 0D;
            this.btnMonthlySales.IconVisible = true;
            this.btnMonthlySales.IconZoom = 90D;
            this.btnMonthlySales.IsTab = false;
            this.btnMonthlySales.Location = new System.Drawing.Point(293, 27);
            this.btnMonthlySales.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMonthlySales.OnHovercolor = System.Drawing.Color.Green;
            this.btnMonthlySales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMonthlySales.selected = false;
            this.btnMonthlySales.Size = new System.Drawing.Size(101, 42);
            this.btnMonthlySales.TabIndex = 5;
            this.btnMonthlySales.Text = "Monthly";
            this.btnMonthlySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMonthlySales.Textcolor = System.Drawing.Color.White;
            this.btnMonthlySales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySales.Click += new System.EventHandler(this.btnMonthlySales_Click);
            // 
            // btnDailySales
            // 
            this.btnDailySales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDailySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDailySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDailySales.BorderRadius = 0;
            this.btnDailySales.ButtonText = "Daily";
            this.btnDailySales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailySales.DisabledColor = System.Drawing.Color.Gray;
            this.btnDailySales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDailySales.Iconimage = null;
            this.btnDailySales.Iconimage_right = null;
            this.btnDailySales.Iconimage_right_Selected = null;
            this.btnDailySales.Iconimage_Selected = null;
            this.btnDailySales.IconMarginLeft = 0;
            this.btnDailySales.IconMarginRight = 0;
            this.btnDailySales.IconRightVisible = true;
            this.btnDailySales.IconRightZoom = 0D;
            this.btnDailySales.IconVisible = true;
            this.btnDailySales.IconZoom = 90D;
            this.btnDailySales.IsTab = false;
            this.btnDailySales.Location = new System.Drawing.Point(29, 27);
            this.btnDailySales.Margin = new System.Windows.Forms.Padding(4);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDailySales.OnHovercolor = System.Drawing.Color.Green;
            this.btnDailySales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDailySales.selected = false;
            this.btnDailySales.Size = new System.Drawing.Size(101, 42);
            this.btnDailySales.TabIndex = 2;
            this.btnDailySales.Text = "Daily";
            this.btnDailySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDailySales.Textcolor = System.Drawing.Color.White;
            this.btnDailySales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnSalesWeekly
            // 
            this.btnSalesWeekly.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(105)))), ((int)(((byte)(188)))));
            this.btnSalesWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalesWeekly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesWeekly.BorderRadius = 0;
            this.btnSalesWeekly.ButtonText = "Weekly";
            this.btnSalesWeekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesWeekly.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalesWeekly.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalesWeekly.Iconimage = null;
            this.btnSalesWeekly.Iconimage_right = null;
            this.btnSalesWeekly.Iconimage_right_Selected = null;
            this.btnSalesWeekly.Iconimage_Selected = null;
            this.btnSalesWeekly.IconMarginLeft = 0;
            this.btnSalesWeekly.IconMarginRight = 0;
            this.btnSalesWeekly.IconRightVisible = true;
            this.btnSalesWeekly.IconRightZoom = 0D;
            this.btnSalesWeekly.IconVisible = true;
            this.btnSalesWeekly.IconZoom = 90D;
            this.btnSalesWeekly.IsTab = false;
            this.btnSalesWeekly.Location = new System.Drawing.Point(161, 27);
            this.btnSalesWeekly.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesWeekly.Name = "btnSalesWeekly";
            this.btnSalesWeekly.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSalesWeekly.OnHovercolor = System.Drawing.Color.Green;
            this.btnSalesWeekly.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalesWeekly.selected = false;
            this.btnSalesWeekly.Size = new System.Drawing.Size(101, 42);
            this.btnSalesWeekly.TabIndex = 2;
            this.btnSalesWeekly.Text = "Weekly";
            this.btnSalesWeekly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalesWeekly.Textcolor = System.Drawing.Color.White;
            this.btnSalesWeekly.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesWeekly.Click += new System.EventHandler(this.btnSalesWeekly_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(736, 37);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(26, 19);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "To";
            // 
            // toDatepicker
            // 
            this.toDatepicker.BackColor = System.Drawing.Color.White;
            this.toDatepicker.BorderRadius = 1;
            this.toDatepicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDatepicker.ForeColor = System.Drawing.Color.Black;
            this.toDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.toDatepicker.FormatCustom = null;
            this.toDatepicker.Location = new System.Drawing.Point(774, 26);
            this.toDatepicker.Margin = new System.Windows.Forms.Padding(4);
            this.toDatepicker.Name = "toDatepicker";
            this.toDatepicker.Size = new System.Drawing.Size(299, 41);
            this.toDatepicker.TabIndex = 3;
            this.toDatepicker.Value = new System.DateTime(2020, 1, 29, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(407, 39);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(48, 19);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "From";
            // 
            // fromDatepicker
            // 
            this.fromDatepicker.BackColor = System.Drawing.Color.White;
            this.fromDatepicker.BorderRadius = 2;
            this.fromDatepicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromDatepicker.ForeColor = System.Drawing.Color.Black;
            this.fromDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.fromDatepicker.FormatCustom = null;
            this.fromDatepicker.Location = new System.Drawing.Point(462, 26);
            this.fromDatepicker.Margin = new System.Windows.Forms.Padding(4);
            this.fromDatepicker.Name = "fromDatepicker";
            this.fromDatepicker.Size = new System.Drawing.Size(269, 42);
            this.fromDatepicker.TabIndex = 3;
            this.fromDatepicker.Value = new System.DateTime(2020, 1, 29, 0, 0, 0, 0);
            // 
            // panelSalesMiddleButton
            // 
            this.panelSalesMiddleButton.Controls.Add(this.panelButtonsContainer);
            this.panelSalesMiddleButton.Controls.Add(this.salesDataGridView);
            this.panelSalesMiddleButton.Location = new System.Drawing.Point(0, 61);
            this.panelSalesMiddleButton.Name = "panelSalesMiddleButton";
            this.panelSalesMiddleButton.Size = new System.Drawing.Size(1316, 658);
            this.panelSalesMiddleButton.TabIndex = 1;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.salesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.salesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sn,
            this.InvoiceNumber,
            this.Date,
            this.Amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesDataGridView.DoubleBuffered = true;
            this.salesDataGridView.EnableHeadersVisualStyles = false;
            this.salesDataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.salesDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.salesDataGridView.Location = new System.Drawing.Point(10, 89);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesDataGridView.RowHeadersVisible = false;
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.Size = new System.Drawing.Size(1155, 582);
            this.salesDataGridView.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 61);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "   Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(634, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sales Record";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1305, 61);
            this.panel5.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1315, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 735);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(979, 10);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 735);
            this.panel2.TabIndex = 21;
            // 
            // panelSalesContainer
            // 
            this.panelSalesContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSalesContainer.Controls.Add(this.panelSalesMiddleButton);
            this.panelSalesContainer.Controls.Add(this.panel1);
            this.panelSalesContainer.Location = new System.Drawing.Point(0, 0);
            this.panelSalesContainer.Name = "panelSalesContainer";
            this.panelSalesContainer.Size = new System.Drawing.Size(1325, 735);
            this.panelSalesContainer.TabIndex = 24;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Sn";
            this.Sn.HeaderText = "      S.N";
            this.Sn.MinimumWidth = 6;
            this.Sn.Name = "Sn";
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "OrderNo";
            this.InvoiceNumber.HeaderText = "Invoice Number";
            this.InvoiceNumber.MinimumWidth = 6;
            this.InvoiceNumber.Name = "InvoiceNumber";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "OrderDate";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Total";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // SalesReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSalesContainer);
            this.Name = "SalesReport";
            this.Size = new System.Drawing.Size(1325, 735);
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.panelButtonsContainer.ResumeLayout(false);
            this.panelButtonsContainer.PerformLayout();
            this.panelSalesMiddleButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSalesContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButtonsContainer;
        private Bunifu.Framework.UI.BunifuFlatButton btnDailySales;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalesWeekly;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker toDatepicker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker fromDatepicker;
        private System.Windows.Forms.Panel panelSalesMiddleButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid salesDataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSalesContainer;
        private Bunifu.Framework.UI.BunifuFlatButton btnMonthlySales;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserInputSales;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}
