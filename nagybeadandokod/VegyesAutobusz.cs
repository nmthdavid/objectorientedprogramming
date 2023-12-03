using System;
namespace nagybeadandokod
{
    public class VegyesAutobusz : Autobusz
    {
        public VegyesAutobusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 2.5;
        }
    }
}

