using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year; //Le llevamos el valor del atributo de la palabra year
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int day, int month, int year)
        {
            if(month==2 && day==29 && IsLeapYear(year))
            {
                return day;
            }
            int[] dayPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >=1 && day <= dayPerMonth[month])
            {
                return day;
            }
            throw new DayExceptions("Invalid Day");
        }
        private int DayExceptions()
        {
            throw new MonthException("Invalid month");
        }
            private  bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year %4==0 && year%100!=0;
            //if(year%4==0)
            //{
            //    if (year %100==0)
            //    {
            //        if (year%400==0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true; ;
            //    }
            //}
            //else
            //{
            //    return true;
            //}

        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <=12)
            {
                return month;
            }
            throw new MonthException("Invalid month");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
