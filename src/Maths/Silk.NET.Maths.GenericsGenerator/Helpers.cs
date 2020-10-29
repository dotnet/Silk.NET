// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Silk.NET.Maths.GenericsGenerator
{
    public static class Helpers
    {
        public static SyntaxTokenList TryRemove
            (this SyntaxTokenList list, Func<SyntaxToken, bool> predicate)
        {
            var tokens = list.Where(predicate);

            foreach (var token in tokens)
            {
                var cIndex = list.IndexOf(token);

                if (cIndex > 0 && cIndex < list.Count)
                {
                    list = list.RemoveAt(cIndex);
                }
            }

            return list;
        }
    }
}
