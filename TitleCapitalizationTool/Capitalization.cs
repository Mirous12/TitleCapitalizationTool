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

            // ReSharper disable once InvertIf
            if ( workingString.Length > 0 )
            {
                var refactoringRules = RulesFabric.GetRefactoringRules();

                foreach ( var rule in refactoringRules )
                {
                    workingString = rule.RefactorString( workingString );
                }
            }

            return workingString;
        }
    }
}