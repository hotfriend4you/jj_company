using System;
using SystemTimeSyncTool.CommonClass;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace SystemTimeSyncTool
{
    public partial class FrmTimeSyncTool : Form
    {
        string[] ntpHostList = { "ntp.aliyun.com", "time1.cloud.tencent.com", "time.windows.com", "time.nist.gov", "ntp.ntsc.ac.cn", "time.izatcloud.net", "time.apple.com", "time.asia.apple.com", "stdtime.gov.hk", "time.smg.gov.mo", "ntp.nict.jp", "s2csntp.miz.nao.ac.jp", "pool.ntp.org", "ntp.ix.ru" };


        public FrmTimeSyncTool()
        {
            InitializeComponent();
        }

        private void FrmTimeSyncTool_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.clock32;
            notifyIcon.Icon = Properties.Resources.clock16;
            txtComputerTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            cmbHostList.Items.AddRange(ntpHostList);
            dtpManualTime.Value = DateTime.Now;
        }

        private void btnSetByNtpTime_Click(object sender, EventArgs e)
        {
            try
            {
                timComputer.Stop();
                Ping ping = new Ping();
                PingReply reply = ping.Send("www.baidu.com");//百度IP
                Ping ping2 = new Ping();
                PingReply reply2 = ping2.Send("www.aliyun.com");
                if (reply.Status == IPStatus.Success || reply2.Status == IPStatus.Success)
                {
                    DateTime dateTimeOrigin = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    string errorMessage = "";
                    if (cmbHostList.Text != "")
                    {
                        DateTime ntpDateTime = NTPTimeHelper.GetNtpDateTime(cmbHostList.Text, out errorMessage);
                        if (errorMessage == "" && ntpDateTime.Date != dateTimeOrigin)
                        {
                            bool isSuccess = NTPTimeHelper.UseDllSetLocalDateTime(ntpDateTime);
                            if (isSuccess == false)
                            {
                                MessageBox.Show("程序出错，设置失败");
                                return;
                            }
                            txtNtpTime.Text = ntpDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                            return;
                        }
                    }
                    for (int i = 0; i < ntpHostList.Length; i++)
                    {
                        DateTime ntpDateTime = NTPTimeHelper.GetNtpDateTime(ntpHostList[i], out errorMessage);
                        if (errorMessage != "" || ntpDateTime.Date == dateTimeOrigin)
                        {
                            continue;
                        }
                        if (i == ntpHostList.Length)
                        {
                            MessageBox.Show("所有服务器均无法获取时间，请重试");
                            return;
                        }
                        bool isSuccess = NTPTimeHelper.UseDllSetLocalDateTime(ntpDateTime);
                        if (isSuccess == false)
                        {
                            MessageBox.Show("程序出错，设置失败");
                            return;
                        }
                        cmbHostList.Text = ntpHostList[i];
                        txtNtpTime.Text = ntpDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                        break;
                    }

                }
                else
                {
                    MessageBox.Show("网络连接失败！请检查电脑网络连接是否正常");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("网络连接失败！请检查电脑网络连接是否正常");
            }
            finally
            {
                timComputer.Start();
            }
            
        }

        private void timComputer_Tick(object sender, EventArgs e)
        {
            txtComputerTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (txtNtpTime.Text != "")
            {
                DateTime dt = Convert.ToDateTime(txtNtpTime.Text);
                txtNtpTime.Text = dt.AddSeconds(1).ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnSetByManulTime_Click(object sender, EventArgs e)
        {
            DateTime dtSet = dtSet = dtpManualTime.Value;
            bool isSuccess = NTPTimeHelper.UseDllSetLocalDateTime(dtSet);
            if(isSuccess == false)
            {
                MessageBox.Show("程序出错，设置失败");
            }
        }

        private void rbtNtpMode_CheckedChanged(object sender, EventArgs e)
        {
            txtNtpTime.Visible = rbtNtpMode.Checked;
            lblNtp.Visible = rbtNtpMode.Checked;
            lblNtpAdd.Visible = rbtNtpMode.Checked;
            cmbHostList.Visible = rbtNtpMode.Checked;
            btnSetByNtpTime.Enabled = rbtNtpMode.Checked;
            lblAutoInterval.Visible = rbtNtpMode.Checked;
            nudAutoInterval.Visible = rbtNtpMode.Checked;
            timAutoSet.Enabled = rbtNtpMode.Checked;

            dtpManualTime.Visible = !rbtNtpMode.Checked;
            lblManual.Visible = !rbtNtpMode.Checked;
            btnSetByManulTime.Enabled = !rbtNtpMode.Checked;

        }

        private void nudAutoInterval_ValueChanged(object sender, EventArgs e)
        {
            timAutoSet.Interval = Convert.ToInt32(nudAutoInterval.Value * 3600);
        }

        private void timAutoSet_Tick(object sender, EventArgs e)
        {
            btnSetByNtpTime_Click(sender, e);
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;//
            this.WindowState = FormWindowState.Normal;//窗口正常显示
            this.ShowInTaskbar = true;//在任务栏中显示该窗口
        }

        private void FrmTimeSyncTool_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//当窗体设置值为最小化时
            {
                notifyIcon.Visible = true;//该控件可见
                this.ShowInTaskbar = false;//在任务栏中显示该窗口
            }
            else
            {
                notifyIcon.Visible = false;//否则该控件不可见
            }
        }
    }
}
