using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Samochod
    {
        private int v;

        protected Samochod(int v)
        {
            this.v = v;
        }

        public String Silnik { get; set; }
        public String Bak { get; set; }
        public String Akumulator { get; set; }
                
        public virtual void UruchomSilnik() {}
        public virtual void Tankuj() {}
        public virtual void Jedz() {}
        public virtual void ZatrzymajSilnik() {}
                
    }
}
