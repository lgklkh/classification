﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace classification_lab1
{
    public partial class SpectrForm : Form
    {
        public SpectrForm()
        {
            InitializeComponent();
        }

        private void SpectrForm_Load(object sender, EventArgs e)
        {
            numericUpDownNumber.Value = 15;
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numericUpDownNumber.Value);
            DataTable dt = new DataTable();

            for (int i = 0; i <= number; i++)
            {
                dt.Columns.Add(i.ToString());
                dt.Rows.Add();
            }

            dataGridViewMatrixOfDistances.DataSource = dt;


            dt = new DataTable();

            for (int i = 0; i <= number; i++)
            {
                dt.Columns.Add(i.ToString());
            }
            dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add();

            dataGridViewSpectrumOfBonds.DataSource = dt;


            for (int i = 0; i <= number; i++)
            {
                dataGridViewMatrixOfDistances[0, 0].Value = "№";
                dataGridViewMatrixOfDistances[i, i].Value = 0;
                dataGridViewMatrixOfDistances[0, i].Value =
                    dataGridViewMatrixOfDistances[i, 0].Value = i;
                dataGridViewSpectrumOfBonds[i, 0].Value = i - 1;
                dataGridViewMatrixOfDistances.Columns[i].Width =
                    dataGridViewMatrixOfDistances.Rows[i].Height =
                    dataGridViewSpectrumOfBonds.Columns[i].Width = 30;
                dataGridViewSpectrumOfBonds[0, 0].Value = "i";
                dataGridViewSpectrumOfBonds[0, 1].Value = "B(i)";
                dataGridViewSpectrumOfBonds[1, 1].Value = "1";
                dataGridViewSpectrumOfBonds[0, 2].Value = "C(i)";
                dataGridViewSpectrumOfBonds[1, 2].Value = "0";
            }

            dataGridViewMatrixOfDistances.Height =
                dataGridViewMatrixOfDistances.Width =
                dataGridViewSpectrumOfBonds.Width = (number + 1) * 30 + 3;
            dataGridViewSpectrumOfBonds.Height = 3 * 30 - 21;
            dataGridViewSpectrumOfBonds.Location =
                new Point(dataGridViewMatrixOfDistances.Location.X, dataGridViewMatrixOfDistances.Location.Y + dataGridViewMatrixOfDistances.Height + 30);
            dataGridViewSpectrumOfBonds.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewSpectrumOfBonds.Columns[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            Graphics gpanel = Graphics.FromHwnd(panelGraph.Handle);
            gpanel.Clear(SystemColors.Control);
            var startSys = new { x = panelGraph.Width / 12, y = panelGraph.Height / 12 };

            // draw coordinate grid
            gpanel.DrawLine(new Pen(Color.Black, 3), startSys.x, startSys.y,
                startSys.x, 11 * startSys.y);
            gpanel.DrawLine(new Pen(Color.Black, 3), startSys.x, 11 * startSys.y,
                11 * startSys.x, 11 * startSys.y);

            // draw graph
            int num = Convert.ToInt32(numericUpDownNumber.Value);
            List<double> blockC = new List<double>();
            for(int i = 1; i <= num; i++)            
                blockC.Add(Convert.ToDouble(dataGridViewSpectrumOfBonds[i, 2].Value));

            List<PointF> points = new List<PointF>();
            for (int i = 1; i <= num; i++)
            {
                int x = Convert.ToInt32(dataGridViewSpectrumOfBonds[i, 0].Value);
                double y = Convert.ToDouble(dataGridViewSpectrumOfBonds[i, 2].Value);
                PointF dot = new PointF(startSys.x - 6 + x * (10 * startSys.x / num),
                    Convert.ToSingle(11 * startSys.y - 6 - y * (10 * startSys.x / blockC.Max())));
                points.Add(new PointF(dot.X + 6, dot.Y + 6));
                gpanel.FillEllipse(Brushes.Blue, dot.X, dot.Y, 12, 12);
                gpanel.DrawString(dataGridViewSpectrumOfBonds[i, 1].Value.ToString(), new Font("Arial", 14),
                    new SolidBrush(Color.Black), dot.X, dot.Y + 20);
            }
            gpanel.DrawLines(new Pen(Color.Blue, 2), points.ToArray());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            double[,] testMatrix = new double[,] {
                {0,5,7,1.4,5,3.5,1.6,1.4,1.2,1.3,1.7,1.6,1.4,1.3,1.2},
                {5,0,7,2,3.5,5,2.2,1.9,1.6,1.7,2,1.7,1.6,1.4,1.4 },
                {7,7,0,1.7,7,7,2,1.6,1.4,1.6,2.2,2,1.7,1.6,1.5 },
                {1.4,2,1.7,0,1.4,2,7,10,7,5,1.8,1.4,1.7,1.4,1.5 },
                {5,3.5,7,1.4,0,5,1.7,1.4,1.3,1.4,2.4,2.2,1.8,1.7,1.6 },
                {3.5,5,7,2,5,0,2.5,2,1.7,2,3.2,2.5,2.2,2,1.9 },
                {1.6,2.2,2,7,1.7,2.5,0,10,5,7,2.4,1.8,2.2,1.7,1.9 },
                {1.4,1.9,1.6,10,1.4,2,10,0,10,10,2,1.6,2,1.6,1.7 },
                {1.2,1.6,1.4,7,1.3,1.7,5,10,0,7,1.7,1.4,1.8,1.4,1.6 },
                {1.3,1.7,1.6,5,1.4,2,7,10,7,0,2.2,1.7,2.4,1.8,2 },
                {1.7,2,2.2,1.8,2.4,3.2,2.4,2,1.7,2.2,0,7,7,5,4.5 },
                {1.6,1.7,2,1.4,2.2,2.5,1.8,1.6,1.4,1.7,7,0,5,7,4.5 },
                {1.4,1.6,1.7,1.7,1.8,2.2,2.2,2,1.8,2.4,7,5,0,7,10 },
                {1.3,1.4,1.6,1.4,1.7,2,1.7,1.6,1.4,1.8,5,7,7,0,10 },
                {1.2,1.4,1.5,1.5,1.6,1.9,1.9,1.7,1.6,2,4.5,4.5,10,10,0 }
            };

            for (int i = 0; i < numericUpDownNumber.Value; i++)
            {
                for (int j = 0; j < numericUpDownNumber.Value; j++)
                {
                    dataGridViewMatrixOfDistances[i + 1, j + 1].Value = testMatrix[j, i];
                }
            }
        }

        private double DistancePower(List<int> blockB, int x)
        {
            double power = 0;
            foreach(var item in blockB)
            {
                power += Convert.ToDouble(dataGridViewMatrixOfDistances[item, x].Value);
            }
            return power / blockB.Count;
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            List<int> blockB = new List<int>();
            blockB.Add(1);
            var xNext = new { index = 1, distance = 0.0 };

            while (blockB.Count < numericUpDownNumber.Value)
            {
                for (int x = 1; x <= numericUpDownNumber.Value; x++)
                {
                    if (!blockB.Contains(x))
                    {
                        double xDistance = Math.Round(DistancePower(blockB, x), 2);
                        if (xDistance > xNext.distance)
                        {
                            xNext = new { index = x, distance = xDistance };
                        }
                    }
                }
                blockB.Add(xNext.index);
                dataGridViewSpectrumOfBonds[blockB.Count, 1].Value = xNext.index;
                dataGridViewSpectrumOfBonds[blockB.Count, 2].Value = xNext.distance;
                xNext = new { index = 0, distance = 0.0 };

                if(blockB.Count > 2 && Convert.ToDouble(dataGridViewSpectrumOfBonds[blockB.Count - 2, 2].Value) >
                    Convert.ToDouble(dataGridViewSpectrumOfBonds[blockB.Count - 1, 2].Value) &&
                    Convert.ToDouble(dataGridViewSpectrumOfBonds[blockB.Count - 1, 2].Value) < 
                    Convert.ToDouble(dataGridViewSpectrumOfBonds[blockB.Count, 2].Value))
                {
                    dataGridViewSpectrumOfBonds.Columns[blockB.Count - 1].DefaultCellStyle.BackColor = Color.Pink;
                }
            }   
        }
    }
}
