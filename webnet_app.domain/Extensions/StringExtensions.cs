using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace webnet_app.domain.Extensions
{
    public static class StringExtensions
    {
        public static Guid ToGuid(this string input)
        {
            if (!input.IsGuid()) return new Guid();


            Guid.TryParse(input, out Guid guid);

            return guid;
        }

        public static bool IsGuid(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            if (Guid.TryParse(input, out _))
                return true;

            return false;
        }

        public static DateTime ToDateTime(this string input, String CultureFormat = "es-DO")
        {
            IFormatProvider culture = new System.Globalization.CultureInfo(CultureFormat, true);

            if (DateTime.TryParse(input, culture, System.Globalization.DateTimeStyles.None, out DateTime oDate))
                return oDate;

            return DateTime.MinValue;
        }

        public static DateTime ToDate(this string input, String CultureFormat = "es-DO")
        {
            IFormatProvider culture = new System.Globalization.CultureInfo(CultureFormat, true);

            if (DateTime.TryParse(input, culture, System.Globalization.DateTimeStyles.None, out DateTime oDate))
                return oDate.Date;

            return DateTime.MinValue;
        }

        public static int ToInt(this string input)
        {
            const string regex = @"/[^\d]+/g";

            if (string.IsNullOrWhiteSpace(input)) return 0;

            if (int.TryParse(Regex.Replace(input, regex, ""), out int oNumber))
                return oNumber;

            return 0;
        }

    }
}
