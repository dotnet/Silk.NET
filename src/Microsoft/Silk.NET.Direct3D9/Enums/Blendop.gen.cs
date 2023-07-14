// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DBLENDOP")]
    public enum Blendop : int
    {
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "D3DBLENDOP_ADD")]
        BlendopAdd = 0x1,
        [Obsolete("Deprecated in favour of \"Subtract\"")]
        [NativeName("Name", "D3DBLENDOP_SUBTRACT")]
        BlendopSubtract = 0x2,
        [Obsolete("Deprecated in favour of \"Revsubtract\"")]
        [NativeName("Name", "D3DBLENDOP_REVSUBTRACT")]
        BlendopRevsubtract = 0x3,
        [Obsolete("Deprecated in favour of \"Min\"")]
        [NativeName("Name", "D3DBLENDOP_MIN")]
        BlendopMin = 0x4,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "D3DBLENDOP_MAX")]
        BlendopMax = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DBLENDOP_FORCE_DWORD")]
        BlendopForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DBLENDOP_ADD")]
        Add = 0x1,
        [NativeName("Name", "D3DBLENDOP_SUBTRACT")]
        Subtract = 0x2,
        [NativeName("Name", "D3DBLENDOP_REVSUBTRACT")]
        Revsubtract = 0x3,
        [NativeName("Name", "D3DBLENDOP_MIN")]
        Min = 0x4,
        [NativeName("Name", "D3DBLENDOP_MAX")]
        Max = 0x5,
        [NativeName("Name", "D3DBLENDOP_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
