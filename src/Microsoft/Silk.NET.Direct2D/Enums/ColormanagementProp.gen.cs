// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP")]
    public enum ColormanagementProp : int
    {
        [Obsolete("Deprecated in favour of \"SourceColorContext\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT")]
        ColormanagementPropSourceColorContext = 0x0,
        [Obsolete("Deprecated in favour of \"SourceRenderingIntent\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT")]
        ColormanagementPropSourceRenderingIntent = 0x1,
        [Obsolete("Deprecated in favour of \"DestinationColorContext\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT")]
        ColormanagementPropDestinationColorContext = 0x2,
        [Obsolete("Deprecated in favour of \"DestinationRenderingIntent\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT")]
        ColormanagementPropDestinationRenderingIntent = 0x3,
        [Obsolete("Deprecated in favour of \"AlphaMode\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE")]
        ColormanagementPropAlphaMode = 0x4,
        [Obsolete("Deprecated in favour of \"Quality\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_QUALITY")]
        ColormanagementPropQuality = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD")]
        ColormanagementPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
