using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Point3D : IComparable, ICloneable
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }

        public Point3D()
        {
            
        }

        public Point3D(int _p1, int _p2, int _p3)
        {
            P1 = _p1;
            P2 = _p2;
            P3 = _p3;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({P1}, {P2}, {P3})";
        }

        public override bool Equals(object? obj)
        {
            Point3D point = obj as Point3D;

            if(point is null ) return false;

            if(ReferenceEquals(this, point)) return true;

            if(this.GetType() != obj.GetType()) return false;

            return this.P1 == point.P1 && this.P2 == point.P2 && this.P3 == point.P3 ;
        }

        public int CompareTo(object? obj)
        {
            Point3D p = obj as Point3D;

            if (this.P1.CompareTo(p.P1) == 0)
            {
                if (this.P2.CompareTo(p.P2) == 0)
                {
                    return this.P3.CompareTo(p.P3);
                }
                return this.P2.CompareTo(p.P2);
            }
            return this.P1.CompareTo(p.P1);
        }

        public object Clone()
        {
            return new Point3D()
            {
                P1 = this.P1,
                P2 = this.P2,
                P3 = this.P3
            };
        }

        public static explicit operator string(Point3D p)
        {
            return p.ToString() ;
        }
    }
}
