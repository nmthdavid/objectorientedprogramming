using System;
namespace nagybeadandokod
{
	public class BelvarosiTrolibusz : Trolibusz
	{
		public BelvarosiTrolibusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 3.0;
        }
    }

}

