using System;

namespace RecurrenceTester
{
    public class DateItem
    {
        private DateTime value;

        public DateItem(DateTime dateValue)
        {
            value = dateValue;
        }

        public DateTime Value
        {
            get
            {
                return value;
            }
        }

        public override string ToString()
        {
            return value.ToString("d MMM, yyyy   ddd");
        }
    }
}