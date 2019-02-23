using System.Collections.Generic;

namespace TitleCapitalizationTool.StringRefactorModules
{
    public class SpaceAndLettersRefactor : StringRefactorRule
    { 
        public override string RefactorString( string value )
        {
            string resultingString = "";

            // ReSharper disable once InvertIf
            if ( value.Length > 0 )
            {
                List< string > words = new List< string >( value.Split( ' ' ) );

                for ( int i = 0; i < words.Count; i++ )
                {
                    if ( i == 0 || i == words.Count - 1 )
                    {
                        words[ i ] = words[ i ].ToLower();

                        words[ i ] = char.ToUpper( words[ i ][ 0 ] ) + words[ i ].Substring( 1 );
                    }
                    else
                    {
                        words[ i ] = words[ i ].ToLower();
                    }
                }

                for (int i = 0; i < words.Count; i++)
                {
                    if ( words[i].Length == 1 && words[i] == " " )
                    {
                        words.RemoveAt( i );
                        i--;
                        continue;
                    }

                    while ( words[i].IndexOf( ' ' ) != -1 )
                    {
                        int pos = words[i].IndexOf( ' ' );

                        // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                        words[i].Remove( pos, 1 );
                    }

                    // ReSharper disable once InvertIf
                    if ( words[i] == "" )
                    {
                        words.RemoveAt( i );
                        i--;
                    }
                }

                resultingString = GatherString( words );
            }

            return resultingString;
        }
    }
}