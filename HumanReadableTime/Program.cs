using System;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(FormatDuration(Convert.ToInt32( Console.ReadLine())));
            Console.ReadKey();
        }

        public static string FormatDuration(int seconds)
        {
            long yrs = 0, days = 0, hr = 0, min = 0, sec = 0;
            string syrs = "year", sdays = "day", shr = "hour", smin = "minute", ssec = "second";

            while (seconds > 0)
            {
                if (seconds > 0)
                {
                    sec++;
                    seconds--;

                    if (sec > 59)
                    {
                        min++;
                        sec = 0;

                        if (min > 59)
                        {
                            min = 0;
                            hr++;

                            if(hr > 23)
                            {
                                hr = 0;
                                days++;

                                if(days>364)
                                {
                                    days = 0;
                                    yrs++;
                                }
                            }
                        }
                    }
                }
            }

            if (yrs > 1)
                syrs += "s";
            if (days > 1)
                sdays += "s";
            if (hr > 1)
                shr += "s";
            if (min > 1)
                smin += "s";
            if (sec > 1)
                ssec += "s";

            if (hr > 0 && min == 0 && sec == 0)
            {
                return string.Format("{0} {1}", hr, shr);
            }
            else if (min > 0 && sec == 0 && hr==0)
            {
                return string.Format("{0} {1}", min, smin);
            }
            else if (yrs>0 && days>0 && hr>0 && min>0 && sec==0)
            {
                return string.Format("{0} {1}, {2} {3}, {4} {5} and {6} {7}", yrs, syrs, days, sdays, hr, shr, min, smin);
            }
            else if (yrs > 0)
            {
                return string.Format("{0} {1}, {2} {3}, {4} {5}, {6} {7} and {8} {9}", yrs, syrs, days, sdays, hr, shr, min, smin, sec, ssec);
            }
            else if (days > 0)
            {
                return string.Format("{0} {1}, {2} {3}, {4} {5} and {6} {7}", days, sdays, hr, shr, min, smin, sec, ssec);
            }
            else if (hr > 0)
            {
                return string.Format("{0} {1}, {2} {3} and {4} {5}", hr, shr, min, smin, sec, ssec);
            }
            else if (min > 0)
            {
                return string.Format("{0} {1} and {2} {3}", min, smin, sec, ssec);
            }
            else if (sec > 0)
            {
                return string.Format("{0} {1}", sec, ssec);
            }
                return "now";
            }
    }
}