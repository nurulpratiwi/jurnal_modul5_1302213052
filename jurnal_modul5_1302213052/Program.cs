// See https://aka.ms/new-console-template for more information
using System.Xml.Schema;

public class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic angka1 = a;
        dynamic angka2 = b;
        dynamic angka3 = c;

        return angka1 + angka2 + angka3;

    }

    public static void Main(string[] argd)
    {
        Penjumlahan Tambah = new Penjumlahan();
        Console.WriteLine(Penjumlahan.JumlahTigaAngka(13,02,21));
    }
    
}
