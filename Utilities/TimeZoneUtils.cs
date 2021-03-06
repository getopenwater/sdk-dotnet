﻿using System;
using System.Text.RegularExpressions;

namespace MemberSuite.SDK.Utilities
{
    public static class TimeZoneUtils
    {
        public static string GetTimeZoneAbbreviatedTime(DateTime dt, TimeZoneInfo tzi)
        {
            if (tzi == null) throw new ArgumentNullException("tzi");
            var sName = tzi.IsDaylightSavingTime(dt) ? tzi.DaylightName : tzi.StandardName;

            var matches = Regex.Matches(sName, RegularExpressions.FirstLetterBreakerRegex, RegexOptions.Compiled);
            var abbrev = "";
            foreach (Match m in matches)
                abbrev += m.Groups[1].Value;

            return abbrev;
        }
    }
}