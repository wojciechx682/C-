using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace wyklad4
{
    public class CmbItem
    {
        public CmbItem(int wartosc)
        {
            this.wartosc = wartosc;
        }
        public int wartosc { get; set; }

        public override string ToString()
        {
            return wartosc.ToString();
        }
    }
}