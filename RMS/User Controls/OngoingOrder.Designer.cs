namespace RMS.User_Controls
{
    partial class OngoingOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ongoingOrderGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWaiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComplete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ongoingOrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ongoingOrderGridView
            // 
            this.ongoingOrderGridView.AllowUserToAddRows = false;
            this.ongoingOrderGridView.AllowUserToDeleteRows = false;
            this.ongoingOrderGridView.AllowUserToResizeColumns = false;
            this.ongoingOrderGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ongoingOrderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ongoingOrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ongoingOrderGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ongoingOrderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ongoingOrderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ongoingOrderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ongoingOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ongoingOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ongoingOrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOrderNo,
            this.ColCustomerName,
            this.ColTableNo,
            this.ColWaiterName,
            this.ColTotal,
            this.ColComplete,
            this.ColEdit,
            this.ColCancel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ongoingOrderGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ongoingOrderGridView.DoubleBuffered = true;
            this.ongoingOrderGridView.EnableHeadersVisualStyles = false;
            this.ongoingOrderGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ongoingOrderGridView.HeaderForeColor = System.Drawing.Color.White;
            this.ongoingOrderGridView.Location = new System.Drawing.Point(3, 3);
            this.ongoingOrderGridView.Name = "ongoingOrderGridView";
            this.ongoingOrderGridView.ReadOnly = true;
            this.ongoingOrderGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ongoingOrderGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ongoingOrderGridView.RowHeadersVisible = false;
            this.ongoingOrderGridView.RowHeadersWidth = 51;
            this.ongoingOrderGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.ongoingOrderGridView.RowTemplate.Height = 85;
            this.ongoingOrderGridView.RowTemplate.ReadOnly = true;
            this.ongoingOrderGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ongoingOrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ongoingOrderGridView.Size = new System.Drawing.Size(828, 113);
            this.ongoingOrderGridView.TabIndex = 10;
            this.ongoingOrderGridView.Visible = false;
            // 
            // ColOrderNo
            // 
            this.ColOrderNo.DataPropertyName = "OrderNo";
            this.ColOrderNo.HeaderText = "OrderNo";
            this.ColOrderNo.Name = "ColOrderNo";
            this.ColOrderNo.ReadOnly = true;
            // 
            // ColCustomerName
            // 
            this.ColCustomerName.DataPropertyName = "CustomerName";
            this.ColCustomerName.HeaderText = "CustomerName";
            this.ColCustomerName.Name = "ColCustomerName";
            this.ColCustomerName.ReadOnly = true;
            // 
            // ColTableNo
            // 
            this.ColTableNo.DataPropertyName = "TableName";
            this.ColTableNo.HeaderText = "TableNo";
            this.ColTableNo.Name = "ColTableNo";
            this.ColTableNo.ReadOnly = true;
            // 
            // ColWaiterName
            // 
            this.ColWaiterName.DataPropertyName = "WaiterName";
            this.ColWaiterName.HeaderText = "WaiterName";
            this.ColWaiterName.Name = "ColWaiterName";
            this.ColWaiterName.ReadOnly = true;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "Total";
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            // 
            // ColComplete
            // 
            this.ColComplete.HeaderText = "Complete";
            this.ColComplete.Name = "ColComplete";
            this.ColComplete.ReadOnly = true;
            this.ColComplete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColComplete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColComplete.Text = "Complete";
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "Edit";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            // 
            // ColCancel
            // 
            this.ColCancel.HeaderText = "Cancel";
            this.ColCancel.Name = "ColCancel";
            this.ColCancel.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(944, 565);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // OngoingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ongoingOrderGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OngoingOrder";
            this.Size = new System.Drawing.Size(944, 565);
            this.Load += new System.EventHandler(this.OngoingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ongoingOrderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid ongoingOrderGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWaiterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
