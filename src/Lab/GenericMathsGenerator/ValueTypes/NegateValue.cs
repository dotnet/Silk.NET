// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace GenericMathsGenerator
{
    public class NegateValue : UnaryOperatorValue
    {
        protected override float Process(float f) => -f;
        protected override string OpStr => "-";
    }
}
