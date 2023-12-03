using System;
namespace nagybeadandokod
{
	public class BelvarosiAutobusz : Autobusz
	{
		public BelvarosiAutobusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 2.0;
        }
    }
}

