using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TransferDataManagement
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void tbModel_Click(object sender, EventArgs e)
		{
			var p = double.Parse(tbP.Text);
			var l = int.Parse(tbL.Text);
			var k = 10;
			List<KeyValuePair<int, double>> points = new List<KeyValuePair<int, double>>();
			var step = 10;
			var rnd = new Random();
			while (k <= 2000)
			{
				if (k >= 100 && step == 10)
					step = 100;

				int v = 0;
				int n = k;

				for (int i = 0; i < k; i++)
					if (p <= rnd.NextDouble())
					{
						v++;
						n++;
					}
				var r0 = ((double)k * (n - v)) / ((k + l) * n);
				points.Add(new KeyValuePair<int, double>(k, r0));

				k += step;
			}

			chart1.Series.First().Points.Clear();
			foreach (var point in points)
			{
				chart1.Series.First().Points.Add(new DataPoint(point.Key, point.Value));
			}
		}
	}
}
