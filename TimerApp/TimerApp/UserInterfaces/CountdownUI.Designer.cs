namespace TimerApp.UserInterfaces
{
    partial class countdownForm
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
            components = new System.ComponentModel.Container();
            menuLayout = new TableLayoutPanel();
            stopwatchBtn = new Button();
            countdownBtn = new Button();
            countdownTimer = new System.Windows.Forms.Timer(components);
            menuLayout.SuspendLayout();
            SuspendLayout();
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
            menuLayout.TabIndex = 3;
            // 
            // stopwatchBtn
            // 
            stopwatchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stopwatchBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
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
            countdownBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            countdownBtn.Location = new Point(145, 3);
            countdownBtn.Name = "countdownBtn";
            countdownBtn.Size = new Size(136, 31);
            countdownBtn.TabIndex = 1;
            countdownBtn.Text = "Countdown";
            countdownBtn.UseVisualStyleBackColor = true;
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 1000;
            // 
            // countdownForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(menuLayout);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "countdownForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Countdown";
            TopMost = true;
            menuLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel menuLayout;
        private Button stopwatchBtn;
        private Button countdownBtn;
        private System.Windows.Forms.Timer countdownTimer;
    }
}