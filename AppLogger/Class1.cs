using System;
using Humanizer;

namespace AppLogger
{
    public static class Logger
    {   
        public static void Log(DateTime text)
        {
            Console.WriteLine(text.Humanize());
        }
    }
}

