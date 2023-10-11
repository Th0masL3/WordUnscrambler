using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace WordUnscrambler
{
    class Program
    {



        static void Main(string[] args)
        {


            bool FValid = false;
            bool EValid = false;
            string language = "";


            while (FValid == false && EValid == false)
            {
                Console.WriteLine("Do you want to want to continue in french? Type Y or N: ");
                language = Console.ReadLine().ToUpper();

                switch (language)
                {
                    case "Y":
                        FValid = true;
                      
                        break;

                    case "N":
                        EValid = true;
                        break;

                    default:
                        Console.WriteLine(Properties.strings.Unrecognized);
                        break;
                }


            }


            if (FValid)
            {
                try
                {
                    string question;
                    string option;
                    do
                    {

                        do
                        {
                            Console.WriteLine(Properties.stringsfr_CA.FMPrompt);

                            option = Console.ReadLine() ?? throw new Exception(Properties.stringsfr_CA.Empty);

                            switch (option.ToUpper())
                            {
                                case "F":
                                    Console.WriteLine(Properties.stringsfr_CA.PathPrompt);
                                    ExtensionMethods.ExecuteScrambledWordsInFileScenario(language);
                                    break;
                                case "M":
                                    ExtensionMethods.ExecuteScrambledWordsManualEntryScenario(language);
                                    break;
                                default:
                                    Console.WriteLine(Properties.stringsfr_CA.Unrecognized);
                                    break;
                            }
                        } while (option.ToUpper() != "F" && option.ToUpper() != "M");
                        Console.WriteLine(Properties.stringsfr_CA.ContPrompt);
                        question = Console.ReadLine();
                       
                    } 
                    while (question.ToUpper() == "O");
                    if (question.ToUpper() != "N") throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Properties.stringsfr_CA.Term + ex.Message);

                }
            }

            if (EValid)
            {
                try
                {
                    string question;
                    string option;
                    do
                    {

                        do
                        {
                            Console.WriteLine(Properties.strings.FMPrompt);

                            option = Console.ReadLine() ?? throw new Exception(Properties.strings.Empty);

                            switch (option.ToUpper())
                            {
                                case "F":
                                    Console.WriteLine(Properties.strings.PathPrompt);
                                    ExtensionMethods.ExecuteScrambledWordsInFileScenario(language);
                                    break;
                                case "M":
                                    ExtensionMethods.ExecuteScrambledWordsManualEntryScenario(language);
                                    break;
                                default:
                                    Console.WriteLine(Properties.strings.Unrecognized);
                                    break;
                            }
                        } while (option.ToUpper() != "F" && option.ToUpper() != "M");
                        Console.WriteLine(Properties.strings.ContPrompt);
                        question = Console.ReadLine();
                       

                    } 
                    while (question.ToUpper() == "Y");
                    if (question.ToUpper() != "N") throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Properties.strings.Term + ex.Message);

                }
            }
        }
    }
}




