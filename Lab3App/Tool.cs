using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
	public abstract class Tool:Collectable
	{
		protected Tool(string description) : base(description) { }

        public abstract void DoAction();

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }
    }

}

