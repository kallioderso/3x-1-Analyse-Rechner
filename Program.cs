using System;
using System.Threading;

namespace Rechner
{
    class Automation()
    {
        static void Main(string[] args)
        {

        
            Console.WriteLine("Wieviele Rechenzyklen sollen Getätigt werden?");//Ask for max Calculating Zyklen
            var Zyklen = Convert.ToInt32(Console.ReadLine());//Get max Calculating Zyklen
            
            Console.WriteLine("Bis zu welcher Zahl soll gerechnet werden?");//Ask for max Calculating Number
            var Zahl = Convert.ToInt64(Console.ReadLine());//Get max Calculating Number

            Setpath.path();//Get file Path
            
            Int64 ZahlCount = 0;//Variable for Number Count (Calculated)
            for (int i = 0; i < Zahl; i++)//Create an Loop
            {
                ZahlCount++;//Count the Calculated number
                Calculating.Calculate(ZahlCount, Zyklen);//Calculate Current ZahlCount Number
            }
            Analyse.WriteAnalyse();//Write Analyse
            Console.WriteLine("Fertig!");//Tell that Finished
        }
    }
}
