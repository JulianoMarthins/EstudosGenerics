using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System {
    static class DateTimeExtensions {

        public static string ElapsedTime(this DateTime thisObj) {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24) {
                return duration.TotalHours.ToString("F2", CultureInfo.InvariantCulture) + " Hours";
            }
            else {
                return duration.TotalDays.ToString("F2", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}
