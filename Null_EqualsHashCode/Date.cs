namespace Null_EqualsHashCode
{
    public class Date
    {
        public readonly int Day;
        public readonly int Month;

        public Date(int day, int month)
        {
            Day = day;
            Month = month;
        }

        public override bool Equals(object obj)
        {
            return obj switch
            {
                Date date => Day == date.Day && Month == date.Month,
                _ => false
            };
        }
    }
}