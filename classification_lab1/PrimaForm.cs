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
    public partial class PrimaForm : Form
    {
        double[,] testDataset;
        double[,] testMatrix;

        public PrimaForm()
        {
            InitializeComponent();
        }

        private void PrimaForm_Load(object sender, EventArgs e)
        {
            numericUpDownNumber.Value = 12;
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
            dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add();

            dataGridViewBHRbuffer.DataSource = dt;


            for (int i = 0; i <= number; i++)
            {
                dataGridViewMatrixOfDistances[0, 0].Value = "№";
                dataGridViewMatrixOfDistances[i, i].Value = 0;
                dataGridViewMatrixOfDistances[0, i].Value =
                    dataGridViewMatrixOfDistances[i, 0].Value = i;
                dataGridViewBHRbuffer[i, 0].Value = i;
                dataGridViewMatrixOfDistances.Columns[i].Width =
                    dataGridViewMatrixOfDistances.Rows[i].Height =
                    dataGridViewBHRbuffer.Columns[i].Width = 30;
                dataGridViewBHRbuffer[0, 0].Value = "i";
                dataGridViewBHRbuffer[0, 1].Value = "B(i)";
                dataGridViewBHRbuffer[0, 2].Value = "H(i)";
                dataGridViewBHRbuffer[0, 3].Value = "R(i)";
                dataGridViewBHRbuffer[1, 1].Value = number;
                dataGridViewBHRbuffer[1, 2].Value = number;
                dataGridViewBHRbuffer[1, 3].Value = "0";
            }

            dataGridViewBHRbuffer.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewBHRbuffer.Columns[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void numericUpDownMetrik_ValueChanged(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numericUpDownNumber.Value);
            int metrik = Convert.ToInt32(numericUpDownMetrik.Value);

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

        private void btnTest_Click(object sender, EventArgs e)
        {
            testMatrix = new double[,] {
                {0,2.2,2.2,5.8,7.6,5,5.1,5.1,8.5,10,8.9,10.8},
                {2.2,0,3.2,3.6,5.4,3.2,5,4.1,6.4,7.8,7.3,8.9},
                {2.2,3.2,0,6.1,8.1,4.5,3,3.6,8.1,9.8,7.8,9.9},
                {5.8,3.6,6.1,0,2,2.2,6.3,4.5,3.2,4.2,5.1,6.1},
                {7.6,5.4,8.1,2,0,4.1,8.2,6.3,3.2,3.2,5.8,6.1},
                {5,3.2,4.5,2.2,4.1,0,4.1,2.2,3.6,5.4,4.1,5.8},
                {5.1,5,3,6.3,8.2,4.1,0,2,7.1,9,5.8,8.1},
                {5.1,4.1,3.6,4.5,6.3,2.2,2,0,5.1,7.1,4.2,6.4},
                {8.5,6.4,8.1,3.2,3.2,3.6,7.1,5.1,0,2,2.8,3},
                {10,7.8,9.8,4.2,3.2,5.4,9,7.1,2,0,4.5,3.6},
                {8.9,7.3,7.8,5.1,5.8,4.1,5.8,4.2,2.8,4.5,0,2.2},
                {10.8,8.9,9.9,6.1,6.1,5.8,8.1,6.4,3,3.6,2.2,0}
            };
            

            for (int i = 0; i < numericUpDownNumber.Value; i++)
            {
                for (int j = 0; j < numericUpDownNumber.Value; j++)
                {
                    dataGridViewMatrixOfDistances[i + 1, j + 1].Value = testMatrix[j, i];
                }
            }
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            // step 1
            int M = (int) numericUpDownNumber.Value;
            // step 2
            List<int> bufferB = new List<int>();
            List<int> bufferH = new List<int>();
            List<double> bufferR = new List<double>();
            // step 2.1
            int N = M - 1;
            // step 2.2
            for(int i = 1; i <= N; i++)
            {
                bufferB.Add(M);
                bufferH.Add(i);
                bufferR.Add(Convert.ToDouble(dataGridViewMatrixOfDistances[i, M].Value));
            }
            // step 3
            while (true)
            {
                // step 3.1
                double L = bufferR.ElementAt(0);
                int S = 1;
                // step 3.2
                for (int i = 1; i <= N; i++)
                {
                    if (bufferR.ElementAt(i - 1) < L)
                    {
                        L = bufferR.ElementAt(i - 1);
                        S = i;
                    }
                }
                // step 4
                // step 4.1
                int V = bufferH.ElementAt(S - 1);
                // step 4.2
                double C = bufferB.ElementAt(S - 1); bufferB[S - 1] = bufferB[N - 1]; bufferB[N - 1] = (int)C;
                C = bufferH.ElementAt(S - 1); bufferH[S - 1] = bufferH[N - 1]; bufferH[N - 1] = (int)C;
                C = bufferR.ElementAt(S - 1); bufferR[S - 1] = bufferR[N - 1]; bufferR[N - 1] = C;
                // step 4.3
                N--;
                // step 4.3.1
                if (N == 0)
                    break;
                // step 4.3.2
                for(int i = 1; i <= N; i++)
                {
                    int J = bufferH.ElementAt(i - 1); double R1 = Convert.ToDouble(dataGridViewMatrixOfDistances[J, V].Value);
                    if(R1 < bufferR.ElementAt(i - 1))
                    {
                        bufferR[i - 1] = R1;
                        bufferB[i - 1] = V;
                    }
                }
            }
            // last step (add data to dataGrid)
            for (int i = 0; i < bufferB.Count; i++)
            {
                dataGridViewBHRbuffer[i + 2, 1].Value = bufferB.ElementAt(bufferB.Count - i - 1);
                dataGridViewBHRbuffer[i + 2, 2].Value = bufferH.ElementAt(bufferB.Count - i - 1);
                dataGridViewBHRbuffer[i + 2, 3].Value = bufferR.ElementAt(bufferB.Count - i - 1);
            }
        }

        private void btnLoadDataset_Click(object sender, EventArgs e)
        {
            var data = File.ReadAllLines("iris.txt");

            numericUpDownNumber.Value = data.Length;
            numericUpDownMetrik.Value = data[0].Split(',').Length;

            int number = Convert.ToInt32(numericUpDownNumber.Value);
            int metrik = Convert.ToInt32(numericUpDownMetrik.Value);

            testDataset = new double[number, metrik];

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < metrik; j++)
                {
                    testDataset[i, j] = Convert.ToDouble(data[i].Split(',')[j]);
                    dataGridViewMatrixDataset[j + 1, i + 1].Value = testDataset[i, j];
                }
            }
        }

        private void btnGetMatrixOfDistances_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numericUpDownNumber.Value);
            int metrik = Convert.ToInt32(numericUpDownMetrik.Value);

            testMatrix = new double[number, number];

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
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

            for (int i = 0; i < firstPoint.Length; i++)
            {
                result += Math.Pow(firstPoint[i] - lastPoint[i], 2);
            }
            return 10 * Math.Sqrt(result);
        }

        private void btnNormalizationOfData_Click(object sender, EventArgs e)
        {
            List<double[]> minmaxvalues = new List<double[]>();

            int number = Convert.ToInt32(numericUpDownNumber.Value);
            int metrik = Convert.ToInt32(numericUpDownMetrik.Value);

            // find min and max values
            for (int j = 0; j < metrik; j++)
            {
                double min = testDataset[0, j], max = testDataset[0, j];
                for (int i = 0; i < number; i++)
                {
                    if (testDataset[i, j] < min)
                        min = testDataset[i, j];
                    if(testDataset[i, j] >= max)
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
                    //testDataset[i, j] = (testDataset[i, j] - minmax[0]) / (minmax[1] - minmax[0]);
                    testDataset[i, j] -= minmax[0];
                    testDataset[i, j] /= minmax[1] - minmax[0];
                    dataGridViewMatrixDataset[j + 1, i + 1].Value = testDataset[i, j];
                }
            }
        }
    }
}
