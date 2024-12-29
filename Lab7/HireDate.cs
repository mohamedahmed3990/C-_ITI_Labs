using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public struct HireDate : IComparable
    {
        int day;
        int month;
        int year;
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public HireDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }

        public override string ToString()
        {
            return $"{day} : {month} : {year}";
        }

        public int CompareTo(object? obj)
        {
            HireDate hireDate = (HireDate)obj;
            if(this.year == hireDate.year)
            {
                if(this.month == hireDate.month)
                {
                    return this.day.CompareTo(hireDate.day);
                }
                return this.month.CompareTo(hireDate.month);
            }
            return this.year.CompareTo(hireDate.year);
        }
    }
}
