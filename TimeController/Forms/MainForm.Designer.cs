namespace TimeController
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbTimeLefted = new System.Windows.Forms.Label();
            this.lbClockStatus = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackListAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.design1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.design2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.design3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимРоботиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBlackListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReduceForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chBoxDisableKeyboard = new System.Windows.Forms.CheckBox();
            this.chBoxDisableMouse = new System.Windows.Forms.CheckBox();
            this.chBoxPlaySound = new System.Windows.Forms.CheckBox();
            this.chBoxShowMessage = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxWorkDuration = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comBoxBreakDuration = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.timerWork = new System.Windows.Forms.Timer(this.components);
            this.timerBreak = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lBoxActiveBlackListApps = new System.Windows.Forms.ListBox();
            this.lBoxActiveTrackApps = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comBoxChooseDesign = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звичайнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ігноуватиЧорнийСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активнийЗавждиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вімкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вимкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheckActive = new System.Windows.Forms.Timer(this.components);
            this.timerInterruptUser = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.lbTimeLefted.TextChanged += new System.EventHandler(this.lbTimeLefted_TextChanged);
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
            this.lbClockStatus.TextChanged += new System.EventHandler(this.lbClockStatus_TextChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.налаштуванняToolStripMenuItem,
            this.режимРоботиToolStripMenuItem,
            this.таймерToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(816, 28);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutProgramToolStripMenuItem.Text = "Про програму";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.helpToolStripMenuItem.Text = "Довідка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.restartToolStripMenuItem.Text = "Рестарт";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackAppsToolStripMenuItem,
            this.blackListAppsToolStripMenuItem,
            this.interfaceColorToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // trackAppsToolStripMenuItem
            // 
            this.trackAppsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trackAppsToolStripMenuItem.Name = "trackAppsToolStripMenuItem";
            this.trackAppsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.trackAppsToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.trackAppsToolStripMenuItem.Text = "Список відслідковуваних додатків";
            this.trackAppsToolStripMenuItem.Click += new System.EventHandler(this.trackAppsToolStripMenuItem_Click);
            // 
            // blackListAppsToolStripMenuItem
            // 
            this.blackListAppsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blackListAppsToolStripMenuItem.Name = "blackListAppsToolStripMenuItem";
            this.blackListAppsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.blackListAppsToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.blackListAppsToolStripMenuItem.Text = "Список додатків-виключень";
            this.blackListAppsToolStripMenuItem.Click += new System.EventHandler(this.blackListAppsToolStripMenuItem_Click);
            // 
            // interfaceColorToolStripMenuItem
            // 
            this.interfaceColorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.interfaceColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.design1ToolStripMenuItem,
            this.design2ToolStripMenuItem,
            this.design3ToolStripMenuItem});
            this.interfaceColorToolStripMenuItem.Name = "interfaceColorToolStripMenuItem";
            this.interfaceColorToolStripMenuItem.Size = new System.Drawing.Size(371, 26);
            this.interfaceColorToolStripMenuItem.Text = "Колір інтерфейсу";
            // 
            // design1ToolStripMenuItem
            // 
            this.design1ToolStripMenuItem.Name = "design1ToolStripMenuItem";
            this.design1ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.design1ToolStripMenuItem.Tag = "DESIGN1";
            this.design1ToolStripMenuItem.Text = "Дизайн 1";
            this.design1ToolStripMenuItem.Click += new System.EventHandler(this.ChooseDesignToolStripMenuItem_Click);
            // 
            // design2ToolStripMenuItem
            // 
            this.design2ToolStripMenuItem.Name = "design2ToolStripMenuItem";
            this.design2ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.design2ToolStripMenuItem.Tag = "DESIGN2";
            this.design2ToolStripMenuItem.Text = "Дизайн 2";
            this.design2ToolStripMenuItem.Click += new System.EventHandler(this.ChooseDesignToolStripMenuItem_Click);
            // 
            // design3ToolStripMenuItem
            // 
            this.design3ToolStripMenuItem.Name = "design3ToolStripMenuItem";
            this.design3ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.design3ToolStripMenuItem.Tag = "DESIGN3";
            this.design3ToolStripMenuItem.Text = "Дизайн 3";
            this.design3ToolStripMenuItem.Click += new System.EventHandler(this.ChooseDesignToolStripMenuItem_Click);
            // 
            // режимРоботиToolStripMenuItem
            // 
            this.режимРоботиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackActiveToolStripMenuItem,
            this.trackBlackListToolStripMenuItem});
            this.режимРоботиToolStripMenuItem.Name = "режимРоботиToolStripMenuItem";
            this.режимРоботиToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.режимРоботиToolStripMenuItem.Text = "Режим роботи";
            // 
            // trackActiveToolStripMenuItem
            // 
            this.trackActiveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trackActiveToolStripMenuItem.Checked = true;
            this.trackActiveToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackActiveToolStripMenuItem.Name = "trackActiveToolStripMenuItem";
            this.trackActiveToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.trackActiveToolStripMenuItem.Text = "Віслідковувати додатки";
            this.trackActiveToolStripMenuItem.Click += new System.EventHandler(this.trackActiveToolStripMenuItem_Click);
            // 
            // trackBlackListToolStripMenuItem
            // 
            this.trackBlackListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trackBlackListToolStripMenuItem.Checked = true;
            this.trackBlackListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackBlackListToolStripMenuItem.Name = "trackBlackListToolStripMenuItem";
            this.trackBlackListToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.trackBlackListToolStripMenuItem.Text = "Відслідковувати додатки-виключення";
            this.trackBlackListToolStripMenuItem.Click += new System.EventHandler(this.trackBlackListToolStripMenuItem_Click);
            // 
            // таймерToolStripMenuItem
            // 
            this.таймерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetTimerToolStripMenuItem});
            this.таймерToolStripMenuItem.Name = "таймерToolStripMenuItem";
            this.таймерToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.таймерToolStripMenuItem.Text = "Таймер";
            // 
            // resetTimerToolStripMenuItem
            // 
            this.resetTimerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resetTimerToolStripMenuItem.Name = "resetTimerToolStripMenuItem";
            this.resetTimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.resetTimerToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.resetTimerToolStripMenuItem.Text = "Скинути таймер";
            this.resetTimerToolStripMenuItem.Click += new System.EventHandler(this.resetTimerToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btnStart.Location = new System.Drawing.Point(13, 60);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 88);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReduceForm);
            this.panel1.Controls.Add(this.lbClockStatus);
            this.panel1.Controls.Add(this.lbTimeLefted);
            this.panel1.Location = new System.Drawing.Point(204, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 197);
            this.panel1.TabIndex = 14;
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
            this.btnReduceForm.TabIndex = 4;
            this.btnReduceForm.Text = "⇲";
            this.btnReduceForm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReduceForm.UseVisualStyleBackColor = false;
            this.btnReduceForm.Click += new System.EventHandler(this.btnReduceForm_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chBoxDisableKeyboard);
            this.panel2.Controls.Add(this.chBoxDisableMouse);
            this.panel2.Controls.Add(this.chBoxPlaySound);
            this.panel2.Controls.Add(this.chBoxShowMessage);
            this.panel2.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel2.Location = new System.Drawing.Point(587, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 197);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дії під час перерви:";
            // 
            // chBoxDisableKeyboard
            // 
            this.chBoxDisableKeyboard.AutoSize = true;
            this.chBoxDisableKeyboard.Enabled = false;
            this.chBoxDisableKeyboard.Location = new System.Drawing.Point(6, 132);
            this.chBoxDisableKeyboard.Name = "chBoxDisableKeyboard";
            this.chBoxDisableKeyboard.Size = new System.Drawing.Size(199, 22);
            this.chBoxDisableKeyboard.TabIndex = 7;
            this.chBoxDisableKeyboard.Text = "Відключати клавіатуру";
            this.chBoxDisableKeyboard.UseVisualStyleBackColor = true;
            // 
            // chBoxDisableMouse
            // 
            this.chBoxDisableMouse.AutoSize = true;
            this.chBoxDisableMouse.Location = new System.Drawing.Point(6, 105);
            this.chBoxDisableMouse.Name = "chBoxDisableMouse";
            this.chBoxDisableMouse.Size = new System.Drawing.Size(161, 22);
            this.chBoxDisableMouse.TabIndex = 6;
            this.chBoxDisableMouse.Text = "Відключати мишу";
            this.chBoxDisableMouse.UseVisualStyleBackColor = true;
            // 
            // chBoxPlaySound
            // 
            this.chBoxPlaySound.AutoSize = true;
            this.chBoxPlaySound.Location = new System.Drawing.Point(6, 78);
            this.chBoxPlaySound.Name = "chBoxPlaySound";
            this.chBoxPlaySound.Size = new System.Drawing.Size(147, 22);
            this.chBoxPlaySound.TabIndex = 5;
            this.chBoxPlaySound.Text = "Програвати звук";
            this.chBoxPlaySound.UseVisualStyleBackColor = true;
            // 
            // chBoxShowMessage
            // 
            this.chBoxShowMessage.AutoSize = true;
            this.chBoxShowMessage.Location = new System.Drawing.Point(6, 51);
            this.chBoxShowMessage.Name = "chBoxShowMessage";
            this.chBoxShowMessage.Size = new System.Drawing.Size(203, 22);
            this.chBoxShowMessage.TabIndex = 4;
            this.chBoxShowMessage.Text = "Виводити повідомлення";
            this.chBoxShowMessage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comBoxWorkDuration);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comBoxBreakDuration);
            this.panel3.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel3.Location = new System.Drawing.Point(204, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 122);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "хв";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "хв";
            // 
            // comBoxWorkDuration
            // 
            this.comBoxWorkDuration.FormattingEnabled = true;
            this.comBoxWorkDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "80"});
            this.comBoxWorkDuration.Location = new System.Drawing.Point(24, 60);
            this.comBoxWorkDuration.Name = "comBoxWorkDuration";
            this.comBoxWorkDuration.Size = new System.Drawing.Size(61, 25);
            this.comBoxWorkDuration.TabIndex = 19;
            this.comBoxWorkDuration.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(21, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Швидка зміна налаштувань:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Тривалість перерви:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Тривалість роботи:";
            // 
            // comBoxBreakDuration
            // 
            this.comBoxBreakDuration.FormattingEnabled = true;
            this.comBoxBreakDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comBoxBreakDuration.Location = new System.Drawing.Point(216, 60);
            this.comBoxBreakDuration.Name = "comBoxBreakDuration";
            this.comBoxBreakDuration.Size = new System.Drawing.Size(60, 25);
            this.comBoxBreakDuration.TabIndex = 16;
            this.comBoxBreakDuration.Text = "0";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 407);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(816, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip1";
            // 
            // timerWork
            // 
            this.timerWork.Interval = 1000;
            this.timerWork.Tick += new System.EventHandler(this.timerWork_Tick);
            // 
            // timerBreak
            // 
            this.timerBreak.Interval = 1000;
            this.timerBreak.Tick += new System.EventHandler(this.timerBreak_Tick);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lBoxActiveBlackListApps);
            this.panel5.Controls.Add(this.lBoxActiveTrackApps);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel5.Location = new System.Drawing.Point(13, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 231);
            this.panel5.TabIndex = 16;
            // 
            // lBoxActiveBlackListApps
            // 
            this.lBoxActiveBlackListApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxActiveBlackListApps.FormattingEnabled = true;
            this.lBoxActiveBlackListApps.HorizontalScrollbar = true;
            this.lBoxActiveBlackListApps.ItemHeight = 17;
            this.lBoxActiveBlackListApps.Location = new System.Drawing.Point(3, 139);
            this.lBoxActiveBlackListApps.Name = "lBoxActiveBlackListApps";
            this.lBoxActiveBlackListApps.Size = new System.Drawing.Size(177, 87);
            this.lBoxActiveBlackListApps.TabIndex = 10;
            // 
            // lBoxActiveTrackApps
            // 
            this.lBoxActiveTrackApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxActiveTrackApps.FormattingEnabled = true;
            this.lBoxActiveTrackApps.HorizontalScrollbar = true;
            this.lBoxActiveTrackApps.ItemHeight = 17;
            this.lBoxActiveTrackApps.Location = new System.Drawing.Point(3, 26);
            this.lBoxActiveTrackApps.Name = "lBoxActiveTrackApps";
            this.lBoxActiveTrackApps.Size = new System.Drawing.Size(177, 87);
            this.lBoxActiveTrackApps.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(3, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Виключення:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.label9.Location = new System.Drawing.Point(0, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Активні:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comBoxChooseDesign);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Italic);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.panel4.Location = new System.Drawing.Point(587, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 122);
            this.panel4.TabIndex = 16;
            // 
            // comBoxChooseDesign
            // 
            this.comBoxChooseDesign.BackColor = System.Drawing.SystemColors.Window;
            this.comBoxChooseDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxChooseDesign.FormattingEnabled = true;
            this.comBoxChooseDesign.Items.AddRange(new object[] {
            "DESIGN1",
            "DESIGN2",
            "DESIGN3"});
            this.comBoxChooseDesign.Location = new System.Drawing.Point(6, 32);
            this.comBoxChooseDesign.Name = "comBoxChooseDesign";
            this.comBoxChooseDesign.Size = new System.Drawing.Size(188, 25);
            this.comBoxChooseDesign.TabIndex = 17;
            this.comBoxChooseDesign.SelectedIndexChanged += new System.EventHandler(this.comBoxChooseDesign_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вибрати дизайн:";
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.паузаToolStripMenuItem.Text = "Змінити режим роботи";
            // 
            // звичайнийToolStripMenuItem
            // 
            this.звичайнийToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.звичайнийToolStripMenuItem.Name = "звичайнийToolStripMenuItem";
            this.звичайнийToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.звичайнийToolStripMenuItem.Text = "Звичайний: - Обрано";
            // 
            // ігноуватиЧорнийСписокToolStripMenuItem
            // 
            this.ігноуватиЧорнийСписокToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ігноуватиЧорнийСписокToolStripMenuItem.Name = "ігноуватиЧорнийСписокToolStripMenuItem";
            this.ігноуватиЧорнийСписокToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.ігноуватиЧорнийСписокToolStripMenuItem.Text = "Ігнорувати чорний список";
            // 
            // активнийЗавждиToolStripMenuItem
            // 
            this.активнийЗавждиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.активнийЗавждиToolStripMenuItem.Name = "активнийЗавждиToolStripMenuItem";
            this.активнийЗавждиToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.активнийЗавждиToolStripMenuItem.Text = "Активний завжди";
            // 
            // паузаToolStripMenuItem1
            // 
            this.паузаToolStripMenuItem1.Name = "паузаToolStripMenuItem1";
            this.паузаToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.паузаToolStripMenuItem1.Text = "Пауза";
            // 
            // вімкToolStripMenuItem
            // 
            this.вімкToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.вімкToolStripMenuItem.Name = "вімкToolStripMenuItem";
            this.вімкToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.вімкToolStripMenuItem.Text = "Увімкнути";
            // 
            // вимкToolStripMenuItem
            // 
            this.вимкToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.вимкToolStripMenuItem.Name = "вимкToolStripMenuItem";
            this.вимкToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.вимкToolStripMenuItem.Text = "Вимкнути";
            // 
            // timerCheckActive
            // 
            this.timerCheckActive.Interval = 5000;
            this.timerCheckActive.Tick += new System.EventHandler(this.timerCheckActive_Tick);
            // 
            // timerInterruptUser
            // 
            this.timerInterruptUser.Tick += new System.EventHandler(this.timerInterruptUser_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TIME CONTROLLER";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(816, 429);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(834, 476);
            this.MinimumSize = new System.Drawing.Size(834, 476);
            this.Name = "MainForm";
            this.Text = "TIME CONTROLLER";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbClockStatus;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackAppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackListAppsToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBoxDisableKeyboard;
        private System.Windows.Forms.CheckBox chBoxDisableMouse;
        private System.Windows.Forms.CheckBox chBoxPlaySound;
        private System.Windows.Forms.CheckBox chBoxShowMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comBoxWorkDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxBreakDuration;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem interfaceColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem design1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem design2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem design3ToolStripMenuItem;
        private System.Windows.Forms.Timer timerWork;
        private System.Windows.Forms.Timer timerBreak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comBoxChooseDesign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звичайнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ігноуватиЧорнийСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem активнийЗавждиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вімкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вимкToolStripMenuItem;
        private System.Windows.Forms.ListBox lBoxActiveTrackApps;
        private System.Windows.Forms.Timer timerCheckActive;
        private System.Windows.Forms.Timer timerInterruptUser;
        private System.Windows.Forms.ListBox lBoxActiveBlackListApps;
        private System.Windows.Forms.ToolStripMenuItem режимРоботиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackBlackListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таймерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTimerToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnReduceForm;
        public System.Windows.Forms.Label lbTimeLefted;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

