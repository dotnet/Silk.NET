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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Point\"")]
        [NativeName("Name", "aiPrimitiveType_POINT")]
        PrimitiveTypePoint = 0x1,
        [Obsolete("Deprecated in favour of \"Line\"")]
        [NativeName("Name", "aiPrimitiveType_LINE")]
        PrimitiveTypeLine = 0x2,
        [Obsolete("Deprecated in favour of \"Triangle\"")]
        [NativeName("Name", "aiPrimitiveType_TRIANGLE")]
        PrimitiveTypeTriangle = 0x4,
        [Obsolete("Deprecated in favour of \"Polygon\"")]
        [NativeName("Name", "aiPrimitiveType_POLYGON")]
        PrimitiveTypePolygon = 0x8,
        [Obsolete("Deprecated in favour of \"NgonEncodingFlag\"")]
        [NativeName("Name", "aiPrimitiveType_NGONEncodingFlag")]
        PrimitiveTypeNgonencodingFlag = 0x10,
        [NativeName("Name", "aiPrimitiveType_POINT")]
        Point = 0x1,
        [NativeName("Name", "aiPrimitiveType_LINE")]
        Line = 0x2,
        [NativeName("Name", "aiPrimitiveType_TRIANGLE")]
        Triangle = 0x4,
        [NativeName("Name", "aiPrimitiveType_POLYGON")]
        Polygon = 0x8,
        [NativeName("Name", "aiPrimitiveType_NGONEncodingFlag")]
        NgonEncodingFlag = 0x10,
    }
}
