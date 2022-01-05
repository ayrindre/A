
using System;
using System.Globalization;

namespace AirLIine_MVC.Models
{
    public static class toPersianDate
    {
        public static string Pdate(DateTime d)
        {

            PersianCalendar p = new PersianCalendar();
            string a = p.GetYear(d).ToString() + "/" + p.GetMonth(d).ToString() + "/" + p.GetDayOfWeek(d).ToString();
            return a;
        }
    }


}