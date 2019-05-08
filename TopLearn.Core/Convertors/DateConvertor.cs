﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TopLearn.Core.Convertors
{
   public static class DateConvertor
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(date) + "/" + pc.GetMonth(date).ToString("00") + "/" + pc.GetDayOfMonth(date).ToString("00");
        }
    }
}
