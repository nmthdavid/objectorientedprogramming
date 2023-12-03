using System;
namespace nagybeadandokod
{
    public class KulvarosiVillamos : Villamos
    {
        public KulvarosiVillamos(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 0.9;
        }
    }
}

