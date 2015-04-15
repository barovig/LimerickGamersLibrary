
using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    public enum EsrbRating
    {
        Ec,         //Early Childhood
        E,          //Everyone
        E10Plus,    //Everyone 10+
        T,          //Teen
        M,          //Mature
        A,          //Adult only
        Rp          //Rating Pending
    };

    [Serializable]
    public class Game
    {
        public string GameName { set; get; }
        public string Developer { set; get; }
        public string Publisher { set; get; }
        public string Genre { set; get; }
        public EsrbRating Rating { set; get; } 
        public string Platform { set; get; }
        public string GameId { set; get; }
        public string Year { set; get; }
        public Game(string name, string dev, string publisher, string genre, string platform, string year, EsrbRating rating)
        {
            GameName = name;
            Developer = dev;
            Publisher = publisher;
            Genre = genre;
            Platform = platform;
            Year = year;
            Rating = rating;
            GameId = Model.GenerateGameId();
        }

        public Game(string name, string dev, string publisher, string genre, string platform, string year, string rating)
        {
            GameName = name;
            Developer = dev;
            Publisher = publisher;
            Genre = genre;
            Platform = platform;
            Year = year;
            switch (rating)
            {
                case "Ec":
                    Rating = EsrbRating.Ec;
                    break;
                case "E":
                    Rating = EsrbRating.E;
                    break;
                case "E10plus":
                    Rating = EsrbRating.E10Plus;
                    break;
                case "T":
                    Rating = EsrbRating.T;
                    break;
                case "M":
                    Rating = EsrbRating.M;
                    break;
                case "A":
                    Rating = EsrbRating.A;
                    break;
                case "Rp":
                    Rating = EsrbRating.Rp;
                    break;
            }
            GameId = Model.GenerateGameId();
        }

        public string[] ToStringArray()
        {
            return new string[]{GameId, GameName, Genre, Platform, Developer, Publisher, Year.ToString(), Enum.GetName(typeof(EsrbRating),Rating)};
        }
    }
}
