// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawCapabilities")]
    public enum WICRawCapabilities : int
    {
        [Obsolete("Deprecated in favour of \"RawCapabilityNotSupported\"")]
        [NativeName("Name", "WICRawCapabilityNotSupported")]
        WicrawCapabilityNotSupported = 0x0,
        [Obsolete("Deprecated in favour of \"RawCapabilityGetSupported\"")]
        [NativeName("Name", "WICRawCapabilityGetSupported")]
        WicrawCapabilityGetSupported = 0x1,
        [Obsolete("Deprecated in favour of \"RawCapabilityFullySupported\"")]
        [NativeName("Name", "WICRawCapabilityFullySupported")]
        WicrawCapabilityFullySupported = 0x2,
        [Obsolete("Deprecated in favour of \"AwcapabilitiesForceDword\"")]
        [NativeName("Name", "WICRAWCAPABILITIES_FORCE_DWORD")]
        WicrawcapabilitiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICRawCapabilityNotSupported")]
        RawCapabilityNotSupported = 0x0,
        [NativeName("Name", "WICRawCapabilityGetSupported")]
        RawCapabilityGetSupported = 0x1,
        [NativeName("Name", "WICRawCapabilityFullySupported")]
        RawCapabilityFullySupported = 0x2,
        [NativeName("Name", "WICRAWCAPABILITIES_FORCE_DWORD")]
        AwcapabilitiesForceDword = 0x7FFFFFFF,
    }
}
