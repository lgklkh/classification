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
    public partial class ForelForm : Form
    {
        int number;
        int metrik;

        double[][] testDataset;

        public ForelForm()
        {
            InitializeComponent();
        }

        private void ForelForm_Load(object sender, EventArgs e)
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

            dt.Columns.Add(1.ToString()); dt.Columns.Add(2.ToString()); dt.Columns.Add(3.ToString());

            for (int i = 0; i <= number; i++)
            {
                dt.Rows.Add();
            }

            dataGridViewClassTable.DataSource = dt;

            for (int i = 0; i <= number; i++)
            {
                dataGridViewClassTable[0, i].Value = "Class " + i;
                dataGridViewClassTable.Rows[i].Height = 25;
            }
            dataGridViewClassTable[0, 0].Value = "T/F";
            dataGridViewClassTable[1, 0].Value = "Class";
            dataGridViewClassTable[2, 0].Value = "№";

            dataGridViewClassTable.Columns[0].Width = 60;
            dataGridViewClassTable.Columns[1].Width = 60;
            dataGridViewClassTable.Columns[2].Width = 60;
            dataGridViewClassTable.Rows[0].DefaultCellStyle.BackColor =
                dataGridViewClassTable.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
        }
        
        private void btnToDo_Click(object sender, EventArgs e)
        {
            int numClusters = (int) numericUpDownCount.Value;

            int[] clustering = Cluster(testDataset, numClusters); // this is it

            for(int i = 0; i < clustering.Length; i++)
            {
                dataGridViewClassTable[0, i + 1].Value = (i != 0 && i != clustering.Length - 1 
                    && clustering[i + 1] != clustering[i] 
                    && clustering[i - 1] != clustering[i]) ? "#" : "";
                dataGridViewClassTable[1, i + 1].Value = clustering[i];
                dataGridViewClassTable[2, i + 1].Value = i + 1;
            }
        }

        private void btnLoadDataset_Click(object sender, EventArgs e)
        {
            var data = File.ReadAllLines("iris.csv");

            numericUpDownNumber.Value = data.Length;
            numericUpDownMetrik.Value = data[0].Split(',').Length;

            testDataset = new double[number][];
            for (int i = 0; i < number; i++)
            {
                double[] arrayMetrik = new double[metrik];
                for (int j = 0; j < metrik; j++)
                {
                    arrayMetrik[j] = Convert.ToDouble(data[i].Split(',')[j + 1]);
                    dataGridViewMatrixDataset[j + 1, i + 1].Value = Convert.ToDouble(data[i].Split(',')[j + 1]);
                }
                testDataset[i] = arrayMetrik;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            numericUpDownNumber.Value = numericUpDownMetrik.Value = 2;

        }

        public int[] Cluster(double[][] rawData, int numClusters)
        {
            double[][] data = Normalized(rawData); 

            bool changed = true; 
            bool success = true; 

            int[] clustering = InitClustering(data.Length, numClusters, 0);
            double[][] means = Allocate(numClusters, data[0].Length); 

            int maxCount = data.Length * 10; 
            int ct = 0;
            while (changed == true && success == true && ct < maxCount)
            {
                ++ct;
                success = UpdateMeans(data, clustering, means);
                changed = UpdateClustering(data, clustering, means);
            }
            return clustering;
        }

        private double[][] Normalized(double[][] rawData)
        {
            double[][] result = new double[rawData.Length][];
            for (int i = 0; i < rawData.Length; ++i)
            {
                result[i] = new double[rawData[i].Length];
                Array.Copy(rawData[i], result[i], rawData[i].Length);
            }

            for (int j = 0; j < result[0].Length; ++j) // each col
            {
                double colSum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                    colSum += result[i][j];
                double mean = colSum / result.Length;
                double sum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                    sum += (result[i][j] - mean) * (result[i][j] - mean);
                double sd = sum / result.Length;
                for (int i = 0; i < result.Length; ++i)
                    result[i][j] = (result[i][j] - mean) / sd;
            }
            return result;
        }

        private int[] InitClustering(int numTuples, int numClusters, int randomSeed)
        {
            Random random = new Random(randomSeed);
            int[] clustering = new int[numTuples];
            for (int i = 0; i < numClusters; ++i) 
                clustering[i] = i;
            for (int i = numClusters; i < clustering.Length; ++i)
                clustering[i] = random.Next(0, numClusters);
            return clustering;
        }

        private double[][] Allocate(int numClusters, int numColumns)
        {
            double[][] result = new double[numClusters][];
            for (int k = 0; k < numClusters; ++k)
                result[k] = new double[numColumns];
            return result;
        }

        private bool UpdateMeans(double[][] data, int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
                if (clusterCounts[k] == 0)
                    return false; 
 
            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] = 0.0;

            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                for (int j = 0; j < data[i].Length; ++j)
                    means[cluster][j] += data[i][j]; 
            }

            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] /= clusterCounts[k]; 
            return true;
        }

        private bool UpdateClustering(double[][] data, int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            bool changed = false;

            int[] newClustering = new int[clustering.Length]; 
            Array.Copy(clustering, newClustering, clustering.Length);

            double[] distances = new double[numClusters]; 

            for (int i = 0; i < data.Length; ++i) 
            {
                for (int k = 0; k < numClusters; ++k)
                    distances[k] = GetLength(data[i], means[k]); 

                int newClusterID = MinIndex(distances);
                if (newClusterID != newClustering[i])
                {
                    changed = true;
                    newClustering[i] = newClusterID; 
                }
            }

            if (changed == false)
                return false;

            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = newClustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
                if (clusterCounts[k] == 0)
                    return false; 

            Array.Copy(newClustering, clustering, newClustering.Length); 
            return true; 
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

        private int MinIndex(double[] distances)
        {
            int indexOfMin = 0;
            double smallDist = distances[0];
            for (int k = 0; k < distances.Length; ++k)
            {
                if (distances[k] < smallDist)
                {
                    smallDist = distances[k];
                    indexOfMin = k;
                }
            }
            return indexOfMin;
        }
    }
}
