// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngBkgdProperties")]
    public enum WICPngBkgdProperties : int
    {
        [Obsolete("Deprecated in favour of \"BackgroundColor\"")]
        [NativeName("Name", "WICPngBkgdBackgroundColor")]
        WicpngBkgdBackgroundColor = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngBkgdProperties_FORCE_DWORD")]
        WicpngBkgdPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngBkgdBackgroundColor")]
        BackgroundColor = 0x1,
        [NativeName("Name", "WICPngBkgdProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
