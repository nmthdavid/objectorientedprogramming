using System;
namespace nagybeadandokod
{
    public class VegyesTrolibusz : Trolibusz
    {
        public VegyesTrolibusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 3.8;
        }
    }
}

