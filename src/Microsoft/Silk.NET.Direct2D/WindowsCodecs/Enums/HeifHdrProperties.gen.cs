// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICHeifHdrProperties")]
    public enum HeifHdrProperties : int
    {
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
