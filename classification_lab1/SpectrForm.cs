using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace classification_lab1
{
    public partial class SpectrForm : Form
    {
        int number;
        int metrik;

        double[,] testDataset;
        int[] classDataset;
        double[,] testMatrix;

        public SpectrForm()
        {
            InitializeComponent();
        }

        private void SpectrForm_Load(object sender, EventArgs e)
        {
            numericUpDownNumber.Value = 15;

            zedGraph.PointValueEvent +=
                new ZedGraphControl.PointValueHandler(zedGraph_PointValueEvent);
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numericUpDownNumber.Value);
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
            dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add();

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
                dataGridViewSpectrumOfBonds[0, 3].Value = "#";
            }

            dataGridViewSpectrumOfBonds.DefaultCellStyle.BackColor = Color.White;
            dataGridViewSpectrumOfBonds.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewSpectrumOfBonds.Columns[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void numericUpDownMetrik_ValueChanged(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numericUpDownNumber.Value);
            metrik = Convert.ToInt32(numericUpDownMetrik.Value) - 1;

            DataTable dt = new DataTable();

            for (int i = 0; i <= metrik; i++)
            {
                dt.Columns.Add(i.ToString());
            }
            for (int i = 0; i <= number; i++)
            {
                dt.Rows.Add();
            }

            dataGridViewMatrixDataset.DataSource = dt;

            for (int i = 0; i <= number; i++)
            {
                dataGridViewMatrixDataset[0, i].Value = i;
                for (int j = 0; j <= metrik; j++)
                {
                    dataGridViewMatrixDataset[j, 0].Value = j;
                    dataGridViewMatrixDataset.Columns[j].Width = 60;
                    dataGridViewMatrixDataset.Rows[i].Height = 30;
                }
            }

            dataGridViewMatrixDataset[0, 0].Value = "№";
            dataGridViewMatrixDataset.Rows[0].DefaultCellStyle.BackColor =
            dataGridViewMatrixDataset.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;

        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();
            pane.Title.Text = "Спектр близкостей";
            pane.YAxis.Title.Text = "Величина зв'язку";
            pane.XAxis.IsVisible = false;
            pane.XAxis.Title.Text = "Номер ітерації";
            PointPairList list = new PointPairList();
            for (int i = 1; i <= numericUpDownNumber.Value; i++)
            {
                list.Add(Convert.ToDouble(i), Convert.ToDouble(dataGridViewSpectrumOfBonds[i, 2].Value));
            }

            LineItem myCurve = pane.AddCurve("Спектр близкостей", list, Color.Blue, SymbolType.Star);

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            testMatrix = new double[,] {
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
                if(classDataset != null)
                    dataGridViewSpectrumOfBonds[blockB.Count, 3].Value = classDataset[xNext.index - 1];
                xNext = new { index = 0, distance = 0.0 };

            }
            GetBreakPoint();
        }

        public void GetBreakPoint()
        {
            int count = (int)numericUpDownCount.Value - 1;

            List<int> result = new List<int>();
            for (int j = 0; j < count; j++)
            {
                var maxValue = new { index = -1, value = 100.0 };
                for (int i = 2; i < numericUpDownNumber.Value; i++)
                {
                    if(Convert.ToDouble(dataGridViewSpectrumOfBonds[i, 2].Value) < maxValue.value 
                        && !result.Contains(i) && !result.Contains(i - 1) && !result.Contains(i + 1))
                    {
                        maxValue = new { index = i, value = Convert.ToDouble(dataGridViewSpectrumOfBonds[i, 2].Value) };
                    }
                }
                result.Add(maxValue.index);
                dataGridViewSpectrumOfBonds.Columns[maxValue.index].DefaultCellStyle.BackColor = Color.Pink;
            }
        }

        private void btnLoadDataset_Click(object sender, EventArgs e)
        {
            var data = File.ReadAllLines("iris.csv");

            numericUpDownNumber.Value = data.Length;
            numericUpDownMetrik.Value = data[0].Split(',').Length;

            testDataset = new double[number, metrik];
            classDataset = new int[number];

            for (int i = 0; i < number; i++)
            {
                for(int j = 0; j < metrik; j++)
                {
                    testDataset[i, j] = Convert.ToDouble(data[i].Split(',')[j + 1]);
                    classDataset[i] = Convert.ToInt32(data[i].Split(',')[0]);
                    dataGridViewMatrixDataset[j + 1, i + 1].Value = testDataset[i, j];
                }
            }
        }

        private void btnGetMatrixOfDistances_Click(object sender, EventArgs e)
        {
            testMatrix = new double[number, number];

            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    if (i == j)
                        testMatrix[i, j] = 0;
                    else
                    {
                        double[] firstPoint = Enumerable.Range(0, metrik)
                            .Select(k => testDataset[i, k])
                            .ToArray();
                        double[] lastPoint = Enumerable.Range(0, metrik)
                            .Select(k => testDataset[j, k])
                            .ToArray();

                        testMatrix[i, j] = GetLength(firstPoint, lastPoint);
                        dataGridViewMatrixOfDistances[i + 1, j + 1].Value = testMatrix[i, j];
                    }
                }
            }
        }

        private double GetLength(double[] firstPoint, double[] lastPoint)
        {
            double result = 0;

            switch (cbMetrik.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        result += Math.Pow(firstPoint[i] - lastPoint[i], 2);
                    }
                    return 1.0 / Math.Sqrt(result);
                case 1:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        result += Math.Pow(firstPoint[i] - lastPoint[i], 2);
                    }
                    return 1.0 / result;
                case 2:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        result += Math.Abs(firstPoint[i] - lastPoint[i]);
                    }
                    return 1.0 / result;
                case 3:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        if (Math.Abs(firstPoint[i] - lastPoint[i]) > result)
                            result = Math.Abs(firstPoint[i] - lastPoint[i]);
                    }
                    return 1.0 / result;
                default:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        result += Math.Pow(Math.Abs(firstPoint[i] - lastPoint[i]), Convert.ToInt32(tbValuep.Text));
                    }
                    return 1.0 / Math.Pow(result, 1.0 / Convert.ToInt32(tbValuer.Text));
            }
        }

        private string zedGraph_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            PointPair point = curve[iPt];

            string result = string.Format("Точка: {1}\nІтерація: {0}\nВеличина зв'язку: {2:F2}", point.X, Convert.ToDouble(dataGridViewSpectrumOfBonds[(int) point.X + 1, 1].Value), point.Y);

            return result;
        }

        private void btnNormalizationOfData_Click(object sender, EventArgs e)
        {
            List<double[]> minmaxvalues = new List<double[]>();

            // find min and max values
            for (int j = 0; j < metrik; j++)
            {
                double min = testDataset[0, j], max = testDataset[0, j];
                for (int i = 0; i < number; i++)
                {
                    if (testDataset[i, j] < min)
                        min = testDataset[i, j];
                    if (testDataset[i, j] >= max)
                        max = testDataset[i, j];
                }
                minmaxvalues.Add(new double[] { min, max });
            }

            // change values
            for (int j = 0; j < metrik; j++)
            {
                var minmax = minmaxvalues.ElementAt(j);
                for (int i = 0; i < number; i++)
                {
                    testDataset[i, j] -= minmax[0];
                    testDataset[i, j] /= minmax[1] - minmax[0];
                    dataGridViewMatrixDataset[j + 1, i + 1].Value = testDataset[i, j];
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            numericUpDownNumber.Value = numericUpDownMetrik.Value = 2;
        }
    }
}
