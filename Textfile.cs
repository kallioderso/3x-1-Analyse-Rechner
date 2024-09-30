using System.Net;
using System.Text;


namespace Rechner;

public class Textfile
{
    
    public static void Exportieren(string Ergebnis)//Method to Write the Text file
    {
        try
        {
            string directoryPath = Path.GetDirectoryName(Setpath.Path);//Getting the Path from Setpath.cs
            
            if (!Directory.Exists(directoryPath))//Check for Directory (if not exist)
            {
                Directory.CreateDirectory(directoryPath);//Create the Directory
                Console.WriteLine("Verzeichnis wurde erstellt: " + directoryPath);//Display the Creation
            }
            
            using (FileStream fileStream = new FileStream(Setpath.Path, FileMode.Append, FileAccess.Write, FileShare.None))//Open the File
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(Ergebnis + Environment.NewLine);//Set the Content of File line
                fileStream.Write(info, 0, info.Length);//Write Line in File
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler beim Exportieren des Ergebnisses: " + ex.Message);//Display the Error
        }
        
    
    }
}