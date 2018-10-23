using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classification_lab1
{
    public class Taxon
    {
        public nPoint centerTaxon;
        public double Radius;
        public List<nPoint> Points = new List<nPoint>();

        public Taxon(double radius, nPoint center, List<nPoint> points)
        {
            Points.AddRange(points);
            centerTaxon = GetCenter(Points);
            Radius = MaxRadius(Points, centerTaxon);
        }

        public static double Length(nPoint x1, nPoint x2)
        {
            double sum = 0;
            for (int i = 0; i < x1.Metrik.Length; i++)
            {
                sum += Math.Pow((x1.Metrik[i] - x2.Metrik[i]), 2);
            }
            return Math.Pow(sum, (1.0 / x1.Metrik.Length));
        }

        public static nPoint GetCenter(List<nPoint> nPoints)
        {
            nPoint centerPoint = new nPoint("C", nPoints.First().Metrik.Length);
            for (int i = 0; i < centerPoint.Metrik.Length; i++)
            {
                centerPoint.Metrik[i] = nPoints.Average(x => x.Metrik[i]);
            }
            return centerPoint;
        }

        public static double MaxRadius(List<nPoint> nPoints, nPoint center)
        {
            var maxValue = Enumerable.Range(0, nPoints.Count)
                 .Select(x => Length(nPoints.ElementAt(x), center))
                 .ToArray().Max();
            return maxValue;
        }

        public double Sum()
        {
            double sum = 0;
            foreach(var item in Points)
            {
                sum += Length(centerTaxon, item);
            }
            return sum;
        }

        public string GetCenterString()
        {
            return string.Join(";", centerTaxon.Metrik.Select(x => Math.Round(x, 2)));
        }
    }
}
