using System.Security.Permissions;
using System.Security;
namespace Rechner;

public class Calculating
{
    public static void Calculate(int Zahl, int Zyklen)//Method to Calculate the Current Number
    {
        var Eingabezahl = Zahl;//var for the Current Number
        var ZyklenCount = 0;//var to Count the Zyklus
        for (int i = 0; i < Zyklen; i++)//loop to Calculate 3x+1 with the current number 
        {
            if (Zahl == 1)//check if Number reached the end of the Loop (reched 1)
            {
                break;//Stop the Calculation
            }
            
            if (Zahl % 2 == 0)//Check if The current Number can be Divided by 2 without an remaining
            {
                var NeueZahl = Zahl / 2;//Divided the current number by 2
                Zahl = NeueZahl; // set created number to the Number
                ZyklenCount++; //Add 1 to the count for the Zyklus
            }
            else //Happens if the Number can not be Divided by 2 without an remaining
            {
                var NeueZahl = Zahl * 3 + 1; //Calculate the Current Number with 3x+1
                Zahl = NeueZahl; // set created number to the Number
                ZyklenCount++; //Add 1 to the count for the Zyklus
            }
        }
        
        var Ergebnis = (Eingabezahl + " -> 1 = " + ZyklenCount + " Zyklen");//creates string for File
        Analyse.Kategorisieren(ZyklenCount);//Starts the Analyse Input
        Textfile.Exportieren(Ergebnis);//Writes the file
    }
}
