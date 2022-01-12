using System;
using System.Collections.Generic;
using System.Linq;

namespace KataTimeTable
{
    public static class Helper
    {
        public static Slot ParseOneLine(string input)
        {
            var test = input.Split('-', ' ');
            var day = int.Parse(test[0]);
            var start = DateTime.Parse(test[1]);
            var end = DateTime.Parse(test[2]);
            return new Slot(day, start, end);
        }

        public static IEnumerable<Slot> Parse(IEnumerable<string> lines)
            => lines.Skip(1).Select(ParseOneLine);
        
    }
}