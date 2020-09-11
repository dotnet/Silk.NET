// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Linq;
using Microsoft.CodeAnalysis;

namespace GenericMathsGenerator
{
    public static class Helpers
    {
        public static SyntaxTokenList TryReplace
            (this SyntaxTokenList list, SyntaxToken tokenInList, SyntaxToken newToken)
        {
            if (list.Contains(tokenInList))
                return list.Replace(tokenInList, newToken);
            return list;
        }
    }
}
