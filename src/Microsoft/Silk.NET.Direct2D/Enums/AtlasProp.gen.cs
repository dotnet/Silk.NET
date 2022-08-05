// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_ATLAS_PROP")]
    public enum AtlasProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InputRect\"")]
        [NativeName("Name", "D2D1_ATLAS_PROP_INPUT_RECT")]
        AtlasPropInputRect = 0x0,
        [Obsolete("Deprecated in favour of \"InputPaddingRect\"")]
        [NativeName("Name", "D2D1_ATLAS_PROP_INPUT_PADDING_RECT")]
        AtlasPropInputPaddingRect = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_ATLAS_PROP_FORCE_DWORD")]
        AtlasPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_ATLAS_PROP_INPUT_RECT")]
        InputRect = 0x0,
        [NativeName("Name", "D2D1_ATLAS_PROP_INPUT_PADDING_RECT")]
        InputPaddingRect = 0x1,
        [NativeName("Name", "D2D1_ATLAS_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
