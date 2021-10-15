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

            Console.WriteLine("Welcome to DevBuild7");
            Console.WriteLine("Student Database!");

            List<Students> StudentDB = new List<Students>();

            for (int i = 0; i < classmates.Length; i++)
            {
                string sIndex = classmates[i];
                Students student = new Students(sIndex, HomeTown[sIndex], FavFood[sIndex]);
                //Console.WriteLine($"Student Name:{student.Name} \nHomeTown:{student.HomeTown} \nFavorite Food: {student.FavoriteFood}");
                StudentDB.Add(student);
                Console.WriteLine($"{i + 1}: {student.Name} "); //Add one for usability, will subract 1 later.
                //Console.WriteLine("");
            }
            bool startStop = true;
            while (startStop)
            {
                Students pickSomebody = FindStudent(StudentDB);
                Console.WriteLine($"You have selected: {pickSomebody.FirstName}");

                string whatDoYouWantToKnow = GetUserInput("What would you like to know?\n1)HomeTown \n2)Favorite Food\n");
                string findTheInfo = LearnMore(whatDoYouWantToKnow, pickSomebody);

                if (findTheInfo == "FavoriteFood")
                {
                    Console.WriteLine($"{pickSomebody.FirstName} likes {pickSomebody.FavoriteFood}");
                }
                else if (findTheInfo == "HomeTown")
                {
                    Console.WriteLine($"{pickSomebody.FirstName} is from {pickSomebody.HomeTown}");
                }
                startStop = KeepGoing();
            }

        }
        public static bool KeepGoing()
        {
            string shouldWeKeepGoing = GetUserInput("Would you like to learn about another student?(y/n)");
            if(shouldWeKeepGoing.ToLower() == "y")
            {
                return true;
            } 
            else if(shouldWeKeepGoing.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that.");
                return KeepGoing();
            }
        }
        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string response = Console.ReadLine();
            return response;
        }

        public static Students FindStudent(List<Students>StudentDB)
        {
            string selectStudent = GetUserInput("Which student would you like to learn more about?");
            int oPut = 0;
            Students tStudent;
            if (int.TryParse(selectStudent, out oPut))
            {
                oPut = oPut - 1; //As promised, subtracting 1
                tStudent = StudentDB[oPut];
                return tStudent;
                
            }
            else
            {
                for (int i = 0; i < StudentDB.Count; i++)
                {
                    if (StudentDB[i].Name.Contains(selectStudent))
                    {
                        tStudent = StudentDB[i];
                        //Console.WriteLine($"{StudentDB[i].Name} selected");
                        return tStudent;
                    }
                    else
                    {
                        //Console.WriteLine("Student not found");
                        continue;
                    }
                }
                return FindStudent(StudentDB);
            }
        }

        public static string LearnMore(string input, Students targetStudent)
        {
            if ((int.TryParse(input, out int result) && result ==2) || input.Contains("Favorite") || input.Contains("Food"))
            {
                return "FavoriteFood";
            }
            else
            {
                return "HomeTown";
            }
        }
    }
}

