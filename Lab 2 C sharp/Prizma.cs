using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_C_sharp
{
    class Prizma : Kvadrat
    {
        protected int visota;
        public Prizma()
            : base()
        {
            visota = 0;
        }

        public Prizma(int st, int vst)
            : base(st)
        {
            visota = vst;
        }
        public int Visota
        {
            get { return visota; }
            set { visota = value; }
        }

        public override string Info()
        {
            return string.Format("Prizma");
        }

        public override int Area()
        {
            return base.Area() * 2 + visota * storona * 4;
        }
        public override int Perimeter()
        {
            return base.Perimeter() * 2 + visota * 4;
        }
        public override double Diagonal()
        {
            return Math.Sqrt(base.Diagonal() * base.Diagonal() + visota * visota);
        }
        public double Objom()
        {
            return storona * storona * visota;
        }
    }
}
