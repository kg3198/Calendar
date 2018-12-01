using System.Collections.Generic;

namespace Family_Schedule
{
    public class DateStore : Date
    {
        private List<string> _dayOfEvent { get; set; }
        private List<int> _times = new List<int> { 0000 };
        private List<string> _description { get; set; }
        private List<int> _block { get; set; }
       
        public DateStore()
        {
            //add military time to the list
            for (int i = 0100; i <= 2400; i = i + 100)
            {
                _times.Add(i);
            }
        }

        public override List<int> GetListOfTimes()
        {
            return _times;
        }

        public override void AddEvent(List<string> dayOfEvent, 
            List<string> description, List<int> block, string date, int time, 
            string title)
        {
            _dayOfEvent = dayOfEvent;
            _dayOfEvent.Add(date);

            _description = description;
            _description.Add(title);

            _block = block;
            _block.Add(time);
        }

        public override List<string> GetDates()
        {            
            return _dayOfEvent;
        }

        public override List<string> GetDesctiption()
        {
            return _description;
        }

        public override List<int> GetBlock()
        {
            return _block;
        }        
    }
}
