using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
	//Parent class for Diamond and Coin
	public abstract class Treasure : Collectable
	{
        // A public property to hold the score value of the treasure.
        public int Score { get; set; }

		//:base() = to call the parent constructor which is Collectable equivalent to calling super() in Java
		protected Treasure(string description, int score) : base(description)
		{
			Score = score;
		}

		public virtual void UpdateTotalScore()
		{
		}

		public override void AddMe(List<Collectable> list)
		{
			base.AddMe(list);
			UpdateTotalScore();
		}
	}
}

