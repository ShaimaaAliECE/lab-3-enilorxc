using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
	//sub-class of Treasure
	public class Diamond : Treasure
	{

		public Diamond(string description, int score) : base(description,score) { }
		public override void UpdateTotalScore()
		{
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + $"{Board.TotalScore}");
        }

        public override void Display()
		{ 
			Console.WriteLine($"Diamond{Description} is displayed");
			
        }


    }
}

