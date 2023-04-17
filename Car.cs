using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCustomTypeProject
{
    internal class Car
    {
        private string name;
        private int unitsSold;

        public Car(string name, int unitsSold)
        {
            this.name = name;
            this.unitsSold = unitsSold;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int UnitsSold
        {
            get { return this.unitsSold; }
            set { this.unitsSold = value; }
        }
    }
}
