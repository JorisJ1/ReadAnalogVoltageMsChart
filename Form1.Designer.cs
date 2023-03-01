namespace TestRealtimeChart2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblPortStatus = new System.Windows.Forms.Label();
            this.PortCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.ChartRefreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.IsSoftShadows = false;
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(800, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(313, 495);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "BtnStart";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblPortStatus
            // 
            this.LblPortStatus.AutoSize = true;
            this.LblPortStatus.Location = new System.Drawing.Point(546, 485);
            this.LblPortStatus.Name = "LblPortStatus";
            this.LblPortStatus.Size = new System.Drawing.Size(113, 13);
            this.LblPortStatus.TabIndex = 2;
            this.LblPortStatus.Text = "Checking port status...";
            // 
            // PortCheckTimer
            // 
            this.PortCheckTimer.Enabled = true;
            this.PortCheckTimer.Interval = 500;
            this.PortCheckTimer.Tick += new System.EventHandler(this.PortCheckTimer_Tick);
            // 
            // ChartRefreshTimer
            // 
            this.ChartRefreshTimer.Enabled = true;
            this.ChartRefreshTimer.Interval = 1000;
            this.ChartRefreshTimer.Tick += new System.EventHandler(this.ChartRefreshTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 559);
            this.Controls.Add(this.LblPortStatus);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblPortStatus;
        private System.Windows.Forms.Timer PortCheckTimer;
        private System.Windows.Forms.Timer ChartRefreshTimer;
    }
}

