using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2_C_sharp
{
    class Kvadrat
    {
        protected int storona;

        public Kvadrat()
        {
            storona = 0;
        }

        public Kvadrat(int st)
        {
            storona = st;
        }

        public int Storona
        {
            get { return storona; }
            set { storona = value; }
        }

        public virtual string Info()
        {
            return string.Format("Kvadrat");
        }

        public virtual int Area()
        {
            return storona * storona;
        }

        public virtual int Perimeter()
        {
            return 4 * storona;
        }

        public virtual double Diagonal()
        {
            return Math.Sqrt(2 * storona * storona);
        }
    }
}
