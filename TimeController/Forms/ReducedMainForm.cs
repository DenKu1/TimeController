using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeController
{
    public partial class ReducedMainForm : Form
    {
        public ReducedMainForm()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            ShowMain();
            Dispose();
        }

        private void ShowMain()
        {
            MainForm main = Owner as MainForm;
            main.Show();
        }

        private void ReducedMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMain();
        }

        private void ReducedMainForm_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        public void MyPaint(Design design)
        {
            BackColor = design.color1;

            lbTimeLefted.BackColor = design.color2;

        }
    }
}
