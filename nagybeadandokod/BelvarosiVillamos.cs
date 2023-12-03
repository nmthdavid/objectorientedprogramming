using System;
namespace nagybeadandokod
{
    public class BelvarosiVillamos : Villamos
    {
        public BelvarosiVillamos(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 1.0;
        }
    }
}

