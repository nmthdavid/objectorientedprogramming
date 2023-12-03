using System;
namespace nagybeadandokod
{
	
	public abstract class Jarmu
	{
		public int jelen;
		public string azonosito;
		public int gyev;
		public int ujar;
		public bool szervizben;


		public Jarmu(string azonosito, int gyev, int ujar)
		{
			this.jelen = 2023;
			this.azonosito = azonosito;
			this.gyev = gyev;
			this.ujar = ujar;
			this.szervizben = false;
		}

		public virtual bool isVillamos()
		{
			return false;
		}

        public virtual bool isAutobusz()
        {
            return false;
        }

        public virtual bool isTrolibusz()
        {
            return false;
        }

		public double aktualisErtek()
		{
            return ujar * ((100 - (jelen - gyev)) / (100.0 * Faktor()));
        }

		public virtual double Faktor()
		{
			return 1;
		}

		public void Szervizbe()
		{
            szervizben = true;
		}

        public void szervizelesKesz()
        {
            szervizben = false;
        }

        public void Dolgozik()
        {
            szervizben = false;
        }
    }
}

