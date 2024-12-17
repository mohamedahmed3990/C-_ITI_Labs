﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Triangle : GeoShape
    {
        public Triangle()
        {
            
        }

        public Triangle(double _base, double _height):base(_base, _height)
        {
            
        }

        public double Area()
        {
            return 0.5 * dim1 * dim2;
        }
    }
}
