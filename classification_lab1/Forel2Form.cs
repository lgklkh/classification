using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classification_lab1
{
    public partial class Forel2Form : Form
    {
        double[,] testMatrix;
        nPoint centerPoint;
        double radius;

        public Forel2Form()
        {
            InitializeComponent();
        }

        private void Forel2Form_Load(object sender, EventArgs e)
        {
            numericUpDownNumberOfDimensions.Value = 2;
            numericUpDownAmountOfPoints.Value = 5;
        }

        private void numericUpDownAmountOfPoints_ValueChanged(object sender, EventArgs e)
        {
            int numberOfnPoints = Convert.ToInt32(numericUpDownAmountOfPoints.Value);
            int numberOfDimensions = Convert.ToInt32(numericUpDownNumberOfDimensions.Value);

            // create CoordinateMatrix table
            DataTable dt = new DataTable();

            for (int i = 0; i <= numberOfDimensions; i++)
            {
                dt.Columns.Add(i.ToString());
            }

            for (int i = 0; i <= numberOfnPoints; i++)
            {
                dt.Rows.Add();
            }

            dataGridViewCoordinateMatrix.DataSource = dt;

            for (int i = 0; i <= numberOfDimensions; i++)
            {
                dataGridViewCoordinateMatrix[i, 0].Value = "S" + i;
                dataGridViewCoordinateMatrix.Columns[i].Width = 40;
            }

            for (int i = 0; i <= numberOfnPoints; i++)
            {
                dataGridViewCoordinateMatrix[0, i].Value = "M" + i;
                dataGridViewCoordinateMatrix.Rows[i].Height = 25;
            }

            dataGridViewCoordinateMatrix[0, 0].Value = "№";

            dataGridViewCoordinateMatrix.Height = (numberOfnPoints + 1) * 25 + 3;
            dataGridViewCoordinateMatrix.Width = (numberOfDimensions + 1) * 40 + 3;
            dataGridViewCoordinateMatrix.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewCoordinateMatrix.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;

            // create Classes table
            dt = new DataTable();

            dt.Columns.Add(1.ToString()); dt.Columns.Add(2.ToString()); dt.Columns.Add(3.ToString()); dt.Columns.Add(4.ToString());

            for (int i = 0; i <= numberOfnPoints; i++)
            {
                dt.Rows.Add();
            }

            dataGridViewClassTable.DataSource = dt;

            dataGridViewClassTable[1, 0].Value = "C(i)";
            dataGridViewClassTable[2, 0].Value = "{,,,}";
            dataGridViewClassTable[3, 0].Value = "R";
            for (int i = 0; i <= numberOfnPoints; i++)
            {
                dataGridViewClassTable[0, i].Value = "Class " + i;
                dataGridViewClassTable.Rows[i].Height = 25;
            }
            dataGridViewClassTable[0, 0].Value = "";
            dataGridViewClassTable.Columns[0].Width = 60;
            dataGridViewClassTable.Columns[1].Width = 90;
            dataGridViewClassTable.Columns[2].Width = 200;
            dataGridViewClassTable.Columns[3].Width = 60;
            dataGridViewClassTable.Width = 410 + 3;
            dataGridViewClassTable.Height = 50;
            dataGridViewClassTable.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewClassTable.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewClassTable.Location =
                new Point(dataGridViewCoordinateMatrix.Location.X + dataGridViewCoordinateMatrix.Width + 30,
                dataGridViewCoordinateMatrix.Location.Y);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            --numericUpDownAmountOfPoints.Value;
            ++numericUpDownAmountOfPoints.Value;

            testMatrix = new double[Convert.ToInt32(numericUpDownNumberOfDimensions.Value),
                Convert.ToInt32(numericUpDownAmountOfPoints.Value)];

            Random random = new Random();
            for (int i = 0; i < numericUpDownNumberOfDimensions.Value; i++)
            {
                for (int j = 0; j < numericUpDownAmountOfPoints.Value; j++)
                {
                    testMatrix[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < numericUpDownNumberOfDimensions.Value; i++)
            {
                for (int j = 0; j < numericUpDownAmountOfPoints.Value; j++)
                {
                    dataGridViewCoordinateMatrix[i + 1, j + 1].Value = testMatrix[i, j];
                }
            }
        }

        private struct nPoint
        {
            public string name;
            public double x;
            public double y;
        }

        private double Length(nPoint x1, nPoint x2)
        {
            return Math.Sqrt(Math.Pow((x1.x - x2.x), 2) + Math.Pow((x1.y - x2.y), 2));
        }

        private double MaxRadius(List<nPoint> nPoints, nPoint center)
        {
           var maxValue = Enumerable.Range(0, nPoints.Count)
                .Select(x => Length(nPoints.ElementAt(x), center))
                .ToArray().Max();
            return maxValue;
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            List<nPoint> bufferAll = new List<nPoint>();
            List<nPoint> bufferInternal = new List<nPoint>();
            for (int i = 0; i < numericUpDownAmountOfPoints.Value; i++)
            {
                var point = new nPoint()
                {
                    name = "M" + (i + 1),
                    x = testMatrix[0, i],
                    y = testMatrix[1, i]
                };
                bufferAll.Add(point);
            }


            for (int i = 1; bufferAll.Count != 0; i++)
            {
                // step 1
                bufferInternal.AddRange(bufferAll);
                centerPoint.x = bufferAll.Average(x => x.x);
                centerPoint.y = bufferAll.Average(x => x.y);

                radius = MaxRadius(bufferAll, centerPoint);


                // step 2
                while (true)
                {
                    radius *= 0.95;

                    for (int j = 0; j < bufferInternal.Count; j++)
                    {
                        var point = bufferInternal.ElementAt(j);
                        if (Length(point, bufferInternal.First()) > radius)
                        {
                            bufferInternal.Remove(point);
                        }
                    }

                    // step 3
                    var centerGravity = new nPoint()
                    {
                        x = bufferInternal.Average(x => x.x),
                        y = bufferInternal.Average(x => x.y)
                    };

                    // step 5
                    if (centerGravity.x == centerPoint.x && centerGravity.y == centerPoint.y)
                    {
                        bufferAll.RemoveAll(item => bufferInternal.Contains(item));
                        break;
                    }
                    else
                    {
                        centerPoint.x = centerGravity.x;
                        centerPoint.y = centerGravity.y;
                    }
                }

                // step 6
                dataGridViewClassTable[1, i].Value = string.Format("C{0}({1};{2})", i, Math.Round(centerPoint.x, 2), Math.Round(centerPoint.y, 2));
                dataGridViewClassTable[2, i].Value = string.Join(" ", bufferInternal.Select(x => x.name));
                dataGridViewClassTable[3, i].Value = (bufferInternal.Count == 1) ? 0 : Math.Round(radius, 2);
                dataGridViewClassTable.Height = (i + 1) * 25;
                bufferInternal.RemoveRange(0, bufferInternal.Count);
            }
        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            Graphics gpanel = Graphics.FromHwnd(panelGraph.Handle);
            gpanel.Clear(SystemColors.Control);
            var startSys = new { x = panelGraph.Width / 12, y = panelGraph.Height / 12 };
            int k = 4;

            // draw coordinate grid
            gpanel.DrawString("X", new Font("Arial", 20),
                    new SolidBrush(Color.Black), 11 * startSys.x - 20, 11 * startSys.y);
            gpanel.DrawString("Y", new Font("Arial", 20),
                new SolidBrush(Color.Black), startSys.x - 30, startSys.y);
            gpanel.DrawLine(new Pen(Color.Black, 3), startSys.x, startSys.y,
                startSys.x, 11 * startSys.y);
            gpanel.DrawLine(new Pen(Color.Black, 3), startSys.x, 11 * startSys.y,
                11 * startSys.x, 11 * startSys.y);
            for (int i = 1; i < 10; i++)
            {
                gpanel.DrawLine(new Pen(Color.Black, 2), startSys.x - 5, (i + 1) * startSys.y,
                    startSys.x + 5, (i + 1) * startSys.y);
                gpanel.DrawString((10 * (10 - i)).ToString(), new Font("Arial", 10),
                    new SolidBrush(Color.Black), startSys.x - 22, (i + 1) * startSys.y - 10);

                gpanel.DrawLine(new Pen(Color.Black, 2), (i + 1) * startSys.x, 11 * startSys.y - 5,
                    (i + 1) * startSys.x, 11 * startSys.y + 5);
                gpanel.DrawString((i * 10).ToString(), new Font("Arial", 10),
                    new SolidBrush(Color.Black), (i + 1) * startSys.x - 10, 11 * startSys.y + 5);
            }

            // draw graph
            int num = Convert.ToInt32(numericUpDownAmountOfPoints.Value);
            for (int i = 1; i <= num; i++)
            {
                string name = dataGridViewCoordinateMatrix[0, i].Value.ToString();
                PointF dot = new PointF(Convert.ToSingle(dataGridViewCoordinateMatrix[1, i].Value),
                    Convert.ToSingle(dataGridViewCoordinateMatrix[2, i].Value));
                gpanel.FillEllipse(Brushes.Blue, startSys.x + (k * dot.X) - 5,
                    11 * startSys.y - (k * dot.Y) - 5, 10, 10);
                gpanel.DrawString(name, new Font("Arial", 10),
                    new SolidBrush(Color.Black), startSys.x + (k * dot.X),
                    11 * startSys.y - (k * dot.Y) - 15);
            }

            for (int i = 1; dataGridViewClassTable[1, i].Value.ToString() != ""; i++)
            {
                string name = "C" + i;
                var centerXY = dataGridViewClassTable[1, i].Value.ToString().Replace(name, "").
                    Replace("(", "").Replace(")", "").Split(';');
                PointF dot = new PointF(Convert.ToSingle(centerXY[0]),
                    Convert.ToSingle(centerXY[1]));
                gpanel.FillEllipse(Brushes.Red, startSys.x + (k * dot.X) - 3,
                    11 * startSys.y - (k * dot.Y) - 3, 6, 6);
                gpanel.DrawString(name, new Font("Arial", 10),
                    new SolidBrush(Color.Red), startSys.x + (k * dot.X),
                    11 * startSys.y - (k * dot.Y) + 3);
                float localRadius = k * Convert.ToSingle(dataGridViewClassTable[3, i].Value);
                gpanel.DrawEllipse(new Pen(Color.Red, 2),
                    startSys.x + (k * dot.X) - localRadius,
                    11 * startSys.y - (k * dot.Y) - localRadius,
                    2 * localRadius,
                    2 * localRadius);
            }
        }
    }
}
