using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Management;

namespace oBTC_ABC_Miner
{
    public partial class frmMain : Form
    {
        string appVersion = "1.3";

        bool logWork = false;

        string logFileName = "";

        string url = "";
        string walletAddr = "";
        string password = "";

        public frmMain()
        {
            InitializeComponent();

            gInfo.Enabled = false;

            Text += " V" + appVersion;

            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.ToLower().Contains("srbminer"))
                {
                    if (process.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                    {
                        process.Kill();
                    }
                }

                if (process.ProcessName.ToLower().Contains("suprminer"))
                {
                    if (process.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                    {
                        process.Kill();
                    }
                }
            }



        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmLoad frml = new frmLoad();
            frml.ShowDialog(this);

            if (frml.deviceList.Count > 0)
            {
                for (int i = 0; i < frml.deviceList.Count; i++)
                {
                    lstDevice.Items.Add(frml.deviceList[i]);
                }

                cbPoolList.SelectedIndex = 0;

                gInfo.Enabled = true;

            }
            else
            {
                MessageBox.Show("Device not found");
                Application.Exit();
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                if (txtWallet.Text.Trim().Length != txtWallet.MaxLength)
                {
                    MessageBox.Show("Enter wallet address");
                    return;
                }

                if (lstDevice.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No device selected");
                    return;
                }

                btnStart.Enabled = false;
                cbPoolList.Enabled = false;
                txtWallet.Enabled = false;
                lstDevice.Enabled = false;
                btnSelectAll.Enabled = false;
                btnClear.Enabled = false;

                walletAddr = txtWallet.Text.Trim();

                switch (cbPoolList.Text)
                {
                    case "pool.opticalbitcoin.com":
                        url = "stratum+tcp://pool.opticalbitcoin.com:5136";
                        password = "c=OBTC";
                        break;

                    case "pool.obtc.me":
                        url = "stratum+tcp://pool.obtc.me:3390";
                        password = ".";
                        break;

                    case "obtc.rxrat.com":
                        url = "stratum+tcp://obtc.rxrat.com:8001";
                        password = "c=OBTC";
                        break;

                    case "obtc.suprnova.cc":
                        url = "stratum+tcp://obtc.suprnova.cc:4075";
                        password = "x";
                        break;

                    case "minersmine.com":
                        url = "stratum+tcp://minersmine.com:5136";
                        password = "c=OBTC";
                        break;
                }

                List<string> amdDevices = new List<string>();
                List<string> nvidiaDevices = new List<string>();

                for (int i = 0; i < lstDevice.CheckedItems.Count; i++)
                {
                    if (lstDevice.CheckedItems[i].ToString().Contains("AMD"))
                    {
                        amdDevices.Add(lstDevice.CheckedItems[i].ToString());
                    }

                    if (lstDevice.CheckedItems[i].ToString().Contains("NVIDIA"))
                    {
                        nvidiaDevices.Add(lstDevice.CheckedItems[i].ToString());
                    }
                }

                List<BackgroundWorker> bwPool = new List<BackgroundWorker>();


                tabDevices.TabPages.Clear();

                if (amdDevices.Count > 0)
                {
                    TabPage tb = new TabPage("AMD");
                    tb.BackColor = Color.White;

                    TextBox info = new TextBox();
                    info.BackColor = Color.White;
                    info.BorderStyle = BorderStyle.None;
                    info.Multiline = true;
                    info.Dock = DockStyle.Fill;
                    info.ReadOnly = true;
                    info.ScrollBars = ScrollBars.Vertical;
                    tb.Controls.Add(info);

                    tabDevices.TabPages.Add(tb);
                }

                if (nvidiaDevices.Count > 0)
                {
                    for (int i = 0; i < nvidiaDevices.Count; i++)
                    {
                        List<string> adevice = nvidiaDevices[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                        TabPage tb = new TabPage(adevice[1]);
                        tb.BackColor = Color.White;

                        TextBox info = new TextBox();
                        info.BackColor = Color.White;
                        info.BorderStyle = BorderStyle.None;
                        info.Multiline = true;
                        info.Dock = DockStyle.Fill;
                        info.ReadOnly = true;
                        info.ScrollBars = ScrollBars.Vertical;
                        tb.Controls.Add(info);

                        tabDevices.TabPages.Add(tb);
                    }
                }


                string saveFile = Application.StartupPath + "\\" + cbPoolList.Text + ".dat";

                if (File.Exists(saveFile))
                {
                    File.Delete(saveFile);
                }

                StreamWriter sw = new StreamWriter(saveFile, false, Encoding.Default);
                sw.WriteLine(txtWallet.Text.Trim());
                for (int i = 0; i < lstDevice.Items.Count; i++)
                {
                    sw.WriteLine(lstDevice.Items[i].ToString() + ";" + lstDevice.GetItemCheckState(i));
                }
                sw.Close();

                int tabId = 0;

                if (amdDevices.Count > 0)
                {
                    BackgroundWorker bwStartAMD = new BackgroundWorker();
                    bwStartAMD.DoWork += BwStartAMD_DoWork;
                    bwStartAMD.RunWorkerAsync(new object[] { amdDevices, tabId++ });

                    bwPool.Add(bwStartAMD);
                }

                if (nvidiaDevices.Count > 0)
                {
                    for (int i = 0; i < nvidiaDevices.Count; i++)
                    {
                        BackgroundWorker bwStartNVIDIA = new BackgroundWorker();
                        bwStartNVIDIA.DoWork += BwStartNVIDIA_DoWork;
                        bwStartNVIDIA.RunWorkerAsync(new object[] { nvidiaDevices[i], tabId++ });

                        bwPool.Add(bwStartNVIDIA);
                    }
                }

                for (int i = 0; i < bwPool.Count; i++)
                {
                    while (bwPool[i].IsBusy)
                    {
                        Application.DoEvents();
                        Thread.Sleep(50);
                    }
                }


                btnStart.Text = "Start";
                cbPoolList.Enabled = true;
                txtWallet.Enabled = true;
                btnStart.Enabled = true;
                lstDevice.Enabled = true;
                btnSelectAll.Enabled = true;
                btnClear.Enabled = true;
            }

            if (btnStart.Text == "Stop")
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName.ToLower().Contains("srbminer"))
                    {
                        if (process.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                        {
                            process.Kill();
                        }
                    }

                    if (process.ProcessName.ToLower().Contains("suprminer"))
                    {
                        if (process.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                        {
                            process.Kill();
                        }
                    }
                }
            }
        }

        private void BwStartAMD_DoWork(object sender, DoWorkEventArgs e)
        {
            TextBox info = (TextBox)tabDevices.TabPages[0].Controls[0];

            Action a;

            bool isFound = false;

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.ToLower().Contains("srbminer"))
                {
                    if (p.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                    {
                        p.Kill();
                        isFound = true;
                    }
                }
            }

            if (isFound)
            {
                Thread.Sleep(1000);
            }

            logFileName = Application.StartupPath + "\\SRBMiner\\_out.txt";

            try
            {
                if (File.Exists(logFileName))
                {
                    File.Delete(logFileName);
                }
            }
            catch (Exception ex)
            {
                a = () => info.AppendText(ex.Message); info.Invoke(a);
                return;
            }

            string worker = "";
            string deviceIdList = "";



            List<string> amdDevices = (List<string>)((object[])e.Argument)[0];

            for (int i = 0; i < amdDevices.Count; i++)
            {
                List<string> adevice = amdDevices[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                worker = "." + adevice[5];

                deviceIdList += adevice[3] + "!";
            }

            deviceIdList = deviceIdList.Substring(0, deviceIdList.Length - 1);


            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = true;
                startInfo.FileName = Application.StartupPath + "\\SRBMiner\\SRBMiner-MULTI.exe";
                startInfo.WorkingDirectory = Application.StartupPath + "\\SRBMiner\\";
                startInfo.Arguments = @"--disable-cpu --algorithm heavyhash --pool " + url + " --wallet " + walletAddr + worker + " --password " + password + " --gpu-id " + deviceIdList + " --log-file _out.txt";
                process.StartInfo = startInfo;
                process.Start();


                a = () => btnStart.Text = "Stop"; btnStart.Invoke(a);
                a = () => btnStart.Enabled = true; btnStart.Invoke(a);


                while (true)
                {
                    if (File.Exists(logFileName))
                    {
                        break;
                    }

                    Thread.Sleep(500);
                }

                logWork = true;

                BackgroundWorker bwLogAMD = new BackgroundWorker();
                bwLogAMD.DoWork += BwLogAMD_DoWork;
                bwLogAMD.RunWorkerAsync();

                process.WaitForExit();

                logWork = false;
            }
            catch (Exception ex)
            {
                logWork = false;
                a = () => info.AppendText(ex.Message); info.Invoke(a);
                return;
            }
        }

        private void BwStartNVIDIA_DoWork(object sender, DoWorkEventArgs e)
        {
            string nvidiaDevice = (string)((object[])e.Argument)[0];
            int tabId = (int)((object[])e.Argument)[1];

            TextBox info = (TextBox)tabDevices.TabPages[tabId].Controls[0];

            Action a;

            bool isFound = false;

            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.ToLower().Contains("suprminer"))
                {
                    if (p.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                    {
                        p.Kill();
                        isFound = true;
                    }
                }
            }

            if (isFound)
            {
                Thread.Sleep(1000);
            }

            string worker = "";
            string deviceIdList = "";

            string advworker = "";
            string advpassword = "";

            List<string> devinfo = nvidiaDevice.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            worker = "." + devinfo[5];
            deviceIdList = devinfo[3];


            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + "\\Suprminer\\suprminer.exe";
                startInfo.WorkingDirectory = Application.StartupPath + "\\Suprminer\\";
                startInfo.Arguments = @"-a obtc -o " + url + " -u " + walletAddr + worker + " -p " + password + " -d " + deviceIdList;
                process.StartInfo = startInfo;
                process.Start();


                a = () => btnStart.Text = "Stop"; btnStart.Invoke(a);
                a = () => btnStart.Enabled = true; btnStart.Invoke(a);


                while (!process.HasExited)
                {
                    while (!process.StandardOutput.EndOfStream)
                    {
                        a = () => info.AppendText(process.StandardOutput.ReadLine() + "\r\n"); info.Invoke(a);
                    }
                }

                process.WaitForExit();
            }
            catch (Exception ex)
            {
                a = () => info.AppendText(ex.Message); info.Invoke(a);
                return;
            }
        }

        private void BwLogAMD_DoWork(object sender, DoWorkEventArgs e)
        {
            TextBox info = (TextBox)tabDevices.TabPages[0].Controls[0];

            Action a;

            FileStream fs = new FileStream(logFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using (StreamReader sr = new StreamReader(fs))
            {
                while (true)
                {
                    if (!logWork)
                    {
                        break;
                    }

                    try
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            a = () => info.AppendText(line + "\r\n"); info.Invoke(a);
                        }

                    }
                    catch { }

                    Thread.Sleep(500);
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.ToLower().Contains("srbminer"))
                {
                    if (process.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                    {
                        process.Kill();
                    }
                }

                if (process.ProcessName.ToLower().Contains("suprminer"))
                {
                    if (process.MainModule.FileName.ToLower().Contains(Application.StartupPath.ToLower()))
                    {
                        process.Kill();
                    }
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDevice.Items.Count; i++)
            {
                lstDevice.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDevice.Items.Count; i++)
            {
                lstDevice.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void cbPoolList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string oldfile = Application.StartupPath + "\\" + cbPoolList.Text + "_basic.dat";


                string loadFile = Application.StartupPath + "\\" + cbPoolList.Text + ".dat";

                try
                {
                    File.Copy(oldfile, loadFile, true);
                }
                catch { }

                try
                {
                    File.Delete(oldfile);
                }
                catch { }

                StreamReader sr = new StreamReader(loadFile, Encoding.Default);

                string wallet = "";
                List<string> devices = new List<string>();
                try
                {
                    int lineNum = 0;
                    while (!sr.EndOfStream)
                    {
                        if (lineNum == 0)
                        {
                            wallet = sr.ReadLine().Trim();
                            lineNum++;
                            continue;
                        }

                        devices.Add(sr.ReadLine().Trim());
                    }

                    if (wallet.Length != 42)
                    {
                        throw new Exception();
                    }

                    txtWallet.Text = wallet;

                    try
                    {
                        for (int i = 0; i < devices.Count; i++)
                        {
                            if (devices[i].Contains(lstDevice.Items[i].ToString()) && (devices[i].Contains("Checked") || devices[i].Contains("Unchecked")))
                            {
                                if (devices[i].Contains("Checked"))
                                {
                                    lstDevice.SetItemChecked(i, true);
                                }

                                if (devices[i].Contains("Unchecked"))
                                {
                                    lstDevice.SetItemChecked(i, false);
                                }
                            }
                        }
                    }
                    catch
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    sr.Close();
                    File.Delete(loadFile);
                    return;
                }

                sr.Close();
            }
            catch { }
        }
    }


}
