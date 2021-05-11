using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Exam
{
    public class Game
    {
        public string Name { get; set; }
        public int Metacritic_Score { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }    
        public string Game_Image { get; set; }

        public Game(string name, int metacritic_score, decimal price, string description, string game_Image = "")
        {
            Name = name;
            Metacritic_Score = metacritic_score;
            Price = price;
            Description = description;
            Game_Image = game_Image;
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
}
