namespace TimerApp
{
    partial class stopwatchForm
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
            startLapBtn = new Button();
            stopBtn = new Button();
            menuLayout = new TableLayoutPanel();
            stopwatchBtn = new Button();
            countdownBtn = new Button();
            stopwatchTimer = new System.Windows.Forms.Timer(components);
            timeTableGV = new DataGridView();
            lapCol = new DataGridViewTextBoxColumn();
            startCol = new DataGridViewTextBoxColumn();
            lapEndCol = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            resetBtn = new Button();
            menuLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeTableGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // startLapBtn
            // 
            startLapBtn.BackColor = Color.FromArgb(128, 255, 128);
            startLapBtn.Dock = DockStyle.Fill;
            startLapBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            startLapBtn.Location = new Point(3, 3);
            startLapBtn.Name = "startLapBtn";
            startLapBtn.Size = new Size(136, 58);
            startLapBtn.TabIndex = 0;
            startLapBtn.Text = "[Start/Lap]";
            startLapBtn.UseVisualStyleBackColor = false;
            // 
            // stopBtn
            // 
            stopBtn.BackColor = Color.FromArgb(255, 128, 128);
            stopBtn.Dock = DockStyle.Fill;
            stopBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            stopBtn.Location = new Point(145, 3);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(136, 58);
            stopBtn.TabIndex = 1;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = false;
            // 
            // menuLayout
            // 
            menuLayout.ColumnCount = 2;
            menuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            menuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            menuLayout.Controls.Add(stopwatchBtn, 0, 0);
            menuLayout.Controls.Add(countdownBtn, 1, 0);
            menuLayout.Dock = DockStyle.Top;
            menuLayout.Location = new Point(0, 0);
            menuLayout.Name = "menuLayout";
            menuLayout.RowCount = 1;
            menuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            menuLayout.Size = new Size(284, 37);
            menuLayout.TabIndex = 2;
            // 
            // stopwatchBtn
            // 
            stopwatchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stopwatchBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stopwatchBtn.Location = new Point(3, 3);
            stopwatchBtn.Name = "stopwatchBtn";
            stopwatchBtn.Size = new Size(136, 31);
            stopwatchBtn.TabIndex = 0;
            stopwatchBtn.Text = "Stopwatch";
            stopwatchBtn.UseVisualStyleBackColor = true;
            // 
            // countdownBtn
            // 
            countdownBtn.Dock = DockStyle.Fill;
            countdownBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countdownBtn.Location = new Point(145, 3);
            countdownBtn.Name = "countdownBtn";
            countdownBtn.Size = new Size(136, 31);
            countdownBtn.TabIndex = 1;
            countdownBtn.Text = "Countdown";
            countdownBtn.UseVisualStyleBackColor = true;
            // 
            // stopwatchTimer
            // 
            stopwatchTimer.Interval = 1000;
            // 
            // timeTableGV
            // 
            timeTableGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timeTableGV.Columns.AddRange(new DataGridViewColumn[] { lapCol, startCol, lapEndCol });
            timeTableGV.Dock = DockStyle.Fill;
            timeTableGV.Location = new Point(3, 3);
            timeTableGV.Name = "timeTableGV";
            timeTableGV.RowHeadersVisible = false;
            timeTableGV.Size = new Size(272, 269);
            timeTableGV.TabIndex = 3;
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
            startCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            startCol.HeaderText = "Start";
            startCol.Name = "startCol";
            startCol.Resizable = DataGridViewTriState.False;
            startCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            startCol.Width = 37;
            // 
            // lapEndCol
            // 
            lapEndCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            lapEndCol.HeaderText = "Lap/End";
            lapEndCol.Name = "lapEndCol";
            lapEndCol.Resizable = DataGridViewTriState.False;
            lapEndCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            lapEndCol.Width = 57;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(timeTableGV, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(278, 275);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(resetBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(startLapBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(stopBtn, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 324);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(284, 137);
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
            resetBtn.Size = new Size(278, 67);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // stopwatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuLayout);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "stopwatchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stopwatch";
            TopMost = true;
            Load += main_Load;
            menuLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timeTableGV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button startLapBtn;
        private Button stopBtn;
        private TableLayoutPanel menuLayout;
        private Button stopwatchBtn;
        private Button countdownBtn;
        private System.Windows.Forms.Timer stopwatchTimer;
        private DataGridView timeTableGV;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn lapCol;
        private DataGridViewTextBoxColumn startCol;
        private DataGridViewTextBoxColumn lapEndCol;
        private TableLayoutPanel tableLayoutPanel2;
        private Button resetBtn;
    }
}
