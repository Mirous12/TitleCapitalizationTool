using System;

namespace TitleCapitalizationTool
{
    public class Capitalization
    {
        public string CapitalizeString( string inputString = "" )
        {
            string workingString = "";

            if ( inputString.Length == 0 )
            {
                Console.Write( "Enter the string: " );

                workingString = Console.ReadLine();
            }

            if ( workingString.Length > 0 )
            {
                
            }

            return "";
        }
    }
}