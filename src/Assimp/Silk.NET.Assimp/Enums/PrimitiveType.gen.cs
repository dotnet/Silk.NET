// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
    [NativeName("Name", "aiPrimitiveType")]
    public enum PrimitiveType : int
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
