// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_GEOMETRY_RELATION")]
    public enum GeometryRelation : int
    {
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_DISJOINT")]
        Disjoint = 0x1,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_IS_CONTAINED")]
        IsContained = 0x2,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_CONTAINS")]
        Contains = 0x3,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_OVERLAP")]
        Overlap = 0x4,
        [NativeName("Name", "D2D1_GEOMETRY_RELATION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
