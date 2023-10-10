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
           
            Console.WriteLine("Do you want to want to continue in french? Type Y or N: ");
            string language = Console.ReadLine().ToUpper();
            if ( language == "Y")
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


                    } while (question.ToUpper() == "O");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Properties.stringsfr_CA.Term + ex.Message);

                }
            }
     
            else
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


                    } while (question.ToUpper() == "Y");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Properties.strings.Term + ex.Message);

                }
            }
        }
    }





}


