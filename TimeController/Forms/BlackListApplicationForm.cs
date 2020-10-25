using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimeController
{
    public partial class BlackListApplicationForm : Form
    {
        MainForm main;

        public BlackListApplicationForm()
        {
            InitializeComponent();
        }   

        private void BlackListApplicationForm_Load(object sender, EventArgs e)
        {
            main = Owner as MainForm;
            UpdateProcesses();

            if (main.actSettings.blackListApps.appsArray != null)
                chListBoxBlackListApps.Items.AddRange(main.actSettings.blackListApps.appsArray);
        }

        private void UpdateProcesses()
        {
            chListBoxRunningApps.Items.Clear();

            Process[] processes = Process.GetProcesses();

            if (chBoxShowAll.Checked == true)
            {
                chBoxShowProcName.Enabled = false;
                chBoxShowProcName.Checked = true;
            }
            else
            {
                chBoxShowProcName.Enabled = true;
            }

            if (chBoxShowProcName.Checked == true)
                ProcInfo.whatShow = false;
            else
                ProcInfo.whatShow = true;

            Process currentProcess = Process.GetCurrentProcess();

            foreach (var proc in processes)
            {

                if ((proc.MainWindowTitle != "" || chBoxShowAll.Checked == true) && proc.ProcessName != currentProcess.ProcessName)
                {
                    ProcInfo newProc;

                    if (proc.MainWindowTitle != "")
                        newProc = new ProcInfo(proc.ProcessName, proc.MainWindowTitle);
                    else
                        newProc = new ProcInfo(proc.ProcessName);

                    if (!chListBoxRunningApps.Items.Contains(newProc))
                        chListBoxRunningApps.Items.Add(newProc);

                }
            }

            chListBoxBlackListApps.Refresh();
        }

        private void AddProcesses()
        {
            foreach (ProcInfo procInfo in chListBoxRunningApps.CheckedItems)
            {
                if (!chListBoxBlackListApps.Items.Contains(procInfo))
                    chListBoxBlackListApps.Items.Add(procInfo);
            }
        }

        private void DeleteProcesses()
        {
            while (chListBoxBlackListApps.CheckedItems.Count > 0)
            {
                chListBoxBlackListApps.Items.Remove(chListBoxBlackListApps.CheckedItems[0]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcesses();
        }

        private void btnAddApps_Click(object sender, EventArgs e)
        {
            AddProcesses();
        }

        private void btnDeleteApps_Click(object sender, EventArgs e)
        {
            DeleteProcesses();
        }

        private void SaveBlackListApps()
        {
            main.actSettings.blackListApps.appsArray = new ProcInfo[chListBoxBlackListApps.Items.Count];

            chListBoxBlackListApps.Items.CopyTo(main.actSettings.blackListApps.appsArray, 0);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBlackListApps();
        }
    }
}
