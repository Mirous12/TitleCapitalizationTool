using System.Collections.Generic;
using TitleCapitalizationTool.StringRefactorModules;

namespace TitleCapitalizationTool
{
    public static class RulesFabric
    {
        // ReSharper disable once ReturnTypeCanBeEnumerable.Global
        public static List< StringRefactorRule > GetRefactoringRules()
        {
            List< StringRefactorRule > result = new List< StringRefactorRule >
            {
                new SpaceAndLettersRefactor(), new SymbolsRefactor()
            };

            return result;
        }
    }
}