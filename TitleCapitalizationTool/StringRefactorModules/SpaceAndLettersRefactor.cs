using System;
using System.Collections.Generic;
using System.Linq;

namespace TitleCapitalizationTool.StringRefactorModules
{
    public class SpaceAndLettersRefactor : StringRefactorRule
    {
        private string GatherString( IReadOnlyCollection< string > wordsArray )
        {
            string result = "";

            // ReSharper disable once InvertIf
            if ( wordsArray.Count > 0 )
            {
                for ( int i = 0; i < wordsArray.Count; i++ )
                {
                    if ( i == 0 )
                    {
                        result += wordsArray.ElementAt( i );
                    }
                    else
                    {
                        result += " " + wordsArray.ElementAt( i );
                    }
                }
            }

            return result;
        }
        
        public override string RefactorString( string value )
        {
            string resultingString = "";

            // ReSharper disable once InvertIf
            if ( value.Length > 0 )
            {
                string[] words = value.Split( ' ' );

                for ( int i = 0; i < words.Length; i++ )
                {
                    if ( i == 0 || i == words.Length - 1 )
                    {
                        words[ i ] = words[ i ].ToLower();

                        words[ i ] = char.ToUpper( words[ i ][ 0 ] ) + words[ i ].Substring( 1 );
                    }
                    else
                    {
                        words[ i ] = words[ i ].ToLower();
                    }
                }

                resultingString = GatherString( words );
            }

            return resultingString;
        }
    }
}