// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DTEXTUREADDRESS")]
    public enum Textureaddress : int
    {
        [Obsolete("Deprecated in favour of \"Wrap\"")]
        [NativeName("Name", "D3DTADDRESS_WRAP")]
        TaddressWrap = 0x1,
        [Obsolete("Deprecated in favour of \"Mirror\"")]
        [NativeName("Name", "D3DTADDRESS_MIRROR")]
        TaddressMirror = 0x2,
        [Obsolete("Deprecated in favour of \"Clamp\"")]
        [NativeName("Name", "D3DTADDRESS_CLAMP")]
        TaddressClamp = 0x3,
        [Obsolete("Deprecated in favour of \"Border\"")]
        [NativeName("Name", "D3DTADDRESS_BORDER")]
        TaddressBorder = 0x4,
        [Obsolete("Deprecated in favour of \"Mirroronce\"")]
        [NativeName("Name", "D3DTADDRESS_MIRRORONCE")]
        TaddressMirroronce = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DTADDRESS_FORCE_DWORD")]
        TaddressForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DTADDRESS_WRAP")]
        Wrap = 0x1,
        [NativeName("Name", "D3DTADDRESS_MIRROR")]
        Mirror = 0x2,
        [NativeName("Name", "D3DTADDRESS_CLAMP")]
        Clamp = 0x3,
        [NativeName("Name", "D3DTADDRESS_BORDER")]
        Border = 0x4,
        [NativeName("Name", "D3DTADDRESS_MIRRORONCE")]
        Mirroronce = 0x5,
        [NativeName("Name", "D3DTADDRESS_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
