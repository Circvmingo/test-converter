using System;
using System.Linq;

namespace PSAT_to_other_scores
{
    public class Program
    {
        public static int psatScore;
        public static int satScore;
        public static string startTest;
        static void Main(string[] args)
        {
            //makes this crap go until you want it to stop
            bool endApp = false;

            string[] list = { "SAT", "SATOLD", "ACT" };

            //starting instructions
            Console.WriteLine("PSAT and SAT to other test conversions");
            Console.WriteLine("-------------------------------------------------");

            while (!endApp)
            {
                //asks for SAT or PSAT
                Console.WriteLine("To convert from a PSAT score, type \"PSAT\". To convert from an SAT score, type \"SAT\".\nNote that PSAT can estimate SAT, SAT 2400 format, and ACT. SAT can only estimate to SAT 2400 format and ACT.");
                startTest = Console.ReadLine();
                startTest = startTest.ToUpper();
                if (startTest == "PSAT")
                {
                    Console.WriteLine("\n Choose what test you would like to convert to");
                    Console.WriteLine("\nTo convert to the SAT 1600 format,type \"SAT\"\nTo convert to the SAT 2400 format, type \"SATOLD\"\nTo convert to the ACT scoring format, type\"ACT\"");

                    //getting user input
                    string testType = (Console.ReadLine());
                    testType = testType.ToUpper();

                    //checks to make sure that the input is a valid test type
                    while (!list.Contains(testType))
                    {
                        Console.WriteLine("Not a valid test type, please try again");
                        testType = (Console.ReadLine());
                        testType = testType.ToUpper();
                    }

                    //gets the users psat score
                    Console.WriteLine("please enter PSAT test score");
                    psatScore = Convert.ToInt32(Console.ReadLine());

                    //runs different programs according to what test is wanted
                    switch (testType)
                    {
                        //runs SAT.cs to create and assign satScore, then prints it
                        case "SAT":
                            SAT.SatConverter();
                            Console.WriteLine("\nA rough estimate of your predicted SAT score: \n" + SAT.satScore);
                            break;
                        /*
                        runs SAT.cs to create and assign satScore, which is then used for
                        running SATOLD.cs. SATOLD.cs then creates and assigns sastOldScore,
                        and then that is printed. I did this bc I couldn't find any sites online
                        that predicted your SAT 2400 format score directly from your PSAT score
                        */
                        case "SATOLD":
                            SAT.SatConverter();
                            SATOLD.SatOldConverter();
                            Console.WriteLine("\nA really rough estimate of your predicted SAT score in the 2400 format: \n" + SATOLD.satOldScore);
                            break;
                        /*
                        runs SAT.cs to create and assign satScore, which is then used for
                        running ACT.cs. ACT.cs then checks that value against a bunch of else if less than
                        lines, and assigns a value to actScore, and then that is printed.
                        */
                        case "ACT":
                            SAT.SatConverter();
                            ACT.ActConverter();
                            Console.WriteLine("\nA pretty rough estimate of your predicted ACT score: \n" + ACT.actScore);
                            break;

                    }
                    //end task is below
                    Console.WriteLine("------------------------\n");

                    // Wait for the user to respond before closing.
                    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "n") endApp = true;

                    Console.WriteLine("\n"); // Friendly linespacing.
                }










                else if (startTest == "SAT")
                {
                    Console.WriteLine("\n Choose what test you would like to convert to");
                    Console.WriteLine("\nTo convert to the SAT 2400 format, type \"SATOLD\"\nTo convert to the ACT scoring format, type\"ACT\"");

                    //getting user input
                    string testType = (Console.ReadLine());
                    testType = testType.ToUpper();
                    //checks to make sure that the input is a valid test type
                    while (!list.Contains(testType))
                    {
                        Console.WriteLine("Not a valid test type, please try again");
                        testType = (Console.ReadLine());
                        testType = testType.ToUpper();
                    }

                    //gets the users psat score
                    Console.WriteLine("please enter SAT test score");
                    satScore = Convert.ToInt32(Console.ReadLine());

                    //runs different programs according to what test is wanted
                    switch (testType)
                    {

                        /*
                        runs SAT.cs to create and assign satScore, which is then used for
                        running SATOLD.cs. SATOLD.cs then creates and assigns sastOldScore,
                        and then that is printed. I did this bc I couldn't find any sites online
                        that predicted your SAT 2400 format score directly from your PSAT score
                        */
                        case "SATOLD":
                            SATOLDs.SatOldConverter();
                            Console.WriteLine("\nA rough estimate of your converted SAT score in the 2400 format: \n" + SATOLDs.satOldScore);
                            break;

                        /*
                        runs SAT.cs to create and assign satScore, which is then used for
                        running ACT.cs. ACT.cs then checks that value against a bunch of else if less than
                        lines, and assigns a value to actScore, and then that is printed.
                        */
                        case "ACT":
                            ACTs.ActConverter();
                            Console.WriteLine("\nA pgood estimate of your converted ACT score: \n" + ACTs.actScore);
                            break;

                    }
                    //end task is below
                    Console.WriteLine("------------------------\n");

                    // Wait for the user to respond before closing.
                    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "n") endApp = true;

                    Console.WriteLine("\n"); // Friendly linespacing.
                }
                else
                {
                    Console.WriteLine("Invalid starting test. Please try again\n");
                }
            }

        }
    }
}