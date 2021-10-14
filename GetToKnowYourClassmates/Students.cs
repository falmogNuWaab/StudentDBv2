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

        public Students(string Name, string HomeTown, string FavoriteFood)
        {
            this.Name = Name;
            this.HomeTown = HomeTown;
            this.FavoriteFood = FavoriteFood;
        }


    }
}
