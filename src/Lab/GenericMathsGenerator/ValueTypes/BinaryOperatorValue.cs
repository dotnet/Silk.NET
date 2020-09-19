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
    [DebuggerDisplay("({Left}) {OpStr} ({Right})")]
    public abstract class BinaryOperatorValue : IValue
    {
        public IValue Left { get; set; }
        public IValue Right { get; set; }
        public int Step => (Left.Step > Right.Step ? Left.Step : Right.Step) + 1;

        public Optional<float> ConstantValue => Left.ConstantValue.HasValue && Right.ConstantValue.HasValue ? new Optional<float>(Process(Left.ConstantValue.Value, Right.ConstantValue.Value)) : default;
        public IEnumerable<IValue> Children
        {
            get => new[] {Left, Right};
            set
            {
                var arr = value.ToArray();
                if (arr.Length != 2)
                    throw new ArgumentOutOfRangeException(nameof(arr.Length), "Binary operator values have exactly 2 children");
                Left = arr[0];
                Right = arr[1];
            }
        }

        protected abstract float Process(float left, float right);
        protected abstract string OpStr { get; }
    }
}
