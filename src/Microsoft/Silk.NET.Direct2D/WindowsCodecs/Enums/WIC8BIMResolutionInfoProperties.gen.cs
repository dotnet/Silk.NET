// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WIC8BIMResolutionInfoProperties")]
    public enum WIC8BIMResolutionInfoProperties : int
    {
        [Obsolete("Deprecated in favour of \"PString\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoPString")]
        Wic8BimresolutionInfoPString = 0x1,
        [Obsolete("Deprecated in favour of \"HResolution\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoHResolution")]
        Wic8BimresolutionInfoHResolution = 0x2,
        [Obsolete("Deprecated in favour of \"HResolutionUnit\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoHResolutionUnit")]
        Wic8BimresolutionInfoHResolutionUnit = 0x3,
        [Obsolete("Deprecated in favour of \"WidthUnit\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoWidthUnit")]
        Wic8BimresolutionInfoWidthUnit = 0x4,
        [Obsolete("Deprecated in favour of \"VResolution\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoVResolution")]
        Wic8BimresolutionInfoVResolution = 0x5,
        [Obsolete("Deprecated in favour of \"VResolutionUnit\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoVResolutionUnit")]
        Wic8BimresolutionInfoVResolutionUnit = 0x6,
        [Obsolete("Deprecated in favour of \"HeightUnit\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoHeightUnit")]
        Wic8BimresolutionInfoHeightUnit = 0x7,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WIC8BIMResolutionInfoProperties_FORCE_DWORD")]
        Wic8BimresolutionInfoPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WIC8BIMResolutionInfoPString")]
        PString = 0x1,
        [NativeName("Name", "WIC8BIMResolutionInfoHResolution")]
        HResolution = 0x2,
        [NativeName("Name", "WIC8BIMResolutionInfoHResolutionUnit")]
        HResolutionUnit = 0x3,
        [NativeName("Name", "WIC8BIMResolutionInfoWidthUnit")]
        WidthUnit = 0x4,
        [NativeName("Name", "WIC8BIMResolutionInfoVResolution")]
        VResolution = 0x5,
        [NativeName("Name", "WIC8BIMResolutionInfoVResolutionUnit")]
        VResolutionUnit = 0x6,
        [NativeName("Name", "WIC8BIMResolutionInfoHeightUnit")]
        HeightUnit = 0x7,
        [NativeName("Name", "WIC8BIMResolutionInfoProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
