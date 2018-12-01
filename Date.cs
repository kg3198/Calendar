using System.Collections.Generic;

namespace Family_Schedule
{
    public abstract class Date
    {
        public abstract List<int> GetListOfTimes();
        public abstract void AddEvent(List<string> dayOfEvent,
            List<string> description, List<int> block, string date, int time,
            string title);
        public abstract List<string> GetDates();
        public abstract List<string> GetDesctiption();
        public abstract List<int> GetBlock();
    }
}
