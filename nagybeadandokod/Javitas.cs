using System;
namespace nagybeadandokod
{
    public class Javitas : Szervizlap
    {
        public Javitas(int mettol) : base(mettol) { }

        public override bool isJavitas()
        {
            return true;
        }

    }
}

