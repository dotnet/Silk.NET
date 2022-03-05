// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_HIT_GROUP_TYPE")]
    public enum HitGroupType : int
    {
        [NativeName("Name", "D3D12_HIT_GROUP_TYPE_TRIANGLES")]
        HitGroupTypeTriangles = 0x0,
        [NativeName("Name", "D3D12_HIT_GROUP_TYPE_PROCEDURAL_PRIMITIVE")]
        HitGroupTypeProceduralPrimitive = 0x1,
    }
}
