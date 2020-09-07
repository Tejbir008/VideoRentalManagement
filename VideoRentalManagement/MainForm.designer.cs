namespace VideoRentalManagement
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.customerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueReturnVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDashBoard = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStripPOS = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerMasterToolStripMenuItem,
            this.addNewVideosToolStripMenuItem,
            this.issueReturnVideoToolStripMenuItem,
            this.regularCustomerToolStripMenuItem,
            this.popularVideosToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(902, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.Visible = false;
            // 
            // customerMasterToolStripMenuItem
            // 
            this.customerMasterToolStripMenuItem.Name = "customerMasterToolStripMenuItem";
            this.customerMasterToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.customerMasterToolStripMenuItem.Text = "Customer Master";
            this.customerMasterToolStripMenuItem.Click += new System.EventHandler(this.customerMasterToolStripMenuItem_Click);
            // 
            // addNewVideosToolStripMenuItem
            // 
            this.addNewVideosToolStripMenuItem.Name = "addNewVideosToolStripMenuItem";
            this.addNewVideosToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.addNewVideosToolStripMenuItem.Text = "Add New Video\'s";
            this.addNewVideosToolStripMenuItem.Click += new System.EventHandler(this.addNewVideosToolStripMenuItem_Click);
            // 
            // issueReturnVideoToolStripMenuItem
            // 
            this.issueReturnVideoToolStripMenuItem.Name = "issueReturnVideoToolStripMenuItem";
            this.issueReturnVideoToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.issueReturnVideoToolStripMenuItem.Text = "Issue/Return Video";
            this.issueReturnVideoToolStripMenuItem.Click += new System.EventHandler(this.issueReturnVideoToolStripMenuItem_Click);
            // 
            // regularCustomerToolStripMenuItem
            // 
            this.regularCustomerToolStripMenuItem.Name = "regularCustomerToolStripMenuItem";
            this.regularCustomerToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.regularCustomerToolStripMenuItem.Text = "Regular Customer";
            this.regularCustomerToolStripMenuItem.Click += new System.EventHandler(this.regularCustomerToolStripMenuItem_Click);
            // 
            // popularVideosToolStripMenuItem
            // 
            this.popularVideosToolStripMenuItem.Name = "popularVideosToolStripMenuItem";
            this.popularVideosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.popularVideosToolStripMenuItem.Text = "Popular Video\'s";
            this.popularVideosToolStripMenuItem.Click += new System.EventHandler(this.popularVideosToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images__3_;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripDashBoard,
            this.toolStripButton9,
            this.toolStripCustomers,
            this.toolStripPOS,
            this.toolStripButton6,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(200, 707);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(200, 40);
            this.toolStripLabel2.Text = "Video Rental System";
            // 
            // toolStripDashBoard
            // 
            this.toolStripDashBoard.AutoSize = false;
            this.toolStripDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDashBoard.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.toolStripDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripDashBoard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripDashBoard.ForeColor = System.Drawing.Color.White;
            this.toolStripDashBoard.Image = global::VideoRentalManagement.Properties.Resources.cus;
            this.toolStripDashBoard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripDashBoard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDashBoard.ImageTransparentColor = System.Drawing.Color.DarkRed;
            this.toolStripDashBoard.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripDashBoard.Name = "toolStripDashBoard";
            this.toolStripDashBoard.Size = new System.Drawing.Size(200, 45);
            this.toolStripDashBoard.Text = "Customer";
            this.toolStripDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDashBoard.Click += new System.EventHandler(this.toolStripDashBoard_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.AutoSize = false;
            this.toolStripButton9.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton9.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.toolStripButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripButton9.ForeColor = System.Drawing.Color.White;
            this.toolStripButton9.Image = global::VideoRentalManagement.Properties.Resources.cinema__1_;
            this.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(200, 45);
            this.toolStripButton9.Text = "Video\'s";
            this.toolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripCustomers
            // 
            this.toolStripCustomers.AutoSize = false;
            this.toolStripCustomers.BackColor = System.Drawing.Color.Transparent;
            this.toolStripCustomers.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.toolStripCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripCustomers.ForeColor = System.Drawing.Color.White;
            this.toolStripCustomers.Image = global::VideoRentalManagement.Properties.Resources.video;
            this.toolStripCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCustomers.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripCustomers.Name = "toolStripCustomers";
            this.toolStripCustomers.Size = new System.Drawing.Size(200, 45);
            this.toolStripCustomers.Text = "Rental/Return Video";
            this.toolStripCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCustomers.Click += new System.EventHandler(this.toolStripCustomers_Click);
            // 
            // toolStripPOS
            // 
            this.toolStripPOS.AutoSize = false;
            this.toolStripPOS.BackColor = System.Drawing.Color.Transparent;
            this.toolStripPOS.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.toolStripPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripPOS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripPOS.ForeColor = System.Drawing.Color.White;
            this.toolStripPOS.Image = global::VideoRentalManagement.Properties.Resources.service;
            this.toolStripPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPOS.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripPOS.Name = "toolStripPOS";
            this.toolStripPOS.Size = new System.Drawing.Size(200, 45);
            this.toolStripPOS.Text = "Most Rental Customer List";
            this.toolStripPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripPOS.Click += new System.EventHandler(this.toolStripPOS_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton6.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.toolStripButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton6.CheckOnClick = true;
            this.toolStripButton6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripButton6.ForeColor = System.Drawing.Color.White;
            this.toolStripButton6.Image = global::VideoRentalManagement.Properties.Resources.campaign;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(200, 45);
            this.toolStripButton6.Text = "Popular Video\'s";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton5.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images;
            this.toolStripButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripButton5.ForeColor = System.Drawing.Color.White;
            this.toolStripButton5.Image = global::VideoRentalManagement.Properties.Resources.exit1;
            this.toolStripButton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(200, 45);
            this.toolStripButton5.Text = "Exit";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::VideoRentalManagement.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoRentalSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VideoRentalManagement_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem customerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueReturnVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popularVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripDashBoard;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripCustomers;
        private System.Windows.Forms.ToolStripButton toolStripPOS;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}



