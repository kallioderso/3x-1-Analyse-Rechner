namespace Rechner;

public class Analyse
{
    #region Analys Criteria

    public static int U50 = 0;
    public static int U75 = 0;
    public static int U100 = 0;
    public static int U125 = 0;
    public static int U150 = 0;
    public static int U175 = 0;
    public static int U200 = 0;
    public static int U225 = 0;
    public static int U250 = 0;
    public static int U275 = 0;
    public static int U300 = 0;
    public static int U325 = 0;
    public static int U350 = 0;
    public static int U375 = 0;
    public static int U400 = 0;
    public static int U425 = 0;
    public static int U450 = 0;
    public static int U475 = 0;
    public static int U500 = 0;
    public static int U525 = 0;
    public static int U550 = 0;
    public static int U575 = 0;
    public static int U600 = 0;
    public static int U625 = 0;
    public static int U650 = 0;
    public static int U675 = 0;
    public static int U700 = 0;
    public static int U725 = 0;
    public static int U750 = 0;
    public static int U775 = 0;
    public static int U800 = 0;
    public static int U825 = 0;
    public static int U850 = 0;
    public static int U875 = 0;
    public static int U900 = 0;
    public static int U925 = 0;
    public static int U950 = 0;
    public static int U975 = 0;
    public static int U1000 = 0;

    #endregion //var for Analyse Criterias
    

    public static void Kategorisieren(int Zyklen)
    {
        #region AnalyseFunktion

        if (Zyklen >= 50)
        {
            U50++;
        }
        
        if (Zyklen >= 75)
        {
            U75++;
        }
        
        if (Zyklen >= 100)
        {
            U100++;
        }
        
        if (Zyklen >= 125)
        {
            U125++;
        }
        
        if (Zyklen >= 150)
        {
            U150++;
        }
        
        if (Zyklen >= 175)
        {
            U175++;
        }
        
        if (Zyklen >= 200)
        {
            U200++;
        }
        
        if (Zyklen >= 225)
        {
            U225++;
        }
        
        if (Zyklen >= 250)
        {
            U250++;
        }
        
        if (Zyklen >= 275)
        {
            U275++;
        }
        
        if (Zyklen >= 300)
        {
            U300++;
        }
        
        if (Zyklen >= 325)
        {
            U325++;
        }
        
        if (Zyklen >= 350)
        {
            U350++;
        }
        
        if (Zyklen >= 375)
        {
            U375++;
        }
        
        if (Zyklen >= 400)
        {
            U400++;
        }
        
        if (Zyklen >= 425)
        {
            U425++;
        }
        
        if (Zyklen >= 450)
        {
            U450++;
        }
        
        if (Zyklen >= 475)
        {
            U475++;
        }
        
        if (Zyklen >= 500)
        {
            U500++;
        }
        
        if (Zyklen >= 525)
        {
            U525++;
        }
        
        if (Zyklen >= 550)
        {
            U550++;
        }
        
        if (Zyklen >= 575)
        {
            U575++;
        }
        
        if (Zyklen >= 600)
        {
            U600++;
        }
                
        if (Zyklen >= 625)
        {
            U625++;
        }
        
        if (Zyklen >= 650)
        {
            U650++;
        }
        
        if (Zyklen >= 675)
        {
            U675++;
        }
        
        if (Zyklen >= 700)
        {
            U700++;
        }
                
        if (Zyklen >= 725)
        {
            U725++;
        }
        
        if (Zyklen >= 750)
        {
            U750++;
        }
        
        if (Zyklen >= 775)
        {
            U775++;
        }
        
        if (Zyklen >= 800)
        {
            U800++;
        }
        if (Zyklen >= 825)
        {
            U825++;
        }
        
        if (Zyklen >= 850)
        {
            U850++;
        }
        
        if (Zyklen >= 875)
        {
            U875++;
        }
        
        if (Zyklen >= 900)
        {
            U900++;
        }
                
        if (Zyklen >= 925)
        {
            U925++;
        }
        
        if (Zyklen >= 950)
        {
            U950++;
        }
        
        if (Zyklen >= 975)
        {
            U975++;
        }
        
        if (Zyklen >= 1000)
        {
            U1000++;
        }

        #endregion//Count the Analyse Criterias
    }

    public static void WriteAnalyse()
    {
        #region Analyse Output File

        Textfile.Exportieren(" ");
        Textfile.Exportieren(" ");
        Textfile.Exportieren(" ");
        Textfile.Exportieren("Analyse:");
        Textfile.Exportieren(" ");
        Textfile.Exportieren(("Über 50 Zyklen: " + U50));
        Textfile.Exportieren(("Über 75 Zyklen: " + U75));
        Textfile.Exportieren(("Über 100 Zyklen: " + U100));
        Textfile.Exportieren(("Über 125 Zyklen: " + U125));
        Textfile.Exportieren(("Über 150 Zyklen: " + U150));
        Textfile.Exportieren(("Über 175 Zyklen: " + U175));
        Textfile.Exportieren(("Über 200 Zyklen: " + U200));
        Textfile.Exportieren(("Über 225 Zyklen: " + U225));
        Textfile.Exportieren(("Über 250 Zyklen: " + U250));
        Textfile.Exportieren(("Über 275 Zyklen: " + U275));
        Textfile.Exportieren(("Über 300 Zyklen: " + U300));
        Textfile.Exportieren(("Über 325 Zyklen: " + U325));
        Textfile.Exportieren(("Über 350 Zyklen: " + U350));
        Textfile.Exportieren(("Über 375 Zyklen: " + U375));
        Textfile.Exportieren(("Über 400 Zyklen: " + U400));
        Textfile.Exportieren(("Über 425 Zyklen: " + U425));
        Textfile.Exportieren(("Über 450 Zyklen: " + U450));
        Textfile.Exportieren(("Über 475 Zyklen: " + U475));
        Textfile.Exportieren(("Über 500 Zyklen: " + U500));
        Textfile.Exportieren(("Über 525 Zyklen: " + U525));
        Textfile.Exportieren(("Über 550 Zyklen: " + U550));
        Textfile.Exportieren(("Über 575 Zyklen: " + U575));
        Textfile.Exportieren(("Über 600 Zyklen: " + U600));
        Textfile.Exportieren(("Über 625 Zyklen: " + U625));
        Textfile.Exportieren(("Über 650 Zyklen: " + U650));
        Textfile.Exportieren(("Über 675 Zyklen: " + U675));
        Textfile.Exportieren(("Über 700 Zyklen: " + U700));
        Textfile.Exportieren(("Über 725 Zyklen: " + U725));
        Textfile.Exportieren(("Über 750 Zyklen: " + U750));
        Textfile.Exportieren(("Über 775 Zyklen: " + U775));
        Textfile.Exportieren(("Über 800 Zyklen: " + U800));
        Textfile.Exportieren(("Über 825 Zyklen: " + U825));
        Textfile.Exportieren(("Über 850 Zyklen: " + U850));
        Textfile.Exportieren(("Über 875 Zyklen: " + U875));
        Textfile.Exportieren(("Über 900 Zyklen: " + U900));
        Textfile.Exportieren(("Über 925 Zyklen: " + U925));
        Textfile.Exportieren(("Über 950 Zyklen: " + U950));
        Textfile.Exportieren(("Über 975 Zyklen: " + U975));
        Textfile.Exportieren(("Über 1000 Zyklen: " + U1000));

        #endregion//Write the Analyse
        
    }
}