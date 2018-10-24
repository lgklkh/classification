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

namespace classification_lab1
{
    public partial class Forel2Form : Form
    {
        int number;
        int metrik;

        double[,] testDataset;
        int[] classDataset;

        double[] centerPoint;
        double radius;

        public Forel2Form()
        {
            InitializeComponent();
        }

        private void Forel2Form_Load(object sender, EventArgs e)
        {
            numericUpDownMetrik.Value = 2;
            numericUpDownNumber.Value = 5;
        }

        private void numericUpDownAmountOfPoints_ValueChanged(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numericUpDownNumber.Value);
            metrik = Convert.ToInt32(numericUpDownMetrik.Value) - 1;

            // create CoordinateMatrix table
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

            for (int i = 0; i <= metrik; i++)
            {
                dataGridViewMatrixDataset[i, 0].Value = "S" + i;
                dataGridViewMatrixDataset.Columns[i].Width = 40;
            }

            for (int i = 0; i <= number; i++)
            {
                dataGridViewMatrixDataset[0, i].Value = "M" + i;
                dataGridViewMatrixDataset.Rows[i].Height = 25;
            }

            dataGridViewMatrixDataset[0, 0].Value = "№";

            dataGridViewMatrixDataset.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixDataset.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;

            // create Classes table
            dt = new DataTable();

            dt.Columns.Add(1.ToString()); dt.Columns.Add(2.ToString()); dt.Columns.Add(3.ToString()); dt.Columns.Add(4.ToString());

            for (int i = 0; i <= number; i++)
            {
                dt.Rows.Add();
            }

            dataGridViewClassTable.DataSource = dt;

            dataGridViewClassTable[1, 0].Value = "C(i)";
            dataGridViewClassTable[2, 0].Value = "{,,,}";
            dataGridViewClassTable[3, 0].Value = "R";
            for (int i = 0; i <= number; i++)
            {
                dataGridViewClassTable[0, i].Value = "Class " + i;
                dataGridViewClassTable.Rows[i].Height = 25;
            }
            dataGridViewClassTable[0, 0].Value = "";
            dataGridViewClassTable.Columns[0].Width = 60;
            dataGridViewClassTable.Columns[1].Width = 90;
            dataGridViewClassTable.Columns[2].Width = 500;
            dataGridViewClassTable.Columns[3].Width = 60;
            dataGridViewClassTable.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewClassTable.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private struct nPoint
        {
            public int index;
            public int classValue;
            public double[] metrik;

            public nPoint(int index, int[] classDataset, double[,] testDataset, int metrik)
            {
                this.index = index;
                this.classValue = classDataset[index];
                this.metrik = Enumerable.Range(0, metrik)
                            .Select(k => testDataset[index, k])
                            .ToArray();
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
                    return Math.Sqrt(result);
                case 1:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        result += Math.Pow(firstPoint[i] - lastPoint[i], 2);
                    }
                    return result;
                case 2:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        result += Math.Abs(firstPoint[i] - lastPoint[i]);
                    }
                    return result;
                case 3:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        if (Math.Abs(firstPoint[i] - lastPoint[i]) > result)
                            result = Math.Abs(firstPoint[i] - lastPoint[i]);
                    }
                    return result;
                default:
                    for (int i = 0; i < firstPoint.Length; i++)
                    {
                        result += Math.Pow(Math.Abs(firstPoint[i] - lastPoint[i]), Convert.ToInt32(tbValuep.Text));
                    }
                    return Math.Pow(result, 1.0 / Convert.ToInt32(tbValuer.Text));
            }
        }

        private double MaxRadius(List<nPoint> nPoints, double[] center)
        {
           var maxValue = Enumerable.Range(0, nPoints.Count)
                .Select(x => GetLength(nPoints.ElementAt(x).metrik, center))
                .ToArray().Max();
            return maxValue;
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            // clear result datagrid
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= 3; j++)
                    dataGridViewClassTable[j, i].Value = "";
            }
            //

            List<nPoint> bufferAll = new List<nPoint>();
            List<nPoint> bufferInternal = new List<nPoint>();

            for (int i = 0; i < number; i++)
            {
                var point = new nPoint(i, classDataset, testDataset, metrik);
                bufferAll.Add(point);
            }


            for (int i = 1; bufferAll.Count != 0; i++)
            {
                // step 1
                bufferInternal.AddRange(bufferAll);

                centerPoint = new double[metrik];
                for(int j = 0; j < metrik; j++)
                {
                    centerPoint[j] = bufferAll.Average(x => x.metrik[j]);
                }

                radius = MaxRadius(bufferAll, centerPoint);

                // step 2
                while (true)
                {
                    radius *= 0.9;

                    for (int j = 0; j < bufferInternal.Count; j++)
                    {
                        var point = bufferInternal.ElementAt(j);
                        if (GetLength(point.metrik, bufferInternal.First().metrik) > radius)
                        {
                            bufferInternal.Remove(point);
                        }
                    }

                    // step 3
                    var centerGravity = new double[metrik];
                    for (int j = 0; j < metrik; j++)
                    {
                        centerGravity[j] = bufferInternal.Average(x => x.metrik[j]);
                    }

                    // step 5
                    if (Equil(centerGravity, centerPoint))
                    {
                        bufferAll.RemoveAll(item => bufferInternal.Contains(item));
                        break;
                    }
                    else
                    {
                        for(int j = 0; j < metrik; j++)
                        {
                            centerPoint[j] = centerGravity[j];
                        }
                    }
                }

                // step 6
                dataGridViewClassTable[1, i].Value = string.Format("Class - " + bufferInternal.Average(x => x.classValue));
                dataGridViewClassTable[2, i].Value = string.Join(" ", bufferInternal.Select(x => x.index + 1));
                dataGridViewClassTable[3, i].Value = (bufferInternal.Count == 1) ? 0 : Math.Round(radius, 2);
                bufferInternal.RemoveRange(0, bufferInternal.Count);
            }
        }

        public bool Equil(double[] firstPoint, double[] lastpoint)
        {
            bool result = true;
            for(int i = 0; i < firstPoint.Length; i++)
            {
                result &= firstPoint[i] == lastpoint[i];
            }
                    
            return result;
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
                for (int j = 0; j < metrik; j++)
                {
                    testDataset[i, j] = Convert.ToDouble(data[i].Split(',')[j + 1]);
                    classDataset[i] = Convert.ToInt32(data[i].Split(',')[0]);
                    dataGridViewMatrixDataset[j + 1, i + 1].Value = testDataset[i, j];
                }
            }
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
