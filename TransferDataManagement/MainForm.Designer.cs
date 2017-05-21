namespace TransferDataManagement
{
	partial class MainForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tbModel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbL = new System.Windows.Forms.TextBox();
			this.tbP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(175, 12);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(339, 336);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// tbModel
			// 
			this.tbModel.Location = new System.Drawing.Point(46, 88);
			this.tbModel.Name = "tbModel";
			this.tbModel.Size = new System.Drawing.Size(75, 23);
			this.tbModel.TabIndex = 1;
			this.tbModel.Text = "Modeling";
			this.tbModel.UseVisualStyleBackColor = true;
			this.tbModel.Click += new System.EventHandler(this.tbModel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(9, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "l";
			// 
			// tbL
			// 
			this.tbL.Location = new System.Drawing.Point(69, 12);
			this.tbL.Name = "tbL";
			this.tbL.Size = new System.Drawing.Size(100, 20);
			this.tbL.TabIndex = 3;
			// 
			// tbP
			// 
			this.tbP.Location = new System.Drawing.Point(69, 38);
			this.tbP.Name = "tbP";
			this.tbP.Size = new System.Drawing.Size(100, 20);
			this.tbP.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "p";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 360);
			this.Controls.Add(this.tbP);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbL);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbModel);
			this.Controls.Add(this.chart1);
			this.Name = "MainForm";
			this.Text = "Transfer data management";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button tbModel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbL;
		private System.Windows.Forms.TextBox tbP;
		private System.Windows.Forms.Label label2;
	}
}

