// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICHeifHdrProperties")]
    public enum WICHeifHdrProperties : int
    {
        [Obsolete("Deprecated in favour of \"MaximumLuminanceLevel\"")]
        [NativeName("Name", "WICHeifHdrMaximumLuminanceLevel")]
        WicheifHdrMaximumLuminanceLevel = 0x1,
        [Obsolete("Deprecated in favour of \"MaximumFrameAverageLuminanceLevel\"")]
        [NativeName("Name", "WICHeifHdrMaximumFrameAverageLuminanceLevel")]
        WicheifHdrMaximumFrameAverageLuminanceLevel = 0x2,
        [Obsolete("Deprecated in favour of \"MinimumMasteringDisplayLuminanceLevel\"")]
        [NativeName("Name", "WICHeifHdrMinimumMasteringDisplayLuminanceLevel")]
        WicheifHdrMinimumMasteringDisplayLuminanceLevel = 0x3,
        [Obsolete("Deprecated in favour of \"MaximumMasteringDisplayLuminanceLevel\"")]
        [NativeName("Name", "WICHeifHdrMaximumMasteringDisplayLuminanceLevel")]
        WicheifHdrMaximumMasteringDisplayLuminanceLevel = 0x4,
        [Obsolete("Deprecated in favour of \"CustomVideoPrimaries\"")]
        [NativeName("Name", "WICHeifHdrCustomVideoPrimaries")]
        WicheifHdrCustomVideoPrimaries = 0x5,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICHeifHdrProperties_FORCE_DWORD")]
        WicheifHdrPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICHeifHdrMaximumLuminanceLevel")]
        MaximumLuminanceLevel = 0x1,
        [NativeName("Name", "WICHeifHdrMaximumFrameAverageLuminanceLevel")]
        MaximumFrameAverageLuminanceLevel = 0x2,
        [NativeName("Name", "WICHeifHdrMinimumMasteringDisplayLuminanceLevel")]
        MinimumMasteringDisplayLuminanceLevel = 0x3,
        [NativeName("Name", "WICHeifHdrMaximumMasteringDisplayLuminanceLevel")]
        MaximumMasteringDisplayLuminanceLevel = 0x4,
        [NativeName("Name", "WICHeifHdrCustomVideoPrimaries")]
        CustomVideoPrimaries = 0x5,
        [NativeName("Name", "WICHeifHdrProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
