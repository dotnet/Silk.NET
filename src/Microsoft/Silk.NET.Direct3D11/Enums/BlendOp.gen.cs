// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_BLEND_OP")]
    public enum BlendOp : int
    {
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "D3D11_BLEND_OP_ADD")]
        BlendOpAdd = 0x1,
        [Obsolete("Deprecated in favour of \"Subtract\"")]
        [NativeName("Name", "D3D11_BLEND_OP_SUBTRACT")]
        BlendOpSubtract = 0x2,
        [Obsolete("Deprecated in favour of \"RevSubtract\"")]
        [NativeName("Name", "D3D11_BLEND_OP_REV_SUBTRACT")]
        BlendOpRevSubtract = 0x3,
        [Obsolete("Deprecated in favour of \"Min\"")]
        [NativeName("Name", "D3D11_BLEND_OP_MIN")]
        BlendOpMin = 0x4,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "D3D11_BLEND_OP_MAX")]
        BlendOpMax = 0x5,
        [NativeName("Name", "D3D11_BLEND_OP_ADD")]
        Add = 0x1,
        [NativeName("Name", "D3D11_BLEND_OP_SUBTRACT")]
        Subtract = 0x2,
        [NativeName("Name", "D3D11_BLEND_OP_REV_SUBTRACT")]
        RevSubtract = 0x3,
        [NativeName("Name", "D3D11_BLEND_OP_MIN")]
        Min = 0x4,
        [NativeName("Name", "D3D11_BLEND_OP_MAX")]
        Max = 0x5,
    }
}
