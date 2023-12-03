using System;
namespace nagybeadandokod
{
    public class KulvarosiAutobusz : Autobusz
    {
        public KulvarosiAutobusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 2.0;
        }
    }
}

