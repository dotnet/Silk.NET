// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiPrimitiveType")]
    public enum PrimitiveType
    {
        [NativeName("Name", "aiPrimitiveType_POINT")]
        PrimitiveTypePoint = 0x1,
        [NativeName("Name", "aiPrimitiveType_LINE")]
        PrimitiveTypeLine = 0x2,
        [NativeName("Name", "aiPrimitiveType_TRIANGLE")]
        PrimitiveTypeTriangle = 0x4,
        [NativeName("Name", "aiPrimitiveType_POLYGON")]
        PrimitiveTypePolygon = 0x8,
    }
}
