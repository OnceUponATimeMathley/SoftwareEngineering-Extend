namespace Visualization
{
    partial class TableResult
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
            this.ItemSetLabel = new System.Windows.Forms.Label();
            this.ItemSetsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RulesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Support = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemSetLabel
            // 
            this.ItemSetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSetLabel.AutoSize = true;
            this.ItemSetLabel.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.ItemSetLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemSetLabel.Name = "ItemSetLabel";
            this.ItemSetLabel.Size = new System.Drawing.Size(85, 25);
            this.ItemSetLabel.TabIndex = 2;
            this.ItemSetLabel.Text = "{{Label}}";
            // 
            // ItemSetsDataGridView
            // 
            this.ItemSetsDataGridView.AllowUserToAddRows = false;
            this.ItemSetsDataGridView.AllowUserToDeleteRows = false;
            this.ItemSetsDataGridView.AllowUserToResizeColumns = false;
            this.ItemSetsDataGridView.AllowUserToResizeRows = false;
            this.ItemSetsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemSetsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemSetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemSetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemSet,
            this.Count});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemSetsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemSetsDataGridView.Location = new System.Drawing.Point(8, 39);
            this.ItemSetsDataGridView.Name = "ItemSetsDataGridView";
            this.ItemSetsDataGridView.ReadOnly = true;
            this.ItemSetsDataGridView.RowHeadersVisible = false;
            this.ItemSetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemSetsDataGridView.Size = new System.Drawing.Size(273, 161);
            this.ItemSetsDataGridView.TabIndex = 3;
            // 
            // ItemSet
            // 
            this.ItemSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemSet.HeaderText = "Item Set";
            this.ItemSet.Name = "ItemSet";
            this.ItemSet.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // RulesDataGridView
            // 
            this.RulesDataGridView.AllowUserToAddRows = false;
            this.RulesDataGridView.AllowUserToDeleteRows = false;
            this.RulesDataGridView.AllowUserToResizeColumns = false;
            this.RulesDataGridView.AllowUserToResizeRows = false;
            this.RulesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Support});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RulesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.RulesDataGridView.Location = new System.Drawing.Point(8, 215);
            this.RulesDataGridView.Name = "RulesDataGridView";
            this.RulesDataGridView.ReadOnly = true;
            this.RulesDataGridView.RowHeadersVisible = false;
            this.RulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RulesDataGridView.Size = new System.Drawing.Size(273, 161);
            this.RulesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rule";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Confidence";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Support
            // 
            this.Support.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Support.HeaderText = "Support";
            this.Support.Name = "Support";
            this.Support.ReadOnly = true;
            // 
            // TableResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.RulesDataGridView);
            this.Controls.Add(this.ItemSetsDataGridView);
            this.Controls.Add(this.ItemSetLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "TableResult";
            this.Size = new System.Drawing.Size(301, 390);
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemSetLabel;
        private System.Windows.Forms.DataGridView ItemSetsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridView RulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Support;
    }
}
