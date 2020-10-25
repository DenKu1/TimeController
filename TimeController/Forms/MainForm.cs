using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading;

namespace TimeController
{
    public partial class MainForm : Form
    {
        DateTime dateTimeEnd;

        TimeSpan timeLeft;

        string startDirectory = Directory.GetCurrentDirectory(); //Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string userSettingsFolder = @"\UserSettings\";

        ProcInfo[] activeTrackingApps;
        ProcInfo[] oldActiveTrackingApps;

        ProcInfo[] activeBlackListApps;
        ProcInfo[] oldActiveBlackListApps;

        ReducedMainForm reducedForm;

        public UserSettings actSettings = new UserSettings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            actSettings.LoadSettings(startDirectory + userSettingsFolder);

            ApplySettings();
        }

        private void ApplySettings()
        {
            comBoxWorkDuration.Text = actSettings.workDuration.ToString();
            comBoxBreakDuration.Text = actSettings.breakDuration.ToString();

            chBoxShowMessage.Checked = actSettings.showMessage;
            chBoxPlaySound.Checked = actSettings.playSound;
            chBoxDisableMouse.Checked = actSettings.disableMouse;
            chBoxDisableKeyboard.Checked = actSettings.disableKeyboard;

            trackActiveToolStripMenuItem.Checked = actSettings.trackActive;
            trackBlackListToolStripMenuItem.Checked = actSettings.trackBlackList;

            MyPaint(DesignFactory.Create(actSettings.currentDesign));
        }

        void UpdateAll()
        {
            try
            {
                actSettings.workDuration = int.Parse(comBoxWorkDuration.Text);
                actSettings.breakDuration = int.Parse(comBoxBreakDuration.Text);
            }
            catch { }

            actSettings.showMessage = chBoxShowMessage.Checked;
            actSettings.playSound = chBoxPlaySound.Checked;
            actSettings.disableMouse = chBoxDisableMouse.Checked;
            actSettings.disableKeyboard = chBoxDisableKeyboard.Checked;

            actSettings.trackActive = trackActiveToolStripMenuItem.Checked;
            actSettings.trackBlackList = trackBlackListToolStripMenuItem.Checked;
        }
        
        private void MyPaint(Design design)
        {
            BackColor = design.color1; 

            lbTimeLefted.BackColor = design.color2;
            btnStart.BackColor = design.color2;
            statusStrip.BackColor = design.color2;

            menuStrip.BackColor = design.color3;
        }

        private ProcInfo[] FindActiveApps(ProcInfo[] appsArray)
        {
            List<ProcInfo> activeAppsList = new List<ProcInfo>();

            Process[] processes = Process.GetProcesses();

            foreach (ProcInfo app1 in appsArray)
            {
                foreach (Process app2 in processes)
                {
                    if (app1.processName == app2.ProcessName)
                    {
                        activeAppsList.Add(app1);
                        break;
                    }
                }

            }

            return activeAppsList.ToArray();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PrepareToWork();

            UpdateAll();
            StartWork();            
        }

        private void CalculateTick()
        {
            timeLeft = dateTimeEnd - DateTime.Now;

            lbTimeLefted.Text = timeLeft.ToString(@"mm\:ss");
        }

        private void btnReduceForm_Click(object sender, EventArgs e)
        {
            Hide();

            reducedForm = new ReducedMainForm();
            reducedForm.Owner = this;
            Rectangle res = Screen.PrimaryScreen.Bounds;
            reducedForm.Location = new Point(res.Width - reducedForm.Size.Width, res.Height - reducedForm.Size.Height - 50);

            reducedForm.MyPaint(DesignFactory.Create(actSettings.currentDesign));
            reducedForm.Show();
        }

        private void lbTimeLefted_TextChanged(object sender, EventArgs e)
        {
            if (reducedForm != null)
            {
                reducedForm.lbTimeLefted.Text = lbTimeLefted.Text;
                reducedForm.lbClockStatus.Text = lbClockStatus.Text;
            }
        }

        private void lbClockStatus_TextChanged(object sender, EventArgs e)
        {
            if (reducedForm != null)
                reducedForm.lbClockStatus.Text = lbClockStatus.Text;
        }

        private void timerWork_Tick(object sender, EventArgs e)
        {
            CalculateTick();            

            if (timeLeft < TimeSpan.Zero)
            {
                timerWork.Stop();
                timerCheckActive.Stop();

                StartBreak();
            }      

        }

        private void timerBreak_Tick(object sender, EventArgs e)
        {
            CalculateTick();

            if (timeLeft < TimeSpan.Zero)
            {
                timerBreak.Stop();
                timerInterruptUser.Stop();
                UnlockAll();


                StartWork();
            }
        }

        private void CheckOnlyActive()
        {
            activeTrackingApps = FindActiveApps(actSettings.trackApps.appsArray);

            if (timerWork.Enabled == true)
            {
                if (activeTrackingApps.Length == 0)
                {
                    timerWork.Enabled = false;

                    oldActiveTrackingApps = null;
                    lBoxActiveTrackApps.Items.Clear();
                }
                else
                    UpdatelBoxActiveTrackApps();
            }
            else
            {
                dateTimeEnd = dateTimeEnd.AddMilliseconds(timerCheckActive.Interval);

                if (activeTrackingApps.Length != 0)
                {
                    timerWork.Enabled = true;
                    UpdatelBoxActiveTrackApps();
                }
            }
        }

        private void CheckOnlyBlackList()
        {
            activeBlackListApps = FindActiveApps(actSettings.blackListApps.appsArray);

            if (timerWork.Enabled == true)
            {
                if (activeBlackListApps.Length != 0)
                {
                    timerWork.Enabled = false;

                    UpdatelBoxActiveBlackListApps();
                }
            }
            else
            {
                dateTimeEnd = dateTimeEnd.AddMilliseconds(timerCheckActive.Interval);

                if (activeBlackListApps.Length != 0)
                {
                    UpdatelBoxActiveBlackListApps();
                }
                else
                {
                    timerWork.Enabled = true;

                    oldActiveTrackingApps = null;
                    lBoxActiveBlackListApps.Items.Clear();

                }

            }

        }

        private void CheckBoth()
        {
            
            activeBlackListApps = FindActiveApps(actSettings.blackListApps.appsArray);
            activeTrackingApps = FindActiveApps(actSettings.trackApps.appsArray);

            if (timerWork.Enabled == true)
            {
                if (activeTrackingApps.Length == 0)
                {
                    timerWork.Enabled = false;

                    oldActiveTrackingApps = null;
                    lBoxActiveBlackListApps.Items.Clear();

                    if (activeBlackListApps.Length == 0)
                    {
                        oldActiveBlackListApps = null;
                        lBoxActiveBlackListApps.Items.Clear();
                    }
                    else
                    {
                        UpdatelBoxActiveBlackListApps();
                    }
                }
                else
                {
                    UpdatelBoxActiveTrackApps();

                    if (activeBlackListApps.Length != 0)
                    {
                        timerWork.Enabled = false;

                        UpdatelBoxActiveBlackListApps();
                    }

                }
            }
            else
            {

                dateTimeEnd = dateTimeEnd.AddMilliseconds(timerCheckActive.Interval);

                if (activeTrackingApps.Length == 0)
                {
                    oldActiveTrackingApps = null;
                    lBoxActiveTrackApps.Items.Clear();

                    if (activeBlackListApps.Length == 0)
                    {           
                        oldActiveBlackListApps = null;
                        lBoxActiveBlackListApps.Items.Clear();
                    }
                    else
                    {
                        UpdatelBoxActiveBlackListApps();
                    }
                }
                else
                {
                    UpdatelBoxActiveTrackApps();

                    if (activeBlackListApps.Length == 0)
                    {
                        timerWork.Enabled = true;                                             

                        oldActiveBlackListApps = null;
                        lBoxActiveBlackListApps.Items.Clear();
                    }
                    else
                    {                       
                        UpdatelBoxActiveBlackListApps();
                    }
                }
            }

        }

        private void timerCheckActive_Tick(object sender, EventArgs e)
        {
            if (actSettings.trackActive == true)
            {
                if (actSettings.trackBlackList == true)
                {
                    CheckBoth();
                }
                else
                {
                    CheckOnlyActive();
                }
            }
            else
            {
                if (actSettings.trackBlackList == true)
                {
                    CheckOnlyBlackList();
                }
               
            }

        }

        private void timerInterruptUser_Tick(object sender, EventArgs e)
        {
            if (actSettings.disableMouse == true)
            {
                Cursor.Position = Location;
                Cursor.Clip = RectangleToScreen(new Rectangle(Location.X + 100 , Location.Y + 100, 1, 1));
            }
            if (actSettings.disableKeyboard == true)
            {
               //Dodelat
            }
        }

        private void UpdatelBoxActiveTrackApps()
        {           
            if (oldActiveTrackingApps == null || !activeTrackingApps.SequenceEqual(oldActiveTrackingApps))
            {
                lBoxActiveTrackApps.Items.Clear();
                lBoxActiveTrackApps.Items.AddRange(activeTrackingApps);
            }

            oldActiveTrackingApps = activeTrackingApps;
        }

        private void UpdatelBoxActiveBlackListApps()
        {
            if (oldActiveBlackListApps == null || !activeBlackListApps.SequenceEqual(oldActiveBlackListApps))
            {
                lBoxActiveBlackListApps.Items.Clear();
                lBoxActiveBlackListApps.Items.AddRange(activeBlackListApps);
            }

            oldActiveBlackListApps = activeBlackListApps;

        }

        private void PrepareToWork()
        {
            lBoxActiveTrackApps.Items.Clear();
            lBoxActiveBlackListApps.Items.Clear();

            trackActiveToolStripMenuItem.Enabled = false;
            trackBlackListToolStripMenuItem.Enabled = false;
        }

        private void StartWork()
        {
            lbClockStatus.Text = "Залишилось до перерви:";

            dateTimeEnd = DateTime.Now.AddMinutes(actSettings.workDuration); 
            lbTimeLefted.Text = TimeSpan.FromMinutes(actSettings.workDuration).ToString(@"mm\:ss");



            resetTimerToolStripMenuItem.Enabled = true;


            if (actSettings.trackActive == false && actSettings.trackBlackList == false)
                timerWork.Start(); 
            else
                timerCheckActive.Start();
        }

        private void StartBreak()
        {
            resetTimerToolStripMenuItem.Enabled = false;

            lbClockStatus.Text = "Перерва:";

            dateTimeEnd = DateTime.Now.AddMinutes(actSettings.breakDuration);
            lbTimeLefted.Text = TimeSpan.FromMinutes(actSettings.breakDuration).ToString(@"mm\:ss");

            timerBreak.Start();
            timerInterruptUser.Start();

            if (actSettings.playSound == true)
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.timer); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name

                audio.Play();

            }
            if (actSettings.showMessage == true)
            {
                    MessageBox.Show("Робочий час вичерпано. Зараз потрібно відпочити!", "Повідомлення",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void UnlockAll()
        {
            if (actSettings.disableMouse == true)
            {
                Cursor.Current = Cursors.Arrow;
                Cursor = Cursors.Arrow;
            }
            if (actSettings.disableKeyboard == true)
            {
              //////
            }


        }

        //menustrip -> Файл 
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm secondForm = new AboutProgramForm();
            secondForm.ShowDialog();
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm secondForm = new HelpForm();
            secondForm.ShowDialog();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //menustrip -> Налаштування
        private void trackAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackApplicationForm secondForm = new TrackApplicationForm();
            secondForm.Owner = this;
            secondForm.ShowDialog();

            if (ProcInfo.whatShow == false)
                ProcInfo.whatShow = true;
        }

        private void blackListAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackListApplicationForm secondForm = new BlackListApplicationForm();
            secondForm.Owner = this;
            secondForm.ShowDialog();

            if (ProcInfo.whatShow == false)
                ProcInfo.whatShow = true;
        }

        private void ChooseDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = ((ToolStripMenuItem)sender).Tag.ToString();

            ParceAndPaint(value);

        }

        private void ParceAndPaint(string value)
        {

            DesignTypes designType = Utils.ParseEnum(value);

            actSettings.currentDesign = designType;

            MyPaint(DesignFactory.Create(designType));

        }



        private void resetTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAll();

            lbClockStatus.Text = "Залишилось до перерви:";

            dateTimeEnd = DateTime.Now.AddMinutes(actSettings.workDuration);
            lbTimeLefted.Text = TimeSpan.FromMinutes(actSettings.workDuration).ToString(@"mm\:ss");

            timerWork.Stop();
            timerBreak.Stop();
            timerCheckActive.Stop();
            timerInterruptUser.Stop();

            trackActiveToolStripMenuItem.Enabled = true;
            trackBlackListToolStripMenuItem.Enabled = true;
        }

        //menustrip -> Режим роботи
        private void trackActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackActiveToolStripMenuItem.Checked = !trackActiveToolStripMenuItem.Checked;
        }

        private void trackBlackListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBlackListToolStripMenuItem.Checked = !trackBlackListToolStripMenuItem.Checked;
        }
        //end

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateAll();
            actSettings.SaveSettings(startDirectory + userSettingsFolder);
        }

        private void comBoxWorkDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                actSettings.workDuration = int.Parse(comBoxWorkDuration.Text);
            }
            catch { }
        }

        private void comBoxBreakDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                actSettings.breakDuration = int.Parse(comBoxBreakDuration.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Будь ласка введіть час в хвилинах");
            }
        }

        private void comBoxChooseDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comBoxChooseDesign.SelectedItem.ToString();

            ParceAndPaint(value);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        
    }
}
