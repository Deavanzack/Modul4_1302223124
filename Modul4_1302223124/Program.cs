using Modul4_1302223124;

internal class program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("uji buah");

        Console.WriteLine("kode buah aprikot: " + KodeBuah.getcodebuah(KodeBuah.buah.Aprikot));

        Console.WriteLine();
        Console.WriteLine("Testing karakter game");
        Console.WriteLine();

        PosisiKarakterGame posisi = new PosisiKarakterGame();

        Console.WriteLine("\ncoba posisi standby...");
        posisi.posisikar();
    }
}