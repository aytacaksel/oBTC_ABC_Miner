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
            this.tabSetup = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.pBasic = new System.Windows.Forms.Panel();
            this.tabAdv = new System.Windows.Forms.TabPage();
            this.pAdv = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearAdv = new System.Windows.Forms.Button();
            this.dataGridDevices = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectAllAdv = new System.Windows.Forms.Button();
            this.btnStartAdv = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParamsAMD = new System.Windows.Forms.TextBox();
            this.txtWalletAdv = new System.Windows.Forms.TextBox();
            this.txtParamsNvidia = new System.Windows.Forms.TextBox();
            this.txtPool = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gInfo.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.pBasic.SuspendLayout();
            this.tabAdv.SuspendLayout();
            this.pAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
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
            this.cbPoolList.Location = new System.Drawing.Point(119, 32);
            this.cbPoolList.Name = "cbPoolList";
            this.cbPoolList.Size = new System.Drawing.Size(315, 23);
            this.cbPoolList.TabIndex = 1;
            this.cbPoolList.SelectedIndexChanged += new System.EventHandler(this.cbPoolList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wallet Address:";
            // 
            // txtWallet
            // 
            this.txtWallet.Location = new System.Drawing.Point(119, 71);
            this.txtWallet.MaxLength = 42;
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.Size = new System.Drawing.Size(315, 23);
            this.txtWallet.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 265);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(197, 31);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(940, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 24);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(778, 5);
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
            this.lstDevice.Location = new System.Drawing.Point(440, 32);
            this.lstDevice.Name = "lstDevice";
            this.lstDevice.Size = new System.Drawing.Size(656, 256);
            this.lstDevice.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 14);
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
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.tabBasic);
            this.tabSetup.Controls.Add(this.tabAdv);
            this.tabSetup.Location = new System.Drawing.Point(12, 12);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.SelectedIndex = 0;
            this.tabSetup.Size = new System.Drawing.Size(1110, 333);
            this.tabSetup.TabIndex = 9;
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.pBasic);
            this.tabBasic.Location = new System.Drawing.Point(4, 24);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(1102, 305);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic Setup";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // pBasic
            // 
            this.pBasic.Controls.Add(this.label1);
            this.pBasic.Controls.Add(this.btnClear);
            this.pBasic.Controls.Add(this.cbPoolList);
            this.pBasic.Controls.Add(this.label2);
            this.pBasic.Controls.Add(this.btnSelectAll);
            this.pBasic.Controls.Add(this.label3);
            this.pBasic.Controls.Add(this.txtWallet);
            this.pBasic.Controls.Add(this.btnStart);
            this.pBasic.Controls.Add(this.lstDevice);
            this.pBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBasic.Location = new System.Drawing.Point(3, 3);
            this.pBasic.Name = "pBasic";
            this.pBasic.Size = new System.Drawing.Size(1096, 299);
            this.pBasic.TabIndex = 13;
            // 
            // tabAdv
            // 
            this.tabAdv.Controls.Add(this.pAdv);
            this.tabAdv.Location = new System.Drawing.Point(4, 24);
            this.tabAdv.Name = "tabAdv";
            this.tabAdv.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdv.Size = new System.Drawing.Size(1102, 305);
            this.tabAdv.TabIndex = 1;
            this.tabAdv.Text = "Advanced Setup";
            this.tabAdv.UseVisualStyleBackColor = true;
            // 
            // pAdv
            // 
            this.pAdv.Controls.Add(this.label4);
            this.pAdv.Controls.Add(this.btnClearAdv);
            this.pAdv.Controls.Add(this.dataGridDevices);
            this.pAdv.Controls.Add(this.btnSelectAllAdv);
            this.pAdv.Controls.Add(this.btnStartAdv);
            this.pAdv.Controls.Add(this.label9);
            this.pAdv.Controls.Add(this.label5);
            this.pAdv.Controls.Add(this.txtParamsAMD);
            this.pAdv.Controls.Add(this.txtWalletAdv);
            this.pAdv.Controls.Add(this.txtParamsNvidia);
            this.pAdv.Controls.Add(this.txtPool);
            this.pAdv.Controls.Add(this.label8);
            this.pAdv.Controls.Add(this.nPort);
            this.pAdv.Controls.Add(this.label7);
            this.pAdv.Controls.Add(this.label6);
            this.pAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAdv.Location = new System.Drawing.Point(3, 3);
            this.pAdv.Name = "pAdv";
            this.pAdv.Size = new System.Drawing.Size(1096, 299);
            this.pAdv.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mining Pool:";
            // 
            // btnClearAdv
            // 
            this.btnClearAdv.Location = new System.Drawing.Point(940, 5);
            this.btnClearAdv.Name = "btnClearAdv";
            this.btnClearAdv.Size = new System.Drawing.Size(156, 24);
            this.btnClearAdv.TabIndex = 19;
            this.btnClearAdv.Text = "Clear Selection";
            this.btnClearAdv.UseVisualStyleBackColor = true;
            // 
            // dataGridDevices
            // 
            this.dataGridDevices.AllowUserToAddRows = false;
            this.dataGridDevices.AllowUserToDeleteRows = false;
            this.dataGridDevices.AllowUserToResizeColumns = false;
            this.dataGridDevices.AllowUserToResizeRows = false;
            this.dataGridDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8});
            this.dataGridDevices.Location = new System.Drawing.Point(440, 32);
            this.dataGridDevices.Name = "dataGridDevices";
            this.dataGridDevices.RowHeadersVisible = false;
            this.dataGridDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDevices.Size = new System.Drawing.Size(656, 196);
            this.dataGridDevices.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Use";
            this.Column1.Name = "Column1";
            this.Column1.Width = 34;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "GPU Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 88;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "GPU Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 88;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "GPU ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 74;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Worker";
            this.Column7.Name = "Column7";
            this.Column7.Width = 74;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Password";
            this.Column8.Name = "Column8";
            this.Column8.Width = 88;
            // 
            // btnSelectAllAdv
            // 
            this.btnSelectAllAdv.Location = new System.Drawing.Point(778, 5);
            this.btnSelectAllAdv.Name = "btnSelectAllAdv";
            this.btnSelectAllAdv.Size = new System.Drawing.Size(156, 24);
            this.btnSelectAllAdv.TabIndex = 18;
            this.btnSelectAllAdv.Text = "Select all";
            this.btnSelectAllAdv.UseVisualStyleBackColor = true;
            // 
            // btnStartAdv
            // 
            this.btnStartAdv.Location = new System.Drawing.Point(3, 265);
            this.btnStartAdv.Name = "btnStartAdv";
            this.btnStartAdv.Size = new System.Drawing.Size(197, 31);
            this.btnStartAdv.TabIndex = 5;
            this.btnStartAdv.Text = "Start";
            this.btnStartAdv.UseVisualStyleBackColor = true;
            this.btnStartAdv.Click += new System.EventHandler(this.btnStartAdv_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "GPU List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wallet Address:";
            // 
            // txtParamsAMD
            // 
            this.txtParamsAMD.Location = new System.Drawing.Point(705, 273);
            this.txtParamsAMD.MaxLength = 42;
            this.txtParamsAMD.Name = "txtParamsAMD";
            this.txtParamsAMD.Size = new System.Drawing.Size(388, 23);
            this.txtParamsAMD.TabIndex = 16;
            // 
            // txtWalletAdv
            // 
            this.txtWalletAdv.Location = new System.Drawing.Point(119, 110);
            this.txtWalletAdv.MaxLength = 42;
            this.txtWalletAdv.Name = "txtWalletAdv";
            this.txtWalletAdv.Size = new System.Drawing.Size(315, 23);
            this.txtWalletAdv.TabIndex = 9;
            // 
            // txtParamsNvidia
            // 
            this.txtParamsNvidia.Location = new System.Drawing.Point(705, 234);
            this.txtParamsNvidia.MaxLength = 42;
            this.txtParamsNvidia.Name = "txtParamsNvidia";
            this.txtParamsNvidia.Size = new System.Drawing.Size(388, 23);
            this.txtParamsNvidia.TabIndex = 15;
            // 
            // txtPool
            // 
            this.txtPool.Location = new System.Drawing.Point(119, 32);
            this.txtPool.Name = "txtPool";
            this.txtPool.Size = new System.Drawing.Size(315, 23);
            this.txtPool.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "AMD Extra Params (SRBMiner) :";
            // 
            // nPort
            // 
            this.nPort.Location = new System.Drawing.Point(119, 71);
            this.nPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPort.Name = "nPort";
            this.nPort.Size = new System.Drawing.Size(120, 23);
            this.nPort.TabIndex = 11;
            this.nPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nvidia Extra Params (Suprminer) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pool Port:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.tabSetup);
            this.Controls.Add(this.gInfo);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "oBTC ABC+ Miner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gInfo.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.pBasic.ResumeLayout(false);
            this.pBasic.PerformLayout();
            this.tabAdv.ResumeLayout(false);
            this.pAdv.ResumeLayout(false);
            this.pAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
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
        private System.Windows.Forms.TabControl tabSetup;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TabPage tabAdv;
        private System.Windows.Forms.DataGridView dataGridDevices;
        private System.Windows.Forms.Button btnStartAdv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtParamsAMD;
        private System.Windows.Forms.TextBox txtParamsNvidia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nPort;
        private System.Windows.Forms.TextBox txtPool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWalletAdv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearAdv;
        private System.Windows.Forms.Button btnSelectAllAdv;
        private System.Windows.Forms.Panel pBasic;
        private System.Windows.Forms.Panel pAdv;
    }
}

