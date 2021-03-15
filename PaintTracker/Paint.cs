using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTracker
{
    class Paint
    {
        
        //definte the backing fields
        private string _colorCat;
        private string _pigment;
        private decimal _quantity;

        //define the properties

        public string ColorCat
        {
            get { return _colorCat; }
            set { _colorCat = value; }

        }

        public string Pigment
        {
            get { return _pigment; }
            set { _pigment = value; }
        }

        public decimal Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        

        //Parameterized constructor
        public Paint(string c, string p, decimal q)
        {
            _colorCat = c; _pigment = p;  _quantity = q;
        }
    }

}
