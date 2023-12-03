using System;
namespace nagybeadandokod
{
    public class KulvarosiTrolibusz : Trolibusz
    {
        public KulvarosiTrolibusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 3.1;
        }
    }
}

