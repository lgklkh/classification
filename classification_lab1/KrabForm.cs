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
    public partial class KrabForm : Form
    {
        public KrabForm()
        {
            InitializeComponent();
        }

        private void KrabForm_Load(object sender, EventArgs e)
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


            dt = new DataTable();

            for (int i = 0; i <= number; i++)
            {
                dt.Columns.Add(i.ToString());
            }
            dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add(); dt.Rows.Add();

            dataGridViewResult.DataSource = dt;

            dataGridViewResult.Columns[0].Width = 30;
            dataGridViewResult[0, 0].Value = "i/j";
            dataGridViewResult[0, 1].Value = "R(i,j)";
            dataGridViewResult[0, 2].Value = "D";
            dataGridViewResult[0, 3].Value = "H";
            dataGridViewResult[0, 4].Value = "R";
            dataGridViewResult[0, 5].Value = "G";
            dataGridViewResult[0, 6].Value = "L";


            for (int i = 0; i <= number; i++)
            {
                dataGridViewMatrixOfDistances[0, 0].Value = "№";
                dataGridViewMatrixOfDistances[i, i].Value = 0;
                dataGridViewMatrixOfDistances[0, i].Value =
                    dataGridViewMatrixOfDistances[i, 0].Value = i;
                dataGridViewBHRbuffer[i, 0].Value = i;
                dataGridViewMatrixOfDistances.Columns[i].Width =
                    dataGridViewMatrixOfDistances.Rows[i].Height =
                    dataGridViewBHRbuffer.Columns[i].Width = 25;
                dataGridViewBHRbuffer[0, 0].Value = "i";
                dataGridViewBHRbuffer[0, 1].Value = "B(i)";
                dataGridViewBHRbuffer[0, 2].Value = "H(i)";
                dataGridViewBHRbuffer[0, 3].Value = "R(i)";
                dataGridViewBHRbuffer[1, 1].Value = "1";
                dataGridViewBHRbuffer[1, 2].Value = "1";
                dataGridViewBHRbuffer[1, 3].Value = "0";
            }

            dataGridViewMatrixOfDistances.Height =
                dataGridViewMatrixOfDistances.Width =
                dataGridViewBHRbuffer.Width = (number + 1) * 25 + 3;
            dataGridViewBHRbuffer.Height = 4 * 25 - 8;
            dataGridViewResult.Height = 6 * 25 + 7;
            dataGridViewResult.Width = 30;
            dataGridViewBHRbuffer.Location =
                new Point(dataGridViewMatrixOfDistances.Location.X, dataGridViewMatrixOfDistances.Location.Y + dataGridViewMatrixOfDistances.Height + 30);
            dataGridViewResult.Location = 
                new Point(dataGridViewMatrixOfDistances.Location.X + dataGridViewMatrixOfDistances.Height + 30, dataGridViewMatrixOfDistances.Location.Y);

            dataGridViewBHRbuffer.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewBHRbuffer.Columns[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewMatrixOfDistances.Columns[0].DefaultCellStyle.BackColor =
                dataGridViewResult.Columns[0].DefaultCellStyle.BackColor =
                dataGridViewResult.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            double[,] testMatrix = new double[,] {
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

        private void ToDoPrima(ref List<int> bufferB, ref List<int> bufferH, ref List<double> bufferR)
        {
            // step 1
            int M = (int)numericUpDownNumber.Value;
            // step 2
            //List<int> bufferB = new List<int>();
            //List<int> bufferH = new List<int>();
            //List<double> bufferR = new List<double>();
            // step 2.1
            int N = M - 1;
            // step 2.2
            for (int i = 1; i <= N; i++)
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
                for (int i = 1; i <= N; i++)
                {
                    int J = bufferH.ElementAt(i - 1); double R1 = Convert.ToDouble(dataGridViewMatrixOfDistances[J, V].Value);
                    if (R1 < bufferR.ElementAt(i - 1))
                    {
                        bufferR[i - 1] = R1;
                        bufferB[i - 1] = V;
                    }
                }
            }
            // last step (add data to dataGrid)
            for (int i = 0; i < bufferB.Count; i++)
            {
                dataGridViewBHRbuffer[i + 2, 1].Value = bufferB.ElementAt(i);
                dataGridViewBHRbuffer[i + 2, 2].Value = bufferH.ElementAt(i);
                dataGridViewBHRbuffer[i + 2, 3].Value = bufferR.ElementAt(i);
            }
        }

        private double R(List<double> bufferR, List<int> bufferGap)
        {
            var bufferSet = new List<int>();
            bufferSet.AddRange(bufferGap);
            bufferSet.Add(-1);
            bufferSet.Add(bufferR.Count);
            bufferSet.Sort();

            double setSum = 0;
            for(int i = 1; i < bufferSet.Count; i++)
            {
                int firstIndex = bufferSet.ElementAt(i - 1), lastIndex = bufferSet.ElementAt(i);
                var subSet = bufferR.GetRange(firstIndex + 1, lastIndex - firstIndex - 1);
                setSum += subSet.Average();
            }
            return setSum / (bufferSet.Count - 1);
        }

        private double H(List<double> bufferR, List<int> bufferGap)
        {
            var bufferSet = new List<int>();
            bufferSet.AddRange(bufferGap);
            bufferSet.Add(-1);
            bufferSet.Add(bufferR.Count);
            bufferSet.Sort();

            double setRes = 1;
            for (int i = 1; i < bufferSet.Count; i++)
            {
                int firstIndex = bufferSet.ElementAt(i - 1), lastIndex = bufferSet.ElementAt(i);
                setRes *= lastIndex - firstIndex;
            }
            return Math.Pow(bufferSet.Count - 1, bufferSet.Count - 1) * (setRes / (Math.Pow(bufferR.Count + 1, bufferSet.Count - 1)));
        }

        private double D(List<double> bufferR, List<int> bufferGap)
        {
            double sum = 0;

            foreach (var item in bufferGap)
                sum += bufferR.ElementAt(item);

            return sum / bufferGap.Count;
        }

        private double G(List<double> bufferR, List<int> bufferGap)
        {
            double sum = 0;
            foreach(var item in bufferGap)
            {
                sum += bufferR.Min() / bufferR.ElementAt(item);
            }
            return Math.Round(sum / (bufferGap.Count), 3);
        }

        private double L(double r, double h, double d, double g)
        {
            return Math.Log((d * h) / (g * r));
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            List<int> bufferB = new List<int>();
            List<int> bufferH = new List<int>();
            List<double> bufferR = new List<double>();
            ToDoPrima(ref bufferB, ref bufferH, ref bufferR);

            List<int> bufferGap = new List<int>();

            for (int j = 1; true; j++)
            {
                var maxElem = new { index = -1, value = -1.0 };
                for (int i = 0; i < bufferR.Count; i++)
                {
                    if (bufferR.ElementAt(i) > maxElem.value && !bufferGap.Contains(i))
                    {
                        maxElem = new { index = i, value = bufferR.ElementAt(i) };
                    }
                }
                bufferGap.Add(maxElem.index);

                double r = R(bufferR, bufferGap), h = H(bufferR, bufferGap),
                    d = D(bufferR, bufferGap), g = G(bufferR, bufferGap);
                double l = L(r, h, d, g);

                dataGridViewResult.Columns[j].Width = 45;
                dataGridViewResult.Width = j * 45 + 30;
                dataGridViewResult[j, 0].Value = bufferB.ElementAt(bufferGap.Last()) + "-" + bufferH.ElementAt(bufferGap.Last());
                dataGridViewResult[j, 1].Value = bufferR.ElementAt(bufferGap.Last());
                dataGridViewResult[j, 2].Value = Math.Round(d, 3);
                dataGridViewResult[j, 3].Value = Math.Round(h, 3);
                dataGridViewResult[j, 4].Value = Math.Round(r, 3);
                dataGridViewResult[j, 5].Value = Math.Round(g, 3);
                dataGridViewResult[j, 6].Value = Math.Round(l, 3);


                if(j > 1)
                    if (l < Convert.ToDouble(dataGridViewResult[j - 1, 6].Value))
                        break;
                this.Text = L(R(bufferR, bufferGap), H(bufferR, bufferGap), D(bufferR, bufferGap), G(bufferR, bufferGap)).ToString();
            }


        }
    }
}
