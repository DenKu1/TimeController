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
    public partial class TrackApplicationForm : Form
    {
        MainForm main;

        public TrackApplicationForm()
        {
            InitializeComponent();
        }       

        private void TrackApplicationForm_Load(object sender, EventArgs e)
        {
            main = Owner as MainForm;
            UpdateProcesses();
            
            if (main.actSettings.trackApps.appsArray != null)
                chListBoxTrackingApps.Items.AddRange(main.actSettings.trackApps.appsArray);

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

            chListBoxTrackingApps.Refresh();
        }

        private void AddProcesses()
        {
            foreach (ProcInfo procInfo in chListBoxRunningApps.CheckedItems)
            {
                if (!chListBoxTrackingApps.Items.Contains(procInfo))
                    chListBoxTrackingApps.Items.Add(procInfo);
            }
        }

        private void DeleteProcesses()
        {
            while (chListBoxTrackingApps.CheckedItems.Count > 0)
            {
                chListBoxTrackingApps.Items.Remove(chListBoxTrackingApps.CheckedItems[0]);
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

        private void SaveTrackingApps()
        {
            main.actSettings.trackApps.appsArray = new ProcInfo[chListBoxTrackingApps.Items.Count];

            chListBoxTrackingApps.Items.CopyTo(main.actSettings.trackApps.appsArray, 0);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTrackingApps();
        }
    }
}
