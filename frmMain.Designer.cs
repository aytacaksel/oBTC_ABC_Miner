namespace oBTC_ABC_Miner
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPoolList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWallet = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lstDevice = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gInfo = new System.Windows.Forms.GroupBox();
            this.tabDevices = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkStats = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mining Pool:";
            // 
            // cbPoolList
            // 
            this.cbPoolList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoolList.FormattingEnabled = true;
            this.cbPoolList.Items.AddRange(new object[] {
            "pool.opticalbitcoin.com",
            "obtc.rxrat.com",
            "pool.obtc.me",
            "minersmine.com"});
            this.cbPoolList.Location = new System.Drawing.Point(127, 49);
            this.cbPoolList.Name = "cbPoolList";
            this.cbPoolList.Size = new System.Drawing.Size(315, 23);
            this.cbPoolList.TabIndex = 1;
            this.cbPoolList.SelectedIndexChanged += new System.EventHandler(this.cbPoolList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wallet Address:";
            // 
            // txtWallet
            // 
            this.txtWallet.Location = new System.Drawing.Point(127, 88);
            this.txtWallet.MaxLength = 42;
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.Size = new System.Drawing.Size(315, 23);
            this.txtWallet.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 31);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStartX_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(948, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 24);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(786, 22);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(156, 24);
            this.btnSelectAll.TabIndex = 11;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lstDevice
            // 
            this.lstDevice.FormattingEnabled = true;
            this.lstDevice.Location = new System.Drawing.Point(448, 49);
            this.lstDevice.Name = "lstDevice";
            this.lstDevice.Size = new System.Drawing.Size(656, 256);
            this.lstDevice.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "GPU List";
            // 
            // gInfo
            // 
            this.gInfo.Controls.Add(this.tabDevices);
            this.gInfo.Location = new System.Drawing.Point(12, 351);
            this.gInfo.Name = "gInfo";
            this.gInfo.Size = new System.Drawing.Size(1110, 298);
            this.gInfo.TabIndex = 7;
            this.gInfo.TabStop = false;
            this.gInfo.Text = "Info";
            // 
            // tabDevices
            // 
            this.tabDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDevices.Location = new System.Drawing.Point(3, 19);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.SelectedIndex = 0;
            this.tabDevices.Size = new System.Drawing.Size(1104, 276);
            this.tabDevices.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.linkStats);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lstDevice);
            this.groupBox1.Controls.Add(this.cbPoolList);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWallet);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 333);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // linkStats
            // 
            this.linkStats.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkStats.AutoSize = true;
            this.linkStats.Location = new System.Drawing.Point(126, 147);
            this.linkStats.Name = "linkStats";
            this.linkStats.Size = new System.Drawing.Size(133, 15);
            this.linkStats.TabIndex = 15;
            this.linkStats.TabStop = true;
            this.linkStats.Text = "View My Pool Stats";
            this.linkStats.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStats_LinkClicked);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(126, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "*Allow up to 30 minutes for your stats to appear in the pool link above.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(356, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 22);
            this.button1.TabIndex = 16;
            this.button1.Text = "Copy Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gInfo);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oBTC ABC Miner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPoolList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWallet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gInfo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckedListBox lstDevice;
        private System.Windows.Forms.TabControl tabDevices;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

