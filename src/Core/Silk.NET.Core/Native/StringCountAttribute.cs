// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Native
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class StringCountAttribute : Attribute
    {
        public object ArbitraryCount { get; }
        public int? ParameterOffset { get; }
        public int? ConstantCount { get; }

        public StringCountAttribute(StringCountType type, int count)
        {
            switch (type)
            {
                case StringCountType.Arbitrary:
                {
                    ArbitraryCount = count;
                    break;
                }
                case StringCountType.Constant:
                {
                    ConstantCount = count;
                    break;
                }
                case StringCountType.ParameterReference:
                {
                    ParameterOffset = count;
                    break;
                }
                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            }

            Type = type;
        }

        public StringCountAttribute(object arbitraryCount)
        {
            ArbitraryCount = arbitraryCount;
            Type = StringCountType.Arbitrary;
        }
        
        public StringCountType Type { get; }
    }
    public enum StringCountType
    {
        Arbitrary,
        Constant,
        ParameterReference
    }
}
