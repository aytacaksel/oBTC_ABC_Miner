using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace oBTC_ABC_Miner
{
    public partial class frmLoad : Form
    {
        public List<string> deviceList;

        public frmLoad()
        {
            InitializeComponent();
        }

        private void frmLoad_Shown(object sender, EventArgs e)
        {
            deviceList = new List<string>();

            BackgroundWorker bwFindDevices = new BackgroundWorker();
            bwFindDevices.DoWork += BwFindDevices_DoWork;
            bwFindDevices.RunWorkerCompleted += BwFindDevices_RunWorkerCompleted;
            bwFindDevices.RunWorkerAsync();

            while (bwFindDevices.IsBusy)
            {
                Application.DoEvents();
                Thread.Sleep(50);
            }
        }

        private void BwFindDevices_DoWork(object sender, DoWorkEventArgs e)
        {
            string _out = "";
            List<string> _outList = new List<string>();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.FileName = Application.StartupPath + "\\Wildrig\\wildrig.exe";
            startInfo.WorkingDirectory = Application.StartupPath + "\\Wildrig\\";
            startInfo.Arguments = "--print-devices";
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            process.StartInfo = startInfo;
            process.Start();
            _out = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            _outList = _out.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int workerId = 1;


            if (_outList.Count > 0)
            {
                for (int i = 0; i < _outList.Count; i++)
                {
                    if (_outList[i].Contains("GPU") && _outList[i].Contains("#"))
                    {
                        _outList[i] = _outList[i].Replace("\t", " ");

                        List<string> device = _outList[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                        string id = device[1].Replace("#", "").Replace(":", "").Trim();

                        string name = "";

                        for (int ii = 2; ii < 100; ii++)
                        {
                            if (device[ii].Trim().Contains("("))
                            {
                                break;
                            }

                            name += device[ii] + "_";
                        }

                        name = name.Substring(0, name.Length - 1);

                        deviceList.Add(name.Trim() + " ID: " + id.ToString());
                    }
                }
            }

        }

        private void BwFindDevicesOld_DoWork(object sender, DoWorkEventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.FileName = Application.StartupPath + "\\SRBMiner\\SRBMiner-MULTI.exe";
            startInfo.WorkingDirectory = Application.StartupPath + "\\SRBMiner\\";
            startInfo.Arguments = @"--list-devices";
            startInfo.RedirectStandardOutput = true;
            process.StartInfo = startInfo;
            process.Start();
            string _out = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            List<string> _outList = _out.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (_outList.Count > 1)
            {
                for (int i = 1; i < _outList.Count; i++)
                {
                    List<string> device = _outList[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    deviceList.Add("AMD: " + device[4].Trim() + " ID: " + (i - 1).ToString() + " Worker: " + "001");
                }
            }

            _out = "";
            _outList = new List<string>();

            process = new Process();
            startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.FileName = Application.StartupPath + "\\Suprminer\\suprminer.exe";
            startInfo.WorkingDirectory = Application.StartupPath + "\\Suprminer\\";
            startInfo.Arguments = "-n";
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            process.StartInfo = startInfo;
            process.Start();
            _out = process.StandardError.ReadToEnd();
            process.WaitForExit();

            _outList = _out.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            int workerId = 1;

            if (deviceList.Count > 0)
            {
                workerId = 2;
            }

            if (_outList.Count > 0)
            {
                for (int i = 0; i < _outList.Count; i++)
                {
                    if (_outList[i].Contains("GPU") && _outList[i].Contains("#"))
                    {
                        List<string> device = _outList[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                        string id = device[1].Replace("#", "").Replace(":", "").Trim();

                        string name = "";

                        for (int ii = 4; ii < 100; ii++)
                        {
                            if (device[ii].Trim() == "@")
                            {
                                break;
                            }

                            name += device[ii] + "_";
                        }

                        name = name.Substring(0, name.Length - 1);

                        deviceList.Add("NVIDIA: " + name.Trim() + " ID: " + id.ToString() + " Worker: " + (workerId++).ToString("000"));
                    }
                }
            }

        }

        private void BwFindDevices_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }


    }
}
