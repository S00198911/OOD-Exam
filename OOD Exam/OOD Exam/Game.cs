using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Exam
{
    public class Game
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public int CriticScore { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }    
        public string GameImage { get; set; }

        public Game(string name, string platform, int metacritic_score, decimal price, string game_Image, string description = "")
        {
            Name = name;
            Platform = platform;
            CriticScore = metacritic_score;
            Price = price;           
            GameImage = game_Image;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }

        public void DecreasePrice(decimal descrease)
        {
            Price -= descrease;
        }      
    }

    public class GameData : DbContext
    {
        public GameData() : base("MyGameData") { }
    }


}
