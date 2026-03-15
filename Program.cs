using System;

public class KodePos
{
    public enum Daerah
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer
    }
    public string getKodePos(Daerah daerah)
    {
        string[] tabelKodePos =
        {
            "40266",
            "40287",
            "40267",
            "40256",
            "40287",
            "40286",
            "40286",
            "40286",
            "40272",
            "40274"
        };

        return tabelKodePos[(int)daerah];
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        KodePos.Daerah lokasi1 = KodePos.Daerah.Batununggal;
        Console.WriteLine(kodePos.getKodePos(lokasi1));
    }
}