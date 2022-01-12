using System;

namespace KataTimeTable
{
    public class Slot :IEquatable<Slot>
    {
        public Slot(int day, DateTime start, DateTime end)
        {
            Day = day;
            Start = start;
            End = end;
        }

        public int Day { get; }
        public DateTime Start { get; }
        public DateTime End { get; }

        public bool Equals(Slot? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Day == other.Day && Start.Equals(other.Start) && End.Equals(other.End);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Slot) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Day, Start, End);
        }
    }
}