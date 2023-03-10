// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE")]
    public enum ColorContextType : int
    {
        [Obsolete("Deprecated in favour of \"Icc\"")]
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_ICC")]
        ColorContextTypeIcc = 0x0,
        [Obsolete("Deprecated in favour of \"Simple\"")]
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_SIMPLE")]
        ColorContextTypeSimple = 0x1,
        [Obsolete("Deprecated in favour of \"Dxgi\"")]
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_DXGI")]
        ColorContextTypeDxgi = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_FORCE_DWORD")]
        ColorContextTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_ICC")]
        Icc = 0x0,
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_SIMPLE")]
        Simple = 0x1,
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_DXGI")]
        Dxgi = 0x2,
        [NativeName("Name", "D2D1_COLOR_CONTEXT_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
