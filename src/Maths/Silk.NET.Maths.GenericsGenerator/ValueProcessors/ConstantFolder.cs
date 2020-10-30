// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Maths.GenericsGenerator.ValueTypes;

namespace Silk.NET.Maths.GenericsGenerator.ValueProcessors
{
    public sealed class ConstantFolder : IValueProcessor
    {
        public IValue Process
            (IValue value, Func<IValue> next)
            => value.ConstantValue.HasValue 
                ? new LiteralValue(value.ConstantValue.Value, value.Type) { Scope = value.Scope}
                : next();
    }
}
