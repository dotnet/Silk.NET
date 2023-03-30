// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_PRINT_FONT_SUBSET_MODE")]
    public enum PrintFontSubsetMode : int
    {
        [NativeName("Name", "D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D2D1_PRINT_FONT_SUBSET_MODE_EACHPAGE")]
        Eachpage = 0x1,
        [NativeName("Name", "D2D1_PRINT_FONT_SUBSET_MODE_NONE")]
        None = 0x2,
        [NativeName("Name", "D2D1_PRINT_FONT_SUBSET_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
