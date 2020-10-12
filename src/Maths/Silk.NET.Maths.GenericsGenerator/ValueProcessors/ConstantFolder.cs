// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using GenericMathsGenerator.ValueTypes;

namespace GenericMathsGenerator
{
    public class ConstantFolder : IValueProcessor
    {
        public IEnumerable<IValue> Process(IEnumerable<IValue> values) 
            => values.Select(x => x.ConstantValue.HasValue ? new LiteralValue(x.ConstantValue.Value) : x.WithChildren(Process(x.Children)));

        public IEnumerable<IVariable> Process(IEnumerable<IVariable> variables)
            => variables.Select
            (
                x => x.WithValue
                (
                    x.Value.ConstantValue.HasValue
                        ? new LiteralValue(x.Value.ConstantValue.Value)
                        : x.Value.WithChildren(Process(x.Value.Children))
                )
            );

        public IValue Process
            (IValue value, Func<IValue> next)
            => value.ConstantValue.HasValue 
                ? new LiteralValue(value.ConstantValue.Value) 
                : next();
    }
}
