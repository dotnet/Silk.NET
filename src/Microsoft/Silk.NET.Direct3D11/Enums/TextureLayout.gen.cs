// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEXTURE_LAYOUT")]
    public enum TextureLayout : int
    {
        [Obsolete("Deprecated in favour of \"LayoutUndefined\"")]
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_UNDEFINED")]
        TextureLayoutUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"LayoutRowMajor\"")]
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_ROW_MAJOR")]
        TextureLayoutRowMajor = 0x1,
        [Obsolete("Deprecated in favour of \"Layout64KStandardSwizzle\"")]
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_64K_STANDARD_SWIZZLE")]
        TextureLayout64KStandardSwizzle = 0x2,
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_UNDEFINED")]
        LayoutUndefined = 0x0,
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_ROW_MAJOR")]
        LayoutRowMajor = 0x1,
        [NativeName("Name", "D3D11_TEXTURE_LAYOUT_64K_STANDARD_SWIZZLE")]
        Layout64KStandardSwizzle = 0x2,
    }
}
