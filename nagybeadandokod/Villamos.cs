using System;
namespace nagybeadandokod
{
	public class Villamos : Jarmu
	{
		public Villamos(string azonosito, int gyev, int ujar) : base(azonosito,gyev,ujar) { }

        public override bool isVillamos()
        {
            return true;
        }
    }
}

