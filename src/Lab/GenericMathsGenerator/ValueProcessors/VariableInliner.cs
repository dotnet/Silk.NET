// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using GenericMathsGenerator.ValueTypes;
using GenericMathsGenerator.VariableTypes;

namespace GenericMathsGenerator
{
    public class VariableInliner : IValueProcessor
    {
        public IEnumerable<IVariable> Process(IEnumerable<IVariable> variables)
        {
            var evaluated = variables.ToArray();
            var toReplace = evaluated
                .OfType<LocalVariable>()
                .Where(x => x.References.Count == 1)
                .ToDictionary(x => x.References[0], x => x.Value);

            IValue RecursiveReplace(IValue value)
            {
                if (value is LocalReferenceValue lrv && toReplace.TryGetValue(lrv, out var n))
                    return n;

                return value.WithChildren(value.Children.Select(RecursiveReplace));
            }

            return evaluated.OfType<LocalVariable>().Where(x => x.References.Count > 1).Select(x => x.WithValue(RecursiveReplace(x.Value)))
                .Concat(evaluated.OfType<ReturnVariable>().Select(x => x.WithValue(RecursiveReplace(x.Value))));
        }
    }
}