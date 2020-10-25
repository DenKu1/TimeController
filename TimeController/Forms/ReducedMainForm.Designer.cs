namespace TimeController
{
    partial class ReducedMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReducedMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReduceForm = new System.Windows.Forms.Button();
            this.lbClockStatus = new System.Windows.Forms.Label();
            this.lbTimeLefted = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReduceForm);
            this.panel1.Controls.Add(this.lbClockStatus);
            this.panel1.Controls.Add(this.lbTimeLefted);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 197);
            this.panel1.TabIndex = 15;
            // 
            // btnReduceForm
            // 
            this.btnReduceForm.BackColor = System.Drawing.Color.Transparent;
            this.btnReduceForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReduceForm.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReduceForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.btnReduceForm.Location = new System.Drawing.Point(339, 159);
            this.btnReduceForm.Name = "btnReduceForm";
            this.btnReduceForm.Size = new System.Drawing.Size(33, 33);
            this.btnReduceForm.TabIndex = 5;
            this.btnReduceForm.Text = "⇱";
            this.btnReduceForm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReduceForm.UseVisualStyleBackColor = false;
            this.btnReduceForm.Click += new System.EventHandler(this.Close);
            // 
            // lbClockStatus
            // 
            this.lbClockStatus.AutoSize = true;
            this.lbClockStatus.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.lbClockStatus.Location = new System.Drawing.Point(20, 10);
            this.lbClockStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClockStatus.Name = "lbClockStatus";
            this.lbClockStatus.Size = new System.Drawing.Size(338, 28);
            this.lbClockStatus.TabIndex = 3;
            this.lbClockStatus.Text = "Залишилось до перерви:";
            // 
            // lbTimeLefted
            // 
            this.lbTimeLefted.AutoSize = true;
            this.lbTimeLefted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.lbTimeLefted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTimeLefted.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeLefted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.lbTimeLefted.Location = new System.Drawing.Point(65, 51);
            this.lbTimeLefted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeLefted.Name = "lbTimeLefted";
            this.lbTimeLefted.Size = new System.Drawing.Size(239, 93);
            this.lbTimeLefted.TabIndex = 2;
            this.lbTimeLefted.Text = "00:00";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TIME CONTROLLER";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // ReducedMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 270);
            this.MinimumSize = new System.Drawing.Size(420, 270);
            this.Name = "ReducedMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TIME CONTROLLER";
            this.Deactivate += new System.EventHandler(this.ReducedMainForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReducedMainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTimeLefted;
        private System.Windows.Forms.Button btnReduceForm;
        public System.Windows.Forms.Label lbClockStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}