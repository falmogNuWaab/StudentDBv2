using System;
using System.Collections.Generic;
using System.Text;

namespace GetToKnowYourClassmates
{
    class Students
    {
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string FavoriteFood { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string [] FullNameArray { get; set; }

        public Students(string Name, string HomeTown, string FavoriteFood)
        {
            this.Name = Name;
            this.HomeTown = HomeTown;
            this.FavoriteFood = FavoriteFood;
            this.FullNameArray = Name.Split(",");
            this.FirstName = this.FullNameArray[1].Trim();
            this.LastName = this.FullNameArray[0];
            
        }


    }
}
