
namespace SystemTimeSyncTool
{
    partial class FrmTimeSyncTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComputerTime = new System.Windows.Forms.TextBox();
            this.txtNtpTime = new System.Windows.Forms.TextBox();
            this.lblNtpAdd = new System.Windows.Forms.Label();
            this.dtpManualTime = new System.Windows.Forms.DateTimePicker();
            this.timComputer = new System.Windows.Forms.Timer(this.components);
            this.btnSetByManulTime = new System.Windows.Forms.Button();
            this.timAutoSet = new System.Windows.Forms.Timer(this.components);
            this.cmbHostList = new System.Windows.Forms.ComboBox();
            this.rbtNtpMode = new System.Windows.Forms.RadioButton();
            this.rbtManualMode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNtp = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.btnSetByNtpTime = new System.Windows.Forms.Button();
            this.lblAutoInterval = new System.Windows.Forms.Label();
            this.nudAutoInterval = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前电脑时间：";
            // 
            // txtComputerTime
            // 
            this.txtComputerTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtComputerTime.Font = new System.Drawing.Font("宋体", 16F);
            this.txtComputerTime.Location = new System.Drawing.Point(203, 39);
            this.txtComputerTime.Name = "txtComputerTime";
            this.txtComputerTime.ReadOnly = true;
            this.txtComputerTime.Size = new System.Drawing.Size(442, 32);
            this.txtComputerTime.TabIndex = 1;
            this.txtComputerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNtpTime
            // 
            this.txtNtpTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtNtpTime.Font = new System.Drawing.Font("宋体", 16F);
            this.txtNtpTime.Location = new System.Drawing.Point(325, 142);
            this.txtNtpTime.Name = "txtNtpTime";
            this.txtNtpTime.ReadOnly = true;
            this.txtNtpTime.Size = new System.Drawing.Size(320, 32);
            this.txtNtpTime.TabIndex = 3;
            // 
            // lblNtpAdd
            // 
            this.lblNtpAdd.AutoSize = true;
            this.lblNtpAdd.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNtpAdd.Location = new System.Drawing.Point(210, 110);
            this.lblNtpAdd.Name = "lblNtpAdd";
            this.lblNtpAdd.Size = new System.Drawing.Size(109, 22);
            this.lblNtpAdd.TabIndex = 2;
            this.lblNtpAdd.Text = "Ntp地址：";
            // 
            // dtpManualTime
            // 
            this.dtpManualTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpManualTime.Font = new System.Drawing.Font("宋体", 16F);
            this.dtpManualTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpManualTime.Location = new System.Drawing.Point(325, 250);
            this.dtpManualTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpManualTime.Name = "dtpManualTime";
            this.dtpManualTime.Size = new System.Drawing.Size(320, 32);
            this.dtpManualTime.TabIndex = 5;
            this.dtpManualTime.Visible = false;
            // 
            // timComputer
            // 
            this.timComputer.Enabled = true;
            this.timComputer.Interval = 1000;
            this.timComputer.Tick += new System.EventHandler(this.timComputer_Tick);
            // 
            // btnSetByManulTime
            // 
            this.btnSetByManulTime.Enabled = false;
            this.btnSetByManulTime.Font = new System.Drawing.Font("宋体", 16F);
            this.btnSetByManulTime.Location = new System.Drawing.Point(372, 315);
            this.btnSetByManulTime.Name = "btnSetByManulTime";
            this.btnSetByManulTime.Size = new System.Drawing.Size(176, 55);
            this.btnSetByManulTime.TabIndex = 7;
            this.btnSetByManulTime.Text = "手动模式校准";
            this.btnSetByManulTime.UseVisualStyleBackColor = true;
            this.btnSetByManulTime.Click += new System.EventHandler(this.btnSetByManulTime_Click);
            // 
            // timAutoSet
            // 
            this.timAutoSet.Enabled = true;
            this.timAutoSet.Interval = 216000;
            this.timAutoSet.Tick += new System.EventHandler(this.timAutoSet_Tick);
            // 
            // cmbHostList
            // 
            this.cmbHostList.BackColor = System.Drawing.SystemColors.Window;
            this.cmbHostList.Font = new System.Drawing.Font("宋体", 16F);
            this.cmbHostList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbHostList.FormattingEnabled = true;
            this.cmbHostList.Location = new System.Drawing.Point(325, 107);
            this.cmbHostList.Name = "cmbHostList";
            this.cmbHostList.Size = new System.Drawing.Size(320, 29);
            this.cmbHostList.TabIndex = 8;
            // 
            // rbtNtpMode
            // 
            this.rbtNtpMode.AutoSize = true;
            this.rbtNtpMode.Checked = true;
            this.rbtNtpMode.Font = new System.Drawing.Font("宋体", 16F);
            this.rbtNtpMode.Location = new System.Drawing.Point(14, 41);
            this.rbtNtpMode.Name = "rbtNtpMode";
            this.rbtNtpMode.Size = new System.Drawing.Size(116, 26);
            this.rbtNtpMode.TabIndex = 9;
            this.rbtNtpMode.TabStop = true;
            this.rbtNtpMode.Text = "自动获取";
            this.rbtNtpMode.UseVisualStyleBackColor = true;
            this.rbtNtpMode.CheckedChanged += new System.EventHandler(this.rbtNtpMode_CheckedChanged);
            // 
            // rbtManualMode
            // 
            this.rbtManualMode.AutoSize = true;
            this.rbtManualMode.Font = new System.Drawing.Font("宋体", 16F);
            this.rbtManualMode.Location = new System.Drawing.Point(14, 148);
            this.rbtManualMode.Name = "rbtManualMode";
            this.rbtManualMode.Size = new System.Drawing.Size(116, 26);
            this.rbtManualMode.TabIndex = 10;
            this.rbtManualMode.Text = "手动设置";
            this.rbtManualMode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtNtpMode);
            this.groupBox1.Controls.Add(this.rbtManualMode);
            this.groupBox1.Location = new System.Drawing.Point(37, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模式";
            // 
            // lblNtp
            // 
            this.lblNtp.AutoSize = true;
            this.lblNtp.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNtp.Location = new System.Drawing.Point(199, 151);
            this.lblNtp.Name = "lblNtp";
            this.lblNtp.Size = new System.Drawing.Size(120, 22);
            this.lblNtp.TabIndex = 12;
            this.lblNtp.Text = "网络时间：";
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("宋体", 16F);
            this.lblManual.Location = new System.Drawing.Point(199, 258);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(120, 22);
            this.lblManual.TabIndex = 13;
            this.lblManual.Text = "手动时间：";
            this.lblManual.Visible = false;
            // 
            // btnSetByNtpTime
            // 
            this.btnSetByNtpTime.Font = new System.Drawing.Font("宋体", 16F);
            this.btnSetByNtpTime.Location = new System.Drawing.Point(129, 315);
            this.btnSetByNtpTime.Name = "btnSetByNtpTime";
            this.btnSetByNtpTime.Size = new System.Drawing.Size(176, 55);
            this.btnSetByNtpTime.TabIndex = 14;
            this.btnSetByNtpTime.Text = "自动模式校准";
            this.btnSetByNtpTime.UseVisualStyleBackColor = true;
            this.btnSetByNtpTime.Click += new System.EventHandler(this.btnSetByNtpTime_Click);
            // 
            // lblAutoInterval
            // 
            this.lblAutoInterval.AutoSize = true;
            this.lblAutoInterval.Font = new System.Drawing.Font("宋体", 16F);
            this.lblAutoInterval.Location = new System.Drawing.Point(199, 189);
            this.lblAutoInterval.Name = "lblAutoInterval";
            this.lblAutoInterval.Size = new System.Drawing.Size(296, 22);
            this.lblAutoInterval.TabIndex = 16;
            this.lblAutoInterval.Text = "自动校准间隔时间（小时）：";
            // 
            // nudAutoInterval
            // 
            this.nudAutoInterval.Font = new System.Drawing.Font("宋体", 16F);
            this.nudAutoInterval.Location = new System.Drawing.Point(501, 180);
            this.nudAutoInterval.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudAutoInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoInterval.Name = "nudAutoInterval";
            this.nudAutoInterval.Size = new System.Drawing.Size(144, 32);
            this.nudAutoInterval.TabIndex = 17;
            this.nudAutoInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAutoInterval.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudAutoInterval.ValueChanged += new System.EventHandler(this.nudAutoInterval_ValueChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "电脑时间校准工具";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // FrmTimeSyncTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.nudAutoInterval);
            this.Controls.Add(this.lblAutoInterval);
            this.Controls.Add(this.btnSetByNtpTime);
            this.Controls.Add(this.lblManual);
            this.Controls.Add(this.lblNtp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbHostList);
            this.Controls.Add(this.btnSetByManulTime);
            this.Controls.Add(this.dtpManualTime);
            this.Controls.Add(this.txtNtpTime);
            this.Controls.Add(this.lblNtpAdd);
            this.Controls.Add(this.txtComputerTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTimeSyncTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "江机实业——电脑时间校准工具 V1.0.0";
            this.Load += new System.EventHandler(this.FrmTimeSyncTool_Load);
            this.Resize += new System.EventHandler(this.FrmTimeSyncTool_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComputerTime;
        private System.Windows.Forms.TextBox txtNtpTime;
        private System.Windows.Forms.Label lblNtpAdd;
        private System.Windows.Forms.DateTimePicker dtpManualTime;
        private System.Windows.Forms.Timer timComputer;
        private System.Windows.Forms.Button btnSetByManulTime;
        private System.Windows.Forms.Timer timAutoSet;
        private System.Windows.Forms.ComboBox cmbHostList;
        private System.Windows.Forms.RadioButton rbtNtpMode;
        private System.Windows.Forms.RadioButton rbtManualMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNtp;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Button btnSetByNtpTime;
        private System.Windows.Forms.Label lblAutoInterval;
        private System.Windows.Forms.NumericUpDown nudAutoInterval;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

