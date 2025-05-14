namespace Replens
{
    partial class MainForm
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vKDBZoneReplensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dataset = new Replens.Dataset();
            this.ClockDisplay = new System.Windows.Forms.TextBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.v_KDB_Zone_ReplensTableAdapter = new Replens.DatasetTableAdapters.v_KDB_Zone_ReplensTableAdapter();
            this.NetworkErrorMsg = new System.Windows.Forms.TextBox();
            this.NetworkRetrySecs = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.RefreshLabel = new System.Windows.Forms.Label();
            this.DataGridColumnMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnReplenish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vKDBZoneReplensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vKDBZoneReplensBindingSource
            // 
            this.vKDBZoneReplensBindingSource.DataMember = "v_KDB_Zone_Replens";
            this.vKDBZoneReplensBindingSource.DataSource = this.Dataset;
            // 
            // Dataset
            // 
            this.Dataset.DataSetName = "Dataset";
            this.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClockDisplay
            // 
            this.ClockDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClockDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.ClockDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClockDisplay.CausesValidation = false;
            this.ClockDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockDisplay.Location = new System.Drawing.Point(41, 978);
            this.ClockDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.ClockDisplay.Name = "ClockDisplay";
            this.ClockDisplay.ReadOnly = true;
            this.ClockDisplay.ShortcutsEnabled = false;
            this.ClockDisplay.Size = new System.Drawing.Size(280, 73);
            this.ClockDisplay.TabIndex = 1;
            this.ClockDisplay.TabStop = false;
            this.ClockDisplay.Text = ".";
            this.ClockDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClockDisplay.WordWrap = false;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // v_KDB_Zone_ReplensTableAdapter
            // 
            this.v_KDB_Zone_ReplensTableAdapter.ClearBeforeFill = true;
            // 
            // NetworkErrorMsg
            // 
            this.NetworkErrorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NetworkErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NetworkErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetworkErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkErrorMsg.Location = new System.Drawing.Point(342, 1338);
            this.NetworkErrorMsg.Multiline = true;
            this.NetworkErrorMsg.Name = "NetworkErrorMsg";
            this.NetworkErrorMsg.ReadOnly = true;
            this.NetworkErrorMsg.ShortcutsEnabled = false;
            this.NetworkErrorMsg.Size = new System.Drawing.Size(685, 150);
            this.NetworkErrorMsg.TabIndex = 2;
            this.NetworkErrorMsg.TabStop = false;
            this.NetworkErrorMsg.Text = "\r\n   The network connection was lost or interrupted.\r\n   A new connection attempt will occur in\r\n       seconds";
            this.NetworkErrorMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NetworkErrorMsg.Visible = false;
            this.NetworkErrorMsg.WordWrap = false;
            // 
            // NetworkRetrySecs
            // 
            this.NetworkRetrySecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NetworkRetrySecs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NetworkRetrySecs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetworkRetrySecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkRetrySecs.ForeColor = System.Drawing.Color.Green;
            this.NetworkRetrySecs.Location = new System.Drawing.Point(607, 1427);
            this.NetworkRetrySecs.Margin = new System.Windows.Forms.Padding(10);
            this.NetworkRetrySecs.Name = "NetworkRetrySecs";
            this.NetworkRetrySecs.Size = new System.Drawing.Size(43, 28);
            this.NetworkRetrySecs.TabIndex = 3;
            this.NetworkRetrySecs.TabStop = false;
            this.NetworkRetrySecs.Text = "00";
            this.NetworkRetrySecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NetworkRetrySecs.Visible = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonExit.Location = new System.Drawing.Point(1033, 936);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(32, 32);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Text = "X";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // RefreshLabel
            // 
            this.RefreshLabel.AutoSize = true;
            this.RefreshLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RefreshLabel.Location = new System.Drawing.Point(115, 1878);
            this.RefreshLabel.Name = "RefreshLabel";
            this.RefreshLabel.Size = new System.Drawing.Size(139, 20);
            this.RefreshLabel.TabIndex = 5;
            this.RefreshLabel.Text = "Last Refresh Time";
            this.RefreshLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridColumnMax
            // 
            this.DataGridColumnMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridColumnMax.DataPropertyName = "MaxDemand";
            this.DataGridColumnMax.HeaderText = "Max";
            this.DataGridColumnMax.Name = "DataGridColumnMax";
            this.DataGridColumnMax.ReadOnly = true;
            this.DataGridColumnMax.Width = 205;
            // 
            // DataGridColumnDemand
            // 
            this.DataGridColumnDemand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridColumnDemand.DataPropertyName = "Demand";
            this.DataGridColumnDemand.HeaderText = "Demand";
            this.DataGridColumnDemand.Name = "DataGridColumnDemand";
            this.DataGridColumnDemand.ReadOnly = true;
            this.DataGridColumnDemand.Width = 255;
            // 
            // DataGridColumnReplenish
            // 
            this.DataGridColumnReplenish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridColumnReplenish.DataPropertyName = "Replenishment";
            this.DataGridColumnReplenish.HeaderText = "Replenish";
            this.DataGridColumnReplenish.Name = "DataGridColumnReplenish";
            this.DataGridColumnReplenish.ReadOnly = true;
            this.DataGridColumnReplenish.Width = 255;
            // 
            // DataGridColumnZone
            // 
            this.DataGridColumnZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataGridColumnZone.DataPropertyName = "Zone";
            this.DataGridColumnZone.HeaderText = "Zone";
            this.DataGridColumnZone.Name = "DataGridColumnZone";
            this.DataGridColumnZone.Width = 379;
            // 
            // DataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeight = 64;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridColumnZone,
            this.DataGridColumnReplenish,
            this.DataGridColumnDemand,
            this.DataGridColumnMax});
            this.DataGrid.DataSource = this.vKDBZoneReplensBindingSource;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataGrid.Location = new System.Drawing.Point(1, 0);
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.RowTemplate.Height = 98;
            this.DataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGrid.Size = new System.Drawing.Size(1075, 1732);
            this.DataGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 1100);
            this.Controls.Add(this.RefreshLabel);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.NetworkRetrySecs);
            this.Controls.Add(this.NetworkErrorMsg);
            this.Controls.Add(this.ClockDisplay);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Zone Replenishment Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vKDBZoneReplensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ClockDisplay;
        private System.Windows.Forms.Timer RefreshTimer;
        private Dataset Dataset;
        private System.Windows.Forms.BindingSource vKDBZoneReplensBindingSource;
        private DatasetTableAdapters.v_KDB_Zone_ReplensTableAdapter v_KDB_Zone_ReplensTableAdapter;
        private System.Windows.Forms.TextBox NetworkErrorMsg;
        private System.Windows.Forms.TextBox NetworkRetrySecs;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label RefreshLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnReplenish;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnZone;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}

