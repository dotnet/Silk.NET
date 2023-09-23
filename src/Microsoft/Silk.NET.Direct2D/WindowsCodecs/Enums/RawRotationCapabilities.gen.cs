// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawRotationCapabilities")]
    public enum RawRotationCapabilities : int
    {
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
