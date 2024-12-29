using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
    public class Duration
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Duration()
        {

        }

        public Duration(int _seconds)
        {

            Hour = _seconds / 3600;
            _seconds %= 3600;
            Minute = _seconds / 60;
            _seconds %= 60;
            Second = _seconds;

        }

        public Duration(int _hour, int _minute, int _seconds)
        {
            Hour = _hour;
            Minute = _minute;
            Second = _seconds;
        }

        public override string ToString()
        {
            return $"Hours: {Hour} : Minutes: {Minute} : Seconds: {Second}";
        }

        public override bool Equals(object? obj)
        {
            Duration duration = obj as Duration;

            if (duration is null) return false;

            if (ReferenceEquals(this, duration)) return true;

            if (this.GetType() != duration.GetType()) return false;

            return this.Hour == duration.Hour && this.Minute == duration.Minute && this.Second == duration.Second;
        }


        public static Duration operator +(Duration duration1, Duration duration2)
        {

            return 
                new Duration
                    (duration1.Hour + duration2.Hour, duration1.Minute + duration2.Minute, duration1.Second + duration2.Second);
        }


        public static Duration operator +(Duration duration, int _seconds)
        {
            Duration d = new Duration(_seconds);
            return
                new Duration
                    (duration.Hour + d.Hour, duration.Minute + d.Minute, duration.Second + d.Second);
        }


        public static Duration operator +(int _seconds, Duration duration)
        {
            Duration d = new Duration(_seconds);
            return
                new Duration
                    (duration.Hour + d.Hour, duration.Minute + d.Minute, duration.Second + d.Second);
        }

        public static Duration operator ++(Duration duration)
        {
            return new Duration(duration.Hour,duration.Minute+1,duration.Second);
        }

        public static Duration operator --(Duration duration)
        {
            return new Duration(duration.Hour, duration.Minute - 1, duration.Second);
        }

        public static bool operator >(Duration duration1, Duration duration2)
        {
            if(duration1.Hour == duration2.Hour)
            {
                if(duration1.Minute == duration2.Minute)
                    return duration1.Second > duration2.Second;

                return duration1.Minute > duration2.Minute;

            }return duration1.Hour > duration2.Hour;

        }
        public static bool operator <(Duration duration1, Duration duration2)
        {
            if (duration1.Hour == duration2.Hour)
            {
                if (duration1.Minute == duration2.Minute)
                    return duration1.Second < duration2.Second;

                return duration1.Minute < duration2.Minute;

            }
            return duration1.Hour < duration2.Hour;
        }

        public static bool operator <=(Duration duration1, Duration duration2)
        {
            if (duration1.Hour == duration2.Hour)
            {
                if (duration1.Minute == duration2.Minute)
                    return duration1.Second <= duration2.Second;

                return duration1.Minute <= duration2.Minute;

            }
            return duration1.Hour <= duration2.Hour;
        }

        public static bool operator >=(Duration duration1, Duration duration2)
        {
            if (duration1.Hour == duration2.Hour)
            {
                if (duration1.Minute == duration2.Minute)
                    return duration1.Second >= duration2.Second;

                return duration1.Minute >= duration2.Minute;

            }
            return duration1.Hour >= duration2.Hour;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, d.Hour, d.Minute, d.Second);
        }
    }
}
