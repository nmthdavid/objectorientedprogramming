using System;
namespace nagybeadandokod
{
    public class Autobusz : Jarmu
    {
        public Autobusz(string azonosito, int gyev, int ujar) : base(azonosito, gyev, ujar) { }

        public override bool isAutobusz()
        {
            return true;
        }
    }
}

