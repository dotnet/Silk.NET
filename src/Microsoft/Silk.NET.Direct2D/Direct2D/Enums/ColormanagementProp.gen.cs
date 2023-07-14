// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP")]
    public enum ColormanagementProp : int
    {
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT")]
        SourceColorContext = 0x0,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT")]
        SourceRenderingIntent = 0x1,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT")]
        DestinationColorContext = 0x2,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT")]
        DestinationRenderingIntent = 0x3,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE")]
        AlphaMode = 0x4,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_QUALITY")]
        Quality = 0x5,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
