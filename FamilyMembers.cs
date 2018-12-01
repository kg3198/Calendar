namespace Family_Schedule
{
    class FamilyMembers
    {
        public FamilyMembers()
        {

        }

        //return the color associated with each member
        public string Color(string name)
        {            
            if(name == "Mom")
            {
                return "pink";
            }

            else if(name == "Dad")
            {
                return "blue";
            }

            else if(name == "Travis")
            {
                return "green";
            }

            else if(name == "Amy")
            {
                return "purple";
            }

            else
            {
                return "red";
            }
        }

        public string Color(string[] names)
        {
            return "black";
        }
    }
}