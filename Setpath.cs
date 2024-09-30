namespace Rechner;

public class Setpath()
{
    public static string Path;//var for the file Path
    public static void path()//Method to Ask for the File Path
    {
        Console.WriteLine("Geben sie den Pfas ein in welchem die Ergebnise Gespeichert werden sollen");//Ask for the file Path
        Path = Console.ReadLine();//Get file Path
    }
}