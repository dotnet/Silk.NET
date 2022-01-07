// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_ALPHA_MODE")]
    public enum AlphaMode : int
    {
        [NativeName("Name", "DXGI_ALPHA_MODE_UNSPECIFIED")]
        AlphaModeUnspecified = 0x0,
        [NativeName("Name", "DXGI_ALPHA_MODE_PREMULTIPLIED")]
        AlphaModePremultiplied = 0x1,
        [NativeName("Name", "DXGI_ALPHA_MODE_STRAIGHT")]
        AlphaModeStraight = 0x2,
        [NativeName("Name", "DXGI_ALPHA_MODE_IGNORE")]
        AlphaModeIgnore = 0x3,
        [NativeName("Name", "DXGI_ALPHA_MODE_FORCE_DWORD")]
        AlphaModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
