using System.Collections.Generic;
using System.Linq;

namespace Family_Schedule
{
    class Delete
    {
        public Delete()
        {

        }
        
        //deletes the date in list at the specifed index
        public List<string> UpdatedDayOfEvent(int i)
        {
            DeleteEvent.DayOfEvent.RemoveAt(i);
            return DeleteEvent.DayOfEvent;
        }

        //returns the dates in the list
        public List<string> UpdatedDayOfEvent()
        {
            return DeleteEvent.DayOfEvent;
        }

        //deletes the description in list at the specifed index
        public List<string> UpdatedDescription(int i)
        {
            DeleteEvent.Description.RemoveAt(i);
            return DeleteEvent.Description;
        }

        //returns the descriptions in the list
        public List<string> UpdatedDescription()
        {
            return DeleteEvent.Description;
        }

        //deletes the time in list at the specifed index
        public List<int> UpdatedBlock(int i)
        {
            DeleteEvent.Block.RemoveAt(i);
            return DeleteEvent.Block;
        }

        //returns the times in the list
        public List<int> UpdatedBlock()
        {
            return DeleteEvent.Block;
        }

        public string[] UpdatedColor(int i)
        {
            var ColorList = DeleteEvent.Colors.ToList();
            ColorList.RemoveAt(i);
            ColorList.Add("");
            return DeleteEvent.Colors = ColorList.ToArray();
        }

        public string[] UpdatedColor()
        {
            return DeleteEvent.Colors;
        }

        //returns the number of events that were deleted
        public int TotalEventsDeleted()
        {
            return DeleteEvent.count;
        }
    }
}
