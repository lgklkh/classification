using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classification_lab1
{
    public class nPoint
    {
        public string Name;
        public double[] Metrik;

        public nPoint(string name, int metrikCount)
        {
            Name = name;
            Metrik = new double[metrikCount];
        }

        public static bool operator ==(nPoint obj1, nPoint obj2)
        {
            var res = true;
            for (int i = 0; i < obj1.Metrik.Length; i++)
            {
                res &= obj1.Metrik[i] == obj2.Metrik[i];
            }

            return (res);
        }

        public static bool operator !=(nPoint obj1, nPoint obj2)
        {
            var res = true;
            for (int i = 0; i < obj1.Metrik.Length; i++)
            {
                res &= obj1.Metrik[i] == obj2.Metrik[i];
            }

            return !(res);
        }

        public void Assign(nPoint obj)
        {
            for (int i = 0; i < Metrik.Length; i++)
            {
                this.Metrik[i] = obj.Metrik[i];
            }
        }
    }
}
