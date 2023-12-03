namespace nagybeadandokod;
public class Program
{
    public static Onkormanyzat beolvas()
    {
        StreamReader sr3 = new StreamReader("onkormanyzat.txt");
        string line = "";
        Onkormanyzat davidvarosa=null;
        while ((line = sr3.ReadLine()) != null)
        {
            string[] splitted = line.Split(",");
            string onkormanyzat = splitted[0];
            davidvarosa = new Onkormanyzat(splitted[0]);
        }
        sr3.Close();

        StreamReader sr = new StreamReader("jarmuvek.txt");
        line = "";
        List<Jarmu> jarmuvek = new List<Jarmu>();
        while ((line = sr.ReadLine())!=null)
        {
            string[] splitted = line.Split(",");
            string kategoria = splitted[0];
            switch (kategoria)
            {
                case "1":
                    davidvarosa.jarmuvetVesz(new BelvarosiVillamos(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "2":
                    davidvarosa.jarmuvetVesz(new KulvarosiVillamos(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "3":
                    davidvarosa.jarmuvetVesz(new VegyesVillamos(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "4":
                    davidvarosa.jarmuvetVesz(new BelvarosiAutobusz(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "5":
                    davidvarosa.jarmuvetVesz(new KulvarosiAutobusz(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "6":
                    davidvarosa.jarmuvetVesz(new VegyesAutobusz(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "7":
                    davidvarosa.jarmuvetVesz(new BelvarosiTrolibusz(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "8":
                    davidvarosa.jarmuvetVesz(new KulvarosiTrolibusz(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                case "9":
                    davidvarosa.jarmuvetVesz(new VegyesTrolibusz(splitted[1], Convert.ToInt32(splitted[2]), Convert.ToInt32(splitted[3])));
                    break;
                default:
                    break;
            }
         }
            sr.Close();

            StreamReader sr2 = new StreamReader("ceg.txt");
            line = "";
            while ((line = sr2.ReadLine()) != null)
            {
                
                string[] splitted = line.Split(",");
                string ceg = splitted[0];
                davidvarosa.szerzodikCeg(new Ceg(ceg));
                
            }
            sr2.Close();

        return davidvarosa;


    }
    static void Main(string[] args)
    {
     
        //Onkormanyzat davidvarosa2 = beolvas();
        Onkormanyzat davidvarosa = beolvas();

        //BelvarosiAutobusz bbuszz1 = new BelvarosiAutobusz("AASDF", 2004, 20000000);
        //BelvarosiAutobusz bbuszz2 = new BelvarosiAutobusz("AASDF", 2023, 20000000);
        //BelvarosiAutobusz bbuszz3 = new BelvarosiAutobusz("AASDF", 2023, 20000000);
        //KulvarosiVillamos kvill1 = new KulvarosiVillamos("AWEDF", 2008, 10000000);
        //VegyesTrolibusz vvill1 = new VegyesTrolibusz("WEDFR", 2010, 5000000);
        //Ceg ceg = new Ceg("David KFT");
        //Ceg ceg2 = new Ceg("Tibor KFT");

        //davidvarosa.szerzodikCeg(davidvarosa.cegek[0]);
        //davidvarosa.szerzodikCeg(davidvarosa.cegek[1]);

        //davidvarosa.jarmuvetVesz(davidvarosa.jarmuvek[0]);
        //davidvarosa.jarmuvetVesz(davidvarosa.jarmuvek[1]);
        //davidvarosa.jarmuvetVesz(davidvarosa.jarmuvek[2]);
        //davidvarosa.jarmuvetVesz(davidvarosa.jarmuvek[3]);
        //davidvarosa.jarmuvetVesz(davidvarosa.jarmuvek[4]);

        Console.WriteLine(davidvarosa.mennyireOreg());
        Console.WriteLine(davidvarosa.maxErtek());

        davidvarosa.jarmuvek[0].Szervizbe();
        Javitas atv1 = new Javitas(2021);
        Javitas atv2 = new Javitas(2021);
        Javitas jav1 = new Javitas(2021);
        Javitas jav2 = new Javitas(2021);
        jav2.meddig = 2022;
        jav1.meddig = 2022;
        atv1.meddig = 2022;
        davidvarosa.cegek[0].Szervizel(atv1);
        davidvarosa.cegek[0].Szervizel(atv2);
        davidvarosa.cegek[0].Szervizel(jav1);
        davidvarosa.cegek[0].Szervizel(jav2);
        Console.WriteLine(davidvarosa.javitasAlatt());

        jav2.setAr(50000);
        jav1.setAr(60000);
        atv1.setAr(70000);

        Console.WriteLine(davidvarosa.dragaSzerivz());
    }
}

