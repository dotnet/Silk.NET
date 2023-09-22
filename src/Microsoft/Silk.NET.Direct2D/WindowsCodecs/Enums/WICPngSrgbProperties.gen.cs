// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngSrgbProperties")]
    public enum WICPngSrgbProperties : int
    {
        [Obsolete("Deprecated in favour of \"RenderingIntent\"")]
        [NativeName("Name", "WICPngSrgbRenderingIntent")]
        WicpngSrgbRenderingIntent = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngSrgbProperties_FORCE_DWORD")]
        WicpngSrgbPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngSrgbRenderingIntent")]
        RenderingIntent = 0x1,
        [NativeName("Name", "WICPngSrgbProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
