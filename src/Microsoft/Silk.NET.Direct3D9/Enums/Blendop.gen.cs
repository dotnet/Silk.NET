// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DBLENDOP")]
    public enum Blendop : int
    {
        [NativeName("Name", "D3DBLENDOP_ADD")]
        BlendopAdd = 0x1,
        [NativeName("Name", "D3DBLENDOP_SUBTRACT")]
        BlendopSubtract = 0x2,
        [NativeName("Name", "D3DBLENDOP_REVSUBTRACT")]
        BlendopRevsubtract = 0x3,
        [NativeName("Name", "D3DBLENDOP_MIN")]
        BlendopMin = 0x4,
        [NativeName("Name", "D3DBLENDOP_MAX")]
        BlendopMax = 0x5,
        [NativeName("Name", "D3DBLENDOP_FORCE_DWORD")]
        BlendopForceDword = 0x7FFFFFFF,
    }
}
