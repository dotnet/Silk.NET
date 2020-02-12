// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Permutations
{
    public class PermutationGenerator
    {
        public static IEnumerable<Function> GetWithPermutations(Function function)
        {
            var spanOverloader = new SpanOverloader();
            var staticCountOverloader = new StaticCountOverloader();
            var stringOverloader = new StringOverloader();
            
            yield return function;

            Function stringedOverload = null;
            foreach (var parameter in function.Parameters)
            {
                if (stringOverloader.IsApplicable(parameter))
                {
                    
                }
            }
        }
    }
}
