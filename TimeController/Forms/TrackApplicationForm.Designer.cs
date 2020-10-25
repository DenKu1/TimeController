namespace TimeController
{
    partial class TrackApplicationForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteApps = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.chListBoxTrackingApps = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddApps = new System.Windows.Forms.Button();
            this.chListBoxRunningApps = new System.Windows.Forms.CheckedListBox();
            this.chBoxShowProcName = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chBoxShowAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(217)))), ((int)(((byte)(231)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btnSave.Location = new System.Drawing.Point(396, 440);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(273, 42);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteApps
            // 
            this.btnDeleteApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.btnDeleteApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteApps.Location = new System.Drawing.Point(18, 356);
            this.btnDeleteApps.Name = "btnDeleteApps";
            this.btnDeleteApps.Size = new System.Drawing.Size(273, 42);
            this.btnDeleteApps.TabIndex = 19;
            this.btnDeleteApps.Text = "Видалити";
            this.btnDeleteApps.UseVisualStyleBackColor = false;
            this.btnDeleteApps.Click += new System.EventHandler(this.btnDeleteApps_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnArrowRight);
            this.panel4.Controls.Add(this.btnArrowLeft);
            this.panel4.Controls.Add(this.chListBoxTrackingApps);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnAddApps);
            this.panel4.Controls.Add(this.chListBoxRunningApps);
            this.panel4.Controls.Add(this.btnDeleteApps);
            this.panel4.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 409);
            this.panel4.TabIndex = 20;
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.btnArrowRight.BackgroundImage = global::TimeController.Properties.Resources.right_arrow;
            this.btnArrowRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArrowRight.Location = new System.Drawing.Point(309, 189);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(42, 42);
            this.btnArrowRight.TabIndex = 30;
            this.btnArrowRight.UseVisualStyleBackColor = false;
            this.btnArrowRight.Click += new System.EventHandler(this.btnDeleteApps_Click);
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.btnArrowLeft.BackgroundImage = global::TimeController.Properties.Resources.left_arrow;
            this.btnArrowLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArrowLeft.Location = new System.Drawing.Point(309, 141);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(42, 42);
            this.btnArrowLeft.TabIndex = 29;
            this.btnArrowLeft.UseVisualStyleBackColor = false;
            this.btnArrowLeft.Click += new System.EventHandler(this.btnAddApps_Click);
            // 
            // chListBoxTrackingApps
            // 
            this.chListBoxTrackingApps.FormattingEnabled = true;
            this.chListBoxTrackingApps.HorizontalScrollbar = true;
            this.chListBoxTrackingApps.Location = new System.Drawing.Point(18, 40);
            this.chListBoxTrackingApps.Name = "chListBoxTrackingApps";
            this.chListBoxTrackingApps.Size = new System.Drawing.Size(273, 310);
            this.chListBoxTrackingApps.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Запущені програми:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Програми які відслідковуються:";
            // 
            // btnAddApps
            // 
            this.btnAddApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.btnAddApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApps.Location = new System.Drawing.Point(383, 356);
            this.btnAddApps.Name = "btnAddApps";
            this.btnAddApps.Size = new System.Drawing.Size(273, 42);
            this.btnAddApps.TabIndex = 21;
            this.btnAddApps.Text = "Додати";
            this.btnAddApps.UseVisualStyleBackColor = false;
            this.btnAddApps.Click += new System.EventHandler(this.btnAddApps_Click);
            // 
            // chListBoxRunningApps
            // 
            this.chListBoxRunningApps.FormattingEnabled = true;
            this.chListBoxRunningApps.HorizontalScrollbar = true;
            this.chListBoxRunningApps.Location = new System.Drawing.Point(383, 40);
            this.chListBoxRunningApps.Name = "chListBoxRunningApps";
            this.chListBoxRunningApps.Size = new System.Drawing.Size(273, 310);
            this.chListBoxRunningApps.TabIndex = 20;
            // 
            // chBoxShowProcName
            // 
            this.chBoxShowProcName.AutoSize = true;
            this.chBoxShowProcName.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxShowProcName.Location = new System.Drawing.Point(12, 3);
            this.chBoxShowProcName.Name = "chBoxShowProcName";
            this.chBoxShowProcName.Size = new System.Drawing.Size(225, 21);
            this.chBoxShowProcName.TabIndex = 28;
            this.chBoxShowProcName.Text = "Показати назву процесу";
            this.chBoxShowProcName.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.btnUpdate.BackgroundImage = global::TimeController.Properties.Resources.refresh_image;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Location = new System.Drawing.Point(266, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(42, 42);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chBoxShowAll
            // 
            this.chBoxShowAll.AutoSize = true;
            this.chBoxShowAll.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxShowAll.Location = new System.Drawing.Point(12, 23);
            this.chBoxShowAll.Name = "chBoxShowAll";
            this.chBoxShowAll.Size = new System.Drawing.Size(204, 21);
            this.chBoxShowAll.TabIndex = 25;
            this.chBoxShowAll.Text = "Показати всі процеси";
            this.chBoxShowAll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chBoxShowProcName);
            this.panel1.Controls.Add(this.chBoxShowAll);
            this.panel1.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel1.Location = new System.Drawing.Point(12, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 55);
            this.panel1.TabIndex = 29;
            // 
            // TrackApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(705, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnUpdate);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 557);
            this.MinimumSize = new System.Drawing.Size(723, 557);
            this.Name = "TrackApplicationForm";
            this.ShowIcon = false;
            this.Text = "Відслідкувати додатки";
            this.Load += new System.EventHandler(this.TrackApplicationForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteApps;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddApps;
        private System.Windows.Forms.CheckedListBox chListBoxRunningApps;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chBoxShowAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chListBoxTrackingApps;
        private System.Windows.Forms.CheckBox chBoxShowProcName;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.Panel panel1;
    }
}