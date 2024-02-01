using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    //sub-class for Treasure
	public class Coin : Treasure
	{
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;

        }
        public override void UpdateTotalScore()
		{
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + $"{Board.TotalScore}");
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed.");
           
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            
        }
    }
}

