using System;
using System.Linq;

namespace PSAT_to_other_scores
{
    public class SATOLD
    {
        public static int satOldScore;
        public static void SatOldConverter()
        {
            /*checks to see if satScore is under a certain value, then adds an amount and assigns
            that value to satOldScore*/
            if(SAT.satScore <= 530)
            {
                satOldScore = SAT.satScore += 200;
            }
            else if (SAT.satScore <= 680)
            {
            satOldScore = SAT.satScore += 190;
            }
            else if(SAT.satScore <= 710)
            {
            satOldScore = SAT.satScore += 200;
            }
            else if(SAT.satScore == 720)
            {
            satOldScore = SAT.satScore += 210;
            }
            else if(SAT.satScore <= 740)
            {
            satOldScore = SAT.satScore += 220;
            }
            else if(SAT.satScore <= 760)
            {
            satOldScore = SAT.satScore += 230;
            }
            else if(SAT.satScore <= 780)
            {
            satOldScore = SAT.satScore += 240;
            }
            else if(SAT.satScore <= 800)
            {
            satOldScore = SAT.satScore += 250;
            }
            else if(SAT.satScore <= 810)
            {
            satOldScore = SAT.satScore += 260;
            }
            else if(SAT.satScore <= 830)
            {
            satOldScore = SAT.satScore += 270;
            }
            else if(SAT.satScore <= 850)
            {
            satOldScore = SAT.satScore += 280;
            }
            else if(SAT.satScore <= 870)
            {
            satOldScore = SAT.satScore += 290;
            }
            else if(SAT.satScore <= 890)
            {
            satOldScore = SAT.satScore += 300;
            }
            else if(SAT.satScore <= 910)
            {
            satOldScore = SAT.satScore += 310;
            }
            else if(SAT.satScore <= 930)
            {
            satOldScore = SAT.satScore += 320;
            }
            else if(SAT.satScore <= 950)
            {
            satOldScore = SAT.satScore += 330;
            }
            else if(SAT.satScore <= 980)
            {
            satOldScore = SAT.satScore += 340;
            }
            else if(SAT.satScore <= 1000)
            {
            satOldScore = SAT.satScore += 350;
            }
            else if(SAT.satScore <= 1020)
            {
            satOldScore = SAT.satScore += 360;
            }
            else if(SAT.satScore == 1030)
            {
            satOldScore = SAT.satScore += 370;
            }
            else if(SAT.satScore <= 1050)
            {
            satOldScore = SAT.satScore += 380;
            }
            else if(SAT.satScore == 1070)
            {
            satOldScore = SAT.satScore += 390;
            }
            else if(SAT.satScore <= 1090)
            {
            satOldScore = SAT.satScore += 400;
            }
            else if(SAT.satScore <= 1110)
            {
            satOldScore = SAT.satScore += 410;
            }
            else if(SAT.satScore <= 1120)
            {
            satOldScore = SAT.satScore += 420;
            }
            else if(SAT.satScore <= 1140)
            {
            satOldScore = SAT.satScore += 430;
            }
            else if(SAT.satScore <= 1160)
            {
            satOldScore = SAT.satScore += 440;
            }
            else if(SAT.satScore <= 1180)
            {
            satOldScore = SAT.satScore += 450;
            }
            else if(SAT.satScore <= 1200)
            {
            satOldScore = SAT.satScore += 460;
            }
            else if(SAT.satScore <= 1210)
            {
            satOldScore = SAT.satScore += 470;
            }
            else if(SAT.satScore <= 1230)
            {
            satOldScore = SAT.satScore += 480;
            }
            else if(SAT.satScore <= 1250)
            {
            satOldScore = SAT.satScore += 490;
            }
            else if(SAT.satScore <= 1270)
            {
            satOldScore = SAT.satScore += 500;
            }
            else if(SAT.satScore <= 1290)
            {
            satOldScore = SAT.satScore += 510;
            }
            else if(SAT.satScore == 1300)
            {
            satOldScore = SAT.satScore += 520;
            }
            else if(SAT.satScore <= 1320)
            {
            satOldScore = SAT.satScore += 530;
            }
            else if(SAT.satScore <= 1340)
            {
            satOldScore = SAT.satScore += 540;
            }
            else if(SAT.satScore <= 1350)
            {
            satOldScore = SAT.satScore += 550;
            }
            else if(SAT.satScore <= 1370)
            {
            satOldScore = SAT.satScore += 560;
            }
            else if(SAT.satScore <= 1380)
            {
            satOldScore = SAT.satScore += 570;
            }
            else if(SAT.satScore <= 1400)
            {
            satOldScore = SAT.satScore += 580;
            }
            else if(SAT.satScore <= 1410)
            {
            satOldScore = SAT.satScore += 590;
            }
            else if(SAT.satScore <= 1430)
            {
            satOldScore = SAT.satScore += 600;
            }
            else if(SAT.satScore <= 1440)
            {
            satOldScore = SAT.satScore += 610;
            }
            else if(SAT.satScore <= 1450)
            {
            satOldScore = SAT.satScore += 620;
            }
            else if(SAT.satScore <= 1470)
            {
            satOldScore = SAT.satScore += 630;
            }
            else if(SAT.satScore <= 1480)
            {
            satOldScore = SAT.satScore += 640;
            }
            else if(SAT.satScore <= 1490)
            {
            satOldScore = SAT.satScore += 650;
            }
            else if(SAT.satScore <= 1500)
            {
            satOldScore = SAT.satScore += 660;
            }
            else if(SAT.satScore <= 1510)
            {
            satOldScore = SAT.satScore += 670;
            }
            else if(SAT.satScore <= 1520)
            {
            satOldScore = SAT.satScore += 680;
            }
            else if(SAT.satScore <= 1530)
            {
            satOldScore = SAT.satScore += 690;
            }
            else if(SAT.satScore <= 1540)
            {
            satOldScore = SAT.satScore += 700;
            }
            else if(SAT.satScore <= 1550)
            {
            satOldScore = SAT.satScore += 710;
            }
            else if(SAT.satScore <= 1560)
            {
            satOldScore = SAT.satScore += 720;
            }
            else if(SAT.satScore <= 1570)
            {
            satOldScore = SAT.satScore += 730;
            }
            else if(SAT.satScore <= 1580)
            {
            satOldScore = SAT.satScore += 740;
            }
            else if(SAT.satScore <= 1590)
            {
            satOldScore = SAT.satScore += 750;
            }
            else if(SAT.satScore <= 1600)
            {
            satOldScore = SAT.satScore += 760;
            }


        }
    }
}