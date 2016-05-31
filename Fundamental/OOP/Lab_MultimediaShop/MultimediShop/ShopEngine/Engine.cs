using System;
using System.Collections.Generic;
using System.Linq;
using MultimediShop.Enums;
using MultimediShop.Interfaces;
using MultimediShop.ModelClasses;


namespace MultimediShop.ShopEngine
{
    class Engine
    {
        private static Dictionary<IItem, int> supplies = new Dictionary<IItem, int>();

        public static void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                // ExecuteCommand(command)
            }

           
        }
        private static void ExecuteCommand(string input)
        {
            //•	supply book 5 id=4fd332&title=Boat&price=20&author=Sellinger&genre=comedy
            //•	supply game 4 id = sfd33 & title = Assassin's_Creed&price=19.00&genre=fiction&ageRestriction=Teen
            string[] splitInput = input.Split();
            string command = splitInput[0];
            switch (command)
            {
                case "supply":
                SupplyItem(splitInput);
                break;
                default:
                break;
            }
        }

        private static void SupplyItem(string[] splitInput)
        {
            string itemType = splitInput[1];
            int quantity = int.Parse(splitInput[2]);
            Dictionary<string, string> parameters = ParseParams( splitInput[3]);
           supplies.Add(CreateItem(itemType, parameters), quantity);

        }

        private static IItem CreateItem(string itemType, Dictionary<string, string> parameters)
        {
            string id = parameters["id"];
            string title = parameters["title"];
            decimal price = decimal.Parse(parameters["price"]);
            List<string> genres = parameters["genres"].Split(',').ToList();
            bool isGenre = genres.Count == 1;

            switch (itemType.ToLower())
            {
                case "book":
                    if(isGenre)
                {
                    return new Book(id, title, price, parameters["author"], genres[0]);
                }
                    return  new Book(id, title, price, parameters["author"], genres);

                case "game":
                AgeRestriction restriction = AgeRestriction.Minor;
                if(parameters["ageRestriction"] == "Teen")
                {
                    restriction = AgeRestriction.Teen;
                }
                else if(parameters["ageRestriction"] == "Adult")
                {
                    restriction = AgeRestriction.Adult;
                }
                return new Game(id, title, price, genres, restriction);
                

                case "Video":
                return new Video(id, title, price, double.Parse(parameters["length"]), genres);

                default:
                throw new NotImplementedException("Game is not implemented yet!");

            }

        }

        private static Dictionary<string, string> ParseParams(string input)
        {
            //•	supply book 5 id=4fd332&title=Boat&price=20&author=Sellinger&genre=comedy
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            string[] pairs = input.Split('&');

            foreach (var pair in pairs)
            {
                string[] keyValuePair = pair.Split('=');
                keyValuePairs[keyValuePair[0]] = keyValuePair[1];
            }
                return keyValuePairs;
        }
    }

}

