using System;
namespace nagybeadandokod
{

	public class Szervizlap
	{
		public int mettol;
		public int meddig;
		public int ar;

		public Szervizlap(int mettol)
		{
			this.mettol = mettol;
			this.meddig = 0;
			this.ar = 0;
		}

		public void setAr(int ar)
		{
			if (isBefejezett())
			{
				this.ar = ar;
			}
			else
			{
				throw new Exception("Nincs még befejezve");
			}
		}

		public virtual bool isBefejezett()
		{
			if (meddig == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public virtual bool isAtvizsgalas(){

			return false;
		}

        public virtual bool isJavitas()
        {

            return false;
        }
    }
}

