namespace TimerApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            startStopwatchBtn = new Button();
            stopStopwatchBtn = new Button();
            stopwatchTimer = new System.Windows.Forms.Timer(components);
            timeTableGV = new DataGridView();
            lapCol = new DataGridViewTextBoxColumn();
            startCol = new DataGridViewTextBoxColumn();
            lapEndCol = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            resetBtn = new Button();
            tabControl = new TabControl();
            stopTab = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            currentStopwatchLbl = new Label();
            downTab = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            secondUD = new NumericUpDown();
            secondLbl = new Label();
            minuteUD = new NumericUpDown();
            minuteLbl = new Label();
            hourLbl = new Label();
            hourUD = new NumericUpDown();
            tableLayoutPanel3 = new TableLayoutPanel();
            pauseCountdownBtn = new Button();
            startCountdownBtn = new Button();
            cancelCountdownBtn = new Button();
            remainingLbl = new Label();
            settingsTab = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            stopSetLbl = new Label();
            comboBox7 = new ComboBox();
            label7 = new Label();
            comboBox6 = new ComboBox();
            label6 = new Label();
            comboBox5 = new ComboBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            countSetLbl = new Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)timeTableGV).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tabControl.SuspendLayout();
            stopTab.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            downTab.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hourUD).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            settingsTab.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // startStopwatchBtn
            // 
            startStopwatchBtn.BackColor = Color.FromArgb(128, 255, 128);
            startStopwatchBtn.Dock = DockStyle.Fill;
            startStopwatchBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            startStopwatchBtn.Location = new Point(3, 3);
            startStopwatchBtn.Name = "startStopwatchBtn";
            startStopwatchBtn.Size = new Size(126, 58);
            startStopwatchBtn.TabIndex = 0;
            startStopwatchBtn.Text = "&Start";
            startStopwatchBtn.UseVisualStyleBackColor = false;
            startStopwatchBtn.Click += startStopwatchBtn_Click;
            // 
            // stopStopwatchBtn
            // 
            stopStopwatchBtn.BackColor = Color.FromArgb(255, 128, 128);
            stopStopwatchBtn.Dock = DockStyle.Fill;
            stopStopwatchBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            stopStopwatchBtn.Location = new Point(135, 3);
            stopStopwatchBtn.Name = "stopStopwatchBtn";
            stopStopwatchBtn.Size = new Size(127, 58);
            stopStopwatchBtn.TabIndex = 1;
            stopStopwatchBtn.Text = "S&top";
            stopStopwatchBtn.UseVisualStyleBackColor = false;
            stopStopwatchBtn.Click += stopStopwatchBtn_Click;
            // 
            // stopwatchTimer
            // 
            stopwatchTimer.Tick += StopwatchTimer_Tick;
            // 
            // timeTableGV
            // 
            timeTableGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timeTableGV.Columns.AddRange(new DataGridViewColumn[] { lapCol, startCol, lapEndCol });
            timeTableGV.Dock = DockStyle.Fill;
            timeTableGV.Location = new Point(3, 47);
            timeTableGV.Name = "timeTableGV";
            timeTableGV.RowHeadersVisible = false;
            timeTableGV.Size = new Size(259, 240);
            timeTableGV.TabIndex = 3;
            timeTableGV.Visible = false;
            // 
            // lapCol
            // 
            lapCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            lapCol.HeaderText = "Lap Count";
            lapCol.Name = "lapCol";
            lapCol.Resizable = DataGridViewTriState.False;
            lapCol.Width = 87;
            // 
            // startCol
            // 
            startCol.HeaderText = "Start";
            startCol.Name = "startCol";
            startCol.Resizable = DataGridViewTriState.False;
            startCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            startCol.Width = 90;
            // 
            // lapEndCol
            // 
            lapEndCol.HeaderText = "Lap/End";
            lapEndCol.Name = "lapEndCol";
            lapEndCol.Resizable = DataGridViewTriState.False;
            lapEndCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            lapEndCol.Width = 90;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(resetBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(startStopwatchBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(stopStopwatchBtn, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(3, 293);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(265, 137);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.ControlDark;
            tableLayoutPanel2.SetColumnSpan(resetBtn, 2);
            resetBtn.Dock = DockStyle.Fill;
            resetBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            resetBtn.Location = new Point(3, 67);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(259, 67);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "&Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(stopTab);
            tabControl.Controls.Add(downTab);
            tabControl.Controls.Add(settingsTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(279, 461);
            tabControl.TabIndex = 6;
            tabControl.Click += tabControl_Click;
            // 
            // stopTab
            // 
            stopTab.Controls.Add(tableLayoutPanel6);
            stopTab.Controls.Add(tableLayoutPanel2);
            stopTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stopTab.Location = new Point(4, 24);
            stopTab.Name = "stopTab";
            stopTab.Padding = new Padding(3);
            stopTab.Size = new Size(271, 433);
            stopTab.TabIndex = 0;
            stopTab.Text = "Stopwatch";
            stopTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(currentStopwatchLbl, 0, 0);
            tableLayoutPanel6.Controls.Add(timeTableGV, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1724138F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 84.82758F));
            tableLayoutPanel6.Size = new Size(265, 290);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // currentStopwatchLbl
            // 
            currentStopwatchLbl.Anchor = AnchorStyles.None;
            currentStopwatchLbl.AutoSize = true;
            currentStopwatchLbl.Font = new Font("Segoe UI", 22F);
            currentStopwatchLbl.Location = new Point(68, 1);
            currentStopwatchLbl.Name = "currentStopwatchLbl";
            currentStopwatchLbl.Size = new Size(128, 41);
            currentStopwatchLbl.TabIndex = 10;
            currentStopwatchLbl.Text = "00:00:00";
            // 
            // downTab
            // 
            downTab.Controls.Add(tableLayoutPanel5);
            downTab.Location = new Point(4, 24);
            downTab.Name = "downTab";
            downTab.Padding = new Padding(3);
            downTab.Size = new Size(271, 433);
            downTab.TabIndex = 1;
            downTab.Text = "Countdown";
            downTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel5.Controls.Add(remainingLbl, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 37.4125862F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5874138F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel5.Size = new Size(265, 427);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.282486F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.85876F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.85876F));
            tableLayoutPanel1.Controls.Add(secondUD, 1, 2);
            tableLayoutPanel1.Controls.Add(secondLbl, 0, 2);
            tableLayoutPanel1.Controls.Add(minuteUD, 1, 1);
            tableLayoutPanel1.Controls.Add(minuteLbl, 0, 1);
            tableLayoutPanel1.Controls.Add(hourLbl, 0, 0);
            tableLayoutPanel1.Controls.Add(hourUD, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(259, 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // secondUD
            // 
            secondUD.Anchor = AnchorStyles.Left;
            secondUD.Location = new Point(133, 72);
            secondUD.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secondUD.Name = "secondUD";
            secondUD.Size = new Size(51, 23);
            secondUD.TabIndex = 5;
            // 
            // secondLbl
            // 
            secondLbl.Anchor = AnchorStyles.Right;
            secondLbl.AutoSize = true;
            secondLbl.Location = new Point(78, 76);
            secondLbl.Name = "secondLbl";
            secondLbl.Size = new Size(49, 15);
            secondLbl.TabIndex = 4;
            secondLbl.Text = "&Second:";
            // 
            // minuteUD
            // 
            minuteUD.Anchor = AnchorStyles.Left;
            minuteUD.Location = new Point(133, 38);
            minuteUD.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteUD.Name = "minuteUD";
            minuteUD.Size = new Size(51, 23);
            minuteUD.TabIndex = 3;
            // 
            // minuteLbl
            // 
            minuteLbl.Anchor = AnchorStyles.Right;
            minuteLbl.AutoSize = true;
            minuteLbl.Location = new Point(79, 42);
            minuteLbl.Name = "minuteLbl";
            minuteLbl.Size = new Size(48, 15);
            minuteLbl.TabIndex = 2;
            minuteLbl.Text = "&Minute:";
            // 
            // hourLbl
            // 
            hourLbl.Anchor = AnchorStyles.Right;
            hourLbl.AutoSize = true;
            hourLbl.Location = new Point(90, 9);
            hourLbl.Name = "hourLbl";
            hourLbl.Size = new Size(37, 15);
            hourLbl.TabIndex = 0;
            hourLbl.Text = "&Hour:";
            // 
            // hourUD
            // 
            hourUD.Anchor = AnchorStyles.Left;
            hourUD.Location = new Point(133, 5);
            hourUD.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hourUD.Name = "hourUD";
            hourUD.Size = new Size(51, 23);
            hourUD.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pauseCountdownBtn, 0, 1);
            tableLayoutPanel3.Controls.Add(startCountdownBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(cancelCountdownBtn, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(3, 289);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(259, 135);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // pauseCountdownBtn
            // 
            pauseCountdownBtn.BackColor = Color.Orange;
            tableLayoutPanel3.SetColumnSpan(pauseCountdownBtn, 2);
            pauseCountdownBtn.Dock = DockStyle.Fill;
            pauseCountdownBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            pauseCountdownBtn.Location = new Point(3, 67);
            pauseCountdownBtn.Name = "pauseCountdownBtn";
            pauseCountdownBtn.Size = new Size(253, 65);
            pauseCountdownBtn.TabIndex = 2;
            pauseCountdownBtn.Text = "&Pause";
            pauseCountdownBtn.UseVisualStyleBackColor = false;
            // 
            // startCountdownBtn
            // 
            startCountdownBtn.BackColor = Color.FromArgb(128, 255, 128);
            startCountdownBtn.Dock = DockStyle.Fill;
            startCountdownBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            startCountdownBtn.Location = new Point(3, 3);
            startCountdownBtn.Name = "startCountdownBtn";
            startCountdownBtn.Size = new Size(123, 58);
            startCountdownBtn.TabIndex = 0;
            startCountdownBtn.Text = "St&art";
            startCountdownBtn.UseVisualStyleBackColor = false;
            // 
            // cancelCountdownBtn
            // 
            cancelCountdownBtn.BackColor = Color.FromArgb(255, 128, 128);
            cancelCountdownBtn.Dock = DockStyle.Fill;
            cancelCountdownBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            cancelCountdownBtn.Location = new Point(132, 3);
            cancelCountdownBtn.Name = "cancelCountdownBtn";
            cancelCountdownBtn.Size = new Size(124, 58);
            cancelCountdownBtn.TabIndex = 1;
            cancelCountdownBtn.Text = "&Cancel";
            cancelCountdownBtn.UseVisualStyleBackColor = false;
            // 
            // remainingLbl
            // 
            remainingLbl.Anchor = AnchorStyles.None;
            remainingLbl.AutoSize = true;
            remainingLbl.Font = new Font("Segoe UI", 22F);
            remainingLbl.Location = new Point(51, 176);
            remainingLbl.Name = "remainingLbl";
            remainingLbl.Size = new Size(162, 41);
            remainingLbl.TabIndex = 9;
            remainingLbl.Text = "[hh:mm:ss]";
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(tableLayoutPanel4);
            settingsTab.Location = new Point(4, 24);
            settingsTab.Name = "settingsTab";
            settingsTab.Size = new Size(271, 433);
            settingsTab.TabIndex = 2;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(stopSetLbl, 0, 0);
            tableLayoutPanel4.Controls.Add(comboBox7, 1, 8);
            tableLayoutPanel4.Controls.Add(label7, 0, 8);
            tableLayoutPanel4.Controls.Add(comboBox6, 1, 7);
            tableLayoutPanel4.Controls.Add(label6, 0, 7);
            tableLayoutPanel4.Controls.Add(comboBox5, 1, 6);
            tableLayoutPanel4.Controls.Add(label5, 0, 6);
            tableLayoutPanel4.Controls.Add(comboBox4, 1, 5);
            tableLayoutPanel4.Controls.Add(label4, 0, 5);
            tableLayoutPanel4.Controls.Add(comboBox3, 1, 3);
            tableLayoutPanel4.Controls.Add(label3, 0, 3);
            tableLayoutPanel4.Controls.Add(comboBox2, 1, 2);
            tableLayoutPanel4.Controls.Add(label2, 0, 2);
            tableLayoutPanel4.Controls.Add(label1, 0, 1);
            tableLayoutPanel4.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel4.Controls.Add(countSetLbl, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1076546F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1120977F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1121F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1121F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1076546F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1120977F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1121F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1121F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1121F));
            tableLayoutPanel4.Size = new Size(271, 433);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // stopSetLbl
            // 
            stopSetLbl.Anchor = AnchorStyles.Left;
            stopSetLbl.AutoSize = true;
            tableLayoutPanel4.SetColumnSpan(stopSetLbl, 2);
            stopSetLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopSetLbl.Location = new Point(3, 13);
            stopSetLbl.Name = "stopSetLbl";
            stopSetLbl.Size = new Size(157, 21);
            stopSetLbl.TabIndex = 14;
            stopSetLbl.Text = "Stopwatch Settings";
            // 
            // comboBox7
            // 
            comboBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(138, 397);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(130, 23);
            comboBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(77, 401);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "setting 7:";
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(138, 348);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(130, 23);
            comboBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(77, 352);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "setting 6:";
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(138, 300);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(130, 23);
            comboBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(77, 304);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "setting 5:";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(138, 252);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(130, 23);
            comboBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(77, 256);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "setting 4:";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(138, 156);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(130, 23);
            comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(77, 160);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "setting 3:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(138, 108);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(130, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(77, 112);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "setting 2:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(77, 64);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "setting 1:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 1;
            // 
            // countSetLbl
            // 
            countSetLbl.Anchor = AnchorStyles.Left;
            countSetLbl.AutoSize = true;
            tableLayoutPanel4.SetColumnSpan(countSetLbl, 2);
            countSetLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            countSetLbl.Location = new Point(3, 205);
            countSetLbl.Name = "countSetLbl";
            countSetLbl.Size = new Size(165, 21);
            countSetLbl.TabIndex = 15;
            countSetLbl.Text = "Countdown Settings";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 461);
            Controls.Add(tabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stopwatch";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)timeTableGV).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            stopTab.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            downTab.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secondUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)minuteUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)hourUD).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            settingsTab.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button startStopwatchBtn;
        private Button stopStopwatchBtn;
        private System.Windows.Forms.Timer stopwatchTimer;
        private DataGridView timeTableGV;
        private TableLayoutPanel tableLayoutPanel2;
        private Button resetBtn;
        private TabControl tabControl;
        private TabPage stopTab;
        private TabPage downTab;
        private System.Windows.Forms.Timer countdownTimer;
        private TableLayoutPanel tableLayoutPanel1;
        private Label hourLbl;
        private NumericUpDown hourUD;
        private NumericUpDown secondUD;
        private Label secondLbl;
        private NumericUpDown minuteUD;
        private Label minuteLbl;
        private TabPage settingsTab;
        private TableLayoutPanel tableLayoutPanel3;
        private Button pauseCountdownBtn;
        private Button startCountdownBtn;
        private Button cancelCountdownBtn;
        private TableLayoutPanel tableLayoutPanel5;
        private Label remainingLbl;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox comboBox7;
        private Label label7;
        private ComboBox comboBox6;
        private Label label6;
        private ComboBox comboBox5;
        private Label label5;
        private ComboBox comboBox4;
        private Label label4;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label stopSetLbl;
        private Label countSetLbl;
        private DataGridViewTextBoxColumn lapCol;
        private DataGridViewTextBoxColumn startCol;
        private DataGridViewTextBoxColumn lapEndCol;
        private TableLayoutPanel tableLayoutPanel6;
        private Label currentStopwatchLbl;
    }
}
