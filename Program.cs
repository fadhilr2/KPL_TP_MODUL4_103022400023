using System;

public class DoorMachine
{
    public enum State {Terkunci, Terbuka };
    public static void Start()
    {
        State state = State.Terkunci;
        string[] screenName = {"Pintu Terkunci", "Pintu tidak terkunci" };
        while (true)
        {
            Console.WriteLine(screenName[(int)state]);
            Console.Write("Enter Command: ");
            string command = Console.ReadLine();
            switch (state)
            {
                case State.Terkunci:
                    if(command == "BukaPintu")
                    {
                        state = State.Terbuka;
                    }
                    else
                    {
                        state = State.Terkunci;
                    }
                    break;
                case State.Terbuka:
                    if(command == "KunciPintu")
                    {
                        state = State.Terkunci;
                    }
                    else
                    {
                        state = State.Terbuka;
                    }
                    break;
            }
        }
    }
}

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

        DoorMachine doorMachine = new DoorMachine();
        DoorMachine.Start();
    }
}