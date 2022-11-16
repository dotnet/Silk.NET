// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SHARPEN_PROP")]
    public enum SharpenProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Sharpness\"")]
        [NativeName("Name", "D2D1_SHARPEN_PROP_SHARPNESS")]
        SharpenPropSharpness = 0x0,
        [Obsolete("Deprecated in favour of \"Threshold\"")]
        [NativeName("Name", "D2D1_SHARPEN_PROP_THRESHOLD")]
        SharpenPropThreshold = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SHARPEN_PROP_FORCE_DWORD")]
        SharpenPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SHARPEN_PROP_SHARPNESS")]
        Sharpness = 0x0,
        [NativeName("Name", "D2D1_SHARPEN_PROP_THRESHOLD")]
        Threshold = 0x1,
        [NativeName("Name", "D2D1_SHARPEN_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
