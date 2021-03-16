// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_HIT_KIND")]
    public enum HitKind : int
    {
        [NativeName("Name", "D3D12_HIT_KIND_TRIANGLE_FRONT_FACE")]
        HitKindTriangleFrontFace = 0xFE,
        [NativeName("Name", "D3D12_HIT_KIND_TRIANGLE_BACK_FACE")]
        HitKindTriangleBackFace = 0xFF,
    }
}
