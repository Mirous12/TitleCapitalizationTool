using System.Collections.Generic;

namespace TitleCapitalizationTool.StringRefactorModules
{
    public class SymbolsRefactor : StringRefactorRule
    {
        public override string RefactorString( string value )
        {
            string result = value;

            // ReSharper disable once InvertIf
            if ( value.Length > 0 )
            {
                List< string > words = new List< string >( value.Split( ' ' ) );

                Dictionary< int, char > charsToPutDictionary = new Dictionary< int, char >();
                
                for ( int i = 0; i < words.Count; i++ )
                {
                    if ( words[ i ].Length != 1 ) continue;
                    
                    char element = words[ i ][ 0 ];
                    bool isLetter = char.IsLetter( element );

                    if ( isLetter ) continue;
                    
                    if ( i == 0 )
                    {
                        words.RemoveAt( 0 );
                    }
                    else if ( i == words.Count - 1 )
                    {
                        words[ words.Count - 2 ] += element; 
                            
                        words.RemoveAt( i );
                    }
                    else
                    {
                        words[ i - 1 ] += element;

                        words.RemoveAt( i );
                    }
                }

                for ( int i = 0; i < words.Count; i++ )
                {
                    if ( words[ i ].Length <= 0 ) continue;
                    
                    char firstSymbol = words[ i ][ 0 ];

                    if ( char.IsLetter( firstSymbol ) ) continue;
                    
                    words[ i ] = words[ i ].Substring( 1 );

                    i--;

                    charsToPutDictionary.TryAdd( i, firstSymbol );
                }

                if ( charsToPutDictionary.Count > 0 )
                {
                    foreach ( var ( key, symbol ) in charsToPutDictionary )
                    {
                        words[ key ] += symbol;
                    }
                }

                result = GatherString( words );
            }

            return result;
        }
    }
}