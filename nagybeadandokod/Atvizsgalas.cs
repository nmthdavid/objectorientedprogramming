using System;
namespace nagybeadandokod
{
	public class Atvizsgalas : Szervizlap
	{
		public Atvizsgalas(int mettol) : base(mettol) { }

		public override bool isAtvizsgalas()
		{
			return true;
		}
		
	}
}

