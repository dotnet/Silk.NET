// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.Maths.GenericsGenerator.ValueProcessors
{
    public class VariableInliner : IVariableProcessor
    {
        public IEnumerable<IVariable> Process(IEnumerable<IVariable> variables)
        {
            return variables.Select
            (
                x =>
                {
                    if (x.References.Count == 1 && x.ExtraReferences <= 0)
                    {
                        var @ref = x.References[0];
                        var value = x.Value;
                        @ref.Parent?.WithChildren(@ref.Parent.Children.Select(x2 => (x2 == @ref) ? value : x2));
                    }

                    return x;
                }
            );
        }
    }
}