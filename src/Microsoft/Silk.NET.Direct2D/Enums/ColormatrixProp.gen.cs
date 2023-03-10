// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_COLORMATRIX_PROP")]
    public enum ColormatrixProp : int
    {
        [Obsolete("Deprecated in favour of \"ColorMatrix\"")]
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_COLOR_MATRIX")]
        ColormatrixPropColorMatrix = 0x0,
        [Obsolete("Deprecated in favour of \"AlphaMode\"")]
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_ALPHA_MODE")]
        ColormatrixPropAlphaMode = 0x1,
        [Obsolete("Deprecated in favour of \"ClampOutput\"")]
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_CLAMP_OUTPUT")]
        ColormatrixPropClampOutput = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_FORCE_DWORD")]
        ColormatrixPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_COLOR_MATRIX")]
        ColorMatrix = 0x0,
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_ALPHA_MODE")]
        AlphaMode = 0x1,
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_CLAMP_OUTPUT")]
        ClampOutput = 0x2,
        [NativeName("Name", "D2D1_COLORMATRIX_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
