using System;
namespace nagybeadandokod
{
	public class Ceg
	{
		public string nev;
		public List<Szervizlap> szervizlapok;

		public Ceg(string nev)
		{
			this.nev = nev;
			this.szervizlapok = new List<Szervizlap>();
        }

		public void Szervizel(Szervizlap sz)
		{
			if (!szervizlapok.Contains(sz))
			{
				szervizlapok.Add(sz);
			}
		}
	}
}

