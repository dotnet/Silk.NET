// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_CROP_PROP")]
    public enum CropProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Rect\"")]
        [NativeName("Name", "D2D1_CROP_PROP_RECT")]
        CropPropRect = 0x0,
        [Obsolete("Deprecated in favour of \"BorderMode\"")]
        [NativeName("Name", "D2D1_CROP_PROP_BORDER_MODE")]
        CropPropBorderMode = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_CROP_PROP_FORCE_DWORD")]
        CropPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_CROP_PROP_RECT")]
        Rect = 0x0,
        [NativeName("Name", "D2D1_CROP_PROP_BORDER_MODE")]
        BorderMode = 0x1,
        [NativeName("Name", "D2D1_CROP_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
