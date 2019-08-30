using System;

namespace Finecom.Quickline.Common.Helper
{
    /// <summary>
    /// Extension-Klasse fuer Enum-Typen.
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// Gibt den letzten Tag im selben Monat wie vom <seealso cref="dateTime"/> an.
        /// Die Zeit wird ebenfalls mit dem Datum mitgegeben, z.b. 31.01.2014 23:59:59.
        /// </summary>
        /// <param name="dateTime">Datum, fuer welches der letzte Tag im selben Monat berrechnet wird.</param>
        /// <returns>Letzter Tag im Monat des angegebenen Datums.</returns>
        public static DateTime GetLastDayOfMonth(this DateTime dateTime)
        {
            if (dateTime == null) throw new ArgumentNullException("dateTime");

            return dateTime.GetLastDayOfMonth(true);
        }

        /// <summary>
        /// Gibt den letzten Tag im selben Monat wie vom <seealso cref="dateTime"/> an.
        /// </summary>
        /// <param name="dateTime">Datum, fuer welches der letzte Tag im selben Monat berrechnet wird.</param>
        /// <param name="includeTime">
        /// True wenn die Zeit ebenfalls mitgegeben wird, z.b 31.01.2014 23:59:59; 
        /// False wenn diese weggelassen werden soll, z.b. 31.01.2014 00:00:00.
        /// </param>
        /// <returns>Letzter Tag im Monat des angegebenen Datums.</returns>
        public static DateTime GetLastDayOfMonth(this DateTime dateTime, bool includeTime)
        {
            if (dateTime == null) throw new ArgumentNullException("dateTime");

            var result = new DateTime(dateTime.Year, dateTime.Month, 1).AddMonths(1);

            return includeTime ? result.AddSeconds(-1) : result.AddDays(-1);
        }

        /// <summary>
        /// Gibt den ersten Tag im selben Monat wie vom <seealso cref="dateTime"/> an.
        /// Wichtig: Die Stunden, Minuten und Sekunden sind alle auf 0 gesetzt.
        /// </summary>
        /// <param name="dateTime">Datum, fuer welches der erste Tag im selben Monat berrechnet wird.</param>
        /// <returns>Erster Tag im Monat des angegebenen Datums.</returns>
        public static DateTime GetFirstDayOfMonth(this DateTime dateTime)
        {
            if (dateTime == null) throw new ArgumentNullException("dateTime");

            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        /// <summary>
        /// Ermittelt ob das Datum in Jahr und Monat mit dem jetzigen Datum übereinstimmt
        /// </summary>
        /// <param name="dateTime">Datum, welches geprüft wird</param>
        /// <returns>True, falls aktuelles Datum im gleichen Monat wie das geprüfte Datum liegt.</returns>
        public static bool IsCurrentMonth(this DateTime dateTime)
        {
            var today = DateTime.Today;

            var monthStart = today.AddDays(-today.Day + 1);
            var monthEnd = monthStart.AddDays(DateTime.DaysInMonth(today.Year, today.Month)).AddSeconds(-1);

            return (dateTime >= monthStart && dateTime <= monthEnd);
        }

        /// <summary>
        /// Ermittelt ob das Datum dem heutigen Tag entpricht.
        /// </summary>
        /// <param name="dateTime">Datum, welches geprüft wird</param>
        /// <returns>True, falls Datum der heutige Tag ist</returns>
        public static bool IsToday(this DateTime dateTime)
        {
            return (dateTime >= DateTime.Today && dateTime < DateTime.Today.AddDays(1));
        }
    }
}
