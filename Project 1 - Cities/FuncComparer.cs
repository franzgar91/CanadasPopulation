using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    //FuncComparer class
    //Purpose: Compares data for sorting city collection in Statistics class
    //Authors: Mark Medvedev, Justin Kuchmy, Francisco Garcia
    class FuncComparer<T> : IComparer<T>
    {
        private readonly Comparison<T> comparison;
        public FuncComparer(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }
        public int Compare(T x, T y)
        {
            return comparison(x, y);
        }
    }
}
