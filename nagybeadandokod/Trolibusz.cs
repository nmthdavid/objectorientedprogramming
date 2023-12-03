using System;
namespace nagybeadandokod
{
    public class Trolibusz : Jarmu
    {
        public Trolibusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override bool isTrolibusz()
        {
            return true;
        }
    }
}

