// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace GenericMathsGenerator
{
    [DebuggerDisplay("{OpStr}({Child})")]
    public abstract class UnaryOperatorValue : IValue
    {
        public IValue Child { get; set; }

        public int Step => Child.Step + 1;

        public Optional<float> ConstantValue
            => Child.ConstantValue.HasValue ? new Optional<float>(Process(Child.ConstantValue.Value)) : default;

        public IEnumerable<IValue> Children
        {
            get => new[] {Child};
            set
            {
                var arr = value.ToArray();
                if (arr.Length != 1)
                    throw new ArgumentOutOfRangeException
                        (nameof(arr.Length), "Unary operator values have exactly 1 child");
                Child = arr[0];
            }
        }

        protected abstract float Process(float f);
        protected abstract string OpStr { get; }
    }
}
