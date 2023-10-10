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
            try
            {
                string question;
                string option;
                do {

                    do
                    {
                        Console.WriteLine("Enter scrambled word(s) manually or as a file: F - file / M - manual");

                        option = Console.ReadLine() ?? throw new Exception("String is empty");

                        switch (option.ToUpper())
                        {
                            case "F":
                                Console.WriteLine("Enter full path including the file name: ");
                                ExtensionMethods.ExecuteScrambledWordsInFileScenario();
                                break;
                            case "M":
                                ExtensionMethods.ExecuteScrambledWordsManualEntryScenario();
                                break;
                            default:
                                Console.WriteLine("The entered option was not recognized.");
                                break;
                        }
                    } while (option.ToUpper() != "F" || option.ToUpper() != "M");
                    Console.WriteLine("Do you wish to continue Y/N");
                    question = Console.ReadLine();
                    

                }while (question.ToUpper() != "Y");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The program will be terminated." + ex.Message);

            }
        }
    }
}


