using System.Collections.Generic;
using System.Linq;

namespace TitleCapitalizationTool
{
    public abstract class StringRefactorRule
    {
        public abstract string RefactorString( string value );
        
        protected string GatherString( IReadOnlyCollection< string > wordsArray )
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
    }
}