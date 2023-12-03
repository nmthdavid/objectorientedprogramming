using System;

namespace nagybeadandokod
{
	public class Onkormanyzat
	{
		public string varos;
		public List<Ceg> cegek;
		public List<Jarmu> jarmuvek;


        public Onkormanyzat(string varos)
		{
			this.cegek = new List<Ceg>();
			this.jarmuvek = new List<Jarmu>();
            this.varos = varos;
		}

		public double mennyireOreg()
		{
			int autobuszok = 0;
			foreach (Jarmu e in jarmuvek)
			{
				if (e.isAutobusz())
				{
					autobuszok++;
				}
			}

            int oregek = 0;
            foreach (Jarmu e in jarmuvek)
			{
				if (e.jelen - e.gyev > 15 && e.isAutobusz())
				{
					oregek++;
				}
			}

			double ans = (double)oregek / (double)autobuszok;
			return ans;
		}

		public double maxErtek()
		{
			double maxert = jarmuvek[0].aktualisErtek();
			foreach (Jarmu e in jarmuvek)
			{
				if (e.aktualisErtek()>maxert)
				{
					maxert = e.aktualisErtek();
				}
			}

			return maxert;
		}

		public double javitasAlatt()
		{
			int javitasalatt=0;

			foreach (Ceg e in cegek)
			{
                foreach (Szervizlap z in e.szervizlapok)
                {
                    if (!z.isBefejezett() && z.isJavitas())
                    {
                        javitasalatt++;
                    }
                }
            }
			return  (double)javitasalatt / (double)jarmuvek.Count;
		}

		public int dragaSzerivz()
		{
			int maxar = cegek[0].szervizlapok[0].ar;

			foreach (Ceg e in cegek)
			{
                foreach (Szervizlap z in e.szervizlapok)
                {
                    if (z.meddig == 2022)
                    {
                        if (z.ar > maxar)
                        {
                            maxar = z.ar;
                        }
                    }
                }
            }
			return maxar;
		}

		public void szervizbeKuld(Jarmu j)
		{
			j.Szervizbe();
		}

		public void szerzodikCeg(Ceg c)
		{
			if (!cegek.Contains(c))
            {
                cegek.Add(c);
            }
		}

        public void jarmuvetVesz(Jarmu j)
		{
			if (!jarmuvek.Contains(j))
			{
				jarmuvek.Add(j);
			}
		}
    }
}

