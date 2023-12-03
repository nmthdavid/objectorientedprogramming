using System;
namespace nagybeadandokod
{
    public class VegyesVillamos : Villamos
    {
        public VegyesVillamos(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override double Faktor()
        {
            return 1.2;
        }
    }
}

