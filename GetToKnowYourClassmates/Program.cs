using System;
using System.Collections.Generic;
using System.Linq;

namespace GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool cntnu = true;
            string[] classmates = new string[10];
            classmates[0] = "Beer, Andy";
            classmates[1] = "Conrad, Phillip";
            classmates[2] = "Parr, Zachary";
            classmates[3] = "Christian, Cortez";
            classmates[4] = "Walter, Erin";
            classmates[5] = "Moss, Richard";
            classmates[6] = "Flynn, Cullin";
            classmates[7] = "Reddy, Anurag";
            classmates[8] = "Patton, Marjorie";
            classmates[9] = "Ebberhart, Cordero";

            Dictionary<string, string> HomeTown = new Dictionary<string, string>();
            HomeTown.Add("Beer, Andy", "Berkley, MI");
            HomeTown.Add("Conrad, Phillip", "Canton, MI");
            HomeTown.Add("Parr, Zachary", "Wyandotte, MI");
            HomeTown.Add("Christian, Cortez", "Detroit, MI");
            HomeTown.Add("Walter, Erin", "Troy, MI");
            HomeTown.Add("Moss, Richard", "Canton, MI");
            HomeTown.Add("Flynn, Cullin", "Fowlerville, MI");
            HomeTown.Add("Reddy, Anurag", "Rochester Hills, MI");
            HomeTown.Add("Patton, Marjorie", "Detroit, MI");
            HomeTown.Add("Ebberhart, Cordero", "Berkley, MI");

            Dictionary<string, string> FavFood = new Dictionary<string, string>();
            FavFood.Add("Beer, Andy", "French Fries");
            FavFood.Add("Conrad, Phillip", "Fried Chicken");
            FavFood.Add("Parr, Zachary", "Sushi");
            FavFood.Add("Christian, Cortez", "Chicken Fettuccine Alfredo");
            FavFood.Add("Walter, Erin", "Tacos");
            FavFood.Add("Moss, Richard", "Sushi");
            FavFood.Add("Flynn, Cullin", "Pad Thai");
            FavFood.Add("Reddy, Anurag", "Tacos");
            FavFood.Add("Patton, Marjorie", "Lasagna");
            FavFood.Add("Ebberhart, Cordero", "BBQ");

            Console.WriteLine("Welcome to DevBuild7!");
            Console.WriteLine("");

            List<Students> StudentDB = new List<Students>();

            for (int i = 0; i < classmates.Length; i++)
            {
                string sIndex = classmates[i];
                Students student = new Students(sIndex, HomeTown[sIndex], FavFood[sIndex]);
                Console.WriteLine($"Student Name:{student.Name} \nHomeTown:{student.HomeTown} \nFavorite Food: {student.FavoriteFood}");
                StudentDB.Add(student);          

                Console.WriteLine("");
            }

            foreach(Students pupil in StudentDB)
            {
                Console.WriteLine(pupil.Name);
            }


        }

    }
}

