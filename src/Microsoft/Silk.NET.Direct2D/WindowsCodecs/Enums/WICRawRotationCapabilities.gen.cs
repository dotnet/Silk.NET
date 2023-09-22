// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawRotationCapabilities")]
    public enum WICRawRotationCapabilities : int
    {
        [Obsolete("Deprecated in favour of \"RawRotationCapabilityNotSupported\"")]
        [NativeName("Name", "WICRawRotationCapabilityNotSupported")]
        WicrawRotationCapabilityNotSupported = 0x0,
        [Obsolete("Deprecated in favour of \"RawRotationCapabilityGetSupported\"")]
        [NativeName("Name", "WICRawRotationCapabilityGetSupported")]
        WicrawRotationCapabilityGetSupported = 0x1,
        [Obsolete("Deprecated in favour of \"RawRotationCapabilityNinetyDegreesSupported\"")]
        [NativeName("Name", "WICRawRotationCapabilityNinetyDegreesSupported")]
        WicrawRotationCapabilityNinetyDegreesSupported = 0x2,
        [Obsolete("Deprecated in favour of \"RawRotationCapabilityFullySupported\"")]
        [NativeName("Name", "WICRawRotationCapabilityFullySupported")]
        WicrawRotationCapabilityFullySupported = 0x3,
        [Obsolete("Deprecated in favour of \"AwrotationcapabilitiesForceDword\"")]
        [NativeName("Name", "WICRAWROTATIONCAPABILITIES_FORCE_DWORD")]
        WicrawrotationcapabilitiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICRawRotationCapabilityNotSupported")]
        RawRotationCapabilityNotSupported = 0x0,
        [NativeName("Name", "WICRawRotationCapabilityGetSupported")]
        RawRotationCapabilityGetSupported = 0x1,
        [NativeName("Name", "WICRawRotationCapabilityNinetyDegreesSupported")]
        RawRotationCapabilityNinetyDegreesSupported = 0x2,
        [NativeName("Name", "WICRawRotationCapabilityFullySupported")]
        RawRotationCapabilityFullySupported = 0x3,
        [NativeName("Name", "WICRAWROTATIONCAPABILITIES_FORCE_DWORD")]
        AwrotationcapabilitiesForceDword = 0x7FFFFFFF,
    }
}
