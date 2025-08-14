// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_FORMAT_LAYOUT")]
    public enum D3DFormatLayout : int
    {
        [Obsolete("Deprecated in favour of \"Standard\"")]
        [NativeName("Name", "D3DFL_STANDARD")]
        D3DflStandard = 0x0,
        [Obsolete("Deprecated in favour of \"Custom\"")]
        [NativeName("Name", "D3DFL_CUSTOM")]
        D3DflCustom = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3DFL_STANDARD")]
        Standard = 0x0,
        [NativeName("Name", "D3DFL_CUSTOM")]
        Custom = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
