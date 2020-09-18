using System;
using System.Linq;

namespace PSAT_to_other_scores
{
    public class SAT
    {
        public static int satScore;
        public static void SatConverter()
        {
            if(Program.psatScore <= 420)
            {
                satScore = Program.psatScore += 230;
            }
            else if (Program.psatScore <= 480)
            {
            satScore = Program.psatScore += 220;
            }
            else if(Program.psatScore <= 550)
            {
            satScore = Program.psatScore += 210;
            }
            else if(Program.psatScore <= 610)
            {
            satScore = Program.psatScore += 200;
            }
            else if(Program.psatScore <= 680)
            {
            satScore = Program.psatScore += 190;
            }
            else if(Program.psatScore <= 740)
            {
            satScore = Program.psatScore += 180;
            }
            else if(Program.psatScore <= 800)
            {
            satScore = Program.psatScore += 170;
            }
            else if(Program.psatScore <= 870)
            {
            satScore = Program.psatScore += 160;
            }
            else if(Program.psatScore <= 930)
            {
            satScore = Program.psatScore += 150;
            }
            else if(Program.psatScore <= 1000)
            {
            satScore = Program.psatScore += 140;
            }
            else if(Program.psatScore <= 1060)
            {
            satScore = Program.psatScore += 130;
            }
            else if(Program.psatScore <= 1120)
            {
            satScore = Program.psatScore += 120;
            }
            else if(Program.psatScore <= 1190)
            {
            satScore = Program.psatScore += 110;
            }
            else if(Program.psatScore <= 1250)
            {
            satScore = Program.psatScore += 100;
            }
            else if(Program.psatScore <= 1320)
            {
            satScore = Program.psatScore += 90;
            }
            else if(Program.psatScore <= 1380)
            {
            satScore = Program.psatScore += 80;
            }
            else if(Program.psatScore <= 1440)
            {
            satScore = Program.psatScore += 70;
            }
            else if(Program.psatScore <= 1510)
            {
            satScore = Program.psatScore += 60;
            }
            else if(Program.psatScore <= 1530)
            {
            satScore = Program.psatScore += 80;
            }
            
        }
    }
}