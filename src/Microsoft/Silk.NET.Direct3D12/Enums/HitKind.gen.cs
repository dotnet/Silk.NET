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
        [Obsolete("Deprecated in favour of \"FrontFace\"")]
        [NativeName("Name", "D3D12_HIT_KIND_TRIANGLE_FRONT_FACE")]
        HitKindTriangleFrontFace = 0xFE,
        [Obsolete("Deprecated in favour of \"BackFace\"")]
        [NativeName("Name", "D3D12_HIT_KIND_TRIANGLE_BACK_FACE")]
        HitKindTriangleBackFace = 0xFF,
        [NativeName("Name", "D3D12_HIT_KIND_TRIANGLE_FRONT_FACE")]
        FrontFace = 0xFE,
        [NativeName("Name", "D3D12_HIT_KIND_TRIANGLE_BACK_FACE")]
        BackFace = 0xFF,
    }
}
