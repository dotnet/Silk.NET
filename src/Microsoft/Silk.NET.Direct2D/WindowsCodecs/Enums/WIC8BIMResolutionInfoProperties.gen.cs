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
