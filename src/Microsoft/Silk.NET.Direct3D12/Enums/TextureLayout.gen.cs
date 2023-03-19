// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_LAYOUT")]
    public enum TextureLayout : int
    {
        [Obsolete("Deprecated in favour of \"LayoutUnknown\"")]
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_UNKNOWN")]
        TextureLayoutUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"LayoutRowMajor\"")]
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_ROW_MAJOR")]
        TextureLayoutRowMajor = 0x1,
        [Obsolete("Deprecated in favour of \"Layout64KBUndefinedSwizzle\"")]
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE")]
        TextureLayout64KBUndefinedSwizzle = 0x2,
        [Obsolete("Deprecated in favour of \"Layout64KBStandardSwizzle\"")]
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE")]
        TextureLayout64KBStandardSwizzle = 0x3,
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_UNKNOWN")]
        LayoutUnknown = 0x0,
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_ROW_MAJOR")]
        LayoutRowMajor = 0x1,
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE")]
        Layout64KBUndefinedSwizzle = 0x2,
        [NativeName("Name", "D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE")]
        Layout64KBStandardSwizzle = 0x3,
    }
}
