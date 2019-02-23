using System;

namespace TitleCapitalizationTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if ( args.Length == 0 )
            {
                Capitalization capitalization = new Capitalization();

                string result = capitalization.CapitalizeString();

                Console.WriteLine( "New string is: " + result );
            }
        }
    }
}